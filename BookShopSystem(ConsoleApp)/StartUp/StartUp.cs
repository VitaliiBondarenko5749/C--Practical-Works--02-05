using BookShop.Data;
using BookShop.Models;
using BookShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BookShop.StartUp
{
    public static class StartUp
    {
        // Task 1.
        public static async Task<string?> GetBooksByAgeRestriction(BookShopContext bookShopDb, string? command)
        {
            if (command is null)
            {
                Console.WriteLine("Wrong command type!");
                return null;
            }

            command = command.ToLower();

            List<string?>? bookTitles = await bookShopDb.Books.AsNoTracking()
                .Where(b => b.AgeRestriction != null && b.AgeRestriction.ToLower().Equals(command))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToListAsync();

            if (bookTitles.Count < 0 || bookTitles is null)
            {
                Console.WriteLine("Empty Title List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            bookTitles.ForEach(bt =>
            {
                stringBuilder.AppendLine(bt);
            });

            return stringBuilder.ToString();
        }

        // Task 2.
        public static async Task<string?> GetGoldenBooks(BookShopContext bookShopDb)
        {
            List<string?>? bookTitles = await bookShopDb.Books.AsNoTracking()
                .Where(b => b.EditionType != null && b.EditionType.Equals(EditionTypes.Gold.ToString()) && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToListAsync();

            if (bookTitles.Count == 0 || bookTitles is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            bookTitles.ForEach(bt =>
            {
                stringBuilder.AppendLine(bt);
            });

            return stringBuilder.ToString();
        }

        // Task 3.
        public static async Task<string?> GetBooksByPrice(BookShopContext bookShopDb)
        {
            var booksTitleAndPrice = await bookShopDb.Books.AsNoTracking()
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => new { b.Title, b.Price })
                .ToListAsync();

            if (booksTitleAndPrice.Count == 0 || booksTitleAndPrice is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            booksTitleAndPrice.ForEach(btp =>
            {
                stringBuilder.AppendLine(btp.Title + " - $" + btp.Price);
            });

            return stringBuilder.ToString();
        }

        // Task 4.
        public static async Task<string?> GetBooksNotRealeasedIn(BookShopContext bookShopDb, int year)
        {
            List<string?>? bookTitles = await bookShopDb.Books.AsNoTracking()
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToListAsync();

            if (bookTitles.Count == 0 || bookTitles is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            bookTitles.ForEach(bt =>
            {
                stringBuilder.AppendLine(bt);
            });

            return stringBuilder.ToString();
        }

        // Task 5.
        public static async Task<string?> GetBooksByCategory(BookShopContext bookShopDb, string input)
        {
            string[] categories = input.ToLower().Split(' ');

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            List<string?>? bookTitles = await bookShopDb.BookCategory.AsNoTracking()
                .Include(bc => bc.Category)
                .Where(bc => bc.Category != null && bc.Category.Name != null && categories.Contains(bc.Category.Name.ToLower()))
                .Include(bc => bc.Book)
                .OrderBy(bc => bc.Book.Title)
                .Select(bc => bc.Book.Title)
                .ToListAsync();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (bookTitles.Count == 0 || bookTitles is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            bookTitles.ForEach(bt =>
            {
                stringBuilder.AppendLine(bt);
            });

            return stringBuilder.ToString();
        }

        // Task 6.
        public static async Task<string?> GetBooksReleasedBefore(BookShopContext bookShopDb, string date)
        {
            if (!DateTime.TryParse(date, out DateTime parsedDate))
            {
                Console.WriteLine("Parsing date error!");

                return null;
            }

            var books = await bookShopDb.Books.AsNoTracking()
                .Where(b => b.ReleaseDate < parsedDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new { b.Title, b.EditionType, b.Price })
                .ToListAsync();

            if (books.Count == 0 || books is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            books.ForEach(b =>
            {
                stringBuilder.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price}");
            });

            return stringBuilder.ToString();
        }

        // Task 7.
        public static async Task<string?> GetAuthorNamesEndingIn(BookShopContext bookShopDb, string input)
        {
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
            List<string?>? fullNames = await bookShopDb.Authors.AsNoTracking()
                .Where(a => a.FirstName != null && a.FirstName.Substring(a.FirstName.Length - input.Length).Equals(input))
                .OrderBy(a => a.FirstName + " " + a.LastName)
                .Select(a => a.FirstName + " " + a.LastName)
                .ToListAsync();
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

            if (fullNames.Count == 0 || fullNames is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            fullNames.ForEach(fn =>
            {
                stringBuilder.AppendLine(fn);
            });

            return stringBuilder.ToString();
        }

        // Task 8.
        public static async Task<string?> GetBookTitlesContaining(BookShopContext bookShopDb, string input)
        {
            List<string?>? bookTitles = await bookShopDb.Books.AsNoTracking()
                .Where(b => b.Title != null && b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .ToListAsync();

            if (bookTitles.Count == 0 || bookTitles is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            bookTitles.ForEach(b =>
            {
                stringBuilder.AppendLine(b);
            });

            return stringBuilder.ToString();
        }

        // Task 9.
        public static async Task<string?> GetBooksByAuthor(BookShopContext bookShopDb, string input)
        {
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.

            List<string?>? bookTitlesWithAuthors = await bookShopDb.Books.AsNoTracking()
                .Include(b => b.Author)
                .Where(b => b.Author != null && b.Author.FirstName != null && b.Author.LastName != null
                && b.Author.LastName.ToLower().Substring(0, input.Length).Equals(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => b.Title + " (" + b.Author.FirstName + " " + b.Author.LastName + ")")
                .ToListAsync();

#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

            if (bookTitlesWithAuthors.Count == 0 || bookTitlesWithAuthors is null)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            bookTitlesWithAuthors.ForEach(b =>
            {
                stringBuilder.AppendLine(b);
            });

            return stringBuilder.ToString();
        }

        // Task 10.
        public static async Task<int> CountBooks(BookShopContext bookShopDb, int lengthCheck)
        {
            return await bookShopDb.Books.AsNoTracking()
                .CountAsync(b => b.Title != null && b.Title.Length > lengthCheck);
        }

        // Task 11.
        public static async Task<string?> CountCopiesByAuthor(BookShopContext bookShopDb)
        {
#pragma warning disable CS8604 // Possible null reference argument.
            var copiesByAuthor = await bookShopDb.Authors.AsNoTracking()
            .Select(a => new
            {
                AuthorName = a.FirstName + " " + a.LastName,
                TotalCopies = a.Books.Sum(b => b.Copies)
            })
            .OrderByDescending(a => a.TotalCopies)
            .ToListAsync();
#pragma warning restore CS8604 // Possible null reference argument.

            if (copiesByAuthor is null || copiesByAuthor.Count == 0)
            {
                Console.Write("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            copiesByAuthor.ForEach(c =>
            {
                stringBuilder.AppendLine(c.AuthorName + " - " + c.TotalCopies);
            });

            return stringBuilder.ToString();
        }

        // Task 12.
        public static async Task<string?> GetTotalProfitByCategory(BookShopContext bookShopDb)
        {
#pragma warning disable 
            var profitsByCategory = await bookShopDb.BookCategory.AsNoTracking()
                .Select(bc => new
                {
                    Name = bc.Category.Name,
                    TotalProfit = bc.Book.Copies * bc.Book.Price
                })
                .OrderByDescending(bc => bc.TotalProfit)
                .ThenBy(bc => bc.Name)
                .ToListAsync();
#pragma warning enable

            if (profitsByCategory is null || profitsByCategory.Count == 0)
            {
                Console.WriteLine("Empty List :(");

                return null;
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            profitsByCategory.ForEach(bc =>
            {
                stringBuilder.AppendLine($"{bc.Name} ${bc.TotalProfit}");
            });

            return stringBuilder.ToString();
        }

        // Task 13.
        public static async Task<string?> GetMostRecentBooks(BookShopContext bookShopDb)
        {
            var mostRecentBooks = await bookShopDb.Categories.AsNoTracking()
                .OrderBy(c => c.BookCategories.Count)
                .Select(c => new
                {
                    Category = c,
                    Books = bookShopDb.Books.AsNoTracking()
                .Where(b => b.BookCategories.Any(bc => bc.CategoryId.Equals(c.CategoryId)))
                .OrderByDescending(b => b.ReleaseDate)
                .Take(3)
                .Select(b => new
                {
                    Title = b.Title,
                    ReleaseYear = b.ReleaseDate.Value.Year
                })
                .ToList()
                }).ToListAsync();

            if (mostRecentBooks.Count == 0 || mostRecentBooks is null)
            {
                Console.WriteLine("Empty List :(");
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append("\n");

            foreach (var recentBook in mostRecentBooks)
            {
                if (recentBook.Books.Count == 0 || recentBook.Books is null)
                {
                    continue;
                }

                stringBuilder.AppendLine($"--{recentBook.Category.Name}");

                recentBook.Books.ForEach(b =>
                {
                    stringBuilder.AppendLine($"{b.Title} ({b.ReleaseYear})");
                });
            }

            return stringBuilder.ToString();
        }

        // Task 14.
        public static async Task IncreasePrices(BookShopContext bookShopDb)
        {
            DateTime targetDate = new(2010, 1, 1);

            List<Book> booksToUpdate = await bookShopDb.Books
                .Where(b => b.ReleaseDate < targetDate)
                .ToListAsync();

            if (booksToUpdate is null || booksToUpdate.Count == 0)
            {
                return;
            }

            booksToUpdate.ForEach(b =>
            {
                b.Price += 5;
            });

            await bookShopDb.SaveChangesAsync();
        }

        public static async Task<int> RemoveBooks(BookShopContext bookShopDb)
        {
            List<Book> booksToDelete = await bookShopDb.Books.Where(b => b.Copies < 4200)
                .ToListAsync();

            bookShopDb.Books.RemoveRange(booksToDelete);

            return await bookShopDb.SaveChangesAsync();
        }
    }
}