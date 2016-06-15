using Rappi.HackerRank.CubeSummation.Cube3D.Business;
using Rappi.HackerRank.CubeSummation.Cube3D.Models;

namespace Rappi.HackerRank.CubeSummation.Installer
{
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
                PathFile = ConfigurationManagerAppConfig.GetPathFile(),
                GenerateInputFormatValidation = new GenerateInputFormatValidation(new ValidationModel
                {
                    DimensionOfMatrix = ConfigurationManagerAppConfig.GetDimensionOfMatrix()
                }),
                GenerateCube = new GenerateCube()
            };

            return settings;
        }
    }
}