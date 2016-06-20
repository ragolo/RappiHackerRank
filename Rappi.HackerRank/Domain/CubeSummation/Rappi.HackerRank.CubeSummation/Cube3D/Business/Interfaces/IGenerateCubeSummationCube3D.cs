namespace Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces
{
    using System.Collections.Generic;
    using Models.Input;

    /// <summary>
    /// 
    /// </summary>
    public interface IGenerateCubeSummationCube3D
    {
        List<int> GetSumTotalOfEachQueryOperation(InputFormatModel inputFormatModel);
    }
}