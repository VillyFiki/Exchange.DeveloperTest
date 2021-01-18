namespace Exchange.DeveloperTest.Types
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public AccountStatus Status { get; set; }
        public AllowedPaymentSchemes AllowedPaymentSchemes { get; set; }
        public bool CheckAbilityToPay(PaymentScheme paymentScheme) 
        {
            switch (paymentScheme)
            {
                case PaymentScheme.Bacs:
                    if (!AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Bacs))
                    {
                        return false;
                    }
                    break;

                case PaymentScheme.FasterPayments:
                    if (!AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.FasterPayments))
                    {
                        return false;
                    }
                    break;

                case PaymentScheme.Chaps:
                    if (!AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Chaps))
                    {
                        return false;
                    }
                    else if (Status != AccountStatus.Live)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
        public bool Decrease(decimal amount)
        {
            if (Balance > amount) 
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
