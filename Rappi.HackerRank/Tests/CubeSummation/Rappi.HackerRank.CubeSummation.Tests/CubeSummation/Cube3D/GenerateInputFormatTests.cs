using System;

namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D
{
    using System.Collections.Generic;
    using System.Linq;
    using HackerRank.CubeSummation.Cube3D.Business.Interfaces;
    using HackerRank.CubeSummation.Cube3D.Business.Operations;
    using HackerRank.CubeSummation.Cube3D.Models;
    using HackerRank.CubeSummation.Cube3D.Models.Input;
    using HackerRank.CubeSummation.Cube3D.Models.Input.Operations;
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
            Assert.IsTrue(generateInputFormatValidation.IsTheNumberDimensionOfMatrixBetweenRange(testCases));
        }

        /// <summary>
        /// Gives the number test case are equal to true.
        /// </summary>
        [Test]
        public void GiveNumberTestCaseAreEqualToTrue()
        {
            var inputFormatModel = new InputFormatModel { NumberOfTestCase = 50 };
            Assert.IsTrue(generateInputFormatValidation.IsTheNumberTestCaseBetweenRange(inputFormatModel));
        }

        /// <summary>
        /// Gives the number of operations are equal to true.
        /// </summary>
        [Test]
        public void GiveNumberOfOperationsAreEqualToTrue()
        {
            var testCases = new TestCasesModel { NumberOfOperations = 1000 };
            Assert.IsTrue(generateInputFormatValidation.IsTheNumberOfOperationsBetweenRange(testCases));
        }

        /// <summary>
        /// Gives the coordinate1 position1 less or equal than coordinate2 position1.
        /// </summary>
        [Test]
        public void GiveCoordinate1Position1LessOrEqualThanCoordinate2Position1()
        {
            var testCase = new TestCasesModel { DimensionOfMatrix = 2 };
            var queryModelList = new List<QueryModel>();
            var query1Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position1 = 1 },
                Coordinate2 = new CoordinateModel { Position1 = 2 }
            };

            var query2Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position1 = 2 },
                Coordinate2 = new CoordinateModel { Position1 = 2 }
            };

            queryModelList.Add(query1Model);
            queryModelList.Add(query2Model);

            BuildNumberOfOperations(queryModelList, testCase);

            Assert.True(generateInputFormatValidation.IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(testCase));
        }

        /// <summary>
        /// Gives the coordinate1 position2 less or equal than coordinate2 position2.
        /// </summary>
        [Test]
        public void GiveCoordinate1Position2LessOrEqualThanCoordinate2Position2()
        {
            var testCase = new TestCasesModel { DimensionOfMatrix = 2 };
            var queryModelList = new List<QueryModel>();
            var query1Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position2 = 1 },
                Coordinate2 = new CoordinateModel { Position2 = 2 }
            };

            var query2Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position2 = 2 },
                Coordinate2 = new CoordinateModel { Position2 = 2 }
            };

            queryModelList.Add(query1Model);
            queryModelList.Add(query2Model);

            BuildNumberOfOperations(queryModelList, testCase);

            Assert.True(generateInputFormatValidation.IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(testCase));
        }

        /// <summary>
        /// Gives the coordinate1 position3 less or equal than coordinate2 position3.
        /// </summary>
        [Test]
        public void GiveCoordinate1Position3LessOrEqualThanCoordinate2Position3()
        {
            var testCase = new TestCasesModel { DimensionOfMatrix = 2 };
            var queryModelList = new List<QueryModel>();
            var query1Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position3 = 1 },
                Coordinate2 = new CoordinateModel { Position3 = 2 }
            };

            var query2Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position3 = 2 },
                Coordinate2 = new CoordinateModel { Position3 = 2 }
            };

            queryModelList.Add(query1Model);
            queryModelList.Add(query2Model);

            BuildNumberOfOperations(queryModelList, testCase);

            Assert.True(generateInputFormatValidation.IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(testCase));
        }

        /// <summary>
        /// Gives the coordinate greater than maximum int32 and less than dimension of matrix.
        /// </summary>
        [Test]
        public void GiveCoordinateGreaterThanMaxInt32AndLessThanDimensionOfMatrix()
        {
            var testCase = new TestCasesModel { DimensionOfMatrix = 4 };
            var queryModelList = new List<QueryModel>();
            var query1Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position1 = 2,Position2 = 1,Position3 = 1 },
                Coordinate2 = new CoordinateModel { Position1 = 2, Position2 = 1, Position3 = 1 }
            };

            var query2Model = new QueryModel
            {
                Coordinate1 = new CoordinateModel { Position1 = 2, Position2 = 1, Position3 = 1 },
                Coordinate2 = new CoordinateModel { Position1 = 2, Position2 = 1, Position3 = 3 }
            };

            queryModelList.Add(query1Model);
            queryModelList.Add(query2Model);

            BuildNumberOfOperations(queryModelList, testCase);

            Assert.True(generateInputFormatValidation.IsCoordinateGreaterThan0AndLessThanOrEqualDimensionOfMatrix(testCase)); 
        }

        /// <summary>
        /// Builds the number of operations.
        /// </summary>
        /// <param name="queryModelList">The query model list.</param>
        /// <param name="testCase">The test case.</param>
        /// <exception cref="ArgumentNullException">queryModelList</exception>
        private void BuildNumberOfOperations(IReadOnlyList<QueryModel> queryModelList, TestCasesModel testCase)
        {
            if (queryModelList == null)
            {
                throw new ArgumentNullException("queryModelList");
            }
            testCase.NumberOfOperations = queryModelList.Count();
            testCase.Operations = new IOperation[testCase.NumberOfOperations];
            for (var i = 0; i < testCase.NumberOfOperations; i++)
            {
                var queryBusiness = new QueryBusiness { QueryModels = queryModelList[i] };
                testCase.Operations[i] = queryBusiness;
            }
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}