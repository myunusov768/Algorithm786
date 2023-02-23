

namespace Algorithm786.LessonTopicsAlgorithm
{
    public class LeanerSearch
    {
        

        public (bool status, int index) LeanerSearching<T>(T[] values, T value)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values));
            if (value is null)
                throw new ArgumentNullException(nameof(value));
            for (int i = 0; i < values.Length - 1 ; i++)
            {
                if (values[i].Equals(value))
                {
                    return (true, i);
                }

            }
            return (false, 0);
        }
    }
}
