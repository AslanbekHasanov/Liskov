using Liskov.Service;
using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isContinue = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to project");
            Console.WriteLine("1. Add writable dacument.");
            Console.WriteLine("2. Add read only dacument.");
            Console.WriteLine("3. Open all for writable dacument.");
            Console.WriteLine("4. Open all for read only dacument.");
            Console.Write("Enter your command: ");
            string command = Console.ReadLine();

            if (command.Contains("1") is true)
            {
                WritableDocument writableDocument = new WritableDocument("../../../Assets/dateSecond.txt");
                Project project = new Project();
                project.AddDocument(writableDocument);
                project.SaveAll();

            }

            if (command.Contains("2") is true)
            {
                WritableDocument writableDocument = new WritableDocument("../../../Assets/dateOne.txt");
                Project project = new Project();
                project.AddDocument(writableDocument);
                project.SaveAll();
            }
            if (command.Contains("3") is true)
            {
                WritableDocument writableDocument = new WritableDocument("../../../Assets/dateSecond.txt");
                Project project = new Project();
                project.AddDocument(writableDocument);
                project.OpenAll();
                project.SaveAll();
            }
            if (command.Contains("4") is true)
            {
                WritableDocument writableDocument = new WritableDocument("../../../Assets/dateOne.txt");
                Project project = new Project();
                project.AddDocument(writableDocument);
                project.OpenAll();
                project.SaveAll();
            }

            Console.Write("Is Continue(no or yes): ");
            string isContinueCommand = Console.ReadLine();
            if (isContinueCommand.ToLower().Contains("no") is true)
            {
                isContinue = false;
            }
            else if (isContinueCommand.ToLower().Contains("yes") is true)
            {
                isContinue = true;
            }
        } while (isContinue is true);
    }
}