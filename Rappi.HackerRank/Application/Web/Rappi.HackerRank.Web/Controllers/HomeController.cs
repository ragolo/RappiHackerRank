using System.Globalization;
using System.Linq;

namespace Rappi.HackerRank.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Web.Mvc;
    using Core.IoC;
    using CubeSummation.Cube3D.Interfaces.Requests;
    using CubeSummation.Cube3D.Requests;
    using Newtonsoft.Json;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Processes the cube summation3 d.
        /// </summary>
        /// <returns></returns>
        public ContentResult ProcessCubeSummation3D()
        {
            var success = false;
            var error = string.Empty;
            var response = new List<int>();
            try
            {
                var container = IocHelper.GetInstance();
                var cubeSummationCube3DRequest = (ICubeSummationCube3DRequest)container.Resolve("CubeSummationCube3DRequest", typeof(CubeSummationCube3DRequest));

                var path = GetPathOfUploadFile();

                var resultSumTotalOfCube3D = cubeSummationCube3DRequest.GetSumTotalOfCube3D(path);

                if (!string.IsNullOrWhiteSpace(resultSumTotalOfCube3D.Error))
                {
                    throw new Exception(resultSumTotalOfCube3D.Error);
                }
                response = resultSumTotalOfCube3D.Result;
                success = true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            var json = JsonConvert.SerializeObject(new
            {
                success = success,
                error = error,
                result = response.ToArray()
            }, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Content(json, "application/json");
        }

        /// <summary>
        /// Gets the path of upload file.
        /// </summary>
        /// <returns></returns>
        private string GetPathOfUploadFile()
        {
            var path = string.Empty;
            const string relativePath = "~/CubeSummation3D/";
            foreach (var stream in from string file in Request.Files select Request.Files[file] into fileContent where fileContent != null && fileContent.ContentLength > 0 select fileContent.InputStream)
            {

                path = string.Concat(Server.MapPath(relativePath), "CubeSummation3D", DateTime.Now.ToString("yyyyMMdd", CultureInfo.InvariantCulture), DateTime.Now.Hour.ToString(CultureInfo.InvariantCulture), DateTime.Now.Minute.ToString(CultureInfo.InvariantCulture), DateTime.Now.Second.ToString(CultureInfo.InvariantCulture), ".txt");

                if (!Directory.Exists(Server.MapPath(relativePath)))
                {
                    Directory.CreateDirectory(Server.MapPath(relativePath));
                }

                using (var fileStream = System.IO.File.Create(path))
                {
                    stream.CopyTo(fileStream);
                }
            }
            return path;
        }
    }
}