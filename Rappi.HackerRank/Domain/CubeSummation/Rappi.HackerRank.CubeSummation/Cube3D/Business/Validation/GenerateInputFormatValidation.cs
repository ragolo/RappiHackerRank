namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ConstAndEnumerations;
    using Exceptions;
    using Interfaces;
    using Models;
    using Models.Input;
    using Operations;

    /// <summary>
    /// Generate Input Format Validation
    /// </summary>
    /// <seealso cref="Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces.IGenerateInputFormatValidation" />
    public class GenerateInputFormatValidation : IGenerateInputFormatValidation
    {
        /// <summary>
        /// Gets or sets the validation model.
        /// </summary>
        /// <value>
        /// The validation model.
        /// </value>
        private ValidationModel ValidationModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateInputFormatValidation"/> class.
        /// </summary>
        /// <param name="validationModel">The validation model.</param>
        public GenerateInputFormatValidation(ValidationModel validationModel)
        {
            ValidationModel = validationModel;
        }

        /// <summary>
        /// Determines whether [is the number test case between range] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">inputFormatModel</exception>
        /// <exception cref="CubeSummationException">El número de casos debe se un número positivo, valide su configuración.</exception>
        public bool IsTheNumberTestCaseBetweenRange(InputFormatModel inputFormatModel)
        {
            if (inputFormatModel == null)
            {
                throw new ArgumentNullException("inputFormatModel");
            }
            if (inputFormatModel.NumberOfTestCase < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, "El número de casos debe se un número positivo, valide su configuración.");
            }

            return inputFormatModel.NumberOfTestCase <= ValidationModel.TheNumberTestCase;
        }

        /// <summary>
        /// Determines whether [is the number dimension of matrix between range] [the specified test cases model].
        /// </summary>
        /// <param name="testCasesModel">The test cases model.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">testCasesModel</exception>
        /// <exception cref="CubeSummationException"></exception>
        public bool IsTheNumberDimensionOfMatrixBetweenRange(List<TestCasesModel> testCasesModel)
        {
            if (testCasesModel == null) throw new ArgumentNullException("testCasesModel");

            if (ValidationModel.DimensionOfMatrix < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, "La dimensión de la matrix debe ser un número positivo, valide su configuración.");
            }

            return !testCasesModel.Any(testCase => testCase.DimensionOfMatrix > ValidationModel.DimensionOfMatrix || testCase.DimensionOfMatrix < 1);
        }

        /// <summary>
        /// Determines whether [is the number of operations between range] [the specified input format model].
        /// </summary>
        /// <param name="testCasesModel">The test cases model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">testCasesModel</exception>
        /// <exception cref="CubeSummationException">
        /// El número de operaciones debe ser un número positivo, valide su configuración.
        /// or
        /// </exception>
        public bool IsTheNumberOfOperationsBetweenRange(TestCasesModel testCasesModel)
        {
            if (testCasesModel == null) throw new ArgumentNullException("testCasesModel");

            if (ValidationModel.NumberOfOperations < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, "El número de operaciones debe ser un número positivo, valide su configuración.");
            }

            return testCasesModel.NumberOfOperations <= ValidationModel.NumberOfOperations;
        }

        /// <summary>
        /// Determines whether [is coordinate1 position1 less or equal than coordinate2 position1] [the specified input format model].
        /// </summary>
        /// <param name="testCasesModel">The test cases model.</param>
        /// <returns></returns>
        public bool IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(TestCasesModel testCasesModel)
        {
            if (testCasesModel.Operations == null)
            {
                throw new ArgumentNullException("Operations");
            }

            return (from operation in testCasesModel.Operations where operation.GetType() == typeof(QueryBusiness) select (QueryBusiness)operation into queryBusiness select queryBusiness.QueryModels).All(querymodel => querymodel.Coordinate1.Position1 >= 1 && querymodel.Coordinate1.Position1 <= querymodel.Coordinate2.Position1 && querymodel.Coordinate2.Position1 <= testCasesModel.DimensionOfMatrix);
        }

        /// <summary>
        /// Determines whether [is coordinate1 position2 less or equal than coordinate2 position2] [the specified test cases model].
        /// </summary>
        /// <param name="testCasesModel">The test cases model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Operations</exception>
        public bool IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(TestCasesModel testCasesModel)
        {
            if (testCasesModel.Operations == null)
            {
                throw new ArgumentNullException("Operations");
            }

            return (from operation in testCasesModel.Operations where operation.GetType() == typeof(QueryBusiness) select (QueryBusiness)operation into queryBusiness select queryBusiness.QueryModels).All(querymodel => querymodel.Coordinate1.Position2 >= 1 && querymodel.Coordinate1.Position2 <= querymodel.Coordinate2.Position2 && querymodel.Coordinate2.Position2 <= testCasesModel.DimensionOfMatrix);
        }

        /// <summary>
        /// Determines whether [is coordinate1 position3 less or equal than coordinate2 position3] [the specified input format model].
        /// </summary>
        /// <param name="testCasesModel">The test cases model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Operations</exception>
        public bool IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(TestCasesModel testCasesModel)
        {
            if (testCasesModel.Operations == null)
            {
                throw new ArgumentNullException("Operations");
            }

            return (from operation in testCasesModel.Operations where operation.GetType() == typeof(QueryBusiness) select (QueryBusiness)operation into queryBusiness select queryBusiness.QueryModels).All(querymodel => querymodel.Coordinate1.Position3 >= 1 && querymodel.Coordinate1.Position3 <= querymodel.Coordinate2.Position3 && querymodel.Coordinate2.Position3 <= testCasesModel.DimensionOfMatrix);
        }
    }
}