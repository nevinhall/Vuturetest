using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuturetest
{
    class TaskThree
    {
        /// <summary>
        /// This methods for trackin the number of times
        /// a tracked word appears in a given sentence. The string
        /// is split and then iterated to see if any of the words are in the 
        /// censored dictionary. If so they value of occurences for the censored word i s
        /// incremented.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="senetence"></param>
        /// <returns>
        /// A String reflecting the contents of the dictionary.
        /// </returns>
        public String CensoredWord(string[] arr, String senetence)
        {
            Dictionary<string, int> censoredWords = new Dictionary<string, int>();
            string res = " ";
            int sumValues = 0;

            //Add words to censored list
            foreach (string word in arr)
            {
                censoredWords.Add(word, 0);
            }

            foreach (string word in senetence.Split(" "))
            {

                if (censoredWords.ContainsKey(word))
                {
                    censoredWords[word] = censoredWords[word] + 1;
                }

            }

            foreach (KeyValuePair<string, int> keyValues in censoredWords)
            {
                res += keyValues.Key + " : " + keyValues.Value + ", ";
                sumValues += keyValues.Value;
            }

            return res + "Total :" + sumValues;
        }




        /// <summary>
        /// Works similiar to the function above however, the dictionary now containe
        /// a censored word that will replace the uncensored word if found when looping.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sentence"></param>
        /// <returns>A censoreded string</returns>
        public  String CensoredWord2(string[] arr, String sentence)
        {
            Dictionary<string, string> censoredWords = new Dictionary<string, string>();
            int i = 0;
            String[] words = sentence.Replace(".", " ").Split(" ");

            //Add words to censored list, replace characters at required index
            // and replace with $
            foreach (string word in arr)
            {
                censoredWords.Add(word, word.Remove(1, 2).Insert(1, "$").Insert(2, "$"));
            }

            foreach (string currWord in words)
            {

                if (censoredWords.ContainsKey(currWord))
                {
                    Console.WriteLine('a');
                    words[i] = censoredWords[currWord];
                }
                i += 1;
            }



            return string.Join(" ", words);
        }






        public String CensoredWord3(String sentence, TaskOneAndTwo TaskOneAndTwoObject)
        {

            int i = 0;
            String[] words = sentence.Replace(".", " ").Split(" ");

            //Add words to censored list, replace characters at required index
            // 

            foreach (string currWord in words)
            {

                if (TaskOneAndTwoObject.IsPalindrome(currWord))
                {
                    words[i] = currWord.Remove(1, currWord.Length - 2).Insert(1, "$").Insert(2, "$");

                }

                i += 1;

            }


            return string.Join(" ", words);
        }

    }
}
