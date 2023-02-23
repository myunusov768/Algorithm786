
namespace Algorithm786.LessonTopicsAlgorithm
{
    public class BinarySearch
    {
        public (bool status, int index) BinarySearching(int[] values, int value ) 
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            
            var (low, hight, middle) = GetLowHightMiddle(values);

            if (value < values[low] || value > values[hight])
                return (false, 0);
            if (value == values[low])
                return (true, low+1);
            if (value == values[hight])
                return (true, hight+1);


            return BinarySearching(values, low, hight, value);
        }

        public (int low, int hight, int middle) GetLowHightMiddle(int[] values) 
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));
            
            int low, high, middle;
            low = 0;
            high = values.Length - 1;
            middle = low + (high - low)/2;
            return (low, high, middle);
        }

        private (bool status, int index) BinarySearching(int[] values, int low, int hight, int value)
        {
            int middle = low + (hight - low) / 2;

            if (values[middle] == value)
                return (true, middle + 1);
            if (value > values[middle])
                return BinarySearching(values ,middle + 1, hight, value);
            else
                return BinarySearching(values, low, middle -1, value);

        }






    }
}
