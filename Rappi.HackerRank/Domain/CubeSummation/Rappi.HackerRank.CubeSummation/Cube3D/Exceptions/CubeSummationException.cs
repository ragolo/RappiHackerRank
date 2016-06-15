namespace Rappi.HackerRank.CubeSummation.Cube3D.Exceptions
{
    using System;
    using ConstAndEnumerations;

    /// <summary>
    /// Cube Summation Exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class CubeSummationException : Exception
    {
        /// <summary>
        /// The type
        /// </summary>
        public CubeSummationExceptionType Type;

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationException"/> class.
        /// </summary>
        public CubeSummationException(): base()
        {
            this.Type = CubeSummationExceptionType.Generic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public CubeSummationException(string message)
            : base(message)
        {
            this.Type = CubeSummationExceptionType.Generic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public CubeSummationException(string message, CubeSummationException innerException)
            : base(message, innerException)
        {
            this.Type = innerException.Type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public CubeSummationException(CubeSummationExceptionType type, string message, Exception inner)
            : base(message, inner)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeSummationException"/> class.
        /// </summary>
        /// <param name="cubeSummationExceptionType">Type of the cube summation exception.</param>
        /// <param name="message">The message.</param>
        public CubeSummationException(CubeSummationExceptionType cubeSummationExceptionType, string message)
            : base(message)
        {
            this.Type = cubeSummationExceptionType;
        }
    }
}