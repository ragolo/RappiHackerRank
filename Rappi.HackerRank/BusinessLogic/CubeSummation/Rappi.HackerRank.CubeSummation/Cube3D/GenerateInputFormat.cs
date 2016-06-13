namespace Rappi.HackerRank.CubeSummation.Cube3D
{
    using System;
    using System.IO;
    using ConstAndEnumerations;
    using Interfaces;
    using Models;
    using Models.Input;
    using Models.Input.Operations;

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
            var inputFormatModel = new InputFormatModel();

            if (File.Exists(file))
            {
                var lines = File.ReadAllLines(file);

                SetNumberOfTestCase(inputFormatModel, lines);
                SetTestCases(inputFormatModel, lines);
                SetOperations(inputFormatModel, lines);
            }

            return inputFormatModel;
        }

        /// <summary>
        /// Sets the number of test case.
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <param name="lines">The lines.</param>
        private void SetNumberOfTestCase(InputFormatModel inputFormatModel, string[] lines)
        {
            inputFormatModel.NumberOfTestCase = Convert.ToInt32(lines[0]);
        }

        /// <summary>
        /// Sets the test cases.
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <param name="lines">The lines.</param>
        private void SetTestCases(InputFormatModel inputFormatModel, string[] lines)
        {
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

        /// <summary>
        /// Sets the operations.
        /// </summary>
        /// <param name="inputFormatModel">The input format model.</param>
        /// <param name="lines">The lines.</param>
        private void SetOperations(InputFormatModel inputFormatModel, string[] lines)
        {
            var positionTestCase = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                var numberOfOperations = Convert.ToInt32(lines[i].Split(' ')[1]);
                var currentPositionOfOperation = i + 1;
                var indexPositionOfOperation = 0;
                inputFormatModel.TestCases[positionTestCase].Operations = new object[numberOfOperations];

                i += numberOfOperations;

                while (numberOfOperations > 0)
                {
                    if (lines[currentPositionOfOperation].StartsWith(InputFormatConstAndEnum.OperatonUpdateStartWith))
                    {
                        var updateModel = new UpdateModel()
                        {
                            Coordinate1 =
                                new CoordinateModel
                                {
                                    Position1 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[1]),
                                    Position2 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[2]),
                                    Position3 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[3]),
                                },
                            ValueOfBlock = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[4])
                        };
                        inputFormatModel.TestCases[positionTestCase].Operations[indexPositionOfOperation] = updateModel;
                    }
                    else if (lines[currentPositionOfOperation].StartsWith(InputFormatConstAndEnum.OperationQueryStartWith))
                    {
                        var queryModel = new QueryModel()
                        {
                            Coordinate1 =
                                new CoordinateModel
                                {
                                    Position1 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[1]),
                                    Position2 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[2]),
                                    Position3 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[3]),
                                },
                            Coordinate2 =
                                new CoordinateModel
                                {
                                    Position1 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[4]),
                                    Position2 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[5]),
                                    Position3 = Convert.ToInt32(lines[currentPositionOfOperation].Split(' ')[6])
                                }
                        };
                        inputFormatModel.TestCases[positionTestCase].Operations[indexPositionOfOperation] = queryModel;
                    }

                    currentPositionOfOperation += 1;
                    numberOfOperations -= 1;
                    indexPositionOfOperation += 1;
                }

                positionTestCase += 1;
            }
        }
    }
}