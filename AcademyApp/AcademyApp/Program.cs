// See https://aka.ms/new-console-template for more information

using AcademyApp.Business.Services;
using AcademyApp.Domain.Models;
using AcademyApp.Helper;
using static AcademyApp.Helper.Helper;

Console.WriteLine("hello");
StudentService studentService = new();

Helper.ChangeTextColor(ConsoleColor.Green, "Academy App");
Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter number:" +
    "1.CreateStudent " +
    "2.GetAllStudent" +
    "3.GetAllStudentWithName" +
    "4.GetStudentById " +
    "5.DeleteStudent" +
    "6.UpdateStudent" +
    "0.ExitMenu");
EnterMenu: string menu = Console.ReadLine();
bool result = int.TryParse(menu, out int intMenu);
while (true)
{
    if (result && intMenu > 0 && intMenu < 3)
    {
        switch (intMenu)
        {
            case (int)Menus.CreateStudent:
                Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter GroupName");
                string groupName = Console.ReadLine();
                Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Name");
                string name = Console.ReadLine();
                Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter Surname");
                string surname = Console.ReadLine();
                Student newStudent = new();
                newStudent.Name = name;
                newStudent.Surname = surname;
                if (studentService.Create(newStudent,groupName) is null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Telebe created");
                }

                break;
            default:
                break;
        }
    }
    else if (intMenu == 0)
    {
        Helper.ChangeTextColor(ConsoleColor.Cyan, "Bye..");
        break;
    }
    else
    {
        Helper.ChangeTextColor(ConsoleColor.Red, "Duzgun ede daxil edin..");
        break;
    }
}