using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using P01_BillsPaymentSystem.Data.Models.Enums;

namespace UserDetails_ConsoleApp_.Services
{
    public static class UserService
    {
        public static async Task ShowAllUserPaymentMethods()
        {
            Console.Write("UserId: ");

            bool isGuidType = Guid.TryParse(Console.ReadLine(), out Guid userId);

            if (!isGuidType)
            {
                Console.WriteLine("The entered value cannot be Guid type!");

                return;
            }

            using (BillsPaymentSystemContext billsPaymentSystemDb = new())
            {
                User? user = await billsPaymentSystemDb.Users.AsNoTracking()
                    .SingleOrDefaultAsync(u => u.UserId.Equals(userId));

                if (user is null)
                {
                    Console.WriteLine($"User with id: {userId} not found!");

                    return;
                }

                List<PaymentMethod>? paymentMethods = await billsPaymentSystemDb.PaymentMethods.AsNoTracking()
                    .Where(pm => pm.UserId.Equals(userId))
                    .Include(pm => pm.BankAccount)
                    .Include(pm => pm.CreditCard)
                    .ToListAsync();

                Console.WriteLine($"\nUser: {user.FirstName} {user.LastName}");

                if (paymentMethods.Count > 0)
                {
                    if (paymentMethods.Where(pm => pm.BankAccount is not null).Count() > 0)
                    {
                        Console.WriteLine("Bank Accounts: ");

                        foreach (PaymentMethod paymentMethod in paymentMethods.Where(pm => pm.BankAccount is not null))
                        {
                            Console.WriteLine($"-- ID: {paymentMethod.BankAccountId}\n" +
                                $"--- Balance: {paymentMethod.BankAccount?.Balance}\n" +
                                $"--- Bank: {paymentMethod.BankAccount?.BankName}\n" +
                                $"--- Swift: {paymentMethod.BankAccount?.SwiftCode}");
                        }
                    }

                    if (paymentMethods.Where(pm => pm.CreditCard is not null).Count() > 0)
                    {
                        Console.WriteLine("Credit Cards: ");

                        foreach (PaymentMethod paymentMethod in paymentMethods.Where(pm => pm.CreditCard is not null))
                        {
                            Console.WriteLine($"-- ID: {paymentMethod.CreditCardId}\n" +
                                $"--- Limit: {paymentMethod.CreditCard?.Limit}\n" +
                                $"--- Money Owed: {paymentMethod.CreditCard?.MoneyOwed}\n" +
                                $"--- Limit Left:: {paymentMethod.CreditCard?.LimitLeft}\n" +
                                $"--- Expiration Date: {paymentMethod.CreditCard?.ExpirationDate.ToString("yyyy/MM")}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("This user doesn't have any payment methods!");
                }
            }
        }

        public static async Task PayBills(Guid userId, decimal amount)
        {
            using (BillsPaymentSystemContext billsPaymentSystemDb = new())
            {
                List<PaymentMethod> paymentMethods = await billsPaymentSystemDb.PaymentMethods
                    .Include(pm => pm.BankAccount)
                    .Include(pm => pm.CreditCard)
                    .Where(pm => pm.UserId.Equals(userId))
                    .OrderBy(pm => pm.BankAccountId)
                    .ThenBy(pm => pm.CreditCardId)
                    .ToListAsync();

                if (paymentMethods.IsNullOrEmpty())
                {
                    Console.WriteLine("Empty list of the payment methods.");
                    return;
                }

                foreach (PaymentMethod paymentMethod in paymentMethods)
                {
                    if (paymentMethod.Type == PaymentMethodTypes.BankAccount.ToString())
                    {
                        paymentMethod.BankAccount?.Withdraw(amount);

                        if (paymentMethod.BankAccount?.Balance >= 0)
                        {
                            billsPaymentSystemDb.Update(paymentMethod.BankAccount);
                            break;
                        }
                    }
                    else if (paymentMethod.Type == PaymentMethodTypes.CreditCard.ToString())
                    {
                        paymentMethod.CreditCard?.Withdraw(amount);

                        if (paymentMethod.CreditCard?.LimitLeft >= 0)
                        {
                            billsPaymentSystemDb.Update(paymentMethod.CreditCard);
                            break;
                        }
                    }
                }

                await billsPaymentSystemDb.SaveChangesAsync();
            }
        }

        public static async Task AddDeposit(Guid userId, decimal amount)
        {
            using (BillsPaymentSystemContext billsPaymentSystemDb = new())
            {
                List<PaymentMethod> paymentMethods = await billsPaymentSystemDb.PaymentMethods
                    .Include(pm => pm.BankAccount)
                    .Include(pm => pm.CreditCard)
                    .Where(pm => pm.UserId.Equals(userId))
                    .OrderBy(pm => pm.BankAccountId)
                    .ThenBy(pm => pm.CreditCardId)
                    .ToListAsync();

                if (paymentMethods.IsNullOrEmpty())
                {
                    Console.WriteLine("Empty list of the payment methods.");
                    return;
                }

                foreach(PaymentMethod paymentMethod in paymentMethods)
                {
                    if (paymentMethod.Type == PaymentMethodTypes.BankAccount.ToString())
                    {
                        paymentMethod.BankAccount?.Deposit(amount);

                        if (paymentMethod.BankAccount?.Balance >= 0)
                        {
                            billsPaymentSystemDb.Update(paymentMethod.BankAccount);
                            break;
                        }
                    }
                    else if (paymentMethod.Type == PaymentMethodTypes.CreditCard.ToString())
                    {
                        paymentMethod.CreditCard?.Deposit(amount);

                        if (paymentMethod.CreditCard?.MoneyOwed < 0)
                        {
                            billsPaymentSystemDb.Update(paymentMethod.CreditCard);
                            break;
                        }
                    }
                }

                await billsPaymentSystemDb.SaveChangesAsync();
            }
        }
    }
}