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

        public bool IsTheNumberTestCaseBetweenRange(InputFormatModel inputFormatModel)
        {
            throw new NotImplementedException();
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

            if (testCasesModel.Any(testCase => testCase.DimensionOfMatrix > ValidationModel.DimensionOfMatrix))
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("La dimensión de la matrix no debe ser mayor a {0}", ValidationModel.DimensionOfMatrix));
            }
            return true;
        }

        public bool IsTheNumberOfOperationsBetweenRange(InputFormatModel inputFormatModel)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}