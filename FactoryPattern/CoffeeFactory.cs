using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern
{
    internal class CoffeeFactory : StarbuzzFactory
    {
        protected override Beverage Create(string type)
        {
            Beverage beverage;

            switch (type)
            {
                case "espresso":
                    beverage = new Espresso();
                    break;

                case "doppio":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    break;

                case "lungo":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    break;

                case "machiato":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    break;

                case "corretta":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Liqour(beverage);
                    break;

                case "conpanna":
                    beverage = new Espresso();
                    beverage = new Whip(beverage);
                    break;

                case "cappuccino":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "americano":
                    beverage = new Espresso();
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;

                case "caffelatte":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "flatwhite":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;

                case "romana":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Lemon(beverage);
                    break;

                case "morocchino":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "mocha":
                    beverage = new Espresso();
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "bicerin":
                    beverage = new Espresso();
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "breve":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;

                case "rafcoffee":
                    beverage = new Espresso();
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "meadraf":
                    beverage = new Espresso();
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "galao":
                    beverage = new Espresso();
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "caffeaffogato":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case "viennacoffee":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "glace":
                    beverage = new Espresso();
                    beverage = new IceCream(beverage);
                    break;

                case "chocolatemilk":
                    beverage = new Chocolate();
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;

                case "demicreme":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;

                case "lattemacchiato":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;

                case "freddo":
                    beverage = new Espresso();
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    break;

                case "frappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;

                case "caramelfrappuccino":
                    beverage = new Espresso();
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;

                case "frappe":
                    beverage = new Espresso();
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;

                case "irishcoffee":
                    beverage = new Espresso();
                    beverage = new Espresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;

                default:
                    // return null so the base class can throw a clear exception
                    return null;
            }

            return beverage;
        }
    }
}
