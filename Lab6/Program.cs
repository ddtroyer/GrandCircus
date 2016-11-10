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
            int numSym;
            int punctuation;
            string punc = "";
            string withoutPunc;
            word = word.ToLower();

            numSym = word.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@' });

            if (numSym >= 0)
            {
                pigWord = word;
            }
            else
            {
                firstPart = word.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });

                if (firstPart == 0)
                {
                    halfWord = (word + "w");
                }
                else if (firstPart < 0)
                {
                    halfWord = (word);
                }
                else
                {
                    char[] first = word.ToCharArray(0, firstPart);
                    string firstChar = new string(first);

                    wordLength = word.Length;

                    char[] rest = word.ToCharArray(firstPart, (wordLength - firstPart));
                    string restChar = new string(rest);

                    punctuation = word.IndexOfAny(new char[] { '!', '?', ',', '.' });

                    if (punctuation != (wordLength - 1))
                    {
                        halfWord = (restChar + firstChar);
                    }
                    else
                    {
                        punc = restChar.Substring(punctuation - 1);
                        withoutPunc = restChar.Substring(0, punctuation - 1);
                        //if yes, remove that punctuation
                        //rename punc
                       

                        halfWord = (withoutPunc + firstChar);
                    }
                }
                firstPart = 0;
                pigWord = (halfWord + "ay" + punc);
            }
        }
    }
}


