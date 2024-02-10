using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeeCodeColectii
{
    public class Solutii
    {

        Functii functii = new Functii();

        public void solutia1()
        {
            Console.WriteLine(functii.RepeatedCharacter("abdcea"));
        }

        public void solutia2()
        {
            int[][] grid = new int[][]{ [ 1, 3 ], [ 2, 2 ] };
            int[] arry = functii.FindMissingAndRepeatedValues(grid);
            foreach (var item in arry)
            {
                Console.WriteLine(item);
            }
        }

        public void solutia3()
        {
            Console.WriteLine(functii.MinimizedStringLength("abcdefgihs"));

        }

        public void solutia4()
        {
            int[] nums1 = [1, 1, 3, 2], nums2 = [2, 3], nums3 = [3];

            IList<int> ints = functii.TwoOutOfThree(nums1,nums2,nums3);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

        }

        public void solutia5()
        {

            Console.WriteLine(functii.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv"));

        }

        public void solutia6()
        {
            functii.EncodeDecode();
        }

        public void solutia7()
        {
            int[] nums = { 1, 2, 3, 1,2,3};
            int[] nr = functii.NumberOfPairs(nums);
            foreach (var item in nr)
            {
                Console.WriteLine(item);
            }
        }

        public void solutia8()
        {
            Console.WriteLine(functii.CheckIfPangram("i went in the park"));

        }

        public void solutia9()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };

            Console.WriteLine(functii.CountKDifference(nums,3));

        }

        public void solutia10()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int[] nr = functii.SmallerNumbersThanCurrent(nums);

            foreach (var item in nr)
            {
                Console.WriteLine(item);
            }

        }

        public void solutia11()
        {
            Console.WriteLine(functii.NumJewelsInStones("aA", "aAAbbbb"));
        }

        public void solutia12()
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(functii.NumIdenticalPairs(nums));

        }

        public void solutia13()
        {
            Console.WriteLine(functii.NumSquares(49));

        }

        public void solutia14()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            IList<IList<string>> group = functii.GroupAnagrams(strs);

            foreach (var item in group)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine(" ");

            }

        }

        public void solutia15()
        {
            Console.WriteLine(functii.RomanToInt("XLVII"));

        }



    }
}
