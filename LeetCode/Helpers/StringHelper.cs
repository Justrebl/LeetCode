using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Helpers
{
    public static class StringHelper
    {
        public static string PrepareResult(this IList<int> intResults)
        {
            return intResults.Aggregate(new StringBuilder(), (fullResult, nextVal) => { return new StringBuilder(fullResult.ToString() + (fullResult.ToString().Length > 0 ? "," : "") + nextVal.ToString()); }).ToString();
        }
    }
}
