using BookShop.Data;
using BookShop.Models;
using BookShop.StartUp;
using BookShopSystem_ConsoleApp_.Enums;
using Microsoft.EntityFrameworkCore;

namespace MyApplication
{
    internal class Program
    {
        private static readonly Commands[] commands = (Commands[])Enum.GetValues(typeof(Commands));

        private static async Task Main(string[] args)
        {
            try
            {

                using BookShopContext bookShopDb = new();

                ShowMenu();

                while (true)
                {
                    Console.Write("\nCommand: ");

#nullable disable
                    Commands commandType = (Commands)int.Parse(Console.ReadLine());
#nullable enable

                    if (commandType.Equals(Commands.Exit))
                    {
                        break;
                    }

                    switch (commandType)
                    {
                        case Commands.GetBooksByAgeRestriction:
                            {
                                Console.Write("\nAge Restriction: ");

                                string? command = Console.ReadLine();

                                string? result = await StartUp.GetBooksByAgeRestriction(bookShopDb, command);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetGoldenBooks:
                            {
                                string? result = await StartUp.GetGoldenBooks(bookShopDb);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetBooksByPrice:
                            {
                                string? result = await StartUp.GetBooksByPrice(bookShopDb);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetBooksNotRealeasedIn:
                            {
                                Console.Write("\nYear: ");
#nullable disable
                                int year = int.Parse(Console.ReadLine());
#nullable enable
                                string? result = await StartUp.GetBooksNotRealeasedIn(bookShopDb, year);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetBooksByCategory:
                            {
                                Console.Write("\nCategories: ");

                                string? input = Console.ReadLine();

                                if (input is null)
                                {
                                    Console.WriteLine("Wrong input!");

                                    break;
                                }

                                string? result = await StartUp.GetBooksByCategory(bookShopDb, input);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetBooksReleasedBefore:
                            {
                                Console.Write("\nDate: ");

                                string? date = Console.ReadLine();

                                if (date is null)
                                {
                                    Console.WriteLine("Empty string...");

                                    break;
                                }

                                string? result = await StartUp.GetBooksReleasedBefore(bookShopDb, date);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetAuthorNamesEndingIn:
                            {
                                Console.Write("\nLetters: ");

                                string? input = Console.ReadLine();

                                if (input is null)
                                {
                                    Console.WriteLine("Wrong entered value!");

                                    break;
                                }

                                string? result = await StartUp.GetAuthorNamesEndingIn(bookShopDb, input);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetBookTitlesContaining:
                            {
                                Console.Write("\nLetters: ");

                                string? input = Console.ReadLine();

                                if (input is null)
                                {
                                    Console.WriteLine("Wrong entered value!");

                                    break;
                                }

                                string? result = await StartUp.GetBookTitlesContaining(bookShopDb, input);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetBooksByAuthor:
                            {
                                Console.Write("\nLetters: ");

                                string? input = Console.ReadLine();

                                if (input is null)
                                {
                                    Console.WriteLine("Wrong entered value!");

                                    break;
                                }

                                string? result = await StartUp.GetBooksByAuthor(bookShopDb, input);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.CountBooks:
                            {
                                Console.Write("\nLength: ");
#nullable disable
                                int lengthCheck = int.Parse(Console.ReadLine());
#nullable enable
                                int result = await StartUp.CountBooks(bookShopDb, lengthCheck);

                                Console.WriteLine(result);

                                break;
                            }

                        case Commands.CountCopiesByAuthor:
                            {
                                string? result = await StartUp.CountCopiesByAuthor(bookShopDb);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetTotalProfitByCategory:
                            {
                                string? result = await StartUp.GetTotalProfitByCategory(bookShopDb);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.GetMostRecentBooks:
                            {
                                string? result = await StartUp.GetMostRecentBooks(bookShopDb);

                                if (result is null)
                                {
                                    Console.WriteLine("No result :( Nullable type!");
                                }
                                else
                                {
                                    Console.Write(result);
                                }

                                break;
                            }

                        case Commands.IncreasePrices:
                            {
                                await StartUp.IncreasePrices(bookShopDb);

                                break;
                            }

                        case Commands.RemoveBooks:
                            {
                                int removedBooks = await StartUp.RemoveBooks(bookShopDb);

                                Console.WriteLine((removedBooks > 1) ? $"{removedBooks} books were deleted"
                                    : (removedBooks.Equals(1) ? $"{removedBooks} book was deleted"
                                    : "0 books were deleted"));

                                break;
                            }

                        case Commands.ClearConsole:
                            {
                                Console.Clear();

                                ShowMenu();

                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Wrong commmand type!");
                                break;
                            }
                    }

                }

                Console.WriteLine("\nPress another one to exit!");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
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