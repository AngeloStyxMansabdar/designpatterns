using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System.IO;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            Beverage doppio = new Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new Espresso();
            lungo.Size = Size.VENDI;
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage machiato = new Espresso();
            machiato = new MilkFoam(machiato); 
            PrintBeverage(machiato);

            Beverage corretta = new Espresso();
            corretta = new Espresso(corretta);
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            Beverage cappucinno = new Espresso();
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage(cappucinno);

            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            Beverage romana = new Espresso();
            romana = new Espresso(romana);
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new Espresso();
            morocchino = new Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            Beverage rafCoffee = new Espresso();
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            Beverage demiCreme = new Espresso();
            demiCreme = new Espresso(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishCoffee = new Espresso();
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}