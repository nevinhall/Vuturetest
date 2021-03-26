
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuturetest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int resLetterOccurence = LetterOccurence("I have some cheese", 'e');

            bool resIsPalindrome = IsPalindrome("I have some cheese");
            bool resIsPalindrome1 = IsPalindrome("God saved Eva’s dog");

            string[] arr = { "dog", "cat", "large" };
            string resCensoredWord = CensoredWord(arr, "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.");

            Console.WriteLine("Result Letter Occurence: \n" + resLetterOccurence);
            Console.WriteLine("\nResult is Palindrome: \n"+ resIsPalindrome);
            Console.WriteLine("\nResult is Palindrome: \n"+ resIsPalindrome1);
            Console.WriteLine("\nResult is Censord Word: \n" + resCensoredWord);

        }


        /// <summary>
        /// This function firstly remove the fullstop, then for each character in the string
        /// checks if its currently stored in the dictionary. If it is not it is added
        /// the dictionary is then update increasing the currences of the current letter by one.
        /// 
        /// The fianl statment retrives the value of the letter passed in.
        /// </summary>
        /// <param name="senetence"></param>
        /// <param name="letter"></param>
        /// <returns>
        /// An int value reflecting the current value of occurences for a given letter.
        /// </returns>
        public static int LetterOccurence(String senetence, Char letter)
        {   //Define dictionary for later use.
            Dictionary<char, int> letterOccurence = new Dictionary<char, int>();
           



            //Clean the String.
            String trimmedSentemce = senetence.Trim(new Char[] { '.'});


            foreach(char currLetter in trimmedSentemce)
            {
               
                if (letterOccurence.ContainsKey(currLetter) == false)
                {
                    letterOccurence.Add(currLetter, 0);
                }
                letterOccurence[currLetter] = letterOccurence[currLetter] + 1;
            }


            if (letterOccurence.ContainsKey(letter))
            {
                return letterOccurence[letter];
            }
            return 0;
        }






        /// <summary>
        /// This method checks to see if a given string is palindrome or not
        /// first the string is cleaned. Then we loop over the string checking id the current letter at i
        /// is equal to the same charcter at location i from the end of the string.
        /// </summary>
        /// <param name="senetence"></param>
        /// <returns>
        /// A bool to determine if a string is or isnt  a palindrome.
        /// </returns>
        public static bool IsPalindrome(String senetence)
        

        {
            String sentence = senetence.Replace(" ", string.Empty).Replace("’", string.Empty).ToLower();


            int length = sentence.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (sentence[i] != sentence[length - i - 1])
                    return false;
            }

            return true;


        }



        public static String CensoredWord(string[] arr, String senetence) {
            Dictionary<string, int> censoredWords;

        
            return "sensoredword";
        }
    }
}


