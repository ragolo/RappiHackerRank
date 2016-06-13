namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using System;
    using Castle.Windsor;
    using NUnit.Framework;
    using HackerRank.CubeSummation.Cube3D.Interfaces;
    using HackerRank.CubeSummation.Cube3D;

    public class Cube3DBaseTests
    {

        /// <summary>
        /// The generate input format
        /// </summary>
        protected IGenerateInputFormat generateInputFormat;

        [SetUp]
        protected virtual void SetUp()
        {
            try
            {
                IWindsorContainer container = WindsorInstallerInstance.GetInstance();
                this.generateInputFormat = (IGenerateInputFormat)container.Resolve("GenerateInputFormatFromText", typeof(GenerateInputFormatFromText));
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}