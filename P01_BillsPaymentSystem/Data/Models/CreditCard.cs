namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public Guid CreditCardId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }

        public decimal Limit { get; private set; }
        public decimal MoneyOwed { get; private set; }
        public decimal LimitLeft { get; set; }
        public DateTime ExpirationDate { get; set; }

        public void Withdraw(decimal amount)
        {
            if (LimitLeft >= amount)
            {
                MoneyOwed += amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= MoneyOwed)
            {
                MoneyOwed -= amount;
            }
            else
            {
                MoneyOwed = 0;
            }
        }
    }
}