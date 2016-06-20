namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using System;
    using Core.IoC;
    using HackerRank.CubeSummation.Cube3D.Business;
    using HackerRank.CubeSummation.Cube3D.Business.Interfaces;
    using HackerRank.CubeSummation.Cube3D.Business.Validation;
    using HackerRank.CubeSummation.Cube3D.Interfaces.Requests;
    using HackerRank.CubeSummation.Cube3D.Requests;
    using NUnit.Framework;

    /// <summary>
    /// Cube3D Base Tests
    /// </summary>
    public class Cube3DBaseTests
    {

        /// <summary>
        /// The generate input format
        /// </summary>
        protected IGenerateInputFormat generateInputFormat;

        /// <summary>
        /// The cube summation cube3 d
        /// </summary>
        protected IGenerateCubeSummationCube3D cubeSummationCube3D;

        /// <summary>
        /// The generate cube
        /// </summary>
        protected IGenerateCube generateCube;

        /// <summary>
        /// The generate input format validation
        /// </summary>
        protected IGenerateInputFormatValidation generateInputFormatValidation;

        /// <summary>
        /// The query business validation
        /// </summary>
        protected IQueryBusinessValidation queryBusinessValidation;

        /// <summary>
        /// The update business validation
        /// </summary>
        protected IUpdateBusinessValidation updateBusinessValidation;

        /// <summary>
        /// The cube summation cube3 d request
        /// </summary>
        protected ICubeSummationCube3DRequest cubeSummationCube3DRequest;

        /// <summary>
        /// Sets up.
        /// </summary>
        [SetUp]
        protected virtual void SetUp()
        {
            try
            {
                var container = IocHelper.GetInstance();
                this.generateInputFormat = (IGenerateInputFormat)container.Resolve("GenerateInputFormatFromText", typeof(GenerateInputFormatFromText));
                this.cubeSummationCube3D = (IGenerateCubeSummationCube3D)container.Resolve("GenerateCubeSummationCube3D", typeof(GenerateCubeSummationCube3D));
                this.generateCube = (IGenerateCube)container.Resolve("GenerateCube", typeof(GenerateCube));
                this.generateInputFormatValidation = (IGenerateInputFormatValidation)container.Resolve("GenerateInputFormatValidation", typeof(GenerateInputFormatValidation));
                this.updateBusinessValidation = (IUpdateBusinessValidation)container.Resolve("UpdateBusinessValidation", typeof(UpdateBusinessValidation));
                this.queryBusinessValidation = (IQueryBusinessValidation)container.Resolve("QueryBusinessValidation", typeof(QueryBusinessValidation));
                this.cubeSummationCube3DRequest = (ICubeSummationCube3DRequest)container.Resolve("CubeSummationCube3DRequest", typeof(CubeSummationCube3DRequest));
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}