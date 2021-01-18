using Exchange.DeveloperTest.Types;

namespace Exchange.DeveloperTest.Services
{
    public interface IPaymentService
    {
        MakePaymentResult MakePayment(MakePaymentRequest request);
    }
}
