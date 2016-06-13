namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using NUnit.Framework;

    /// <summary>
    /// Summary description for GenerateInputFormatTests
    /// </summary>
    [TestFixture]
    public class GenerateInputFormatTests : Cube3DBaseTests
    {
        [Test]
        public void ShloudBeGenerateInputFormat()
        {
            var inputFormat = this.generateInputFormat.GetInputFormat();
            var result = this.cubeSummationCube3D.GetSumTotalOfEachQueryOperation(inputFormat);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}