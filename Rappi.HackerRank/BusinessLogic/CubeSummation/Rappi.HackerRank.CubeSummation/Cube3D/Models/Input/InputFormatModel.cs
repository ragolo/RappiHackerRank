namespace Rappi.HackerRank.CubeSummation.Cube3D.Models.Input
{
    /// <summary>
    /// Input Format Model
    /// </summary>
    public class InputFormatModel
    {
        /// <summary>
        /// Gets or sets the number of test case.
        /// </summary>
        /// <value>
        /// The number of test case.
        /// </value>
        public int NumberOfTestCase { get; set; }

        /// <summary>
        /// The test caseses
        /// </summary>
        public TestCasesModel[] TestCases;
    }
}