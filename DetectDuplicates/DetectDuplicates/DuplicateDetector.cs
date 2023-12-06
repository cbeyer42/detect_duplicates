using DetectDuplicates.Lib.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DetectDuplicates.Lib
{
    public class DuplicateDetector : IDetectDuplicates
    {
        public IEnumerable<IDuplicate> CheckCandidates(IEnumerable<IDuplicate> candidates)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDuplicate> CollectCandidates(string path)
        {
            return CollectCandidates(path, ComparisonTypes.SizeAndName);
        }

        public IEnumerable<IDuplicate> CollectCandidates(string path, ComparisonTypes modus)
        {
            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            if (files.Length < 1)
            {
                return Enumerable.Empty<IDuplicate>();
            }

            throw new NotImplementedException();
        }
    }
}
