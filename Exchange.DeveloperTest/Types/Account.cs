namespace Exchange.DeveloperTest.Types
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public AccountStatus Status { get; set; }
        public AllowedPaymentSchemes AllowedPaymentSchemes { get; set; }
        public bool Decrease(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
    public static class AccountExtensions
    {
        public static bool IsAllowedPaymentScheme(this Account account, PaymentScheme paymentScheme)
        {
            if (account == null)
                return false;

            if ((int)paymentScheme != (int)account.AllowedPaymentSchemes)
                return false;
            if ((int)paymentScheme != (int)AllowedPaymentSchemes.Chaps && account.Status != AccountStatus.Live)
                return false;

            return true;
        }
    }
}
