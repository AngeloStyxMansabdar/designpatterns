using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso(Beverage beverage = null)
        {
            description = "Espresso";
            this.baseBeverage = beverage;
        
        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            double baseCost;
            switch (Size)
            {
                case Size.TALL:
                    baseCost = 1.99;
                    break;
                case Size.GRANDE:
                    baseCost = 2.49;
                    break;
                case Size.VENDI:
                    baseCost = 2.99;
                    break;
                default:
                    baseCost = 1.99;
                    break;
            }

            if (baseBeverage != null)
            {
                return baseCost + baseBeverage.cost();
            }
            return baseCost;
        }
    }
}
