namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    using System.Collections.Generic;
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
        /// <returns></returns>
        bool IsTheNumberTestCaseBetweenRange(InputFormatModel inputFormatModel);

        /// <summary>
        /// Determines whether [is the number dimension of matrix between range] [the specified test cases model].
        /// </summary>
        /// <param name="testCasesModel">The test cases model.</param>
        /// <returns></returns>
        bool IsTheNumberDimensionOfMatrixBetweenRange(List<TestCasesModel> testCasesModel);

        /// <summary>
        /// Determines whether [is the number of operations between range] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        bool IsTheNumberOfOperationsBetweenRange(InputFormatModel inputFormatModel);

        /// <summary>
        /// Determines whether [is coordinate1 position1 less or equal than coordinate2 position1] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        bool IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(InputFormatModel inputFormatModel);

        /// <summary>
        /// Determines whether [is coordinate1 position2 less or equal than coordinate2 position2] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        bool IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(InputFormatModel inputFormatModel);

        /// <summary>
        /// Determines whether [is coordinate1 position3 less or equal than coordinate2 position3] [the specified input format model].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        bool IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(InputFormatModel inputFormatModel);

        /// <summary>
        /// Determines whether [is all validate].
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <returns></returns>
        bool IsAllValidate(InputFormatModel inputFormatModel);
    }
}