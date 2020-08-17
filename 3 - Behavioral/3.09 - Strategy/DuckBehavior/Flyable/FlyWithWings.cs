using System;

namespace DuckBehavior.Flyable {
    public class FlyWithWings : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying!!!");
        }
    }
}
