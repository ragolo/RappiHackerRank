namespace Rappi.HackerRank.CubeSummation.Installer
{
    using Cube3D.Validation;

    /// <summary>
    /// Cube3D Configuration Settings
    /// </summary>
    public class CubeSummationConfigurationSettings
    {
        /// <summary>
        /// Gets or sets the path file.
        /// </summary>
        /// <value>
        /// The path file.
        /// </value>
        public string PathFile { get; set; }

        /// <summary>
        /// Gets or sets the generate input format validation.
        /// </summary>
        /// <value>
        /// The generate input format validation.
        /// </value>
        public GenerateInputFormatValidation GenerateInputFormatValidation { get; set; }
    }
}