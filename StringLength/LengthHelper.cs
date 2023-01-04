namespace StringLength
{
    public class LengthHelper
    {
        public static int findLength(string inputString)
        {
            return inputString.Length;
        }

        public static void Main()
        {
            Console.WriteLine(LengthHelper.findLength("hello"));
        }
    }
}