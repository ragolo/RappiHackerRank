namespace Rappi.HackerRank.CubeSummation.Cube3D.Models.Input
{
    using Operations;

    /// <summary>
    /// Test Cases
    /// </summary>
    public class TestCasesModel
    {
        /// <summary>
        /// Gets or sets the dimension of matrix.
        /// </summary>
        /// <value>
        /// The dimension of matrix.
        /// </value>
        public int DimensionOfMatrix { get; set; }

        /// <summary>
        /// Gets or sets the number of operations.
        /// </summary>
        /// <value>
        /// The number of operations.
        /// </value>
        public int NumberOfOperations { get; set; }

        /// <summary>
        /// The operations
        /// </summary>
        public OperationModel[] Operations;
    }
}