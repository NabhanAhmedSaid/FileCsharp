using System;
using System.IO;

class Program
{
    static void Main(){
         Console.WriteLine("Write the name of file");
        string inputName = Console.ReadLine();

        string fileName = inputName;

         Console.WriteLine("Write the content of the file");
        string input = Console.ReadLine();
        string content = input;

        File.WriteAllText(fileName,content);
        Console.Write("Done");
    }
}
