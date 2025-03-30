using System;

namespace CarPricing
{
    public class CarCostCalculator
    {
        // Returns base price depending on trim
        public static int BasePrice(int trimLevel)
        {
            if (trimLevel == 1) return 32000;     // Base
            else if (trimLevel == 2) return 36000; // EX
            else if (trimLevel == 3) return 40000; // Touring
            else return 0; // invalid input
        }

        // Returns price for chosen package
        public static int PackagePrice(int packageLevel)
        {
            if (packageLevel == 1) return 0;        // Basic Package
            else if (packageLevel == 2) return 2500; // Mid Package
            else if (packageLevel == 3) return 5000; // Premium Package
            else return 0; // fallback
        }

        // Calculates tax (13% in Ontario)
        public static int AddTax(int price)
        {
            double taxRate = 0.13;
            double taxedPrice = price + (price * taxRate);
            return (int)Math.Round(taxedPrice); // convert to int
        }
    }
}
