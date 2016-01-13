//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to upper-case. The tags cannot be nested.
//Example: We are living in a<upcase> yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE.We don't have ANYTHING else.

using System;
using System.Text;
using System.IO;

class ParseTags
{
    static void Main()
    {
        //Console.WriteLine("Insert text surrounded by tags");
        //string text = Console.ReadLine();
        StreamReader reader = new StreamReader(@"..\..\content.txt");
        string text = reader.ReadToEnd();
        reader.Close();
        string endFirstTag = ">";
        int indexEndFirstTag = text.IndexOf(endFirstTag);
        string startSecondTag = "</";
        int indexStartSecondTag = text.IndexOf(startSecondTag);
        StringBuilder upperText = new StringBuilder();       
        int tempEnd = 0;
        int tempIndex = indexStartSecondTag - indexEndFirstTag;
        Console.Write(text.Remove(tempIndex + 2));
        while (indexEndFirstTag != -1 && indexStartSecondTag != -1)
        {
            upperText.Clear();
            while (indexEndFirstTag < indexStartSecondTag - 1)
            {
                indexEndFirstTag++;
                upperText.Append(text[indexEndFirstTag]);

            }

            string upper = upperText.ToString();
            upper = upper.ToUpper();
            Console.Write(upper);

            indexEndFirstTag = text.IndexOf(endFirstTag, indexEndFirstTag);
            tempIndex = indexEndFirstTag - indexStartSecondTag;
            indexEndFirstTag = text.IndexOf(endFirstTag, indexStartSecondTag + tempIndex + 1);

            if (indexEndFirstTag > indexStartSecondTag)
            {
                Console.Write(text.Substring(indexStartSecondTag + tempIndex + 1, indexEndFirstTag - indexStartSecondTag - 2* tempIndex));
                tempEnd = text.IndexOf(startSecondTag, indexEndFirstTag + 1);
            }

            indexStartSecondTag = text.IndexOf(startSecondTag, indexEndFirstTag + 1);
            
        }

        Console.WriteLine(text.Substring(tempEnd + tempIndex + 1));
    }
}
