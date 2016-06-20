namespace Rappi.HackerRank.CubeSummation.Cube3D.Helpers
{
    using Models;

    public static class CubeSummationCube3DHelpers
    {
        /// <summary>
        /// Gets the validation model.
        /// </summary>
        /// <returns></returns>
        public static ValidationModel GetValidationModel()
        {
            var validationModel = new ValidationModel
            {
                DimensionOfMatrix = ConfigurationManagerAppConfig.GetDimensionOfMatrix(),
                TheNumberTestCase = ConfigurationManagerAppConfig.GetNumberTestCase(),
                NumberOfOperations = ConfigurationManagerAppConfig.GetNumberOfOperations(),
                ValueOfBlockMax = ConfigurationManagerAppConfig.GetValueOfBlockMax(),
                ValueOfBlockMin = ConfigurationManagerAppConfig.GetValueOfBlockMin()
            };
            return validationModel;
        }
    }
}