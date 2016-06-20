namespace Rappi.HackerRank.CubeSummation.Installer
{
    using Cube3D.Business.Validation;
    using Cube3D.Business;
    using Cube3D.Models;

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

        /// <summary>
        /// Gets or sets the query business validation.
        /// </summary>
        /// <value>
        /// The query business validation.
        /// </value>
        public QueryBusinessValidation QueryBusinessValidation { get; set; }

        /// <summary>
        /// Gets or sets the update business validation.
        /// </summary>
        /// <value>
        /// The update business validation.
        /// </value>
        public UpdateBusinessValidation UpdateBusinessValidation { get; set; }

        /// <summary>
        /// Gets or sets the generate cube.
        /// </summary>
        /// <value>
        /// The generate cube.
        /// </value>
        public GenerateCube GenerateCube { get; set; }

        /// <summary>
        /// Gets or sets the validation model.
        /// </summary>
        /// <value>
        /// The validation model.
        /// </value>
        public ValidationModel ValidationModel { get; set; }

        /// <summary>
        /// Gets or sets the generate input format.
        /// </summary>
        /// <value>
        /// The generate input format.
        /// </value>
        public GenerateInputFormatFromText GenerateInputFormat { get; set; }

        /// <summary>
        /// Gets or sets the generate cube summation cube3 d.
        /// </summary>
        /// <value>
        /// The generate cube summation cube3 d.
        /// </value>
        public GenerateCubeSummationCube3D GenerateCubeSummationCube3D { get; set; }
    }
}