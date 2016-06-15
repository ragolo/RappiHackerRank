namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    public interface IGenerateCube
    {
        /// <summary>
        /// Gets the cube3 d.
        /// </summary>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        int[, ,] GetCube3D(int dimensionOfMatrix);
    }
}