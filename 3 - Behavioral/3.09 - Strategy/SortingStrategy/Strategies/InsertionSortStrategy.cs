namespace SortingStrategy.Strategies {
    /// <summary>
    /// Стратегия - Сортировка вставками
    /// </summary>
    public class InsertionSortStrategy : BaseStrategy {
        public override void Sort(ref int[] array) {
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];
                for (j = i - 1; j >= 0; j--) {
                    if (array[j] < buffer) {
                        break;
                    }

                    array[j + 1] = array[j];
                }

                array[j + 1] = buffer;
            }
        }
    }
}
