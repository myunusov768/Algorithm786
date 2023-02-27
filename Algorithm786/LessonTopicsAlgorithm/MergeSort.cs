
namespace MergeSortN
{
    public class MergeSort
    {
        public void MergeSorting(int[] ints)
        {
            if(ints == null)
                throw new ArgumentNullException(nameof(ints));
            if (ints.Length == 1)
                return;

            var (low, hight, middle) = GetLowHightMiddle(ints);

            MergeSorting(ints, low, hight);

        }

        private void MergeSorting(int[] ints, int low, int hight)
        {
            if (ints == null)
                throw new ArgumentNullException(nameof(ints));

            if (low < hight)
            {
                var middle = low + (hight - low) / 2;
                //left
                MergeSorting(ints, low, middle);
                //right
                MergeSorting(ints, middle + 1, hight);

                Merge(ints, low, hight, middle);


            }
        }

        public void Merge(int[] ints, int low, int hight, int middle)
        {
            int leftLength = middle - low + 1;
            int rightLength = hight - middle;

            var leftInts = new int[leftLength];
            for (int i = 0; i < leftLength; i++)
            {
                leftInts[i] = ints[low + i];
            }

            var rightInts = new int[rightLength];
            for (int l = 0; l < rightLength; l++)
            {
                rightInts[l] = ints[middle + 1 + l];
            }

            int j =0;
            int f = 0;

            int k = low;





            while (j < leftLength && f < rightLength)
            {
                if (leftInts[j] <= rightInts[f])
                {
                    ints[k] = leftInts[j];
                    j++;
                }
                else
                {
                    ints[k] = rightInts[f];
                    f++;
                }
                k++;

            }

            while (j < leftLength)
            {
                ints[k] = leftInts[j];
                j++;
                k++;
            }
            while (f < rightLength)
            {
                ints[k] = rightInts[f];
                f++;
                k++;
            }
        }





        public (int low, int hight, int middle) GetLowHightMiddle(int[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            int low, high, middle;
            low = 0;
            high = values.Length - 1;
            middle = low + (high - low) / 2;
            return (low, high, middle);
        }

    }
}
