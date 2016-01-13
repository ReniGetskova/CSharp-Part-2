//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format<identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string data = File.ReadAllText(@"..\..\text.txt"); //read File 
        //instantiate with this pattern 
        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
        //find items that matches with our pattern
        MatchCollection emailMatches = emailRegex.Matches(data);

        StringBuilder sb = new StringBuilder();

        foreach (Match emailMatch in emailMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }
        //store to file
        File.WriteAllText(@"..\..\emailAddresses.txt", sb.ToString());
        Console.WriteLine("Email addresses were saved in file");
    }
}

