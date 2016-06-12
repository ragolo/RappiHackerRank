namespace Rappi.HackerRank.CubeSummation.Tests.Cube3D
{
    using NUnit.Framework;
    using CubeSummation.Cube3D;
    using CubeSummation.Cube3D.Interfaces;

    /// <summary>
    /// Summary description for GenerateInputFormatTests
    /// </summary>
    [TestFixture]
    public class GenerateInputFormatTests
    {

        private IGenerateInputFormat generateInputFormat;

        [SetUp]
        public void SetUp()
        {
            this.generateInputFormat = new GenerateInputFormat();
        }

        [Test]
        public void ShloudBeGenerateInputFormat()
        {
            this.generateInputFormat.GetInputFormat();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}