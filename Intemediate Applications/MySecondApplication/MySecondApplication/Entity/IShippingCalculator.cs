using System;
namespace MySecondApplication.Entity
{
    public interface IShippingCalculator
    {
        float CalculateShipping(PurchaseOrder order);
    }
}

