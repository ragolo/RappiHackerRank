namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    using Models;
    using Models.Input.Operations;

    public interface IUpdateBusinessValidation
    {
        /// <summary>
        /// Determines whether [is value of block less equal to value of block maximum and greater than value of block minimum] [the specified test cases model].
        /// </summary>
        /// <param name="updateModel">The update model.</param>
        /// <param name="validationModel">The validation model.</param>
        /// <returns></returns>
        bool IsValueOfBlockLessEqualToValueOfBlockMaxAndGreaterThanValueOfBlockMin(UpdateModel updateModel, ValidationModel validationModel);
    }
}