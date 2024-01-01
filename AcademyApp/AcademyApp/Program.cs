// See https://aka.ms/new-console-template for more information

using AcademyApp.Helper;

Helper.ChangeTextColor(ConsoleColor.Green, "Academy App");
Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter number:" +
    "1.CreateStudent 2.GetAllStudent 0.ExitMenu");
EnterMenu:  string menu = Console.ReadLine();
bool result = int.TryParse(menu, out int intMenu);
while (true)
{
    if (result && intMenu > 0 && intMenu<3)
    {

    }
    else if (intMenu==0)
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
