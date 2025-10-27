using DecoratorPattern.Beverages;
    using System;

namespace DecoratorPattern
{
    internal abstract class StarbuzzFactory
    {
        public Beverage CreateCoffee(string type, Size size = Size.TALL)
        {
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("type must be provided", nameof(type));

            Beverage beverage = Create(type.ToLowerInvariant());

            if (beverage == null)
                throw new ArgumentException("Unknown coffee type: " + type);

            beverage.Size = size;
            return beverage;
        }

        protected abstract Beverage Create(string type);
    }
}
