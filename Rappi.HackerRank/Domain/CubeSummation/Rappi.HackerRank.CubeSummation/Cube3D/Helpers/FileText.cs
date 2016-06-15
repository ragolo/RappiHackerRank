namespace Rappi.HackerRank.CubeSummation.Cube3D.Helpers
{
    using System;
    using System.IO;
    using ConstAndEnumerations;
    using Exceptions;

    /// <summary>
    /// File Text
    /// </summary>
    public static class FileText
    {
        /// <summary>
        /// Gets the file from text.
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllLinesOfFile(string pathFile)
        {
            try
            {
                if (File.Exists(pathFile))
                {
                    return File.ReadAllLines(pathFile);
                }
                throw new CubeSummationException(CubeSummationExceptionType.File,"El archivo no existe");
            }
            catch (Exception ex)
            {
                throw new CubeSummationException(CubeSummationExceptionType.File, ex.Message);
            }
        }
    }
}