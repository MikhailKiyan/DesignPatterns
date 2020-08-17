using System;

namespace DuckBehavior.Flyable {
    public class FlyNoWay : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("I can't fly");
        }
    }
}
