using System.Diagnostics.Tracing;
using SeriesAnalyzer;

namespace SeriesAnalyzer
{
    class program()
    {
        static void Main(string[] args)
        {


            string CipherKey(string EncryptedText)
            {

            }

            char DecodingCode(char signal)
            {
                
            }


            ﻿void printMessage(int point, string message)
            {

            }


            int SearchProblemticWords(string LisztDeciphered)
            {
                int counter = 0;
                string str = "bomb, nukhba, fighter, rocket, secret";
                char[] delimiterChars = [' ', ',', ':', '-', '.', '/', '!', '?'];
                string[] WordsList = LisztDeciphered.Split(delimiterChars);
                foreach (var word in WordsList)
                {
                    if (str.Contains(word))
                    {
                        counter += 1;
                    }
                }
                return counter;
            }

        }
    }
}

