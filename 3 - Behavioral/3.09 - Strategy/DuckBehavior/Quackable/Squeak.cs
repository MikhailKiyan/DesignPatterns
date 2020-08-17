using System;

namespace DuckBehavior.Quackable {
    public class Squeak : IQuackBehavior {
        public void Quack() {
            Console.WriteLine("Squeak");
        }
    }
}
