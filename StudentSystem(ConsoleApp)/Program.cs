using Azure;
using P01_StudentSystem.Data.Models;
using StudentSystem_ConsoleApp_.Enums;
using StudentSystem_ConsoleApp_.Services;

namespace MyApplication
{
    internal class Program
    {
        private static readonly CommandTypes[] commandTypes = (CommandTypes[])Enum.GetValues(typeof(CommandTypes));

        private static async Task Main(string[] args)
        {
            ShowMenu();

            while (true)
            {
                Console.Write("\nCommand: ");

                bool isNumber = int.TryParse(Console.ReadLine(), out int command);

                if (!isNumber)
                {
                    Console.WriteLine("Wrong command type!");

                    continue;
                }

                CommandTypes commandType = (CommandTypes)command;

                if (commandType.Equals(CommandTypes.Exit))
                {
                    break;
                }

                switch (commandType)
                {
                    case CommandTypes.ShowAllCourses:
                        {
                            await CourseService.ShowAllCoursesAsync();
                            break;
                        }
                    case CommandTypes.ShoAllStudents:
                        {
                            await StudentService.ShowAllStudentsAsync();
                            break;
                        }
                    case CommandTypes.ClearConsole:
                        {
                            Console.Clear();

                            ShowMenu();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong command type!");
                            break;
                        }
                }
            }
        }

        private static void ShowMenu()
        {
            foreach (CommandTypes command in commandTypes)
            {
                Console.WriteLine((int)command + " - " + command);
            }
        }
    }
}