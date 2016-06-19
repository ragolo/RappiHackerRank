namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Validation
{
    using Interfaces;
    using Models;
    using Models.Input.Operations;
    using System;

    /// <summary>
    /// The Update Business Validation
    /// </summary>
    public class UpdateBusinessValidation : IUpdateBusinessValidation
    {

        /// <summary>
        /// Determines whether [is value of block less equal to value of block maximum and greater than value of block minimum] [the specified test cases model].
        /// </summary>
        /// <param name="updateModel">The update model.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">updateModel</exception>
        public bool IsValueOfBlockLessEqualToValueOfBlockMaxAndGreaterThanValueOfBlockMin(UpdateModel updateModel, ValidationModel validationModel)
        {
            if (updateModel == null)
            {
                throw new ArgumentNullException("updateModel");
            }
            return (updateModel.ValueOfBlock >= validationModel.ValueOfBlockMin && updateModel.ValueOfBlock <= validationModel.ValueOfBlockMax);
        }
    }
}