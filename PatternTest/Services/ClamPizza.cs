using PatternTest.Services.Factory;
using System.Diagnostics;

namespace PatternTest.Services
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Debug.WriteLine(Name + "を下準備");
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _clam = _ingredientFactory.CreateClam();
        }
    }
}
