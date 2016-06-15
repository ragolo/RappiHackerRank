namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    using Models.Input;

    /// <summary>
    /// Interface Generate Input Format
    /// </summary>
    public interface IGenerateInputFormat
    {
        /// <summary>
        /// Gets the input format.
        /// </summary>
        /// <returns></returns>
        InputFormatModel GetInputFormat();
    }
}