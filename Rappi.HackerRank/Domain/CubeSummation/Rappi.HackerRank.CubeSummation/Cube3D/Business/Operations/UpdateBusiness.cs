namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Operations
{
    using Interfaces;
    using Models.Input.Operations;

    /// <summary>
    /// Update Model
    /// </summary>
    public class UpdateBusiness : IOperation
    {
        /// <summary>
        /// Gets or sets the update models.
        /// </summary>
        /// <value>
        /// The update models.
        /// </value>
        public UpdateModel UpdateModels { get; set; }

        /// <summary>
        /// Excecutes this instance.
        /// </summary>
        /// <param name="cube3D"></param>
        public void Excecute(int[, ,] cube3D)
        {
            cube3D[UpdateModels.Coordinate1.Position1, UpdateModels.Coordinate1.Position2,UpdateModels.Coordinate1.Position3] = UpdateModels.ValueOfBlock;
        }

        /// <summary>
        /// Gets a value indicating whether [any value of return].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [any value of return]; otherwise, <c>false</c>.
        /// </value>
        public bool AnyValueOfReturn
        {
            get { return false; }
        }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public int Result
        {
            get { return 0; }
        }
    }
}