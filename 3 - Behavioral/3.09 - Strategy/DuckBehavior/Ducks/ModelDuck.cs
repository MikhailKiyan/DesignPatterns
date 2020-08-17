using System;
using DuckBehavior.Flyable;
using DuckBehavior.Quackable;

namespace DuckBehavior.Ducks {
    public class ModelDuck : Duck {
        public ModelDuck() : base(
            // Утка-приманка изначально летать не умеет
            new FlyNoWay(),
            new Quack()) { }

        public override void Display() {
            Console.WriteLine("I'n a model duck");
        }
    }
}
