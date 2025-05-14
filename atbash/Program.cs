
// See https://aka.ms/new-console-template for more information

//string CipherKey(string EncryptedText)
//{

//}

//char DecodingCode(char signal)
//{

//}


//﻿void printMessage(int point, string message)
//{

//}bomb, nukhba, fighter, rocket, secret



using System.Diagnostics.Tracing;

int SearchProblemticWords(string LisztDeciphered)
{
    int counter = 0;
    string str = "bomb, nukhba, fighter, rocket, secret";
    char[] delimiterChars = [' ',',',':','-','.','/','!','?'];
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
Console.WriteLine("");
