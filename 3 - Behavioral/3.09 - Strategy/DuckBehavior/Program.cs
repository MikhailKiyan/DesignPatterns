using DuckBehavior.Ducks;
using System;
using System.Net.Http.Headers;
using DuckBehavior.Flyable;

namespace DuckBehavior {
    class Program {
        static void Main() {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.WriteLine(new string('-', 80));

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            // Способность утки-приманки к полёту переключается динамически!
            // Если бы реализация находилась в иерархии класса Duck, такое было бы невозможно
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.WriteLine(new string('-', 80));

            Console.ReadKey();
        }
    }
}
