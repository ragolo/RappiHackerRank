namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    using Models;
    using Models.Input;

    /// <summary>
    /// Interface Generate Input Format Validation
    /// </summary>
    public interface IGenerateInputFormatValidation
    {

        /// <summary>
        /// Determines whether [is the number test case between range] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        bool IsTheNumberTestCaseBetweenRange(InputFormatModel inputFormatModel, ValidationModel validationModel);

        /// <summary>
        /// Determines whether [is the number dimension of matrix between range] [the specified test cases model].
        /// </summary>
        /// <param name="testCase">The test case.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        bool IsTheNumberDimensionOfMatrixBetweenRange(TestCasesModel testCase, ValidationModel validationModel);

        /// <summary>
        /// Determines whether [is the number of operations between range] [the specified input format model].
        /// </summary>
        /// <param name="operations">The operations.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        bool IsTheNumberOfOperationsBetweenRange(IOperation[] operations, ValidationModel validationModel);
    }
}