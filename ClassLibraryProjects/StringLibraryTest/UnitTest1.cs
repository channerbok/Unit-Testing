using FluentAssertions;
using UtilityLibraries;

namespace StringLibraryTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
             string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };

            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                result.Should().BeTrue($"'{word}'");
            }
        }

        [Fact]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                    "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                result.Should().BeFalse();
                
            }
        }

        //[Fact]
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]

        public void DirectCallWithNullOrEmpty(string word)
        {
            // Tests that we expect to return false.   
            bool result = StringLibrary.StartsWithUpper(word);
            result.Should().BeFalse();
              
        }
    }
}
