using System;

namespace Exercises.Level1
{
    /// <summary>
    /// Basic array problems -- no loops.. Use a[0], a[1], ... to access elements in an array, a.Length is the length of array.
    /// Allocate a new array like this: int[] a = new int[10];
    /// </summary>
    public class Array1
    {
        /// <summary>
        /// Given an array of ints, return true if 6 appears as either the first or last element in the
        /// array. The array will be length 1 or more.
        /// 
        /// firstLast6([1, 2, 6]) → true
        /// firstLast6([6, 1, 2, 3]) → true
        /// firstLast6([13, 6, 1, 2, 3]) → false
        /// </summary>
        public bool FirstLast6(int[] nums)
        {
            //      bool isFirst = nums[0] == 6;
            //      int lastIndex = nums.Length - 1;
            //      bool isLast = nums[lastIndex] == 6;
            return nums[0] == 6 || nums[nums.Length - 1] == 6;
            //return isFirst || isLast;
        }

        /// <summary>
        /// Given an array of ints, return true if the array is length 1 or more, and the first element
        /// and the last element are equal.
        /// 
        /// sameFirstLast([1, 2, 3]) → false
        /// sameFirstLast([1, 2, 3, 1]) → true
        /// sameFirstLast([1, 2, 1]) → true
        /// </summary>
        public bool SameFirstLast(int[] nums)
        {
            int length = nums.Length;
            return length != 0 && nums[0] == nums[length - 1];
        }

        /// <summary>
        /// Return an int array length 3 containing the first 3 digits of pi, {3, 1, 4}.
        /// 
        /// makePi() → [3, 1, 4]
        /// </summary>
        public int[] MakePi()
        {
            return new int[] { 3, 1, 4 };
        }

        /// <summary>
        /// Given 2 arrays of ints, a and b, return true if they have the same first element or they
        /// have the same last element. Both arrays will be length 1 or more.
        /// 
        /// commonEnd([1, 2, 3], [7, 3]) → true
        /// commonEnd([1, 2, 3], [7, 3, 2]) → false
        /// commonEnd([1, 2, 3], [1, 3]) → true
        /// </summary>
        public bool CommonEnd(int[] a, int[] b)
        {
            return a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1];
        }

        /// <summary>
        /// Given an array of ints length 3, return the sum of all the elements.
        /// 
        /// sum3([1, 2, 3]) → 6
        /// sum3([5, 11, 2]) → 18
        /// sum3([7, 0, 0]) → 7
        /// </summary>
        public int Sum3(int[] nums)
        {
            int sumNums = 0;
            //   for (int i = 0; i < nums.Length; i++)
            //   {
            //       sumNums += nums[i];
            //   }
            //   return sumNums;

            foreach (int num in nums)
            {
                sumNums += num;
            }
            return sumNums;
        }
        //Mājās
        /// <summary>
        /// Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2,
        /// 3} yields {2, 3, 1}.
        /// 
        /// rotateLeft3([1, 2, 3]) → [2, 3, 1]
        /// rotateLeft3([5, 11, 9]) → [11, 9, 5]
        /// rotateLeft3([7, 0, 0]) → [0, 0, 7]
        /// </summary>
        public int[] RotateLeft3(int[] nums)
        {
            return new int[] { nums[1], nums[2], nums[0] };
        }

        /// <summary>
        /// Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2,
        /// 3} yields {2, 3, 1}.
        /// 
        /// reverse3([1, 2, 3]) → [3, 2, 1]
        /// reverse3([5, 11, 9]) → [9, 11, 5]
        /// reverse3([7, 0, 0]) → [0, 0, 7]
        /// </summary>
        public int[] Reverse3(int[] nums)
        {
            return new int[] { nums[2], nums[1], nums[0] };
        }

        /// <summary>
        /// Given an array of ints length 3, figure out which is larger, the first or last element in the
        /// array, and set all the other elements to be that value. Return the changed array.
        /// 
        /// maxEnd3([1, 2, 3]) → [3, 3, 3]
        /// maxEnd3([11, 5, 9]) → [11, 11, 11]
        /// maxEnd3([2, 11, 3]) → [3, 3, 3]
        /// </summary>
        public int[] MaxEnd3(int[] nums)
        {
            int maxNums = Math.Max(nums[0], nums[nums.Length - 1]);
            return new int[] { maxNums, maxNums, maxNums };
        }

