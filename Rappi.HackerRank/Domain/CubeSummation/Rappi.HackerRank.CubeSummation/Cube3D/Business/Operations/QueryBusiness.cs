namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Operations
{
    using ConstAndEnumerations;
    using Exceptions;
    using Interfaces;
    using Models.Input.Operations;
    using Validation;

    /// <summary>
    /// Query Model
    /// </summary>
    public class QueryBusiness : IOperation
    {
        /// <summary>
        /// The query business validation
        /// </summary>
        private readonly IQueryBusinessValidation queryBusinessValidation;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBusiness" /> class.
        /// </summary>
        /// <param name="queryBusinessValidation">The query business validation.</param>
        public QueryBusiness(IQueryBusinessValidation queryBusinessValidation)
        {
            this.queryBusinessValidation = queryBusinessValidation;
        }
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
            if (queryBusinessValidation.IsCoordinateGreaterThan0AndLessThanOrEqualDimensionOfMatrix(QueryModels, cube3D.Length))
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
            else
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("Validar las coordenadas de la matrix y su ultima coordenada no puede superior a {0}", cube3D.Length));
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