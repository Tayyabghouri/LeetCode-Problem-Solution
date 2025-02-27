using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LeetCode
    {
        //public int[] TwoSum(int[] nums, int target)
        //{
        //    int index = 0;
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        index = i;
        //        for (int j = index; j < nums.Length - 1; j++)
        //        {

        //            if (nums[i] + nums[j + 1] == target)
        //            {
        //                return new int[] { i, j + 1 };
        //            }
        //        }

        //    }
        //    return new int[0];
        //}

        public int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store numbers and their indices
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            // Loop through the array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i]; // Calculate the complement

                // If the complement is already in the dictionary, return the pair of indices
                if (numIndices.ContainsKey(complement))
                {
                    return new int[] { numIndices[complement], i }; // Return the indices
                }

                // Otherwise, add the current number and its index to the dictionary
                numIndices[nums[i]] = i;
            }

            // If no solution is found, return an empty array
            return new int[0];
        }

    }
}
