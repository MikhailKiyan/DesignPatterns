namespace SortingStrategy.Strategies {
    /// <summary>
    /// Стратегия - Сортировка выбором
    /// </summary>
    public class SelectionSortStrategy : BaseStrategy {
        public override void Sort(ref int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                int k = 1;
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[k] > array[j]) {
                        k = j;
                    }
                }

                if (k != 1) {
                    int temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
