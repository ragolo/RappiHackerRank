namespace Rappi.HackerRank.CubeSummation.Cube3D.ConstAndEnumerations
{
    /// <summary>
    /// Input Format Const And Enum
    /// </summary>
    public static class InputFormatConstAndEnum
    {
        /// <summary>
        /// The operation query start with
        /// </summary>
        public const string OperationQueryStartWith = "QUERY";

        /// <summary>
        /// The operaton update start with
        /// </summary>
        public const string OperatonUpdateStartWith = "UPDATE";

        public enum OperationType
        {
            Query = 1,
            Update=2
        }
    }
}