namespace DesignPatternsSolution.StructuralPatterns.Facade
{
    public class FacadePattern
    {
        
        public ProcessPaymentFacade _processPayment { get; set; }

        public StockFacade _stock { get; set; }

        public ProductFacade _product { get; set; }
        public FacadePattern(ProcessPaymentFacade process, StockFacade stock, ProductFacade product) 
        {
            _processPayment = process;
            _stock = stock;
            _product = product;
        }

        public void ProcessPayment()
        {
            if (_stock.CheckAvailabilityProduct(_product))
            {
                _processPayment.ProcessPayment();
            }
        }
    }
}
