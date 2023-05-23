using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.SectionB
{
    class SubsetSumProblem
    {
        public static bool sumExists(int[] set, int sum, int n)
        {
            // Base Cases
            if (sum == 0)
                return true;
            if (n == 0)
                return false;

            // If last element is greater than sum, then ignore it
            if (set[n - 1] > sum)
                return sumExists(set, sum, n - 1);

            //else, check if sum can be obtained by any of the following
            //(a) including the last element
            //(b) excluding the last element
            return sumExists(set, sum, n - 1) || sumExists(set, sum - set[n - 1], n - 1);
        }
    }
}
