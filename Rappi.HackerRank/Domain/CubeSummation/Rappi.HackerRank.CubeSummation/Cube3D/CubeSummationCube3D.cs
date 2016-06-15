using System;
using Rappi.HackerRank.CubeSummation.Cube3D.ConstAndEnumerations;
using Rappi.HackerRank.CubeSummation.Cube3D.Exceptions;

namespace Rappi.HackerRank.CubeSummation.Cube3D
{
    using System.Collections.Generic;
    using Business.Interfaces;
    using Interfaces;
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
        /// The cube3 d
        /// </summary>
        private int[, ,] cube3D;

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationCube3D"/> class.
        /// </summary>
        /// <param name="generateInputFormatValidation">The generate input format validation.</param>
        public CubeSummationCube3D(IGenerateInputFormatValidation generateInputFormatValidation, IGenerateCube generateCube)
        {
            this.generateInputFormatValidation = generateInputFormatValidation;
            this.generateCube = generateCube;
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
                if (generateInputFormatValidation.IsAllValidate(inputFormatModel))
                {
                    foreach (var testCase in inputFormatModel.TestCases)
                    {
                        cube3D = generateCube.GetCube3D(testCase.DimensionOfMatrix);

                        foreach (var operation in testCase.Operations)
                        {
                            operation.Excecute(cube3D);
                            if (operation.AnyValueOfReturn)
                            {
                                result.Add(operation.Result);
                            }
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