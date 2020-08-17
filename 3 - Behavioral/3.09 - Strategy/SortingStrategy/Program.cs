using System;
using SortingStrategy.Strategies;

namespace SortingStrategy {
    class Program {
        static void Main(string[] args) {
            var sortStrategy = new SelectionSortStrategy();
            var context = new Context(sortStrategy);
            context.Sort();
            context.PrintArray();

            Console.ReadKey();
        }
    }
}
