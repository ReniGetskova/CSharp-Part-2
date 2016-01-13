//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.

using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main()
    {
        string data = File.ReadAllText(@"..\..\text.txt");
        Regex dateRegex = new Regex(@"[0-9]{1,2}\.[0-9]{1,2}\.[0-9]{2,4}");

        MatchCollection dateMatches = dateRegex.Matches(data);
        StringBuilder sb = new StringBuilder();

        foreach (Match dateMatch in dateMatches)
        {
            sb.AppendLine(dateMatch.Value);
        }

        File.WriteAllText(@"..\..\dates.txt", sb.ToString());
        Console.WriteLine("Dates were saved in file");
    }
}

