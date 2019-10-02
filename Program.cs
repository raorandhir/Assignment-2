using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("\n");
            int[] arr1 = new int[] { 2, 3, 5, 6 };
            int Target = 9;
            Console.Write("----------Question 1 - Search Insert----------");
            Console.Write("\n");
            int index = SearchInsert(arr1, Target);
            Console.Write(index);

            Console.Write("\n");
            int[] arr2_1 = new int[] { 6, 3, 6, 7, 3};
            int [] arr2_2 = { 3, 6, 2 };
            Console.Write("----------Question 2 - Common Elements----------");
            Console.Write("\n");
            int[] result = Intersect(arr2_1, arr2_2);
            for (int i = 0; i < result.Length; i++)
            Console.Write(result[i] + " ");

            Console.Write("\n");
            int[] arr3 = new int[] { 9,9,8,8 };
           Console.Write("----------Question 3 - Largest Unique Number----------");
            Console.Write("\n");
            int LargestNumber = LargestUniqueNumber(arr3);
            Console.Write(LargestNumber);

            Console.Write("\n");
            int[] arr7 = new int[] { -7, -3, 2, 3, 11 };
            Console.Write("----------Question 7 - Square of an Array----------");
            Console.Write("\n");
            SortedSquares(arr7);
           
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            int j = 0;
            int length = nums.Length;
            int index = 0;
            int mid = length / 2;


            index = Array.IndexOf(nums, target);
            if (index >= 0)
            { return index; }
            else if (index < 0)
           {
                for (i = 0; i < length; i++)
                {
                    for (j = 0; j < mid; j++)
                    {
                        if (nums[j] < target)
                        {
                            
                            if (nums[j] + 1 == target)
                            {
                                index = Array.IndexOf(nums, nums[j]) + 1;
                                return index;
                            }
                            
                            continue;
                            //index = Array.IndexOf(nums, nums[j]) + 1;
                            //return index;
                        }
                        else if (nums[j] > target)
                        {
                            index = Array.IndexOf(nums, nums[j]);
                            return index;
                        }                                             
                    }//j  
                    i = j + 1;
                    if (nums[i] + 1 <= target)
                    {
                        index = Array.IndexOf(nums, nums[i]) + 1;
                        return index;
                    }
                }//i
            }//else if      
           return -2;
        }

        

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            foreach (int count in nums1)
            {
                try { myDict.Add(count, 1); }
                catch { myDict[count]++; }
            }

            foreach (int count in nums2)
            {
                if (myDict.ContainsKey(count) && myDict[count] > 0)
                {
                    myDict[count]--;
                    result.Add(count);
                }
            }

            return result.ToArray();
        }
    



    public static int LargestUniqueNumber(int[] A)
        {
            Array.Sort(A);
            Array.Reverse(A);
            int length = A.Length;
            int i;

            for (i = 0; i < length; i++)
            {
                if (A[i] == A[i + 1])
                {
                    i+=1;
                   
                }
                else if(A[i]!=A[i+1])
                { return A[i]; }
                else
                { return -1; }
            }
            return -1;
        }


        public static int[] SortedSquares(int[] A)
        {
            
            int length = A.Length;
            int i;
            for (i = 0; i < length; i++)
            {
                A[i] = A[i] * A[i];
            }
            Array.Sort(A);
            for (i = 0; i < length; i++)
            {
                Console.Write(" " + A[i]);
            }

            return A;

        }

    }
    }

   

