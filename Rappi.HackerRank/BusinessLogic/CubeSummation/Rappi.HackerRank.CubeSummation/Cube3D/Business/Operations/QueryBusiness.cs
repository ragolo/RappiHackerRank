namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Operations
{
    using Interfaces;
    using Models.Input.Operations;

    /// <summary>
    /// Query Model
    /// </summary>
    public class QueryBusiness : IOperation
    {
        /// <summary>
        /// The result
        /// </summary>
        private int result = 0;

        /// <summary>
        /// Gets or sets the query models.
        /// </summary>
        /// <value>
        /// The query models.
        /// </value>
        public QueryModel QueryModels { get; set; }

        /// <summary>
        /// Excecutes this instance.
        /// </summary>
        /// <param name="cube3D"></param>
        public void Excecute(int[, ,] cube3D)
        {
            for (var i = QueryModels.Coordinate1.Position1; i <= QueryModels.Coordinate2.Position1; i++)
            {
                for (var j = QueryModels.Coordinate1.Position2; j <= QueryModels.Coordinate2.Position2; j++)
                {
                    for (var k = QueryModels.Coordinate1.Position3; k <= QueryModels.Coordinate2.Position3; k++)
                    {
                        result += cube3D[i, j, k];
                    }
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether [any value of return].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [any value of return]; otherwise, <c>false</c>.
        /// </value>
        public bool AnyValueOfReturn
        {
            get { return true; }
        }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public int Result
        {
            get { return result; }
        }
    }
}