        /// <summary>
        /// Given an array of ints, return the sum of the first 2 elements in the array. If the array
        /// length is less than 2, just sum up the elements that exist, returning 0 if the array is length
        /// 0.
        /// 
        /// sum2([1, 2, 3]) → 3
        /// sum2([1, 1]) → 2
        /// sum2([1, 1, 1, 1]) → 2
        /// </summary>
        public int Sum2(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length < 2)
            {
                return nums[0];
            }
            return nums[0] + nums[1];
        }

        /// <summary>
        /// Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their
        /// middle elements.
        /// 
        /// middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
        /// middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
        /// middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
        /// </summary>
        public int[] MiddleWay(int[] a, int[] b)
        {
            return new int[2] { a[1], b[1] };
        }

        /// <summary>
        /// Given an array of ints, return a new array length 2 containing the first and last elements
        /// from the original array. The original array will be length 1 or more.
        /// 
        /// makeEnds([1, 2, 3]) → [1, 3]
        /// makeEnds([1, 2, 3, 4]) → [1, 4]
        /// makeEnds([7, 4, 6, 2]) → [7, 2]
        /// </summary>
        public int[] MakeEnds(int[] nums)
        {
            return new int[] { nums[0], nums[nums.Length - 1] };
        }

        /// <summary>
        /// Given an int array length 2, return true if it contains a 2 or a 3.
        /// 
        /// has23([2, 5]) → true
        /// has23([4, 3]) → true
        /// has23([4, 5]) → false
        /// </summary>
        public bool Has23(int[] nums)
        {
            return nums[0] == 2 || nums[0] == 3 || nums[1] == 2 || nums[1] == 3;
        }

        /// <summary>
        /// Given an int array length 2, return true if it does not contain a 2 or 3.
        /// 
        /// no23([4, 5]) → true
        /// no23([4, 2]) → false
        /// no23([3, 5]) → false
        /// </summary>
        public bool No23(int[] nums)
        {
            return nums[0] != 2 && nums[0] != 3 && nums[1] != 2 && nums[1] != 3;
        }

        /// <summary>
        /// Given an int array, return a new array with double the length where its last element is the
        /// same as the original array, and all the other elements are 0. The original array will be
        /// length 1 or more. Note: by default, a new int array contains all 0's.
        /// 
        /// makeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
        /// makeLast([1, 2]) → [0, 0, 0, 2]
        /// makeLast([3]) → [0, 3]
        /// </summary>
        public int[] MakeLast(int[] nums)
        {
            int doubleLength = nums.Length * 2;
            int[] newArray = new int[doubleLength];
            for (int i = 0; i < doubleLength; i++)
            {
                if (doubleLength - 1 == i)
                {
                    newArray[i] = nums[nums.Length - 1];
                }
                else
                    newArray[i] = 0;
            }
            return newArray;
        }

        /// <summary>
        /// Given an int array, return true if the array contains 2 twice, or 3 twice. The array will be
        /// length 0, 1, or 2.
        /// 
        /// double23([2, 2]) → true
        /// double23([3, 3]) → true
        /// double23([2, 3]) → false
        /// </summary>
        public bool Double23(int[] nums)
        {
            bool twice = false;
            if (nums.Length > 0)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    twice = nums[i - 1] == nums[i];
                }
            }
            return twice;
        }

        /// <summary>
        /// Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the
        /// 3 element to 0. Return the changed array.
        /// 
        /// fix23([1, 2, 3]) → [1, 2, 0]
        /// fix23([2, 3, 5]) → [2, 0, 5]
        /// fix23([1, 2, 1]) → [1, 2, 1]
        /// </summary>
        public int[] Fix23(int[] nums)
        {
            int[] changedArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == 3 && nums[i - 1] == 2)
                {
                    changedArray[i] = 0;
                }
                else changedArray[i] = nums[i];
            }
            return changedArray;
        }

        /// <summary>
        /// Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as
        /// their first element.
        /// 
        /// start1([1, 2, 3], [1, 3]) → 2
        /// start1([7, 2, 3], [1]) → 1
        /// start1([1, 2], []) → 1
        /// </summary>
        public int Start1(int[] a, int[] b)
        {
            if (a.Length > 0 && a[0] == 1 && b.Length > 0 && b[0] == 1)
            {
                return 2;
            }
            else if (a.Length > 0 && a[0] == 1 || b.Length > 0 && b[0] == 1)
            {
                return 1;
            }
            return 0;
        }


        /// <summary>
        /// Start with 2 int arrays, a and b, each length 2. Consider the sum of the values in each
        /// array. Return the array which has the largest sum. In event of a tie, return a.
        /// 
        /// biggerTwo([1, 2], [3, 4]) → [3, 4]
        /// biggerTwo([3, 4], [1, 2]) → [3, 4]
        /// biggerTwo([1, 1], [1, 2]) → [1, 2]
        /// </summary>
        public int[] BiggerTwo(int[] a, int[] b)
        {
            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sumA += a[i];
            }
            for (int j = 0; j < b.Length; j++)
            {
                sumB += b[j];
            }
            if (sumA >= sumB)
            {
                return a;
            }
            else
                return b;
        }

        /// <summary>
        /// Given an array of ints of even length, return a new array length 2 containing the middle
        /// two elements from the original array. The original array will be length 2 or more.
        /// 
        /// makeMiddle([1, 2, 3, 4]) → [2, 3]
        /// makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
        /// makeMiddle([1, 2]) → [1, 2]
        /// </summary>
        public int[] MakeMiddle(int[] nums)
        {
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
        }

        /// <summary>
        /// Given 2 int arrays, each length 2, return a new array length 4 containing all their
        /// elements.
        /// 
        /// plusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]
        /// plusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]
        /// plusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
        /// </summary>
        public int[] PlusTwo(int[] a, int[] b)
        {
            int[] newArray = new int[a.Length + b.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i <= a.Length - 1)
                {
                    newArray[i] = a[i];
                }
                else
                    newArray[i] = b[i - a.Length];
            }
            return newArray;
            //  Iespējams, ka aizkomentētais kods par vienkāršu :)
            //  return new int[] {a[0], a[1], b[0], b[1] };
        }

        /// <summary>
        /// Given an array of ints, swap the first and last elements in the array. Return the modified
        /// array. The array length will be at least 1.
        /// 
        /// swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
        /// swapEnds([1, 2, 3]) → [3, 2, 1]
        /// swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
        /// </summary>
        public int[] SwapEnds(int[] nums)
        {
            int[] newArray = new int[nums.Length];
            newArray[0] = nums[nums.Length - 1];
            for (int i = 1; i <= nums.Length - 2; i++)
            {
                newArray[i] = nums[i];
            }
            newArray[nums.Length - 1] = nums[0];
            return newArray;
        }

        /// <summary>
        /// Given an array of ints of odd length, return a new array length 3 containing the elements
        /// from the middle of the array. The array length will be at least 3.
        /// 
        /// midThree([1, 2, 3, 4, 5]) → [2, 3, 4]
        /// midThree([8, 6, 7, 5, 3, 0, 9]) → [7, 5, 3]
        /// midThree([1, 2, 3]) → [1, 2, 3]
        /// </summary>
        public int[] MidThree(int[] nums)
        {
            int[] newArray = new int[3];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = nums[nums.Length / 2 + i - 1];
            }
            return newArray;
        }

        /// <summary>
        /// Given an array of ints of odd length, look at the first, last, and middle values in the array
        /// and return the largest. The array length will be a least 1.
        /// 
        /// maxTriple([1, 2, 3]) → 3
        /// maxTriple([1, 5, 3]) → 5
        /// maxTriple([5, 2, 3]) → 5
        /// </summary>
        public int MaxTriple(int[] nums)
        {
            return Math.Max(Math.Max(nums[0], nums[nums.Length - 1]), nums[nums.Length / 2]);
        }

        /// <summary>
        /// Given an int array of any length, return a new array of its first 2 elements. If the array is
        /// smaller than length 2, use whatever elements are present.
        /// 
        /// frontPiece([1, 2, 3]) → [1, 2]
        /// frontPiece([1, 2]) → [1, 2]
        /// frontPiece([1]) → [1]
        /// </summary>
        public int[] FrontPiece(int[] nums)
        {
            int[] newArray = new int[nums.Length >= 2 ? 2 : nums.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = nums[i];
            }
            return newArray;
        }

        /// <summary>
        /// We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. Return true if
        /// the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.
        /// 
        /// unlucky1([1, 3, 4, 5]) → true
        /// unlucky1([2, 1, 3, 4, 5]) → true
        /// unlucky1([1, 1, 1]) → false
        /// </summary>
        public bool Unlucky1(int[] nums)
        {
            bool containsUnlucky1 = false;
            if (nums.Length > 1)
            {
                if (nums[0] == 1 && nums[1] == 3 || nums[1] == 1 && nums[2] == 3)
                {
                    containsUnlucky1 = true;
                }
                if (nums[nums.Length - 1] == 3 && nums[nums.Length - 2] == 1 || nums[nums.Length - 2] == 3 && nums[nums.Length - 3] == 1)
                {
                    containsUnlucky1 = true;
                }
            }
            return containsUnlucky1;
        }

        /// <summary>
        /// Given 2 int arrays, a and b, return a new array length 2 containing, as much as will fit, the
        /// elements from a followed by the elements from b. The arrays may be any length, including
        /// 0, but there will be 2 or more elements available between the 2 arrays.
        /// 
        /// make2([4, 5], [1, 2, 3]) → [4, 5]
        /// make2([4], [1, 2, 3]) → [4, 1]
        /// make2([], [1, 2]) → [1, 2]
        /// </summary>
        public int[] Make2(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int j = 0; j < b.Length; j++)
            {
                c[a.Length + j] = b[j];
            }
            return new int[] { c[0], c[1] };
        }

        /// <summary>
        /// Given 2 int arrays, a and b, of any length, return a new array with the first element of
        /// each array. If either array is length 0, ignore that array.
        /// 
        /// front11([1, 2, 3], [7, 9, 8]) → [1, 7]
        /// front11([1], [2]) → [1, 2]
        /// front11([1, 7], []) → [1]
        /// </summary>
        public int[] Front11(int[] a, int[] b)
        {
            int[] c = new int[a.Length == 0 && b.Length == 0 ? 0 : (a.Length == 0 || b.Length == 0 ? 1 : 2)];

            if (a.Length == 0)
            {
                if (b.Length == 0)
                {
                    return c;
                }
                else c[0] = b[0];
                return c;
            }
            else if (b.Length == 0)
            {
                c[0] = a[0];
                return c;
            }
            else c[0] = a[0];
            c[1] = b[0];
            return c;
        }
    }
}
