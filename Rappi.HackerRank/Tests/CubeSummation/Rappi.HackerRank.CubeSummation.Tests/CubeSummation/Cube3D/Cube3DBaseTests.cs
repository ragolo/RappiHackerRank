namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using System;
    using Core.IoC;
    using HackerRank.CubeSummation.Cube3D;
    using HackerRank.CubeSummation.Cube3D.Business;
    using HackerRank.CubeSummation.Cube3D.Business.Interfaces;
    using HackerRank.CubeSummation.Cube3D.Interfaces;
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
        protected ICubeSummationCube3D cubeSummationCube3D;

        /// <summary>
        /// The generate cube
        /// </summary>
        protected IGenerateCube generateCube;

        /// <summary>
        /// Sets up.
        /// </summary>
        [SetUp]
        protected virtual void SetUp()
        {
            try
            {
                var container = IocHelper.GetInstance();
                generateInputFormat = (IGenerateInputFormat)container.Resolve("GenerateInputFormatFromText", typeof(GenerateInputFormatFromText));
                cubeSummationCube3D = (ICubeSummationCube3D)container.Resolve("CubeSummationCube3D", typeof(CubeSummationCube3D));
                generateCube = (IGenerateCube)container.Resolve("GenerateCube", typeof(GenerateCube));
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}