using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSolution.StructuralPatterns.Adapter.Interface
{
    public interface IPaymentAdapter
    {
        void ProcessPayment(string accountNumber, decimal amount);
    }
}
