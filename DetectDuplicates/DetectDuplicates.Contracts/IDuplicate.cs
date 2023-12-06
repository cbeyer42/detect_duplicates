using System;
using System.Collections.Generic;
using System.Text;

namespace DetectDuplicates.Lib.Contracts
{
    public interface IDuplicate
    {
        IEnumerable<string> Dateipfade { get; }
    }
}
