using System;
using System.Collections.Generic;
using System.Text;

namespace DetectDuplicates.Lib.Contracts
{
    public enum ComparisonTypes
    {
        SizeAndName,
        Size
    }

    public interface IDetectDuplicates
    {
        IEnumerable<IDuplicate> CollectCandidates(string pfad);
        IEnumerable<IDuplicate> CollectCandidates(string pfad, ComparisonTypes modus);
        IEnumerable<IDuplicate> CheckCandidates(IEnumerable<IDuplicate> candidates);
    }
}
