
namespace Algorithm786.Tests
{
    public class CheckNForDoubleExist
    {
        public bool CheckForDouble(int[] ints)
        {
            if (ints is null)
                return false;
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j] * 2)
                        return true;
                }
            }
            return false;
        }
    }
}
