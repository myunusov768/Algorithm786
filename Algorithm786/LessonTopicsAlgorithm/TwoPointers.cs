
namespace Algorithm786.LessonTopicsAlgorithm
{
    public sealed class TwoPointers
    {
        public (bool status ,int a, int b) TwoPointer(int[] ints, int number)
        {
            if(ints == null)
                throw new ArgumentNullException(nameof(ints));
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > number)
                    return (false, 0, 0);
                for (int j = ints.Length - 1; j > i; j--)
                {
                    if (ints[j] > number)
                        continue;
                    if (ints[i] + ints[j] == number)
                        return (true, ints[i], ints[j]);
                }
            }
            return (false, 0, 0);
        }

    }
}
