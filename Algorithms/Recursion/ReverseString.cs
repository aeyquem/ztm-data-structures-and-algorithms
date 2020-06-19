namespace data_structures_and_algorithms.Algorithms.Recursion
{
    public static partial class Recursion
    {
        public static string ReverseStringRecursive(string text)
        {
            if (text.Length < 2)
                return text;

            return text[text.Length - 1] + ReverseStringRecursive(text.Substring(0, text.Length - 1));
        }
    }
}