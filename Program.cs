
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
            
            String resLetterOccurence = LetterOccurence("I have some cheese", "e");

            String resIsPalindrome = IsPalindrome("I have some cheese");
            String resIsPalindrome1 = IsPalindrome("God saved Eva’s dog");

            string[] arr = { "dog", "cat", "large" };
            string resCensoredWord = CensoredWord(arr, "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.");

            Console.WriteLine("Result Letter Occurence: \n" + resLetterOccurence);
            Console.WriteLine("\nResult is Palindrome: \n"+ resIsPalindrome);
            Console.WriteLine("\nResult is Palindrome: \n"+ resIsPalindrome1);
            Console.WriteLine("\nResult is Censord Word: \n" + resCensoredWord);

        }



        public static String LetterOccurence(String senetence, String letter)
        {
            return "letter_occurence";
        }

 
        public static String IsPalindrome(String senetence)
        {
            return "IsPalindrome";
        }



        public static String CensoredWord(string[] arr, String senetence) {
            Dictionary<string, int> censoredWords;
        
            return "sensoredword";
        }
    }
}


