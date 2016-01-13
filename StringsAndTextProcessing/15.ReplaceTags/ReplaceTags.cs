/*
Write a program that replaces in a HTML document given as string all the tags<a href="…">…</a> with corresponding tags[URL =…]…/URL].
Example:
input 
<p>Please visit <a href = "http://academy.telerik. com" > our site</a> to choose a training course. Also visit <a href = "www.devbg.org" > our forum</a> to discuss the courses.</p>	
output
<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
*/
using System;
using System.Text;

class ReplaceTags
{
    static void Main(string[] args)
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(input);
        var output = new StringBuilder();
        bool inATag = false;
        for (int i = 0; i < input.Length; i++)
        {
            output.Append(input[i]);
            if (i > 0 && input[i] == 'a' && input[i - 1] == '<')
            {
                inATag = true;
            }
            if (inATag && input[i] == '>')
            {
                output[output.Length - 1] = ']'; //replaces the closing > with a ] only if it closes an <a> tag
                output.Remove(output.Length - 2, 1); //removes the " before the closing bracket
                inATag = false;
            }
        }
        output.Replace("<a href=\"", "[URL=").Replace("</a>", "[/URL]");
        Console.WriteLine(output);

    }
}

