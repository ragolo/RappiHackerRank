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
        /// <exception cref="System.NotImplementedException"></exception>
        public List<int> GetSumTotalOfEachQueryOperation(InputFormatModel inputFormatModel)
        {
            throw new System.NotImplementedException();
        }
    }
}