namespace StringLength
{
    public class LengthHelper
    {
        public static int findLength(string inputString)
        {
            if (inputString != null)
            {
                return inputString.Length;
            }
            return 0;
        }

        public static void Main()
        {
            Console.WriteLine(LengthHelper.findLength("hello"));
        }
    }
}