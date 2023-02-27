namespace Algorithm786.LessonTopicsAlgorithm
{
    public class BinarySearchNotRecurs
    {
        private (bool status, int index) BinarySearching(int[] values, int low, int hight, int value)
        {
            
            while (low < hight)
            {
                int middle = low + (hight - low) / 2;
                if (values[middle] == value)
                    return (true, middle);
                if (value < values[middle])
                {
                    hight = middle - 1;
                }
                else
                {
                    low= middle + 1;
                }
            }
            return (false, 0);
        }
    }
}
