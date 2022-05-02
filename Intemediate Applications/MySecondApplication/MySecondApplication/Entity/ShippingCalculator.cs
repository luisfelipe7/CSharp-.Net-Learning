using System;
namespace MySecondApplication.Entity
{
    public class ShippingCalculator : IShippingCalculator
    {
        public ShippingCalculator()
        {
        }

        public float CalculateShipping(PurchaseOrder order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}

