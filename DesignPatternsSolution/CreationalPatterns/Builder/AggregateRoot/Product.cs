using DesignPatternsSolution.CreationalPatterns.Builder.Enum;
using System;

namespace DesignPatternsSolution.CreationalPatterns.Builder
{
    public class Product
    {

        public Guid Id { get; private set; } = Guid.NewGuid();

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public EnumProductType ProductType { get; set; }
    }
}
