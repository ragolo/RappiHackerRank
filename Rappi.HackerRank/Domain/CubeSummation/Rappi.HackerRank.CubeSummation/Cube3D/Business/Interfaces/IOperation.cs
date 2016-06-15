namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    /// <summary>
    /// IOperation
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Excecutes this instance.
        /// </summary>
        void Excecute(int[, ,] cube3D);

        /// <summary>
        /// Gets a value indicating whether [any value of return].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [any value of return]; otherwise, <c>false</c>.
        /// </value>
        bool AnyValueOfReturn { get;}

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        int Result { get;}
    }
}
