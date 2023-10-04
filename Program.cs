namespace Lab3Problema2;

internal class Program
{
    static void Main(string[] args)
    {
        IsPalindrome("ana");
        IsPalindrome("cojoc");
        IsPalindrome("califragilistic");
        IsPalindrome("001100");
        IsPalindrome("");
        IsPalindrome(" ");


        void IsPalindrome(string word)
        {
            if (word.Length % 2 != 0)
                word = word.Remove(word.Length / 2, 1);

            string firstHalf = word.Substring(0, word.Length / 2);
            string secondHalf = word.Substring(word.Length / 2, word.Length / 2);

            char[] charArray = secondHalf.ToCharArray();
            Array.Reverse(charArray);
            secondHalf = new (charArray);

            if (string.Equals(firstHalf, secondHalf))
            {
                Console.WriteLine("The word is a palindrome");
                return;
            }

            Console.WriteLine("The word is not a palindrome");
        }
    }
}