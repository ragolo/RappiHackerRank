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
    public class UpdateBusinessValidationTests : Cube3DBaseTests
    {
        /// <summary>
        /// Gives the value of block less equal to value of block maximum and greater than value of block minimum.
        /// </summary>
        [Test]
        public void GiveValueOfBlockLessEqualToValueOfBlockMaxAndGreaterThanValueOfBlockMin()
        {
            var testCase = new TestCasesModel { DimensionOfMatrix = 4 };
            var queryModelList = new List<UpdateModel>();
            var validationModel = new ValidationModel { ValueOfBlockMax = 1000000000, ValueOfBlockMin = -1000000000 };

            var query1Model = new UpdateModel
            {
                Coordinate1 = new CoordinateModel { Position1 = 2, Position2 = 1, Position3 = 1 },
                ValueOfBlock = 12222
            };

            var query2Model = new UpdateModel
            {
                Coordinate1 = new CoordinateModel { Position1 = 2, Position2 = 1, Position3 = 1 },
                ValueOfBlock = 1000000000
            };

            queryModelList.Add(query1Model);
            queryModelList.Add(query2Model);

            BuildNumberOfOperationsUpdate(queryModelList, testCase);

            foreach (var updateModel in queryModelList)
            {
                Assert.True(updateBusinessValidation.IsValueOfBlockLessEqualToValueOfBlockMaxAndGreaterThanValueOfBlockMin(updateModel, validationModel));
            }
        }

        /// <summary>
        /// Builds the number of operations update.
        /// </summary>
        /// <param name="updateModelList">The query model list.</param>
        /// <param name="testCase">The test case.</param>
        /// <exception cref="ArgumentNullException">queryModelList</exception>
        private void BuildNumberOfOperationsUpdate(IReadOnlyList<UpdateModel> updateModelList, TestCasesModel testCase)
        {
            if (updateModelList == null)
            {
                throw new ArgumentNullException("updateModelList");
            }
            testCase.NumberOfOperations = updateModelList.Count();
            testCase.Operations = new IOperation[testCase.NumberOfOperations];
            for (var i = 0; i < testCase.NumberOfOperations; i++)
            {
                var updateBusiness = new UpdateBusiness { UpdateModels = updateModelList[i] };
                testCase.Operations[i] = updateBusiness;
            }
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}