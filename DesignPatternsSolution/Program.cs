using DesignPatternsSolution.CreationalPatterns.Builder.AggregateRoot;
using DesignPatternsSolution.CreationalPatterns.Builder.Enum;
using DesignPatternsSolution.CreationalPatterns.Builder;
using System;
using DesignPatternsSolution.StructuralPatterns.Decorator;
using DesignPatternsSolution.StructuralPatterns.Decorator.Notifications;


namespace DesignPatternsSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basicNotify = new BasicNofitication();
            var fullNotify = new FullNotification();

            var basicEmail = new EmailDecorator(basicNotify);
            var fullEmail = new EmailDecorator(fullNotify);

            // Decorando com envio por SMS

            // Enviando a notificação
            basicEmail.SendNotification("Compra realizada com sucesso");
            fullEmail.SendNotification("Pedido negado");
            return;
            // ex Singleton: SingletonMethodTwo.TestingSingletonInParallel();
            // ex: Build:
            var requestingCustomer = new RequestingCustomer
            {
                FirstName = "Bruno",
                LastName = "Reis",
                Email = "brunoreis@gmail.com",
            };

            var product = new Product
            {
                ProductDescription = "Desfrute de uma experiência visual imersiva com a Televisão Smart LED 4K UHD de 55 polegadas.",
                ProductName = "Televisão",
                ProductType = EnumProductType.Digital
            };

            var order = new Order()
            .SetOrderNumber("1")
            .SetOrderDate(DateTime.Now)
            .SetRequestingCustomer(requestingCustomer)
            .AddProduct(product)
            .SetShippingAddress("Rua garanhuns, 490")
            .SetBillingAddress("Rua das ninfas, 2039")
            .SetPaymentMethod(EnumPaymentOrder.Approved)
            .SetTotalAmount(299.99M)
            .SetOrderStatus("Pending")
            .Build();

            Console.WriteLine(order.Id);
        }
    }
}
