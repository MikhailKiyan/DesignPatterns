using System;

namespace DuckBehavior.Quackable {
    public class Quack : IQuackBehavior {
        void IQuackBehavior.Quack() {
            Console.WriteLine("Quack");
        }
    }
}
