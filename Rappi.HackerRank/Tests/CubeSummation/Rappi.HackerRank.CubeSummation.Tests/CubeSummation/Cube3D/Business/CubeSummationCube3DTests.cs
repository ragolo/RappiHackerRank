namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D.Business
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using HackerRank.CubeSummation.Cube3D.Business.Interfaces;
    using HackerRank.CubeSummation.Cube3D.Business.Operations;
    using HackerRank.CubeSummation.Cube3D.Helpers;
    using HackerRank.CubeSummation.Cube3D.Models;
    using HackerRank.CubeSummation.Cube3D.Models.Input;
    using HackerRank.CubeSummation.Cube3D.Models.Input.Operations;

    /// <summary>
    /// The Cube Summation Cube3D Tests
    /// </summary>
    /// <seealso cref="Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D.Cube3DBaseTests" />
    [TestFixture]
    public class CubeSummationCube3DTests : Cube3DBaseTests
    {

        /// <summary>
        /// Gives the sum total of each query operation that is equal tor result sum total.
        /// </summary>
        [Test]
        public void GiveSumTotalOfEachQueryOperationThatIsEqualTorResultSumTotal()
        {
            var inputFormatModel = GetInputFormatModel();
            var expectResultSumTotal = new List<int> {4, 4, 27, 0, 1, 1};
            var resultSumTotal = this.cubeSummationCube3D.GetSumTotalOfEachQueryOperation(inputFormatModel);

            Assert.That(expectResultSumTotal, Is.EqualTo(resultSumTotal));
        }

        /// <summary>
        /// Gets the input format model.
        /// </summary>
        /// <returns></returns>
        private InputFormatModel GetInputFormatModel()
        {
            var inputFormatModel = new InputFormatModel {NumberOfTestCase = 2};
            var testCases = new List<TestCasesModel>();
            var validatinoModel = CubeSummationCube3DHelpers.GetValidationModel();

            var operations1 = new IOperation[5];
            operations1[0] = new UpdateBusiness(updateBusinessValidation, validatinoModel)
            {
                UpdateModels =
                    new UpdateModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 2, Position2 = 2, Position3 = 2},
                        ValueOfBlock = 4
                    }
            };
            operations1[1] = new QueryBusiness(this.queryBusinessValidation)
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 1, Position2 = 1, Position3 = 1},
                        Coordinate2 = new CoordinateModel {Position1 = 3, Position2 = 3, Position3 = 3}
                    }
            };
            operations1[2] = new UpdateBusiness(updateBusinessValidation, validatinoModel)
            {
                UpdateModels =
                    new UpdateModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 1, Position2 = 1, Position3 = 1},
                        ValueOfBlock = 23
                    }
            };
            operations1[3] = new QueryBusiness(this.queryBusinessValidation)
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 2, Position2 = 2, Position3 = 2},
                        Coordinate2 = new CoordinateModel {Position1 = 4, Position2 = 4, Position3 = 4}
                    }
            };
            operations1[4] = new QueryBusiness(this.queryBusinessValidation)
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 1, Position2 = 1, Position3 = 1},
                        Coordinate2 = new CoordinateModel {Position1 = 3, Position2 = 3, Position3 = 3}
                    }
            };

            testCases.Add(new TestCasesModel {DimensionOfMatrix = 4, NumberOfOperations = 5, Operations = operations1});

            var operations2 = new IOperation[4];
            operations2[0] = new UpdateBusiness(updateBusinessValidation, validatinoModel)
            {
                UpdateModels =
                    new UpdateModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 2, Position2 = 2, Position3 = 2},
                        ValueOfBlock = 1
                    }
            };
            operations2[1] = new QueryBusiness(this.queryBusinessValidation)
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 1, Position2 = 1, Position3 = 1},
                        Coordinate2 = new CoordinateModel {Position1 = 1, Position2 = 1, Position3 = 1}
                    }
            };
            operations2[2] = new QueryBusiness(this.queryBusinessValidation)
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 1, Position2 = 1, Position3 = 1},
                        Coordinate2 = new CoordinateModel {Position1 = 2, Position2 = 2, Position3 = 2}
                    }
            };
            operations2[3] = new QueryBusiness(this.queryBusinessValidation)
            {
                QueryModels =
                    new QueryModel
                    {
                        Coordinate1 = new CoordinateModel {Position1 = 2, Position2 = 2, Position3 = 2},
                        Coordinate2 = new CoordinateModel {Position1 = 2, Position2 = 2, Position3 = 2}
                    }
            };

            testCases.Add(new TestCasesModel {DimensionOfMatrix = 2, NumberOfOperations = 4, Operations = operations2});
            inputFormatModel.TestCases = testCases;
            return inputFormatModel;
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}