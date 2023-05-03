using UserDetails_ConsoleApp_.Enums;
using UserDetails_ConsoleApp_.Services;

namespace MyApplication
{
    internal class Program
    {
        private static readonly Commands[] commands = (Commands[])Enum.GetValues(typeof(Commands));

        private static async Task Main(string[] args)
        {
            ShowMenu();

            while (true)
            {
                Console.Write("\nCommand: ");

#nullable disable
                int command = int.Parse(Console.ReadLine());
#nullable enable

                Commands commandType = (Commands)command;

                if (commandType.Equals(Commands.Exit))
                {
                    break;
                }

                switch (commandType)
                {
                    case Commands.ShowAllUserPaymentMethods:
                        {
                            await UserService.ShowAllUserPaymentMethods();

                            break;
                        }
                    case Commands.PayBills:
                        {
                            Console.Write("UserId: ");

                            bool isGuidType = Guid.TryParse(Console.ReadLine(), out Guid userId);

                            if (!isGuidType)
                            {
                                Console.WriteLine("The entered value cannot be Guid type!");

                                break;
                            }


                            Console.Write("Amount: ");

#nullable disable
                            decimal amount = decimal.Parse(Console.ReadLine());
#nullable enable

                            await UserService.PayBills(userId, amount);
                            break;
                        }
                    case Commands.ClearTheConsole:
                        {
                            Console.Clear();

                            ShowMenu();

                            break;
                        }
                }

            }

            Console.ReadKey();
        }

        private static void ShowMenu()
        {
            foreach (Commands command in commands)
            {
                Console.WriteLine((int)command + " - " + command);
            }
        }
    }
}