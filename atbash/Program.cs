
// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;
using SeriesAnalyzer;

namespace SeriesAnalyzer
{
    class program()
    {
        static void Main(string [] args)
        {
        System.Console.WriteLine(CipherKey("rhizvo"));


            string CipherKey(string encryptedText)
            {
                string decryptedText = "";
                foreach(var signal in encryptedText)
                {
                    if(char.IsLetter(signal))
                    {
                        decryptedText += DecodingCode(signal);
                    }
                    else
                    {
                        decryptedText += signal;
                    }
                }
                return decryptedText;

            }

            char DecodingCode(char signal)
            {
                Dictionary<char,char> cipherDictionary = new Dictionary<char, char>{
                    {'a','z'},
                    {'b','y'},
                    {'c','x'},
                    {'d','w'},
                    {'e','v'},
                    {'f','u'},
                    {'g','t'},
                    {'h','s'},
                    {'i','r'},
                    {'j','q'},
                    {'k','p'},
                    {'l','o'},
                    {'m','n'}};
                char decodedSignal = ' ';
                foreach (var key in cipherDictionary)
                {
                    if (signal == key.Key)
                    {
                        decodedSignal = key.Value;
                    }
                }
                foreach (var value in cipherDictionary)
                {
                    if (signal == value.Value)
                    {
                        decodedSignal = value.Key;
                    }
                }
                return decodedSignal;

            }


            // ﻿void printMessage(int point, string message)
            // {

            // }


            // ﻿int SearchProblemticWords(string LisztDeciphered)
            // {
            //     char[] delimiterChars = [' ',',',':','-','.','\t'];
            //     string [] WordsList = LisztDeciphered.Split(delimiterChars);
                
            // }


        }
         

    }
}




