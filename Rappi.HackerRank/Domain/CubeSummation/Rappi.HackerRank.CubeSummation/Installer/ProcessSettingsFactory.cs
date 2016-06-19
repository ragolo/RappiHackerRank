namespace Rappi.HackerRank.CubeSummation.Installer
{
    using Cube3D.Business;
    using Cube3D.Business.Validation;
    using Cube3D.Helpers;
    using Cube3D.Models;

    /// <summary>
    /// Process Settings Factory
    /// </summary>
    public class ProcessSettingsFactory
    {

        /// <summary>
        /// Creates the process settings.
        /// </summary>
        /// <returns></returns>
        public CubeSummationConfigurationSettings CreateProcessSettings()
        {
            var validationModel = new ValidationModel
            {
                DimensionOfMatrix = ConfigurationManagerAppConfig.GetDimensionOfMatrix(),
                TheNumberTestCase = ConfigurationManagerAppConfig.GetNumberTestCase(),
                NumberOfOperations = ConfigurationManagerAppConfig.GetNumberOfOperations(),
                ValueOfBlockMax = ConfigurationManagerAppConfig.GetValueOfBlockMax(),
                ValueOfBlockMin = ConfigurationManagerAppConfig.GetValueOfBlockMin()
            };
            var settings = new CubeSummationConfigurationSettings()
            {
                ValidationModel = validationModel,
                PathFile = ConfigurationManagerAppConfig.GetPathFile(),
                GenerateInputFormatValidation = new GenerateInputFormatValidation(validationModel),
                GenerateCube = new GenerateCube()
            };

            return settings;
        }
    }
}