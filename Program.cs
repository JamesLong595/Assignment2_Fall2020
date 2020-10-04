﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_Fall2020
{
    class Program
    {


        static void Main(string[] args)
        {
            //// print a triangle of arbitary height
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Please enter a positive integer:");
            //        int n = int.Parse(Console.ReadLine());
            //        Console.WriteLine("");
            //        if (n > 0)
            //        {
            //            PrintPatternAnyComplexity(n);
            //            Console.WriteLine("");
            //            PrintPatternLinearComplexity(n);
            //            break;
            //        } // end of if block
            //        else
            //        {
            //            Console.WriteLine("\nOnly positive integers are allowed.");
            //        } // end of else block
            //    } // end of try block
            //    catch
            //    {
            //        Console.WriteLine("\nInvalid input ...");
            //    } // end of catch block
            //} // end of triangle while loop


            //// print the length of a continuous increasing subsequence
            //while (true)
            //{
            //    try
            //    {
            //        // collect data from user and convert to an integer array
            //        Console.WriteLine("Enter a comma-separated array of integers in any order:\n");
            //        string input = Console.ReadLine();
            //        string[] strArr = input.Split(",");
            //        int[] array1 = new int[strArr.Length];
            //        int num;
            //        for (int i = 0; i < array1.Length; i++)
            //        {
            //            num = Convert.ToInt32(strArr[i]);
            //            array1[i] = num;
            //        }
            //        int result = LongestSubSeq(array1);
            //        if (result == -1)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nThe longest continuous increasing subsequence is " + result + " elements long.");
            //            Console.ReadKey();
            //            break;
            //        }
            //    } // end of try block
            //    catch
            //    {
            //        Console.WriteLine("\nInvalid input ...");
            //    }  // end of catch block
            //} // end of longest continuous increasing subsequence while loop


            //// split an array of integers conditionally and print them, else print false
            //while (true)
            //{
            //    try
            //    {
            //        // collect data from user and convert to an integer array
            //        Console.WriteLine("Enter a comma-separated array of positive integers in any order:\n");
            //        string input = Console.ReadLine();
            //        string[] strArr = input.Split(",");
            //        int[] array2 = new int[strArr.Length];
            //        int num;
            //        for (int i = 0; i < array2.Length; i++)
            //        {
            //            num = Convert.ToInt32(strArr[i]);
            //            if (num >= 0)
            //            {
            //                array2[i] = num;
            //            }
            //            else
            //            {
            //                throw new ArgumentOutOfRangeException();
            //            }
            //        } // end of for loop
            //        PrintTwoParts(array2);
            //        break;
            //    } // end of try block
            //    catch
            //    {
            //        Console.WriteLine("\nInvalid input ...\n");
            //    } // end of catch block
            //} // end of split array while loop


//            // square values of an array and return sorted squares
//            while (true)
//            {
//                try
//                {
//                    // collect data from user, validate, and convert to an integer array
//                    Console.WriteLine(@"
//Enter a comma-separated array of integers sorted in non-decreasing order.
//The minimum allowable length is 1.
//The maximum allowable length is 10,000.
//The minimum allowable value is -10,000.
//The maximum allowable value is 10,000.
//");
//                    string input = Console.ReadLine();
//                    string[] strArr = input.Split(",");
//                    if (strArr.Length > 10000)
//                    {
//                        throw new ArgumentOutOfRangeException();
//                    }
//                    int[] array3 = new int[strArr.Length];
//                    int num;
//                    for (int i = 0; i < array3.Length; i++)
//                    {
//                        num = Convert.ToInt32(strArr[i]);
//                        array3[i] = num;
//                        if (i > 0 && array3[i] < array3[i - 1])
//                        {
//                            throw new ArgumentOutOfRangeException();
//                        }
//                        if (array3[i] < -10000 || array3[i] > 10000)
//                        {
//                            throw new ArgumentOutOfRangeException();
//                        }
//                    } // end of for loop
//                    int[] result2 = SortedSquares(array3);
//                    if (result2 == null)
//                    {
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("\n" + string.Join(", ", result2));
//                        Console.WriteLine("\nPress any key to continue ...\n");
//                        Console.ReadKey();
//                        break;
//                    }
//                } // end of try block
//                catch
//                {
//                    Console.WriteLine("\nInvalid input ...\n");
//                } // end of catch block
//            } // end of sorted squares while loop


            Console.WriteLine("Question 5");
            int[] nums1 = { 4, 2, 2, 4 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect(nums1, nums2);
            // Write code to print the result array here


            //Console.WriteLine("Question 6");
            //int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };
            //Console.WriteLine(UniqueOccurrences(arr));


            //Console.WriteLine("Question 7");
            //int[] numbers = { 0, 1, 3, 50, 75 };
            //int lower = 0;
            //int upper = 99;
            //List<String> ResultList = Ranges(numbers, lower, upper);
            ////Write code to print list here


            //Console.WriteLine("Question 8");
            //string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            //string[] namesResult = UniqFolderNames(names);
            ////Write code to print your result here
        }


        public static void PrintPatternAnyComplexity(int n)

        {
            // Given a number n, print triangular pattern.  
            // *
            // * * 
            // * * *
            // * * * *
            // * * * * *
            // * * * * * *
            // * * * * * * *
            try
            {
                // iterate thru the lines
                for (int i = 1; i <= n; i++)
                {
                    string newline = new String('*', i);
                    Console.WriteLine(newline);
                } // end of for loop
                Console.WriteLine("\nPress any key to continue ...");
                Console.ReadKey();
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing PrintPatternLinearComplexity()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of catch block
        } // end of method PrintPatternAnyComplexity


        public static void PrintPatternLinearComplexity(int n)

        {
             // Given a number n, print triangular pattern.  
             // *
             // * * 
             // * * *
             // * * * *
             // * * * * *
             // * * * * * *
             // * * * * * * *
            try
            {
                // iterate thru the lines
                for (int i = 1; i <= n; i++)
                {
                    string newline = new String('*', i);
                    Console.WriteLine(newline);
                } // end of for loop
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing PrintPatternLinearComplexity()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of catch block
        } // end of method PrintPatternLinearComplexity


        public static int LongestSubSeq(int[] nums)
        {
            // Given an unsorted array of integers, find the length of
            // the longest continuous increasing subsequence (subarray).
            try
            {
                int curCnt = 1;
                int maxCnt = 1;
                // count number of continuous increasing elements
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i < nums.Length - 1 && nums[i] < nums[i + 1])
                    {
                        curCnt++;
                    }
                    else
                    {
                        if (curCnt > maxCnt)
                        {
                            maxCnt = curCnt;
                        }
                        curCnt = 1;
                    }
                } //end of for loop
                return maxCnt;
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing LongestSubSeq()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return -1;
            } // end of catch block
        } // end of method LongestSubSeq


        public static void PrintTwoParts(int[] array2)
        {
            // Given an array of integers greater than zero, find if it is possible to split it
            // in two subarrays (without reordering the elements), such that the sum of the two
            // subarrays is the same. Print the two subarrays.
            try
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < array2.Length; i++)
                {
                    sum1 += array2[i];
                    sum2 = array2.Sum() - sum1;
                    if (array2.Length == 1)
                    {
                        Console.WriteLine("\nFalse");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    }
                    else if (sum1 == sum2)
                    {
                        int[] subArr1 = array2[0..(i + 1)];
                        int[] subArr2 = array2[(i + 1)..array2.Length];
                        Console.WriteLine("\n" + string.Join(", ", subArr1) + "\n" + string.Join(", ", subArr2) + "\n");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    }
                    else if (i == array2.Length - 1)
                    {
                        Console.WriteLine("\nFalse");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    }
                } // end of for loop
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing PrintTwoParts()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
            } // end of catch block
        } // end of method PrintTwoParts


        public static int[] SortedSquares(int[] A)
        {
            // Given an array of integers A sorted in non-decreasing order, return an array of
            // the squares of each number, also in sorted non-decreasing order.
            try
            {
                int maxIdx = A.Length - 1;
                int[] B = new int[A.Length];
                // initialize right side index tracker
                int r = 0;
                // find first non-negative element
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] >= 0)
                    {
                        r = i;
                        break;
                    }
                } // end of for loop
                // initialize left side index tracker
                int l = r - 1;
                // start in middle and work outward in both directions
                for (int i = 0; i < B.Length; i++)
                {
                    if (l == -1 && r < B.Length)
                    {
                        B[i] = A[r] * A[r];
                        r++;
                    }
                    else if (r == B.Length && l > -1)
                    {
                        B[i] = A[l] * A[l];
                        l--;
                    }
                    else if (Math.Abs(A[l]) <= Math.Abs(A[r]))
                    {
                        B[i] = A[l] * A[l];
                        l--;
                    }
                    else
                    {
                        B[i] = A[r] * A[r];
                        r++;
                    }
                } // end of for loop
                return B;
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing SortedSquares()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return null;
            } // end of catch block
        } // end of method SortedSquares


        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                throw;
            }

            return new int[] { };
        } // end of method Intersect


        public static bool UniqueOccurrences(int[] arr)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        } // end of method UniqueOccurrences


        public List<String> Ranges(int[] numbers, int lower, int upper)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        } // end of method Ranges


        public static string[] UniqFolderNames(string[] names)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {

                throw;
            }
            return default;
        } // end of method UniqFolderNames
    }
}