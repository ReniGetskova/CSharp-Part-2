/*
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the 
[protocol], [server] and [resource] elements.
Example:
URL
http://telerikacademy.com/Courses/Courses/Details/212	
Information
[protocol] = http
[server] = telerikacademy.com
[resource] = /Courses/Courses/Details/212
*/

using System;


class ParseURL
{
    static void Main()
    {
        string inputUrl = @"http://telerikacademy.com/Courses/Courses/Details/212";
        var url = new Uri(inputUrl);
        Console.WriteLine("[protocol] = {0}", url.Scheme);
        Console.WriteLine("[server] = {0}", url.DnsSafeHost);
        Console.WriteLine("[resource] = {0}", url.LocalPath);
    }
}

