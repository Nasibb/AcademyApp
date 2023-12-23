// See https://aka.ms/new-console-template for more information

using AcademyApp.Helper;

Helper.ChangeTextColor(ConsoleColor.Green, "Academy App");
Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter number:" +
    "1.CreateStudent 2.GetAllStudent");
string menu = Console.ReadLine();
