using PatternTest.Services.Factory;
using PatternTest.Services.Models;
using System.Diagnostics;

namespace PatternTest.Services
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type == "チーズ")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "ニューヨークスタイルチーズピザ";
            }
            else
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "ニューヨークスタイルアサリピザ";
            }

            return pizza;
        }
    }
}
