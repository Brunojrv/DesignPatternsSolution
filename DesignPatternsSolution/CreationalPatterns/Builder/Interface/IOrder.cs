using System;
using DesignPatternsSolution.CreationalPatterns.Builder.AggregateRoot;
using DesignPatternsSolution.CreationalPatterns.Builder.Enum;

namespace DesignPatternsSolution.CreationalPatterns.Builder.Interface
{
    public interface IOrder
    {
        IOrder SetOrderNumber(string orderNumber);
        IOrder SetOrderDate(DateTime orderDate);
        IOrder SetRequestingCustomer(RequestingCustomer requestingCustomer);
        IOrder AddProduct(Product product);
        IOrder SetShippingAddress(string shippingAddress);
        IOrder SetBillingAddress(string billingAddress);
        IOrder SetPaymentMethod(EnumPaymentOrder paymentMethod);
        IOrder SetTotalAmount(decimal totalAmount);
        IOrder SetOrderStatus(string status);

        Order Build();
    }
}
