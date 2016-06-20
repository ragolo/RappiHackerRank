namespace Rappi.HackerRank.CubeSummation.Cube3D.Interfaces.Requests
{
    using Models.Responses;

    /// <summary>
    /// 
    /// </summary>
    public interface ICubeSummationCube3DRequest
    {
        /// <summary>
        /// Gets the sum total of cube3 d.
        /// </summary>
        /// <param name="manualPathFile">The manual path file.</param>
        /// <returns></returns>
        CubeSummationCube3DResponses GetSumTotalOfCube3D(string manualPathFile = "");
    }
}