namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Validation
{
    using System;
    using Interfaces;
    using Models.Input.Operations;

    /// <summary>
    /// The Query Business Validation
    /// </summary>
    public class QueryBusinessValidation : IQueryBusinessValidation
    {
        /// <summary>
        /// Determines whether [is coordinate1 position1 less or equal than coordinate2 position1] [the specified input format model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">queryModel</exception>
        public bool IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(QueryModel queryModel, int dimensionOfMatrix)
        {
            if (queryModel == null)
            {
                throw new ArgumentNullException("queryModel");
            }

            return (queryModel.Coordinate1.Position1 >= 1 && queryModel.Coordinate1.Position1 <= queryModel.Coordinate2.Position1 && queryModel.Coordinate2.Position1 <= dimensionOfMatrix);
        }

        /// <summary>
        /// Determines whether [is coordinate1 position2 less or equal than coordinate2 position2] [the specified test cases model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Operations</exception>
        public bool IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(QueryModel queryModel, int dimensionOfMatrix)
        {
            if (queryModel == null)
            {
                throw new ArgumentNullException("queryModel");
            }

            return (queryModel.Coordinate1.Position2 >= 1 && queryModel.Coordinate1.Position2 <= queryModel.Coordinate2.Position2 && queryModel.Coordinate2.Position2 <= dimensionOfMatrix);
        }

        /// <summary>
        /// Determines whether [is coordinate1 position3 less or equal than coordinate2 position3] [the specified input format model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Operations</exception>
        public bool IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(QueryModel queryModel, int dimensionOfMatrix)
        {
            if (queryModel == null)
            {
                throw new ArgumentNullException("queryModel");
            }

            return (queryModel.Coordinate1.Position3 >= 1 && queryModel.Coordinate1.Position3 <= queryModel.Coordinate2.Position3 && queryModel.Coordinate2.Position3 <= dimensionOfMatrix);
        }

        /// <summary>
        /// Determines whether [is coordinate greater than maximum int32 and less than dimension of matrix] [the specified test cases model].
        /// </summary>
        /// <param name="queryModel">The query model.</param>
        /// <param name="dimensionOfMatrix">The dimension of matrix.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Operations</exception>
        public bool IsCoordinateGreaterThan0AndLessThanOrEqualDimensionOfMatrix(QueryModel queryModel, int dimensionOfMatrix)
        {
            if (queryModel == null)
            {
                throw new ArgumentNullException("queryModel");
            }
            return (IsCoordinate1Position1LessOrEqualThanCoordinate2Position1(queryModel, dimensionOfMatrix) &&
                    IsCoordinate1Position2LessOrEqualThanCoordinate2Position2(queryModel, dimensionOfMatrix) &&
                    IsCoordinate1Position3LessOrEqualThanCoordinate2Position3(queryModel, dimensionOfMatrix));
        }
    }
}