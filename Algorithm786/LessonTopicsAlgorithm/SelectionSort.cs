namespace MySelectionSort
{
    public sealed class SelectionSort
    {
        public void SelectSort(int[] ints)
        {
            if (ints == null)
                throw new ArgumentNullException(nameof(ints));

            if (ints.Length == 1)
                return;

            for (int i = 0; i < ints.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] < ints[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                    (ints[i], ints[minIndex]) = (ints[minIndex], ints[i]);
            }
        }
    }
}
