namespace TestProject4.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }


        public SavingsAccount(int number, string holder, double balance, double interestRate)
         : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //Sealed cannot subscribed again
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}