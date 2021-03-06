
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuturetest
{
    public class Program
    {
      public static void Main(string[] args)
        {
            //Instantiate Objects for later use.
            TaskOneAndTwo taskOneAndTwoObject = new TaskOneAndTwo();
            TaskThree taskThreeObject = new TaskThree();

            //Instantiate Arrays for later use
            string[] arr = { "dog", "cat", "large" };
            string[] arr2 = { "Meow", "Woof" };

            int resLetterOccurence = taskOneAndTwoObject.LetterOccurence("I have some cheese", 'e');

            bool resIsPalindrome = taskOneAndTwoObject.IsPalindrome("I have some cheese");
            bool resIsPalindrome1 =taskOneAndTwoObject.IsPalindrome("God saved Eva’s dog");

            string resCensoredWord = taskThreeObject.CensoredWord(arr, "I have a cat named Meow and a dog name Woof. I love the dog a lot. He is larger than a small horse.");
            string resCensoredWord2 = taskThreeObject.CensoredWord2(arr2, "I have a cat named Meow and a dog name Woof.I love the dog a lot.He is larger than a small horse.");
            string resCensoredWord3 = taskThreeObject.CensoredWord3("Anna went to vote in the election to fulfil her civic duty",taskOneAndTwoObject);

            Console.WriteLine("Result Letter Occurence: \n" + resLetterOccurence);
            Console.WriteLine("\nResult is Palindrome: \n"+ resIsPalindrome);
            Console.WriteLine("\nResult is Palindrome: \n"+ resIsPalindrome1);
            Console.WriteLine("\nResult is Censord Word: \n" + resCensoredWord);
            Console.WriteLine("\nResult Censord Word2: \n" + resCensoredWord2);
            Console.WriteLine("\nResult Censord Word3: \n" + resCensoredWord3);




        }
       
    }
}


