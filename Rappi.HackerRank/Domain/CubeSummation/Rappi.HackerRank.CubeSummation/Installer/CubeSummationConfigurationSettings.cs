﻿namespace Rappi.HackerRank.CubeSummation.Installer
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
    }
}