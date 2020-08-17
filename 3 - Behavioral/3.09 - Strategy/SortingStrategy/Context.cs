using System;

using SortingStrategy.Strategies;

namespace SortingStrategy {
    public class Context {
        BaseStrategy strategy;
        int[] array = {3, 5, 1, 2, 55};

        public Context(BaseStrategy strategy) {
            this.strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public void ChangeStrategy(BaseStrategy strategy) { 
            this.strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public void Sort() {
            strategy.Sort(ref array);
        }

        public void PrintArray() {
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
