namespace Rappi.HackerRank.CubeSummation.Installer
{
    using Cube3D.Business;
    using Cube3D.Business.Validation;
    using Cube3D.Helpers;

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
            
            var settings = new CubeSummationConfigurationSettings()
            {
                ValidationModel = CubeSummationCube3DHelpers.GetValidationModel(),
                PathFile = ConfigurationManagerAppConfig.GetPathFile(),
                GenerateInputFormatValidation = new GenerateInputFormatValidation(),
                QueryBusinessValidation = new QueryBusinessValidation(),
                UpdateBusinessValidation = new UpdateBusinessValidation(),
                GenerateCube = new GenerateCube()
            };

            return settings;
        }
    }
}