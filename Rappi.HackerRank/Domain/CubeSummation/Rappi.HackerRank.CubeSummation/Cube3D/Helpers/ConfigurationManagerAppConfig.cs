﻿using Rappi.HackerRank.CubeSummation.Cube3D.Exceptions;

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

        /// <summary>
        /// Gets the number test case.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="CubeSummationException">El numero de caso debe ser númerico validar por favor</exception>
        public static Int32 GetNumberTestCase()
        {
            try
            {
                var numberTestCase = ConfigurationManager.AppSettings[AppSettingsConstants.NumberTestCase];
                if (numberTestCase == null)
                {
                    throw new ArgumentNullException(AppSettingsConstants.NumberTestCase);
                }
                return Convert.ToInt32(numberTestCase);

            }
            catch (Exception ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.AppSettings, "El numero de caso debe ser númerico validar por favor");
            }
        }

        /// <summary>
        /// Gets the number of operations.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="CubeSummationException">El numero de operaciones debe ser númerico validar por favor</exception>
        public static Int32 GetNumberOfOperations()
        {
            try
            {
                var numberOfOperations = ConfigurationManager.AppSettings[AppSettingsConstants.NumberOfOperations];
                if (numberOfOperations == null)
                {
                    throw new CubeSummationException(AppSettingsConstants.NumberOfOperations);
                }
                return Convert.ToInt32(numberOfOperations);

            }
            catch (Exception ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.AppSettings, "El numero de operaciones debe ser númerico validar por favor");
            }
        }
    }
}