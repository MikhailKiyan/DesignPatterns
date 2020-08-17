using System;

using DuckBehavior.Flyable;
using DuckBehavior.Quackable;

namespace DuckBehavior.Ducks {
    public abstract class Duck {
        // Объявляем двы ссылочных поля с типами интерфейсов поведения
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) {
            this.flyBehavior = flyBehavior ?? throw new ArgumentNullException(nameof(flyBehavior));
            this.quackBehavior = quackBehavior ?? throw new ArgumentNullException(nameof(quackBehavior));
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior) {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior) {
            this.quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly() {
            // Делегирование операции классам поведения
            this.flyBehavior.Fly();
        }

        public void PerformQuack() {
            // Делегирование операции классам поведения
            this.quackBehavior.Quack();
        }

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
