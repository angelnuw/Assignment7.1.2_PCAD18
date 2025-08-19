using System;
using System.Text;

namespace Assignment7._1._2
{
    internal class Program
    {
        //Take a (from word1) → "a"

        //Take p(from word2) → "ap"

        //Take b(from word1) → "apb"

        //Take q(from word2) → "apbq"

        //Take c(from word1) → "apbqc"

        //Take r(from word2) → "apbqcr"

        //Final output = "apbqcr"
        //i for word1
        //j for word2
        //both start at 0

        static string MergeAlternately(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            int i = 0, j = 0;

            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length)
                {
                    result.Append(word1[i]);
                    i++;
                }
                if (j < word2.Length)
                {
                    result.Append(word2[j]);
                    j++;
                }
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";

            string mergedString = MergeAlternately(word1, word2);
            Console.WriteLine(mergedString);
        }
    }
}
