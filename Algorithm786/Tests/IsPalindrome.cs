

namespace Algorithm786.Tests
{
    public class IsPalindrome
    {

        public int PalindromeAB(string text)
        {
            if (text == null)
                throw new ArgumentNullException("text");
            text = text.ToLower();

            int i = 0;
            int j = text.Length - 1;
            while (i < j)
            {
                if (text[i] != text[j])
                    return 2;
                i++;
                j--;
            }
            return 1;
        }


        public bool Palindrome(string text)
        {
            if (text == null)
                throw new ArgumentNullException("text");
            text = text.ToLower();

            int length = 0;
            var textArrayChar = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    continue;
                textArrayChar[length] = text[i];
                length++;
            }


            var _textForCheck = new char[length];

            for (int i = 0; i < _textForCheck.Length; i++)
            {
                _textForCheck[i] = textArrayChar[i];
            }

            int f = _textForCheck.Length - 1;
            for (int i = 0; i < textArrayChar.Length; i++)
            {
                if (_textForCheck[i] == _textForCheck[f])
                {
                    f--;
                    if (f < i)
                        return true;
                    continue;
                }

                return false;
            }
            return false;
        }
    }
}
