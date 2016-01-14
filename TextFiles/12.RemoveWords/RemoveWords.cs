//Write a program that removes from a text file all words listed in given another text file

using System.IO;
using System.Text;

class RemoveWords
{
    static void Main()
    {
        StreamReader sr;
        string[] words;
        string[] text;

        sr = new StreamReader(@"..\..\words.txt");
        using (sr)
        {
            words = (sr.ReadToEnd()).Split(' ');
        }

        sr = new StreamReader(@"..\..\text.txt");
        using (sr)
        {
            text = (sr.ReadToEnd()).Split(' ');
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            foreach (var word in words)
            {
                if (text[i] == word)
                {
                    text[i] = string.Empty;
                }
            }

            if (text[i] == string.Empty)
            {
                result.Append(string.Empty);
            }
            else
            {
                result.Append(text[i] + " ");
            }
        }

        StreamWriter sw = new StreamWriter(@"..\..\result.txt");

        using (sw)
        {
            sw.Write(result.ToString());
        }
    }
}

