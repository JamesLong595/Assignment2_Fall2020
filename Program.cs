using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2_Fall2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a triangle of arbitary height
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** print a triangle of arbitary height **\n"); 
                    Console.WriteLine("Please enter a positive integer:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    if (n > 0)
                    {
                        PrintPatternAnyComplexity(n);
                        Console.WriteLine("");
                        PrintPatternLinearComplexity(n);
                        break;
                    } // end of if block
                    else
                    {
                        Console.WriteLine("\nOnly positive integers are allowed.\n");
                    } // end of else block
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...\n");
                } // end of catch block
            } // end of while loop for triangle


            // print the length of a continuous increasing subsequence
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** print the length of longest continuous increasing subsequence **\n");
                    // collect data from user and convert to an integer array
                    Console.WriteLine("\nEnter a comma-separated array of integers in any order:\n");
                    string input = Console.ReadLine();
                    string[] strArr = input.Split(",");
                    int[] array1 = new int[strArr.Length];
                    int num;
                    for (int i = 0; i < array1.Length; i++)
                    {
                        num = Convert.ToInt32(strArr[i]);
                        array1[i] = num;
                    }
                    int result = LongestSubSeq(array1);
                    if (result == -1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThe longest continuous increasing subsequence is " + result + " elements long.\n");
                        Console.ReadKey();
                        break;
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...");
                }  // end of catch block
            } // end of while loop for increasing subsequence


            // split an array of integers conditionally and print them, else print false
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** split an array of integers conditionally & print them, else print false **\n");
                    // collect data from user and convert to an integer array
                    Console.WriteLine("\nEnter a comma-separated array of positive integers in any order:\n");
                    string input = Console.ReadLine();
                    string[] strArr = input.Split(",");
                    int[] array2 = new int[strArr.Length];
                    int num;
                    for (int i = 0; i < array2.Length; i++)
                    {
                        num = Convert.ToInt32(strArr[i]);
                        if (num >= 0)
                        {
                            array2[i] = num;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    } // end of for loop
                    PrintTwoParts(array2);
                    break;
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...\n");
                } // end of catch block
            } // end of while loop for split array


            // square values of an array and return sorted squares
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** square values of an array and return sorted squares **\n");
                    // collect data from user, validate, and convert to an integer array
                    Console.WriteLine(@"
Enter a comma-separated array of integers sorted in non-decreasing order.
The minimum allowable length is 1.
The maximum allowable length is 10,000.
The minimum allowable value is -10,000.
The maximum allowable value is 10,000.
");
                    string input = Console.ReadLine();
                    string[] strArr = input.Split(",");
                    if (strArr.Length > 10000)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    int[] array3 = new int[strArr.Length];
                    int num;
                    for (int i = 0; i < array3.Length; i++)
                    {
                        num = Convert.ToInt32(strArr[i]);
                        array3[i] = num;
                        if (i > 0 && array3[i] < array3[i - 1])
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        if (array3[i] < -10000 || array3[i] > 10000)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    } // end of for loop
                    int[] result2 = SortedSquares(array3);
                    if (result2 == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n[" + string.Join(", ", result2) + "]");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...\n");
                } // end of catch block
            } // end of while loop for sorted squares


            // find and print intersection of two arrays
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** find and print intersection of two arrays **\n");
                    // collect data from user and convert to the first integer array
                    Console.WriteLine("\nEnter the first comma-separated array of integers in any order:\n");
                    string input1 = Console.ReadLine();
                    string[] strArr1 = input1.Split(",");
                    int[] nums1 = new int[strArr1.Length];
                    int num1;
                    for (int i = 0; i < nums1.Length; i++)
                    {
                        num1 = Convert.ToInt32(strArr1[i]);
                        nums1[i] = num1;
                    } // end of for loop
                    // collect data from user and convert to the second integer array
                    Console.WriteLine("\nEnter the second comma-separated array of integers in any order:\n");
                    string input2 = Console.ReadLine();
                    string[] strArr2 = input2.Split(",");
                    int[] nums2 = new int[strArr2.Length];
                    int num2;
                    for (int i = 0; i < nums2.Length; i++)
                    {
                        num2 = Convert.ToInt32(strArr2[i]);
                        nums2[i] = num2;
                    } // end of for loop
                    int[] intersect1 = Intersect(nums1, nums2);
                    if (intersect1 == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n[" + string.Join(", ", intersect1) + "]");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...\n");
                } // end of catch block
            } // end of while loop for intersection


            // determine whether the number of occurrences of each value in an array is unique
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** determine whether number of occurrences of each value in an array is unique **\n");
                    // collect data from user and convert to an integer array
                    Console.WriteLine("Enter a comma-separated array of integers in any order:\n");
                    string input1 = Console.ReadLine();
                    string[] strArr1 = input1.Split(",");
                    int[] arr = new int[strArr1.Length];
                    int num;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        num = Convert.ToInt32(strArr1[i]);
                        arr[i] = num;
                    } // end of for loop
                    Console.WriteLine("\n" + UniqueOccurrences(arr));
                    Console.WriteLine("\nPress any key to continue ...\n");
                    Console.ReadKey();
                    break;
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...\n");
                } // end of catch block
            } // end of while loop for unique occurrences


            // find missing ranges in an array
            while (true)
            {
                try
                {
                    Console.WriteLine("\n** find missing ranges in an array **\n");
                    // collect data from user and convert to an integer array with boundaries
                    Console.WriteLine("Enter an integer representing the LOWER bound of the range (inclusive):\n");
                    string low = Console.ReadLine();
                    int lower = int.Parse(low);
                    Console.WriteLine("\nEnter an integer representing the UPPER bound of the range (inclusive):\n");
                    string up = Console.ReadLine();
                    int upper = int.Parse(up);
                    if (upper < lower)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    Console.WriteLine("\nEnter a comma-separated array of non-decreasing integers:\n");
                    string input = Console.ReadLine();
                    string[] strArr = input.Split(",");
                    int[] numbers = new int[strArr.Length];
                    int num;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        num = Convert.ToInt32(strArr[i]);
                        numbers[i] = num;
                    } // end of for loop
                    /* the next line of code threw error CS0120: object reference required for the non-static method
                     * method Ranges was not static, which caused the error
                     * method Ranges was the only non-static method in the Program.cs file provided by the professor
                     * making the method static eliminates the error
                     */
                    List<string> ResultList = Ranges(numbers, lower, upper);
                    if (ResultList == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n[" + string.Join(", ", ResultList) + "]");
                        Console.WriteLine("\nPress any key to continue ...\n");
                        Console.ReadKey();
                        break;
                    }
                } // end of try block
                catch
                {
                    Console.WriteLine("\nInvalid input ...\n");
                } // end of catch block
            } // end of while loop for missing ranges


            //// create unique folder names
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("\n** create unique folder names **\n");
            //        // explain
            //        Console.WriteLine("Question 8");
            //        string[] names = new string[] { "pes", "fifa", "gta", "pes(2019)" };
            //        string[] namesResult = UniqFolderNames(names);
            //        //Write code to print your result here
            //    } // end of try block
            //    catch
            //    {
            //        Console.WriteLine("\nInvalid input ...\n");
            //    } // end of catch block
            //} // end of while loop for unique folder names

        } // end of method Main


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
                // build a dictionary containing the lines to be printed
                Dictionary<int, string> stars = new Dictionary<int, string>();
                for (int i = n; i > 0; i--)
                {
                    stars[i] = String.Concat(Enumerable.Repeat("*", i));
                }
                // print the dictionary values
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(stars[i]);
                }
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
        // if n = number of lines, then O(2n) which simplifies to O(n)


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
        // if n = number of lines, then O(n)


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
        // if n = length of input array, then O(n)


        public static void PrintTwoParts(int[] array2)
        {
            // Given an array of integers greater than zero, find if it is possible to split it
            // in two subarrays (without reordering the elements), such that the sum of the two
            // subarrays is the same. Print the two subarrays or False.
            try
            {
                int sum1 = 0;
                int sum2 = array2.Sum();
                for (int i = 0; i < array2.Length; i++)
                {
                    sum1 += array2[i];
                    sum2 -= array2[i];
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
                        Console.WriteLine("\n[" + string.Join(", ", subArr1) + "]" + "\n[" + string.Join(", ", subArr2) + "]\n");
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
        // if n = length of input array, then O(n)


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
                    if (A[i] >= 0 || i == (A.Length-1))
                    {
                        r = i;
                        break;
                    }
                } // end of for loop
                // initialize left side index tracker
                int l = r - 1;
                // start somewhere in the middle and work outward in both directions
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
        // if n = length of input array, then O(2n) which simplifies to O(n)


        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            // Given two arrays, write a function to compute their intersection. 
            // Each element in the result should appear as many times as it shows in both arrays.
            // The result can be in any order.
            try
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                List<int> lst = new List<int>();
                foreach (int i in nums1)
                {
                    if (dict.TryAdd(i, 1))
                    { }
                    else
                    {
                        dict[i]++;
                    }
                } // end of foreach loop
                foreach (int i in nums2)
                {
                    if (dict.ContainsKey(i) && dict[i] > 0)
                    {
                        lst.Add(i);
                        dict[i]--;
                    }
                }
                int[] intersection = new int[lst.Count];
                for (int i = 0; i < lst.Count; i++)
                {
                    intersection[i] = lst[i];
                }
                return intersection;
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing Intersect()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return null;
            } // end of catch block
        } // end of method Intersect
        // if n = total length of both input arrays, then O(n)
        // if n = length of first array & k = length of second array, then O(n+k) which simplifies to O(n)


        public static bool UniqueOccurrences(int[] arr)
        {
            // Given an array of integers arr, write a function that returns true if and only if
            // the number of occurrences of each value in the array is unique.
            try
            {
                // create and populate a dictionary of array value counters
                Dictionary<int, int> uo = new Dictionary<int, int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (uo.TryAdd(arr[i], 1)) { }
                    else { uo[arr[i]]++; }
                }
                // create and populate a dictionary of unique counter values
                Dictionary<int, int> uc = new Dictionary<int, int>();
                foreach (KeyValuePair<int, int> kvp in uo)
                {
                    if (uc.TryAdd(kvp.Value, 1)) { }
                    else
                    {
                        return false;
                    }
                }
                return true;
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing UniqueOccurrences()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return false;
            } // end of catch block
        } // end of method UniqueOccurrences
          // if n = total length of the input array, then O(2n) which simplifies to O(n)


        public static List<string> Ranges(int[] numbers, int lower, int upper)
        {
            /* Given a non-decreasing integer array nums, where the range of elements
             * are in the inclusive range [lower, upper], return its missing ranges.
             * Return empty array if the given array contains all the elements from the range
             * or return ["0->99"] if the given array is empty.
             */
            try
            {
                List<string> missing = new List<string>();
                int maxIdx = numbers.Length - 1;
                // find gaps in array up to max value in array
                for (int i = 0; i <= maxIdx; i++)
                {
                    if (i == 0 && numbers[i] == lower) { }
                    else if (i == 0 && numbers[i] == lower + 1)
                    {
                        missing.Add("\"" + Convert.ToString(lower) + "\"");
                    }
                    else if (i == 0)
                    {
                        missing.Add("\"" + Convert.ToString(lower) + "->" + Convert.ToString(numbers[i] - 1) + "\"");
                    }
                    else if (numbers[i] == numbers[i - 1] || numbers[i] - 1 == numbers[i - 1]) { }
                    else if (numbers[i] - 1 == numbers[i - 1] + 1)
                    {
                        missing.Add("\"" + Convert.ToString(numbers[i] - 1) + "\"");
                    }
                    else
                    {
                        missing.Add("\"" + Convert.ToString(numbers[i - 1] + 1) + "->" + Convert.ToString(numbers[i] - 1) + "\"");
                    }
                } // end of for loop
                // find gaps in array above max value in array
                if (numbers[maxIdx] == upper) { }
                else if (numbers[maxIdx] + 1 == upper)
                {
                    missing.Add("\"" + Convert.ToString(numbers[maxIdx] + 1) + "\"");
                }
                else
                {
                    missing.Add("\"" + Convert.ToString(numbers[maxIdx] + 1) + "->" + Convert.ToString(upper) + "\"");
                }
                return missing;
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing Ranges()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return new List<string>() { null };
            } // end of catch block
        } // end of method Ranges
        // if n = total length of the range (upper - lower), then O(n)


        public static string[] UniqFolderNames(string[] names)
        {
            /* Given an array of strings names of size n, you will create output string array
             * which stores folder names. Since two files cannot have the same name, if you enter
             * a folder name which is previously used, the system will have a suffix addition to
             * its name in the form of(k) where, k is the smallest positive integer such that the
             * obtained name remains unique. Return an array of strings of length n where the names
             * of the files are according to the assignments by the system.
             */
            try
            {
                string[] folders = new string[] { };

                return folders;
            } // end of try block
            catch (Exception e)
            {
                Console.WriteLine($"\nAn {e.GetType().Name} error occured while computing UniqFolderNames()");
                Console.WriteLine("\nPress any key to continue ...\n");
                Console.ReadKey();
                return new string[] { };
            } // end of catch block
        } // end of method UniqFolderNames
    }
}
