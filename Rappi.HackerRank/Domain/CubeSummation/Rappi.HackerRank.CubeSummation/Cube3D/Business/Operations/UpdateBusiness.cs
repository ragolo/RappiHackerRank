namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Operations
{
    using ConstAndEnumerations;
    using Exceptions;
    using Interfaces;
    using Models;
    using Models.Input.Operations;

    /// <summary>
    /// Update Model
    /// </summary>
    public class UpdateBusiness : IOperation
    {
        /// <summary>
        /// The update business validation
        /// </summary>
        private readonly IUpdateBusinessValidation updateBusinessValidation;

        /// <summary>
        /// The validation model
        /// </summary>
        private readonly ValidationModel validationModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBusiness" /> class.
        /// </summary>
        /// <param name="updateBusinessValidation">The update business validation.</param>
        /// <param name="validationModel">The validation model.</param>
        public UpdateBusiness(IUpdateBusinessValidation updateBusinessValidation, ValidationModel validationModel)
        {
            this.updateBusinessValidation = updateBusinessValidation;
            this.validationModel = validationModel;
        }

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
            if (updateBusinessValidation.IsValueOfBlockLessEqualToValueOfBlockMaxAndGreaterThanValueOfBlockMin(UpdateModels, validationModel))
            {
                cube3D[UpdateModels.Coordinate1.Position1, UpdateModels.Coordinate1.Position2, UpdateModels.Coordinate1.Position3] = UpdateModels.ValueOfBlock;
            }
            else
            {
                throw new CubeSummationException(CubeSummationExceptionType.ValidationModel, string.Format("El número maximo para actualizar el valor de la matrix esta entre {0} y {1}", validationModel.ValueOfBlockMin, validationModel.ValueOfBlockMax));
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