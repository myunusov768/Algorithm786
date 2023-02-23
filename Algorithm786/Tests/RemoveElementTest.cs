using System.Diagnostics.CodeAnalysis;


namespace Algorithm786.Tests
{
    public class RemoveElementTest<T> : IEqualityComparer<T>
    {
        public bool Equals(T? x, T? y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;
            if (x.Equals(y))
                return true;
            return false;
        }

        public int GetHashCode([DisallowNull] T obj)
        {
            return obj.GetHashCode();
        }

        public (T[], int count) Method(T[] array, T value)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (value == null)
                throw new ArgumentNullException("value");
            int count = 0;
            var newArray = new T[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i].Equals(value))
                {
                    count++;
                    continue;
                }

                newArray[j] = array[i];
                j++;
            }
            return (newArray, count);
        }
    }
}
