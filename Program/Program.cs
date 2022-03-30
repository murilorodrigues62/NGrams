using System.Text.RegularExpressions;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                throw new ArgumentException("An argument is required");

            var grams = GetGrams(args[0]);

            foreach (var gram in grams)
                Console.WriteLine(gram);
        }
        public static List<string> GetGrams(string text)
        {            
            List<string> grams = new();

            if (string.IsNullOrEmpty(text.Trim()))
                return grams;

            text = CleanInput(text);
            string[] words = text.Split(' ');
            int numberOfWords = words.Length;

            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string gram = String.Empty;
                for (int numberOfWordsIndex = 0; numberOfWordsIndex < numberOfWords - wordIndex; numberOfWordsIndex++)
                {
                    gram += gram != String.Empty ? " " : String.Empty;
                    gram += words[wordIndex + numberOfWordsIndex];
                    grams.Add(gram);
                }
            }
            return grams;
        }
        static string CleanInput(string text)
        {
            try
            {
                return Regex.Replace(text, @"[,.;:!?]", String.Empty,
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return string.Empty;
            }
        }
    }
}
