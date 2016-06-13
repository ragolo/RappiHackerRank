namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using System;
    using Core.IoC;
    using NUnit.Framework;
    using HackerRank.CubeSummation.Cube3D.Interfaces;
    using HackerRank.CubeSummation.Cube3D;

    public class Cube3DBaseTests
    {

        /// <summary>
        /// The generate input format
        /// </summary>
        protected IGenerateInputFormat generateInputFormat;

        protected ICubeSummationCube3D cubeSummationCube3D;

        [SetUp]
        protected virtual void SetUp()
        {
            try
            {
                var container = IocHelper.GetInstance();
                this.generateInputFormat = (IGenerateInputFormat)container.Resolve("GenerateInputFormatFromText", typeof(GenerateInputFormatFromText));
                this.cubeSummationCube3D = (ICubeSummationCube3D)container.Resolve("CubeSummationCube3D", typeof(CubeSummationCube3D));
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}