using Rappi.HackerRank.CubeSummation.Cube3D.Exceptions;

namespace Rappi.HackerRank.CubeSummation.Cube3D.Helpers
{
    using System;
    using System.Configuration;
    using ConstAndEnumerations;

    /// <summary>
    /// Configuration Manager AppConfig
    /// </summary>
    public static class ConfigurationManagerAppConfig
    {
        /// <summary>
        /// Gets the path file.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static string GetPathFile()
        {
            var pathFile = ConfigurationManager.AppSettings[AppSettingsConstants.PathFile];
            if (pathFile == null)
            {
                throw new ArgumentNullException(AppSettingsConstants.PathFile);
            }
            return pathFile;
        }

        /// <summary>
        /// Gets the dimension of matrix.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="CubeSummationException">La dimension de la matrix debe ser númerica validar por favor</exception>
        public static Int32 GetDimensionOfMatrix()
        {
            try
            {
                var dimensionOfMatrix = ConfigurationManager.AppSettings[AppSettingsConstants.DimensionOfMatrix];
                if (dimensionOfMatrix == null)
                {
                    throw new ArgumentNullException(AppSettingsConstants.DimensionOfMatrix);
                }
                return Convert.ToInt32(dimensionOfMatrix);

            }
            catch (Exception ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.AppSettings, "La dimension de la matrix debe ser númerica validar por favor");
            }
        }
    }
}