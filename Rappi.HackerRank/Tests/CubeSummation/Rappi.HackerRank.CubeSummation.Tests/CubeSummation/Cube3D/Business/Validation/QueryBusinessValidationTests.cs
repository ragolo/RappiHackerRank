namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D.Business.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    public class QueryBusinessValidationTests : Cube3DBaseTests
    {
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

            BuildNumberOfOperationsQuery(queryModelList, testCase);
            foreach (var queryModel in queryModelList)
            {
                Assert.True(queryBusinessValidation.IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(queryModel, testCase.DimensionOfMatrix));
            }
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

            BuildNumberOfOperationsQuery(queryModelList, testCase);

            foreach (var queryModel in queryModelList)
            {
                Assert.True(queryBusinessValidation.IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(queryModel, testCase.DimensionOfMatrix));
            }
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

            BuildNumberOfOperationsQuery(queryModelList, testCase);

            foreach (var queryModel in queryModelList)
            {
                Assert.True(queryBusinessValidation.IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(queryModel, testCase.DimensionOfMatrix));
            }
        }

        /// <summary>
        /// Builds the number of operations query.
        /// </summary>
        /// <param name="queryModelList">The query model list.</param>
        /// <param name="testCase">The test case.</param>
        /// <exception cref="ArgumentNullException">queryModelList</exception>
        private void BuildNumberOfOperationsQuery(IReadOnlyList<QueryModel> queryModelList, TestCasesModel testCase)
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