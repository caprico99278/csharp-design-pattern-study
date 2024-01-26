using PatternTest.Services.Factory;
using PatternTest.Services.Models;
using System.Diagnostics;

namespace PatternTest.Services
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Debug.WriteLine(Name + "を下準備");
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
        }
    }
}
