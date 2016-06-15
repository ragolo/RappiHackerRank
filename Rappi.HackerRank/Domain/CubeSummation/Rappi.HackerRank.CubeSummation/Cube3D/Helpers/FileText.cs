namespace Rappi.HackerRank.CubeSummation.Cube3D.Helpers
{
    using System;
    using System.Configuration;
    using System.IO;
    using ConstAndEnumerations;
    using Exceptions;

    /// <summary>
    /// File Text
    /// </summary>
    public static class FileText
    {
        /// <summary>
        /// Gets the file from text.
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllLinesOfFile(string pathFile)
        {
            try
            {
                if (File.Exists(pathFile))
                {
                    return File.ReadAllLines(pathFile);
                }
                throw new CubeSummationException(CubeSummationExceptionType.File,"El archivo no existe");
            }
            catch (Exception ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.File, ex.Message);
            }
        }

        /// <summary>
        /// Gets the path file.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetPathFile()
        {
            var pathFile = ConfigurationManager.AppSettings[AppSettingsConstants.PathFile];
            if (pathFile == null)
            {
                throw new ArgumentNullException(AppSettingsConstants.PathFile);
            }
            return pathFile;
        }
    }
}