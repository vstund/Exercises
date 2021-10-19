﻿using System;

namespace Exercises.Level1
{
    /// <summary>
    /// Medium array problems -- 1 loop.
    /// </summary>
    public class Array2
    {
        /// <summary>
        ///  Return the number of even ints in the given array. Note: the % "mod" operator computes
        ///  the remainder, e.g. 5 % 2 is 1.
        /// 
        /// countEvens([2, 1, 2, 3, 4]) → 3
        /// countEvens([2, 2, 0]) → 3
        /// countEvens([1, 3, 5]) → 0
        /// </summary>
        public int CountEvens(int[] nums)
        {
            int even = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                }
            }
            return even;
        }
        // Mājās

        /// <summary>
        /// Given an array length 1 or more of ints, return the difference between the largest and
        /// smallest values in the array. Note: the built-in Math.min(v1, v2) and Math.max(v1, v2)
        /// methods return the smaller or larger of two values.
        /// 
        /// bigDiff([10, 3, 5, 6]) → 7
        /// bigDiff([7, 2, 10, 9]) → 8
        /// bigDiff([2, 10, 7, 2]) → 8
        /// </summary>
        ///
        public int BigDiff(int[] nums)
        {
            int smalest = nums[0];
            int largest = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                smalest = Math.Min(smalest, nums[i]);
                largest = Math.Max(largest, nums[i]);
            }
            return largest - smalest;
        }

        /// <summary>
        /// Return the "centered" average of an array of ints, which we'll say is the mean average of
        /// the values, except ignoring the largest and smallest values in the array. If there are
        /// multiple copies of the smallest value, ignore just one copy, and likewise for the largest
        /// value. Use int division to produce the final average. You may assume that the array is
        /// length 3 or more.
        /// 
        /// centeredAverage([1, 2, 3, 4, 100]) → 3
        /// centeredAverage([1, 1, 5, 5, 10, 8, 7]) → 5
        /// centeredAverage([-10, -4, -2, -4, -2, 0]) → -3
        /// </summary>
        public int CenteredAverage(int[] nums)
        {
            int smalest = nums[0];
            int largest = nums[0];
            int sum = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                smalest = Math.Min(smalest, nums[i]);
                largest = Math.Max(largest, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return (sum - smalest - largest) / (nums.Length - 2);
        }

        /// <summary>
        /// Return the sum of the numbers in the array, returning 0 for an empty array. Except the
        /// number 13 is very unlucky, so it does not count and numbers that come immediately after
        /// a 13 also do not count.
        /// 
        /// sum13([1, 2, 2, 1]) → 6
        /// sum13([1, 1]) → 2
        /// sum13([1, 2, 2, 1, 13]) → 6
        /// </summary>
        public int Sum13(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 13)
                {
                    sum -= nums[j];
                }
            }
            for (int k = 1; k < nums.Length; k++)
            {
                if (nums[k - 1] == 13 && nums[k] != 13)
                {
                    sum -= nums[k];
                }
            }
            return sum;
        }

        /// <summary>
        /// Return the sum of the numbers in the array, except ignore sections of numbers starting
        /// with a 6 and extending to the next 7 (every 6 will be followed by at least one 7). Return 0
        /// for no numbers.
        /// 
        /// sum67([1, 2, 2]) → 5
        /// sum67([1, 2, 2, 6, 99, 99, 7]) → 5
        /// sum67([1, 1, 6, 7, 2]) → 4
        /// </summary>
        public int Sum67(int[] nums)
        {
            int sum = 0;
            bool count = true;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 6)
                {
                    count = false;
                }
                if (i > 1)
                {
                    if (!count && nums[i - 1] == 7 && nums[i] != 6)
                    {
                        count = true;
                    }
                }
                if (count)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
        /// 
        /// has22([1, 2, 2]) → true
        /// has22([1, 2, 1, 2]) → false
        /// has22([2, 1, 2]) → false
        /// </summary>
        public bool Has22(int[] nums)
        {
            bool has2two = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == 2 && nums[i - 1] == 2)
                {
                    has2two = true;
                }
            }
            return has2two;
        }

        /// <summary>
        /// Given an array of ints, return true if the array contains no 1's and no 3's.
        /// 
        /// lucky13([0, 2, 4]) → true
        /// lucky13([1, 2, 3]) → false
        /// lucky13([1, 2, 4]) → false
        /// </summary>
        public bool Lucky13(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3 || nums[i] == 1)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
        /// 
        /// sum28([2, 3, 2, 2, 4, 2]) → true
        /// sum28([2, 3, 2, 2, 4, 2, 2]) → false
        /// sum28([1, 2, 3, 4]) → false
        /// </summary>
        public bool Sum28(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    sum += 2;
                }
            }
            return sum == 8 ? true : false;
        }

        /// <summary>
        /// Given an array of ints, return true if the number of 1's is greater than the number of 4's
        /// 
        /// more14([1, 4, 1]) → true
        /// more14([1, 4, 1, 4]) → false
        /// more14([1, 1]) → true
        /// </summary>
        public bool More14(int[] nums)
        {
            int sum1 = 0;
            int sum4 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    sum1 += 1;
                }
                if (nums[i] == 4)
                {
                    sum4 += 1;
                }
            }
            return sum1 > sum4 ? true : false;
        }

        /// <summary>
        /// Given a number n, create and return a new int array of length n, containing the numbers
        /// 0, 1, 2, ... n-1. The given n may be 0, in which case just return a length 0 array. You do
        /// not need a separate if-statement for the length-0 case; the for-loop should naturally
        /// execute 0 times in that case, so it just works.
        /// 
        /// fizzArray(4) → [0, 1, 2, 3]
        /// fizzArray(1) → [0]
        /// fizzArray(10) → [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
        /// </summary>
        public int[] FizzArray(int n)
        {
            int[] newArray = new int[n];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }

        /// <summary>
        /// Given an array of ints, return true if every element is a 1 or a 4.
        /// 
        /// only14([1, 4, 1, 4]) → true
        /// only14([1, 4, 2, 4]) → false
        /// only14([1, 1]) → true
        /// </summary>
        public bool Only14(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 1 && nums[i] != 4)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Given a number n, create and return a new string array of length n, containing the strings
        /// "0", "1" "2" .. through n-1. N may be 0, in which case just return a length 0 array. Note:
        /// String.valueOf(xxx) will make the String form of most types.
        /// 
        /// fizzArray2(4) → ["0", "1", "2", "3"]
        /// fizzArray2(10) → ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
        /// fizzArray2(2) → ["0", "1"]
        /// </summary>
        public string[] FizzArray2(int nums)
        {
            string[] newArray = new string[nums];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i.ToString();
            }
            return newArray;
        }

        /// <summary>
        /// Given an array of ints, return true if it contains no 1's or it contains no 4's.
        /// 
        /// no14([1, 2, 3]) → true
        /// no14([1, 2, 3, 4]) → false
        /// no14([2, 3, 4]) → true
        /// </summary>
        public bool No14(int[] nums)
        {
            bool countains1 = false;
            bool countains4 = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    countains1 = true;
                }
                if (nums[i] == 4)
                {
                    countains4 = true;
                }
            }
            return !(countains1 && countains4);
        }

        /// <summary>
        /// We'll say that a value is "everywhere" in an array if for every pair of adjacent elements in
        /// the array, at least one of the pair is that value. Return true if the given value is everywhere
        /// in the array.
        /// 
        /// isEverywhere([1, 2, 1, 3], 1) → true
        /// isEverywhere([1, 2, 1, 3], 2) → false
        /// isEverywhere([1, 2, 1, 3, 4], 1) → false
        /// </summary>
        public bool IsEverywhere(int[] nums, int val)
        {
            int countNoVal = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    countNoVal = 0;
                }
                countNoVal++;

                if (countNoVal > 2)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Given an array of ints, return true if the array contains a 2 next to a 2 or a 4 next to a 4,
        /// but not both.
        /// 
        /// either24([1, 2, 2]) → true
        /// either24([4, 4, 1]) → true
        /// either24([4, 4, 1, 2, 2]) → false
        /// </summary>
        public bool Either24(int[] nums)
        {
            bool pair2 = false;
            bool pair4 = false;


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == 2 && nums[i - 1] == 2)
                {
                    pair2 = true;
                }
                if (nums[i] == 4 && nums[i - 1] == 4)
                {
                    pair4 = true;
                }
            }
            if (!pair4 && pair2 || pair4 && !pair2)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Given arrays nums1 and nums2 of the same length, for every element in nums1, consider
        /// the corresponding element in nums2 (at the same index). Return the count of the number
        /// of times that the two elements differ by 2 or less, but are not equal.
        /// 
        /// matchUp([1, 2, 3], [2, 3, 10]) → 2
        /// matchUp([1, 2, 3], [2, 3, 5]) → 3
        /// matchUp([1, 2, 3], [2, 3, 3]) → 2
        /// </summary>
        public int MatchUp(int[] nums1, int[] nums2)
        {
            int countSomething = 0;

            if (nums1.Length == nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    int dif = Math.Abs(nums1[i] - nums2[i]);
                    if (dif <= 2 && dif != 0)
                    {
                        countSomething++;
                    }
                }
            }
            return countSomething;
        }

        /// <summary>
        /// Given an array of ints, return true if the array contains two 7's next to each other, or there
        /// are two 7's separated by one element, such as with {7, 1, 7}.
        /// 
        /// has77([1, 7, 7]) → true
        /// has77([1, 7, 1, 7]) → true
        /// has77([1, 7, 1, 1, 7]) → false
        /// </summary>
        public bool Has77(int[] nums)
        {
            bool has7Values = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1] && nums[i] == 7)
                {
                    has7Values = true;
                }
            }
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 2] && nums[i] == 7)
                {
                    has7Values = true;
                }
            }
            return has7Values;
        }

        /// <summary>
        /// Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in
        /// the array.
        /// 
        /// has12([1, 3, 2]) → true
        /// has12([3, 1, 2]) → true
        /// has12([3, 1, 4, 5, 2]) → true
        /// </summary>
        public bool Has12(int[] nums)
        {
            bool has1 = false;
            bool has2 = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    has1 = true;
                }
                if (has1 && nums[i] == 2)
                {
                    has2 = true;
                }
            }
            return has1 && has2;
        }

        /// <summary>
        /// Given an array of ints, return true if the array contains either 3 even or 3 odd values all
        /// next to each other.
        /// 
        /// modThree([2, 1, 3, 5]) → true
        /// modThree([2, 1, 2, 5]) → false
        /// modThree([2, 4, 2, 5]) → true
        /// </summary>
        public bool ModThree(int[] nums)
        {
            bool oddValues3 = false;
            bool evenValues3 = false;
            if (nums.Length >= 3)
            {
                for (int i = 2; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0 && nums[i - 1] % 2 == 0 && nums[i - 2] % 2 == 0)
                    {
                        oddValues3 = true;
                    }
                    else if (nums[i] % 2 != 0 && nums[i - 1] % 2 != 0 && nums[i - 2] % 2 != 0)
                    {
                        evenValues3 = true;
                    }
                }
            }
            return oddValues3 || evenValues3;
        }

        /// <summary>
        /// Given an array of ints, return true if the value 3 appears in the array exactly 3 times, and
        /// no 3's are next to each other.
        /// 
        /// haveThree([3, 1, 3, 1, 3]) → true
        /// haveThree([3, 1, 3, 3]) → false
        /// haveThree([3, 4, 3, 3, 4]) → false
        /// </summary>
        public bool HaveThree(int[] nums)
        {
            int counter3 = 0;

            if (nums.Length >= 5)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == 0)
                    {
                        if (nums[i] == 3 && nums[i + 1] != 3)
                        {
                            counter3++;
                        }
                    }
                    else
                    if (i > 0 && i < nums.Length - 2)
                    {
                        if (nums[i] == 3 && nums[i - 1] != 3)
                        {
                            counter3++;
                        }
                    }
                    else
                    if (i == nums.Length - 1)
                    {
                        if (nums[i] == 3 && nums[i - 1] != 3)
                        {
                            counter3++;
                        }
                    }
                }
            }
            else return false;
            return counter3 == 3;
        }

        /// <summary>
        /// Given an array of ints, return true if every 2 that appears in the array is next to another 2.
        /// 
        /// twoTwo([4, 2, 2, 3]) → true
        /// twoTwo([2, 2, 4]) → true
        /// twoTwo([2, 2, 4, 2]) → false
        /// </summary>
        public bool TwoTwo(int[] nums)
        {
            bool two2 = false;
            bool one2 = false;
            int count2 = 0; // Šo es pats izdomāju, jo citādi nevarēja iziet testu ar atbildi true pie masīva {1, 3, 4}

            if (nums.Length > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == 0)
                    {
                        if (nums[i] == 2 && nums[i + 1] == 2)
                        {
                            two2 = true;
                        }
                        if (nums[i] == 2 && nums[i + 1] != 2)
                        {
                            one2 = true;
                        }
                    }
                    if (i > 0 && i <= nums.Length - 2)
                    {
                        if (nums[i] == 2 && nums[i + 1] == 2 || nums[i - 1] == 2)
                        {
                            two2 = true;
                        }
                        if (nums[i] == 2 && nums[i + 1] != 2 && nums[i - 1] != 2)
                        {
                            one2 = true;
                        }
                    }
                    if (i == nums.Length - 1)
                    {
                        if (nums[i] == 2 && nums[i - 1] == 2)
                        {
                            two2 = true;
                        }
                        if (nums[i] == 2 && nums[i - 1] != 2)
                        {
                            one2 = true;
                        }
                    }

                }
            }
            else return false;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == 2)
                {
                    count2++;
                }
            }
            return two2 && !one2 || count2 < 1;
        }


        /// <summary>
        /// Return true if the group of N numbers at the start and end of the array are the same. For
        /// example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, and false
        /// for n=1 and n=3. You may assume that n is in the range 0..nums.length inclusive.
        /// 
        /// sameEnds([5, 6, 45, 99, 13, 5, 6], 1) → false
        /// sameEnds([5, 6, 45, 99, 13, 5, 6], 2) → true
        /// sameEnds([5, 6, 45, 99, 13, 5, 6], 3) → false
        /// </summary>
        public bool SameEnds(int[] nums, int val)
        {
            bool pass = false;
            int newVal = val;
            for (int i = 0; i < val; i++)
            {
                if (nums[i] == nums[nums.Length - newVal])
                {
                    pass = true;
                }
                newVal--;
            }
            if (val == 0)
            {
                return true;
            }
            else
                return pass;
        }

        /// <summary>
        /// Return true if the array contains, somewhere, three increasing adjacent numbers like ....
        /// 4, 5, 6, ... or 23, 24, 25.
        /// 
        /// tripleUp([1, 4, 5, 6, 2]) → true
        /// tripleUp([1, 2, 3]) → true
        /// tripleUp([1, 2, 4]) → false
        /// </summary>
        public bool TripleUp(int[] nums)
        {
            if (nums.Length > 2)
            {
                for (int i = 2; i < nums.Length; i++)
                {
                    if (nums[i] == (nums[i - 1] - 1) && nums[i] == nums[i - 2] - 2)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Given start and end numbers, return a new array containing the sequence of integers
        /// rom start up to but not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The
        /// end number will be greater or equal to the start number. Note that a length-0 array is
        /// valid.
        /// 
        /// fizzArray3(5, 10) → [5, 6, 7, 8, 9]
        /// fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]
        /// fizzArray3(1, 3) → [1, 2]
        /// </summary>
        public int[] FizzArray3(int start, int end)
        {
            int[] newArray = new int[end - start];
            for (int i = start; i < end; i++)
            {
                newArray[i - start] = i;
            }
            return newArray;
        }

        /// <summary>
        /// Return an array that is "left shifted" by one -- so {6, 2, 5, 3} returns {2, 5, 3, 6}. You
        /// may modify and return the given array, or return a new array.
        /// 
        /// shiftLeft([6, 2, 5, 3]) → [2, 5, 3, 6]
        /// shiftLeft([1, 2]) → [2, 1]
        /// shiftLeft([1]) → [1]
        /// </summary>
        public int[] ShiftLeft(int[] nums)

        {
            int[] newArray = new int[nums.Length];
            if (nums.Length > 0)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    newArray[i] = nums[i + 1];
                }
                newArray[nums.Length - 1] = nums[0];
            }
            return newArray;
        }

        /// <summary>
        /// For each multiple of 10 in the given array, change all the values following it to be that
        /// multiple of 10, until encountering another multiple of 10. So {2, 10, 3, 4, 20, 5} yields {2,
        /// 10, 10, 10, 20, 20}.
        /// 
        /// tenRun([2, 10, 3, 4, 20, 5]) → [2, 10, 10, 10, 20, 20]
        /// tenRun([10, 1, 20, 2]) → [10, 10, 20, 20]
        /// tenRun([10, 1, 9, 20]) → [10, 10, 10, 20]
        /// </summary>
        public int[] TenRun(int[] nums)
        {
            bool tenActive = false;
            int[] newArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 10 == 0)
                {
                    newArray[i] = nums[i];
                    tenActive = true;
                }
                else
                    if (tenActive)
                {
                    newArray[i] = newArray[i - 1];
                }
                else newArray[i] = nums[i];
            }
            return newArray;
        }

        /// <summary>
        /// Given a non-empty array of ints, return a new array containing the elements from the
        /// original array that come before the first 4 in the original array. The original array will
        /// contain at least one 4. Note that it is possible to create an array of length 0.
        /// 
        /// pre4([1, 2, 4, 1]) → [1, 2]
        /// pre4([3, 1, 4]) → [3, 1]
        /// pre4([1, 4, 4]) → [1]
        /// </summary>
        public int[] Pre4(int[] nums)
        {
            int lng = 0;
            for (int i = 0; i < nums.Length && nums[i] != 4; i++)
            {
                lng = i + 1;
            }
            int[] newArray = new int[lng];

            for (int i = 0; i < nums.Length && nums[i] != 4; i++)
            {
                newArray[i] = nums[i];
            }
            return newArray;
        }

        // Kā šo var izdarīt vienā cilpā?

        /// <summary>
        /// Given a non-empty array of ints, return a new array containing the elements from the
        /// original array that come after the last 4 in the original array. The original array will contain
        /// at least one 4. Note that it is possible to create an array of length 0.
        /// 
        /// post4([2, 4, 1, 2]) → [1, 2]
        /// post4([4, 1, 4, 2]) → [2]
        /// post4([4, 4, 1, 2, 3]) → [1, 2, 3]
        /// </summary>
        public int[] Post4(int[] nums)
        {
            int lng = 0;
            for (int i = nums.Length - 1; i > 0 && nums[i] != 4; i--)
            {
                lng++;
            }
            int[] newArray = new int[lng];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = nums[nums.Length - lng + i];
            }
            return newArray;
        }

        /// <summary>
        /// We'll say that an element in an array is "alone" if there are values before and after it, and
        /// those values are different from it. Return a version of the given array where every instance
        /// of the given value which is alone is replaced by whichever value to its left or right is larger.
        /// 
        /// notAlone([1, 2, 3], 2) → [1, 3, 3]
        /// notAlone([1, 2, 3, 2, 5, 2], 2) → [1, 3, 3, 5, 5, 2]
        /// notAlone([3, 4], 3) → [3, 4]
        /// </summary>
        
        //Šo vēl neuzspēju pabeigt!
        public int[] NotAlone(int[] nums, int val)
        {
            int[] newArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if(i%val == 0)
                {
                    newArray[i] = Math.Max(nums[i-1], nums[i+1]);
                }
                newArray[i] = nums[i];
            }

            return newArray;
        }

        /// <summary>
        /// Return an array that contains the exact same numbers as the given array, but rearranged
        /// so that all the zeros are grouped at the start of the array. The order of the non-zero
        /// numbers does not matter. So {1, 0, 0, 1} becomes {0 ,0, 1, 1}. You may modify and
        /// return the given array or make a new array.
        /// 
        /// zeroFront([1, 0, 0, 1]) → [0, 0, 1, 1]
        /// zeroFront([0, 1, 1, 0, 1]) → [0, 0, 1, 1, 1]
        /// zeroFront([1, 0]) → [0, 1]
        /// </summary>
        public int[] ZeroFront(int[] nums)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return a version of the given array where all the 10's have been removed. The remaining
        /// elements should shift left towards the start of the array as needed, and the empty spaces
        /// a the end of the array should be 0. So {1, 10, 10, 2} yields {1, 2, 0, 0}. You may modify
        /// and return the given array or make a new array.
        /// 
        /// withoutTen([1, 10, 10, 2]) → [1, 2, 0, 0]
        /// withoutTen([10, 2, 10]) → [2, 0, 0]
        /// withoutTen([1, 99, 10]) → [1, 99, 0]
        /// </summary>
        public int[] WithoutTen(int[] nums)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return a version of the given array where each zero value in the array is replaced by the
        /// largest odd value to the right of the zero in the array. If there is no odd value to the right
        /// of the zero, leave the zero as a zero.
        /// 
        /// zeroMax([0, 5, 0, 3]) → [5, 5, 3, 3]
        /// zeroMax([0, 4, 0, 3]) → [3, 4, 3, 3]
        /// zeroMax([0, 1, 0]) → [1, 1, 0]
        /// </summary>
        public int[] ZeroMax(int[] nums)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an array that contains the exact same numbers as the given array, but rearranged
        /// so that all the even numbers come before all the odd numbers. Other than that, the
        /// numbers can be in any order. You may modify and return the given array, or make a new
        /// array.
        /// 
        /// evenOdd([1, 0, 1, 0, 0, 1, 1]) → [0, 0, 0, 1, 1, 1, 1]
        /// evenOdd([3, 3, 2]) → [2, 3, 3]
        /// evenOdd([2, 2, 2]) → [2, 2, 2]
        /// </summary>
        public int[] EvenOdd(int[] nums)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is slightly more difficult version of the famous FizzBuzz problem which is sometimes
        /// given as a first problem for job interviews. Consider the series
        /// of numbers beginning at start and running up to but not including end, so for example
        /// start=1 and end=5 gives the series 1, 2, 3, 4. Return a new String[] array containing the
        /// string form of these numbers, except for multiples of 3, use "Fizz" instead of the number,
        /// for multiples of 5 use "Buzz", and for multiples of both 3 and 5 use "FizzBuzz".
        /// This version is a little more complicated than the usual version since you have to
        /// allocate and index into an arrayinstead of just printing, and we vary the start/end instead of just always doing 1..100.
        /// 
        /// fizzBuzz(1, 6) → ["1", "2", "Fizz", "4", "Buzz"]
        /// fizzBuzz(1, 8) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7"]
        /// fizzBuzz(1, 11) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]
        /// </summary>
        public string[] FizzBuzz(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
