using System;

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
            int[] arr3 = new int[] { 9,9,8,8 };
           Console.Write("----------Question 3 - Largest Unique Number----------");
            Console.Write("\n");
            int LargestNumber = LargestUniqueNumber(arr3);
            Console.Write(LargestNumber);
           
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

        

                
           
        public static int LargestUniqueNumber(int[] A)
        {
            Array.Sort(A);
            Array.Reverse(A);
            int length = A.Length;
            int i = 0;

            for (i = 0; i < length; i++)
            {
                if (A[i] == A[i + 1])
                {
                    i = i+1;
                   
                }
                else if(A[i]!=A[i+1])
                { return A[i]; }
                else
                { return -1; }
            }
            return -1;
        }
    }

   
}
