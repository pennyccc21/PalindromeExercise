using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void MyTest(string word, bool expected)
        {
            var tester = new WordSmith();
           
            
            bool actual = tester.IsPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
