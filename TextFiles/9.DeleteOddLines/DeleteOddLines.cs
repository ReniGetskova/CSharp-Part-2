//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        string tempFile = Path.GetTempFileName();

        StreamReader reader = new StreamReader(@"..\..\file.txt");
        StreamWriter writer = new StreamWriter(tempFile);

        StringBuilder sb = new StringBuilder();

        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1) // check if odd
                    {
                        writer.WriteLine(line);
                    }
                    else
                    {
                        sb.AppendLine(line);
                    }

                    line = reader.ReadLine();
                }
            }
        }

        File.Delete(@"..\..\file.txt");
        File.Move(tempFile, @"..\..\file.txt");

        Console.WriteLine("Deleted lines:\n{0}", sb);
    }
}
