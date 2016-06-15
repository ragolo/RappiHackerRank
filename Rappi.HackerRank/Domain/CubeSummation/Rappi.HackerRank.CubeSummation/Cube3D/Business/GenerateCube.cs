namespace Rappi.HackerRank.CubeSummation.Cube3D.Business
{
    using ConstAndEnumerations;
    using Interfaces;

    /// <summary>
    /// The Generate Cube
    /// </summary>
    /// <seealso cref="Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces.IGenerateCube" />
    public class GenerateCube : IGenerateCube
    {
        /// <summary>
        /// Gets the cube3 d.
        /// </summary>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns>The cube of 3 dimensions</returns>
        public int[, ,] GetCube3D(int dimensionOfMatrix)
        {
            dimensionOfMatrix += CubeSummationCube3DConstAndEnum.IntializeToFirstBlock;
            var cube3D = new int[dimensionOfMatrix, dimensionOfMatrix, dimensionOfMatrix];
            return cube3D;
        }
    }
}