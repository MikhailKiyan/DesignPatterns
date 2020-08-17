using System;

namespace DuckBehavior.Flyable {
    public class FlyRocketPowered : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
