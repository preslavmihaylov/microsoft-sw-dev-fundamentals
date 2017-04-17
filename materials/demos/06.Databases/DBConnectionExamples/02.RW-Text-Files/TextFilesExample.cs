using System.IO;
using System;

class TextFilesExample
{
    static string[] names = { "pesho", "gosho", "ivan" };

    static void Main()
    {
        int cnt = 0;

        foreach (var name in names)
        {
            WriteToFile("./log.txt", cnt  + " " + name);
            ++cnt;
        }

        /*
        WriteToFile("./log.txt", "1 Some dummy info");
        WriteToFile("./log.txt", "2 Some dummy info");
        WriteToFile("./log.txt", "3 Some dummy info");
        WriteToFile("./log.txt", "4 Some dummy info");
        */

        Console.WriteLine(ReadFromFile("./log.txt"));
    }

    static void WriteToFile(string filename, string text)
    {
        // true is for appending data
        StreamWriter sw = 
            new StreamWriter(
                new FileStream(filename, FileMode.Open, FileAccess.ReadWrite),
                System.Text.Encoding.UTF8);
        
        sw.WriteLine(text);

        sw.Close();
    }

    static string ReadFromFile(string filename)
    {
        string result;
        using (StreamReader sr = new StreamReader(filename))
        {
            result = sr.ReadToEnd();
        }

        return result;
    }
}