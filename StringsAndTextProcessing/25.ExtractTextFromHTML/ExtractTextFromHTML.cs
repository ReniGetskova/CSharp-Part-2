/*
Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:
<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>

Output:
Title: News
Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
*/
using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        string input = @"
<html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">Telerik Academy </ a > aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</ p >
</ body >
</ html > ";

        StringBuilder result = new StringBuilder();
        if (input.Contains("<title>"))
        {
            result.Append("Title: ");
        }

        string inputWithoutTags = Regex.Replace(input, "<[^>]*>", String.Empty);
        foreach (char item in inputWithoutTags)
        {           
            if (item != '\n' && item != '\t' && item != '\r')
            {
                result.Append(item);
            }
        }

        Console.WriteLine(result);
    }
}

