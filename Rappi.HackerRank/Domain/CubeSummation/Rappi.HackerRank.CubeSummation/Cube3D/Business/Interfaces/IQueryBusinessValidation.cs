namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    using Models.Input.Operations;

    public interface IQueryBusinessValidation
    {
        /// <summary>
        /// Determines whether [is coordinate1 position1 less or equal than coordinate2 position1] [the specified test cases model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        bool IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(QueryModel queryModel, int dimensionOfMatrix);

        /// <summary>
        /// Determines whether [is coordinate1 position2 less or equal than coordinate2 position2] [the specified test cases model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        bool IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(QueryModel queryModel, int dimensionOfMatrix);

        /// <summary>
        /// Determines whether [is coordinate1 position3 less or equal than coordinate2 position3] [the specified test cases model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        bool IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(QueryModel queryModel, int dimensionOfMatrix);

        /// <summary>
        /// Determines whether [is coordinate greater than0 and less than or equal dimension of matrix] [the specified test cases model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        bool IsCoordinateGreaterThan0AndLessThanOrEqualDimensionOfMatrix(QueryModel queryModel, int dimensionOfMatrix);
    }
}