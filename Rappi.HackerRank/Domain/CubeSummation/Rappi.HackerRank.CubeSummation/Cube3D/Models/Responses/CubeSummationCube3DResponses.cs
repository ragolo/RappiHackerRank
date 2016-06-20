namespace Rappi.HackerRank.CubeSummation.Cube3D.Models.Responses
{
    using System.Collections.Generic;

    public class CubeSummationCube3DResponses
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationCube3DResponses"/> class.
        /// </summary>
        public CubeSummationCube3DResponses()
        {
            Result = new List<int>();
        }
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public List<int> Result { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public string Error { get; set; }
    }
}