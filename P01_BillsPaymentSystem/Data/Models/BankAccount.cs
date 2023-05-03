namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        public Guid BankAccountId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }

        public decimal Balance { get; private set; }
        public string? BankName { get; set; }
        public string? SwiftCode { get; set; }

        public void Withdraw(decimal amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}