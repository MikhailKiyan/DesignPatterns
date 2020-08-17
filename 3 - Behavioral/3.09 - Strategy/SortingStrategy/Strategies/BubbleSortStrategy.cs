namespace SortingStrategy.Strategies {
    /// <summary>
    /// Стратегия - Пузырьковая сортировка
    /// </summary>
    public class BubbleSortStrategy : BaseStrategy {
        public override void Sort(ref int[] array) {
            for (int i = 0; i < array.Length; i++) {
                for (int j = array.Length - 1; j > i; j--) {
                    if (array[j] < array[j - 1]) {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
