using System;
namespace MySecondApplication.Entity
{
    public class FakeShippingCalculator : IShippingCalculator
    {
        public FakeShippingCalculator()
        {
        }

        public float CalculateShipping(PurchaseOrder order)
        {
            return 1;
        }
    }
}

