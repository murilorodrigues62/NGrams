using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckCombinations()
        {
            var text = "Show me the code.";
            var words = text.Split(' ');
            var combinations = 0;
            
            for (int i = words.Length; i >= 1; i--) // calculate possible combinations
                combinations += i;

            var grams = Program.Program.GetGrams(text);
            Assert.Equal(combinations, grams.Count);
        }

        [Fact]
        public void CheckContent()
        {
            var grams = Program.Program.GetGrams("Show me the code.");            
            Assert.Contains<string>("Show", grams);
            Assert.Contains<string>("Show me", grams);
            Assert.Contains<string>("Show me the", grams);
            Assert.Contains<string>("Show me the code", grams);
            Assert.Contains<string>("me", grams);
            Assert.Contains<string>("me the", grams);
            Assert.Contains<string>("me the code", grams);
            Assert.Contains<string>("the", grams);
            Assert.Contains<string>("the code", grams);
            Assert.Contains<string>("code", grams);
        }

        [Fact]
        public void CheckStripPunctuation()
        {
            var grams = Program.Program.GetGrams("Show me the code.");
            Assert.DoesNotContain<string>(".", grams);
            Assert.DoesNotContain<string>("code.", grams);
        }

        [Fact]
        public void CheckInvalidText()
        {
            var grams = Program.Program.GetGrams(string.Empty);
            Assert.Empty(grams);

            grams = Program.Program.GetGrams(" ");
            Assert.Empty(grams);
        }
    }
}