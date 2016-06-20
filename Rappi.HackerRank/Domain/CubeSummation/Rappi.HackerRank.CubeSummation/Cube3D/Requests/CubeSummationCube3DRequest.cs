namespace Rappi.HackerRank.CubeSummation.Cube3D.Requests
{
    using System;
    using Business.Interfaces;
    using Exceptions;
    using Models.Responses;
    using Interfaces.Requests;

    /// <summary>
    /// Cube Summation Cube3D Request
    /// </summary>
    public class CubeSummationCube3DRequest : ICubeSummationCube3DRequest
    {
        /// <summary>
        /// The generate input format
        /// </summary>
        private readonly IGenerateInputFormat generateInputFormat;

        /// <summary>
        /// The cube summation cube3 d
        /// </summary>
        private readonly IGenerateCubeSummationCube3D generateCubeSummationCube3D;

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationCube3DRequest" /> class.
        /// </summary>
        /// <param name="generateInputFormat">The generate input format.</param>
        /// <param name="generateCubeSummationCube3D">The generate cube summation cube3 d.</param>
        public CubeSummationCube3DRequest(IGenerateInputFormat generateInputFormat, IGenerateCubeSummationCube3D generateCubeSummationCube3D)
        {
            this.generateInputFormat = generateInputFormat;
            this.generateCubeSummationCube3D = generateCubeSummationCube3D;
        }

        /// <summary>
        /// Gets the sum total of cube 3D.
        /// </summary>
        /// <param name="manualPathFile">The manual path file.</param>
        /// <returns></returns>
        public CubeSummationCube3DResponses GetSumTotalOfCube3D(string manualPathFile="")
        {
            var cubeSummationCube3DResponses = new CubeSummationCube3DResponses();
            try
            {
                var inputFormat = this.generateInputFormat.GetInputFormat(manualPathFile);
                cubeSummationCube3DResponses.Result = this.generateCubeSummationCube3D.GetSumTotalOfEachQueryOperation(inputFormat);
            }
            catch (CubeSummationException ex)
            {
                cubeSummationCube3DResponses.Error = ex.Message;
            }
            catch (Exception ex)
            {

                cubeSummationCube3DResponses.Error = ex.Message;
            }
            return cubeSummationCube3DResponses;
        }
    }
}
