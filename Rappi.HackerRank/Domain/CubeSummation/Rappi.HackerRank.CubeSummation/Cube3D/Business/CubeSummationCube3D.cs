namespace Rappi.HackerRank.CubeSummation.Cube3D.Business
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using ConstAndEnumerations;
    using Exceptions;
    using Cube3D.Interfaces;
    using Models;
    using Models.Input;

    /// <summary>
    /// Cube Summation Cube3D
    /// </summary>
    /// <seealso cref="Rappi.HackerRank.CubeSummation.Cube3D.Interfaces.ICubeSummationCube3D" />
    public class CubeSummationCube3D : ICubeSummationCube3D
    {
        /// <summary>
        /// The generate input format validation
        /// </summary>
        private readonly IGenerateInputFormatValidation generateInputFormatValidation;

        /// <summary>
        /// The generate cube
        /// </summary>
        private readonly IGenerateCube generateCube;

        /// <summary>
        /// The validation model
        /// </summary>
        private readonly ValidationModel validationModel;

        /// <summary>
        /// The cube3 d
        /// </summary>
        private int[, ,] cube3D;

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationCube3D" /> class.
        /// </summary>
        /// <param name="generateInputFormatValidation">The generate input format validation.</param>
        /// <param name="generateCube">The generate cube.</param>
        /// <param name="validationModel">The validation model.</param>
        public CubeSummationCube3D(IGenerateInputFormatValidation generateInputFormatValidation, IGenerateCube generateCube, ValidationModel validationModel)
        {
            this.generateInputFormatValidation = generateInputFormatValidation;
            this.generateCube = generateCube;
            this.validationModel = validationModel;
        }

        /// <summary>
        /// Gets the sum total of each query operation.
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        public List<int> GetSumTotalOfEachQueryOperation(InputFormatModel inputFormatModel)
        {
            try
            {
                var result = new List<int>();

                if (!this.generateInputFormatValidation.IsTheNumberTestCaseBetweenRange(inputFormatModel, this.validationModel))
                {
                    throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("El número de casos de prueba no puede ser mayor a {0}", this.validationModel.TheNumberTestCase));
                }

                foreach (var testCase in inputFormatModel.TestCases)
                {
                    if (!this.generateInputFormatValidation.IsTheNumberDimensionOfMatrixBetweenRange(testCase, this.validationModel))
                    {
                        throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("El número de la dimension de la matrix no pueder se mayor a {0}", this.validationModel.DimensionOfMatrix));
                    }
                    cube3D = generateCube.GetCube3D(testCase.DimensionOfMatrix);

                    if (!this.generateInputFormatValidation.IsTheNumberOfOperationsBetweenRange(testCase.Operations, this.validationModel))
                    {
                        throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("El número de operaciones por casos de prueba no pueder se superior a {0}", this.validationModel.NumberOfOperations));
                    }
                    foreach (var operation in testCase.Operations)
                    {
                        operation.Excecute(cube3D);
                        if (operation.AnyValueOfReturn)
                        {
                            result.Add(operation.Result);
                        }
                    }
                }
                return result;
            }
            catch (CubeSummationException ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, ex.Message);
            }
            catch (Exception ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.Generic, ex.Message);
            }
        }
    }
}