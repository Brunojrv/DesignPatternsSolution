using DesignPatternsSolution.CreationalPatterns.Builder.AggregateRoot;
using System.Collections.Generic;
using System;
using DesignPatternsSolution.CreationalPatterns.Builder.Enum;
using DesignPatternsSolution.CreationalPatterns.Builder.Interface;

namespace DesignPatternsSolution.CreationalPatterns.Builder
{
    public class Order : IOrder
    {
        public Guid Id { get; private set; } = Guid.NewGuid();  
        private string OrderNumber { get; set; }
        private DateTime OrderDate { get; set; }
        private RequestingCustomer RequestingCustomer { get; set; }
        private List<Product> ListProduct { get; set; }
        private string ShippingAddress { get; set; }
        private string BillingAddress { get; set; }
        private EnumPaymentOrder PaymentOrder { get; set; }
        private decimal TotalAmount { get; set; }
        private string Status { get; set; }

        public IOrder SetOrderNumber(string orderNumber)
        {
            OrderNumber = orderNumber;
            return this;
        }

        public IOrder SetOrderDate(DateTime orderDate)
        {
            OrderDate = orderDate;
            return this;
        }

        public IOrder SetRequestingCustomer(RequestingCustomer requestingCustomer)
        {
            RequestingCustomer = requestingCustomer;
            return this;
        }

        public IOrder AddProduct(Product product)
        {
            if (ListProduct == null)
                ListProduct = new List<Product>();
           
            ListProduct.Add(product);
            return this;
        }

        public IOrder SetShippingAddress(string shippingAddress)
        {
            ShippingAddress = shippingAddress;
            return this;
        }

        public IOrder SetBillingAddress(string billingAddress)
        {
            BillingAddress = billingAddress;
            return this;
        }

        public IOrder SetPaymentMethod(EnumPaymentOrder paymentMethod)
        {
            PaymentOrder = paymentMethod;
            return this;
        }

        public IOrder SetTotalAmount(decimal totalAmount)
        {
            TotalAmount = totalAmount;
            return this;
        }

        public IOrder SetOrderStatus(string status)
        {
            Status = status;
            return this;
        }

        public Order Build()
        {
            return this;
        }
    }
}
