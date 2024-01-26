using PatternTest.Services.Models;
using System.Diagnostics;

namespace PatternTest.Services
{
    public abstract class Pizza
    {
        public Dough _dough = new Dough();

        public Sauce _sauce = new Sauce();

        public Veggies[] _veggies = {};

        public Cheese _cheese = new Cheese();

        public Pepperoni _pepperoni = new Pepperoni();

        public Clams _clam = new Clams();
        public string Name { get; set; } = string.Empty;

        public abstract void Prepare();

        public void Bake() 
        {
            Debug.WriteLine("180度で25分間焼く。");
        }

        public void Cut()
        {
            Debug.WriteLine("ピザを扇形にカットする。");
        }

        public void Box()
        {
            Debug.WriteLine("PizzaStoreの箱にピザを入れる。");
        }

        public string toString() 
        {
            return "ピザを出力";
        }
    }
}
