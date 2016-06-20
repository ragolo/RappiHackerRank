namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D.Requests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    /// <summary>
    /// Cube Summation Cube3D Request Tests
    /// </summary>
    /// <seealso cref="Rappi.HackerRank.CubeSummation.Tests.CubeSummation.Cube3D.Cube3DBaseTests" />
    [TestFixture]
    public class CubeSummationCube3DRequestTests : Cube3DBaseTests
    {
        /// <summary>
        /// Cubes the summation cube3 d request.
        /// </summary>
        [Test]
        public void CubeSummationCube3DRequest()
        {
            var expectResultSumTotal = new List<int> { 4, 4, 27, 0, 1, 1 };
            var resultSumTotal = this.cubeSummationCube3DRequest.GetSumTotalOfCube3D();
            if (!string.IsNullOrWhiteSpace(resultSumTotal.Error))
            {
                Assert.Fail(resultSumTotal.Error);
            }
            Assert.That(expectResultSumTotal, Is.EqualTo(resultSumTotal.Result));
        }
    }
}
