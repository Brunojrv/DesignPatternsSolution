using DesignPatternsSolution.StructuralPatterns.Adapter.Interface;

namespace DesignPatternsSolution.StructuralPatterns.Adapter
{
    public class NewPaymentAdapter : IPaymentAdapter
    {
        public LegacyPaymentAdapter _legacy { get; set; }

        public NewPaymentAdapter(LegacyPaymentAdapter legacy)
        {
            _legacy = legacy;
        }
        public void ProcessPayment(string accountNumber, decimal amount)
        {
            //use the legacy data here inside the adapter.
        }
    }
}
