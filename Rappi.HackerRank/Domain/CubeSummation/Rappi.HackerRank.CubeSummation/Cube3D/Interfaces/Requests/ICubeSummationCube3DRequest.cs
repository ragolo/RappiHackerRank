namespace Rappi.HackerRank.CubeSummation.Cube3D.Interfaces.Requests
{
    using Models.Responses;

    public interface ICubeSummationCube3DRequest
    {
        /// <summary>
        /// Gets the sum total of cube3 d.
        /// </summary>
        /// <returns></returns>
        CubeSummationCube3DResponses GetSumTotalOfCube3D();
    }
}