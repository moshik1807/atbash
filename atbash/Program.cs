using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Tracing;
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

