namespace Rappi.HackerRank.CubeSummation.Cube3D
{
    using System;
    using System.IO;
    using Interfaces;
    using Models.Input;

    /// <summary>
    /// Generate Cube3D
    /// </summary>
    public class GenerateInputFormat : IGenerateInputFormat
    {
        /// <summary>
        /// Gets the input format.
        /// </summary>
        /// <returns></returns>
        public InputFormatModel GetInputFormat()
        {
            var file = @"C:\CubeSummation3D\input00.txt";

            if (File.Exists(file))
            {
                var lines = File.ReadAllLines(file);

                //obtiene el numero de casos
                var inputFormatModel = new InputFormatModel { NumberOfTestCase = Convert.ToInt32(lines[0]) };

                //armar los casos de uso
                for (int i = 1; i < lines.Length; i++)
                {
                    var testCase = lines[i].Split(' ');
                    var dimensionOfMatrix = Convert.ToInt32(testCase[0]);
                    var numberOfOperations = Convert.ToInt32(testCase[1]);

                    inputFormatModel.TestCases.Add(new TestCasesModel()
                    {
                        DimensionOfMatrix = dimensionOfMatrix,
                        NumberOfOperations = numberOfOperations
                    });

                    i += numberOfOperations;
                }
            }
            return new InputFormatModel();
        }
    }
}