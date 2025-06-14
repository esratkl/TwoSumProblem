using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TwoSumProblem
{
    public class TwoSum
    {
        // HashSet
        public int[] TwoSumHashSet(int[] nums, int target)
        {
            var set = new HashSet<int>();  
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];  
                if (set.Contains(complement))
                {
                    return new int[] { i, Array.IndexOf(nums, target - nums[i]) };
                }
                set.Add(nums[i]);
            }
            return new int[2]; 
        }

        // (HashMap)Dictionary
        public int[] TwoSumDictionary(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>(); 
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { i, dict[complement] };
                }
                dict[nums[i]] = i;
            }
            return new int[2];
        }
    }
}
