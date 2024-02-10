using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCodeColectii
{
    public class Functii
    {

        public char RepeatedCharacter(string s)
        {

            Dictionary<int, char> dictionary = new Dictionary<int, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i])) return s[i];
                else dictionary.Add(s[i], s[i]);
            }

            return ' ';
        }

        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            int n = grid.Length;
            HashSet<int> seen = new HashSet<int>();
            int repeated = 0, expectedSum = 0, actualSum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int num = grid[i][j];

                    if (seen.Contains(num))
                    {
                        repeated = num;
                    }
                    else
                    {
                        seen.Add(num);
                    }

                    expectedSum += (i * n) + (j + 1);
                    actualSum += num;
                }
            }
            int missing = expectedSum - actualSum + repeated;

            return new int[] { repeated, missing };
        }

        public int MinimizedStringLength(string s)
        {
            Dictionary<int, char> dictionary = new Dictionary<int, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dictionary.ContainsKey(s[i]))
                    dictionary.Add(s[i], s[i]);
            }

            int ct = 0;
            for (int i = 97; i <= 123; i++)
            {
                if (dictionary.ContainsKey(i)) ct++;
            }

            return ct;
        }

        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            Dictionary<int, int> countDict = new Dictionary<int, int>();

            CountOccurrences(nums1, countDict);
            CountOccurrences(nums2, countDict);
            CountOccurrences(nums3, countDict);

            List<int> result = countDict
                .Where(kv => kv.Value >= 2)
                .Select(kv => kv.Key)
                .ToList();

            return result;
        }

        private void CountOccurrences(int[] nums, Dictionary<int, int> countDict)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(nums);
            foreach (var num in uniqueNumbers)
            {
                if (countDict.ContainsKey(num))
                {
                    countDict[num]++;
                }
                else
                {
                    countDict[num] = 1;
                }
            }
        }

        public string DecodeMessage(string key, string message)
        {

            Dictionary<char, char> table = new Dictionary<char, char>();
            char currentChar = 'a';

            foreach (char c in key)
            {
                if (c != ' ' && !table.ContainsKey(c))
                {
                    table[c] = currentChar;
                    currentChar++;
                }
            }

            string decodedMessage = "";

            foreach (char c in message)
            {
                if (c == ' ')
                {
                    decodedMessage += ' ';
                }
                else if (table.ContainsKey(c))
                {
                    decodedMessage += table[c];
                }
            }

            return decodedMessage;
        }

        public void EncodeDecode()
        {
            Dictionary<string, string> shortToLong = new Dictionary<string, string>();
            Dictionary<string, string> longToShort = new Dictionary<string, string>();
            string baseUrl = "http://tinyurl.com/";
            int counter = 1;

            string encode(string longUrl)
            {
                if (longToShort.ContainsKey(longUrl))
                {
                    return baseUrl + longToShort[longUrl];
                }

                string shortUrl = counter.ToString();
                shortToLong[shortUrl] = longUrl;
                longToShort[longUrl] = shortUrl;
                counter++;

                return baseUrl + shortUrl;
            }

            string decode(string shortUrl)
            {
                string shortKey = shortUrl.Replace(baseUrl, "");

                if (shortToLong.ContainsKey(shortKey))
                {
                    return shortToLong[shortKey];
                }

                return "";
            }
        }

        public int[] NumberOfPairs(int[] nums)
        {

            Dictionary<int, int> numCount = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num]++;
                }
                else
                {
                    numCount[num] = 1;
                }
            }

            int totalPairs = 0;
            int leftovers = 0;

            foreach (int count in numCount.Values)
            {
                totalPairs += count / 2;
                leftovers += count % 2;
            }

            return new int[] { totalPairs, leftovers };
        }

        public bool CheckIfPangram(string sentence)
        {

            Dictionary<char, int> frecv = new Dictionary<char, int>();
            int ct = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (frecv.ContainsKey(sentence[i]))
                    frecv[sentence[i]]++;
                else frecv[sentence[i]] = 1;
            }

            for (int i = 97; i <= 122; i++)
            {

                if (!frecv.ContainsKey((char)i))
                {
                    return false;
                }

            }

            return true;
        }

        public int CountKDifference(int[] nums, int k)
        {

            Dictionary<int, int> frecv = new Dictionary<int, int>();
            int ct = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                frecv[i] = nums[i];
            }

            for (int i = 0; i < frecv.Count - 1; i++)
            {
                for (int j = i + 1; j < frecv.Count; j++)
                {
                    if (Math.Abs(frecv[i] - frecv[j]) == k)
                    {
                        ct++;
                    }
                }
            }

            return ct;
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {

            Dictionary<int, int> vector = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                vector.Add(i, nums[i]);
            }
            int[] smallerNums = new int[nums.Length];

            for (int i = 0; i < vector.Count; i++)
            {
                for (int j = 0; j < vector.Count; j++)
                {
                    if (i != j)
                    {
                        if (vector[i] > vector[j])
                        {
                            smallerNums[i]++;
                        }
                    }
                }
            }

            return smallerNums;
        }

        public int NumJewelsInStones(string jewels, string stones)
        {

            Dictionary<int, char> jewel = new Dictionary<int, char>();

            for (int i = 0; i < jewels.Length; i++)
            {
                jewel.Add(i, jewels[i]);
            }

            int ct = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                if (jewel.ContainsValue(stones[i]))
                {
                    //jewel[i]++;
                    ct++;
                }
            }


            return ct;
        }

        public int NumIdenticalPairs(int[] nums)
        {

            Dictionary<int, int> savePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (savePairs.ContainsKey(nums[i]))
                    savePairs[nums[i]]++;
                else
                {
                    savePairs.Add(nums[i], 1);
                }
            }

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (savePairs.ContainsKey(i))
                    sum = sum + ((savePairs[i] * (savePairs[i] - 1)) / 2);
            }


            return sum;
        }

        public int NumSquares(int n)
        {

            Dictionary<int, int> dp = new Dictionary<int, int>();
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = int.MaxValue;
                int j = 1;
                while (j * j <= i)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                    j++;
                }
            }

            return dp[n];
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                var key = GetKey(str);
                if (!map.ContainsKey(key))
                {
                    map.Add(key, new List<string>());
                }
                map[key].Add(str);
            }

            var res = new List<IList<string>>();
            foreach (var key in map.Keys)
            {
                res.Add(map[key]);
            }
            return res;
        }

        private static string GetKey(string str)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }

        public int RomanToInt(string s)
        {

            Dictionary<char, int> map = new Dictionary<char, int>();

            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int nr = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    if (map[s[i]] >= map[s[i + 1]])
                    {
                        nr += map[s[i]];
                    }
                    else nr -= map[s[i]];
                }
                else
                {
                    nr += map[s[i]];
                }

            }

            return Math.Abs(nr);
        }

    }

}
