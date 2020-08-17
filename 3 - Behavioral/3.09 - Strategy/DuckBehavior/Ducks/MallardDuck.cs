
using System;
using System.Collections.Generic;
using System.Text;
using DuckBehavior.Flyable;
using DuckBehavior.Quackable;

namespace DuckBehavior.Ducks {
    public class MallardDuck : Duck {
        public MallardDuck() : base(new FlyWithWings(), new Quack()) { }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
