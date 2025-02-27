using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyHashMap
    {
        Dictionary<int, int> objHashMap;

        public MyHashMap()
        {
            objHashMap = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            
                objHashMap[key] = value;
                
            
        }

        public int Get(int key)
        {
            if (objHashMap.ContainsKey(key))
            {
                return objHashMap[key];
            }
            else
            {
                return -1;
            }
        }

        public void Remove(int key)
        {
            if (objHashMap.ContainsKey(key))
            {
                objHashMap.Remove(key);
            }
        }

        
            public bool ContainsDuplicate(int[] nums)
            {

                int count = 0;
                HashSet<int> objHasSet = new HashSet<int>();
                foreach (int number in nums)
                {
                if (objHasSet.Contains(number))
                {
                    count++;
                    if(count == 2) return true;
                }
                objHasSet.Add(number);

          
                
                }
            return false;

        }

        public int SingleNumber(int[] nums)
        {
            HashSet<int> findNumber = new HashSet<int>();
            foreach (int num in nums)
            {
                if (findNumber.Contains(num))
                {
                    findNumber.Remove(num);
                }
                else
                {
                    findNumber.Add(num);
                }

            }
            foreach (int single in findNumber)
            {
                return single;
            }

            return -1;

        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> findIntersaction = new HashSet<int>(nums1);
            findIntersaction.IntersectWith(nums2);
            return findIntersaction.ToArray();
        }


        //public bool IsHappy(int n)
        //{
        //    HashSet<int> findNumber = new HashSet<int>();
        //    int firstDigit = 0;
        //    int secondtDigit = 0;
        //    int sum = 0;
        //    if (n >= 0)
        //    {
        //        while (n > 1)
        //        {
        //            firstDigit = n % 10;

        //            secondtDigit = n /= 10;
        //            sum += (firstDigit * firstDigit) + (secondtDigit * secondtDigit);
        //            n = sum;
        //            sum = 0;
        //            secondtDigit = 0;
        //            firstDigit = 0;

        //            if (n == 1)
        //            {
        //                return true;
        //            }

        //        }

        //    }
        //    return false;
        //}
        public bool IsHappy(int n)
        {
            // HashSet to store numbers we've already encountered (cycle detection)
            HashSet<int> seenNumbers = new HashSet<int>();

            // Loop until the number becomes 1 or we detect a cycle
            while (n != 1)
            {
                if (seenNumbers.Contains(n))
                {
                    // If we've seen this number before, it's in a cycle (not a happy number)
                    return false;
                }

                // Add the current number to the set to track it
                seenNumbers.Add(n);

                // Calculate the sum of the squares of the digits
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;  // Add the square of the digit to the sum
                    n /= 10;  // Remove the last digit from n
                }

                // Set n to the sum for the next iteration
                n = sum;
            }

            // If we reach 1, it's a happy number
            return true;
        }


    }
}
