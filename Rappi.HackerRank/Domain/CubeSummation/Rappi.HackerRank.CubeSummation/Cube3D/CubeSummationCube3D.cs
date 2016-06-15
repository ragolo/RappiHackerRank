using Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces;
using Rappi.HackerRank.CubeSummation.Cube3D.ConstAndEnumerations;

namespace Rappi.HackerRank.CubeSummation.Cube3D
{
    using System.Collections.Generic;
    using Models.Input;
    using Interfaces;

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

        private int[,,] cube3D;

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationCube3D"/> class.
        /// </summary>
        /// <param name="generateInputFormatValidation">The generate input format validation.</param>
        public CubeSummationCube3D(IGenerateInputFormatValidation generateInputFormatValidation)
        {
            this.generateInputFormatValidation = generateInputFormatValidation;
        }

        /// <summary>
        /// Gets the sum total of each query operation.
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        public List<int> GetSumTotalOfEachQueryOperation(InputFormatModel inputFormatModel)
        {
            var result = new List<int>();
            foreach (var testCase in inputFormatModel.TestCases)
            {
                testCase.DimensionOfMatrix += CubeSummationCube3DConstAndEnum.IntializeToFirstBlock;

                this.cube3D = new int[testCase.DimensionOfMatrix, testCase.DimensionOfMatrix, testCase.DimensionOfMatrix];

                foreach (var operation in testCase.Operations)
                {
                    operation.Excecute(this.cube3D);
                    if (operation.AnyValueOfReturn)
                    {
                       result.Add(operation.Result); 
                    }
                }
            }
            return result;
        }
    }
}