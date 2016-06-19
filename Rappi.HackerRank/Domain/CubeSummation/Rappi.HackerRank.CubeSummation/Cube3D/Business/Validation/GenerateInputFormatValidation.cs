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

            if (inputFormatModel.NumberOfTestCase > ValidationModel.TheNumberTestCase)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("Los casos de prueba deben estar entre 1 y {0}", ValidationModel.TheNumberTestCase));
            }
            return true;
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

            if (testCasesModel.Any(testCase => testCase.DimensionOfMatrix > ValidationModel.DimensionOfMatrix || testCase.DimensionOfMatrix < 1))
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("La dimensión de la matrix debe estar entre 1  y {0}", ValidationModel.DimensionOfMatrix));
            }
            return true;
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
            if (testCasesModel == null)
            {
                throw new CubeSummationException("testCasesModel");
            }

            if (ValidationModel.NumberOfOperations < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, "El número de operaciones debe ser un número positivo, valide su configuración.");
            }

            if (testCasesModel.NumberOfOperations > ValidationModel.NumberOfOperations)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("El número de las operaciones debe ser entre 1  y {0}", ValidationModel.NumberOfOperations));
            }
            return true;
        }

        public bool IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(InputFormatModel inputFormatModel)
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(InputFormatModel inputFormatModel)
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(InputFormatModel inputFormatModel)
        {
            throw new NotImplementedException();
        }

        public bool IsAllValidate(InputFormatModel inputFormatModel)
        {
            return IsTheNumberDimensionOfMatrixBetweenRange(inputFormatModel.TestCases);
        }
    }
}