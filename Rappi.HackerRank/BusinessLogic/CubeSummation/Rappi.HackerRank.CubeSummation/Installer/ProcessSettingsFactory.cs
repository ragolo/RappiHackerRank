namespace Rappi.HackerRank.CubeSummation.Installer
{
    using Cube3D.Helpers;
    using Cube3D.Validation;

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
                PathFile = FileText.GetPathFile(),
                GenerateInputFormatValidation = new GenerateInputFormatValidation()
            };

            return settings;
        }
    }
}