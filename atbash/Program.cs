using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Tracing;
using SeriesAnalyzer;
namespace SeriesAnalyzer
{
    class program()
    {
        static void Main(string [] args)
        {

            string encrypted = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm�g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";

            string CipherKey(string encryptedText)
            {
                string decryptedText = "";
                foreach(var signal in encryptedText)
                {
                    if(char.IsLetter(signal))
                    {
                        decryptedText += DecodingCode(char.ToLower(signal));
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


            int SearchProblemticWords()
            {
                string LisztDeciphered = CipherKey(encrypted);
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
          
          void printMessage()
          {
              int point = SearchProblemticWords();
              string message = CipherKey(encrypted);
                Console.WriteLine($"The message is:\n{message}\n");
              if (point > 0 && point < 6)
              {
                  Console.WriteLine($"WARNING!WARNING!WARNING!\nThe number of point:\n{point}\n");
              }
              if (point > 5 && point < 11)
              {
                  Console.WriteLine($"DANGER!DANGER!DANGER!\nThe number of point:\n{point}\n");
              }
              if (point > 10 && point < 16)
              {
                  Console.WriteLine($"ULTRA ALERT!ULTRA ALERT!ULTRA ALERT!\nThe number of point:\n{point}\n");
              }
          }
          printMessage();


        }

    }
}


