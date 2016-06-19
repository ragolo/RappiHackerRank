namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Validation
{
    using System;
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
        /// Determines whether [is the number test case between range] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">inputFormatModel</exception>
        /// <exception cref="CubeSummationException">El número de casos debe se un número positivo, valide su configuración.</exception>
        public bool IsTheNumberTestCaseBetweenRange(InputFormatModel inputFormatModel, ValidationModel validationModel)
        {
            if (inputFormatModel == null)
            {
                throw new ArgumentNullException("inputFormatModel");
            }
            if (validationModel == null)
            {
                throw new ArgumentNullException("validationModel");
            }

            if (inputFormatModel.NumberOfTestCase < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, "El número de casos debe se un número positivo, valide su configuración.");
            }

            return inputFormatModel.NumberOfTestCase <= validationModel.TheNumberTestCase;
        }

        /// <summary>
        /// Determines whether [is the number dimension of matrix between range] [the specified test cases model].
        /// </summary>
        /// <param name="testCase">The test case.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">testCasesModel</exception>
        /// <exception cref="CubeSummationException">La dimensión de la matrix debe ser un número positivo, valide su configuración.</exception>
        /// <exception cref="System.ArgumentNullException">testCasesModel</exception>
        public bool IsTheNumberDimensionOfMatrixBetweenRange(TestCasesModel testCase, ValidationModel validationModel)
        {
            if (testCase == null) throw new ArgumentNullException("testCase");

            if (validationModel.DimensionOfMatrix < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel,
                    "La dimensión de la matrix debe ser un número positivo, valide su configuración.");
            }

            return (testCase.DimensionOfMatrix >= 1 && testCase.DimensionOfMatrix <= validationModel.DimensionOfMatrix);
        }

        /// <summary>
        /// Determines whether [is the number of operations between range] [the specified input format model].
        /// </summary>
        /// <param name="operations">The operations.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">testCasesModel</exception>
        /// <exception cref="CubeSummationException">El número de operaciones debe ser un número positivo, valide su configuración.
        /// or</exception>
        public bool IsTheNumberOfOperationsBetweenRange(IOperation[] operations, ValidationModel validationModel)
        {
            if (operations == null) throw new ArgumentNullException("operations");

            if (validationModel.NumberOfOperations < 1)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, "El número de operaciones debe ser un número positivo, valide su configuración.");
            }

            return operations.Count() <= validationModel.NumberOfOperations;
        }
    }
}