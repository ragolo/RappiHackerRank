namespace Rappi.HackerRank.CubeSummation.Cube3D.Interfaces
{
    using System.Collections.Generic;
    using Models.Input;

    /// <summary>
    /// 
    /// </summary>
    public interface ICubeSummationCube3D
    {
        List<int> GetSumTotalOfEachQueryOperation(InputFormatModel inputFormatModel);
    }
}