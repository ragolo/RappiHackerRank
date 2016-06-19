namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D.Business
{
    using NUnit.Framework;
    using HackerRank.CubeSummation.Cube3D.Business.Interfaces;
    using HackerRank.CubeSummation.Cube3D.Business.Operations;
    using HackerRank.CubeSummation.Cube3D.Models;
    using HackerRank.CubeSummation.Cube3D.Models.Input;
    using HackerRank.CubeSummation.Cube3D.Models.Input.Operations;

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
            var testCase = new TestCasesModel { DimensionOfMatrix = 1 };
            var validationModel = new ValidationModel { DimensionOfMatrix = 2 };
            Assert.IsTrue(generateInputFormatValidation.IsTheNumberDimensionOfMatrixBetweenRange(testCase, validationModel));
        }

        /// <summary>
        /// Gives the number test case are equal to true.
        /// </summary>
        [Test]
        public void GiveNumberTestCaseAreEqualToTrue()
        {
            var inputFormatModel = new InputFormatModel { NumberOfTestCase = 50 };
            var validationModel = new ValidationModel { TheNumberTestCase = 50 };
            Assert.IsTrue(generateInputFormatValidation.IsTheNumberTestCaseBetweenRange(inputFormatModel, validationModel));
        }

        /// <summary>
        /// Gives the number of operations are equal to true.
        /// </summary>
        [Test]
        public void GiveNumberOfOperationsAreEqualToTrue()
        {
            var operations = new IOperation[2];
            var validationModel = new ValidationModel { NumberOfOperations = 1000 };
            operations[0] = new QueryBusiness
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel { Position1 = 1, Position2 = 2, Position3 = 3 },
                        Coordinate2 = new CoordinateModel { Position1 = 1, Position2 = 2, Position3 = 3 }
                    }
            };

            Assert.IsTrue(generateInputFormatValidation.IsTheNumberOfOperationsBetweenRange(operations, validationModel));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}