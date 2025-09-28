using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Liqour : CondimentDecorator
    {
        public Liqour(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost() // prijzen kunnen altijd nog veranderd worden
        {
            double addOn;

            switch (Size)
            {
                case Size.TALL:
                    addOn = 0.10;
                    break;
                case Size.GRANDE:
                    addOn = 0.15;
                    break;
                case Size.VENDI:
                    addOn = 0.20;
                    break;
                default:
                    addOn = 0.10;
                    break;
            }

            return baseBeverage.cost() + addOn;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Liqour";
        }
    }
}
