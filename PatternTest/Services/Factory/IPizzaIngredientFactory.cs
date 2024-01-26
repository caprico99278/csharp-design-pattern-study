using PatternTest.Services.Models;

namespace PatternTest.Services.Factory
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();

        public Sauce CreateSauce();

        public Cheese CreateCheese();

        public Veggies[] createVeggies();

        public Pepperoni createPepperoni();

        public Clams CreateClam();
    }
}
