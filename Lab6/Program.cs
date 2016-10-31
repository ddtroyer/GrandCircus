using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            string pigWord;
            string answer;
            do
            {
                Console.WriteLine("Please enter a sentence:");
                string sentence = Console.ReadLine();
                sentence = sentence.ToLower();

                string[] words = sentence.Split(' ');

                foreach (string word in words)
                {
                    PigLatin(word, out pigWord);
                    Console.Write(pigWord + " ");
                }
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Translate another line? (y/n)");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() == "y" || answer.ToLower() == "yes");

            Console.WriteLine("amegay overway");
        }
        static public void PigLatin(string word, out string pigWord)
        {
            string halfWord;
            int firstPart = 0;
            int wordLength = 0;

            firstPart = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });

            if (firstPart == 0)
            {
                halfWord = (word + "w"); //reverts to original word and adds "w" to end 
            }
            else
            {
                char[] first = word.ToCharArray(0, firstPart); //removes first part of word
                string firstChar = new string(first);

                wordLength = word.Length;

                char[] rest = word.ToCharArray(firstPart, (wordLength - firstPart)); //rest of word
                string restChar = new string(rest);

                halfWord = (restChar + firstChar);
                
            }
            firstPart = 0;
            pigWord = (halfWord + "ay");
        }
    }
}

