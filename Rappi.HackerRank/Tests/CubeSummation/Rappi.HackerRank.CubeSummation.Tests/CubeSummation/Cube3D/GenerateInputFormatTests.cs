namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using System.Collections.Generic;
    using HackerRank.CubeSummation.Cube3D.Models.Input;
    using NUnit.Framework;

    /// <summary>
    /// Summary description for GenerateInputFormatTests
    /// </summary>
    [TestFixture]
    public class GenerateInputFormatTests : Cube3DBaseTests
    {

        /// <summary>
        /// Gives the dimension of matrix are equal to true.
        /// </summary>
        [Test]
        public void GiveDimensionOfMatrixAreEqualToTrue()
        {
            var testCases = new List<TestCasesModel> { new TestCasesModel { DimensionOfMatrix = 1 }, new TestCasesModel { DimensionOfMatrix = 50 }, new TestCasesModel { DimensionOfMatrix = 100 } };
            Assert.IsTrue(this.generateInputFormatValidation.IsTheNumberDimensionOfMatrixBetweenRange(testCases));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}