/*
Write a program that extracts from given XML file all the text without the tags.
Example:
<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest>
<interest>Java</interest></interests></student>
*/

using System.IO;
using System.Text;

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader sr = new StreamReader(@"..\..\text.xml");
        string input = string.Empty;
        StringBuilder result = new StringBuilder();

        using (sr)
        {
            input = sr.ReadToEnd();
        }

        bool inTag = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                inTag = true;                
            }
            if (!inTag)
            {
                result.Append(input[i]);
            }
            if (input[i] == '>')
            {
                inTag = false;
            }           
        }

        StreamWriter sw = new StreamWriter(@"..\..\result.txt"); //check the file

        using (sw)
        {
            sw.WriteLine(result.ToString());
        }
    }
}

