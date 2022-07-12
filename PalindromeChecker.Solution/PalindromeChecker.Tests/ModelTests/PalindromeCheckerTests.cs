using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace PalindromeChecker.Tests
{
  [TestClass]
  public class P_CheckerTests
  {
    [TestMethod]
    public void checkPalindrome_WordIsPalindrome_True()
    {
      P_Checker palindrome = new P_Checker();
      string test = "ABBA";
      Assert.AreEqual(true, palindrome.checkPalindrome(test));
    }
    [TestMethod]
    public void checkPalindrome_WordNotAPalindrome_False()
    {
      P_Checker palindrome = new P_Checker();
      string test = "ABzz";
      Assert.AreEqual(false, palindrome.checkPalindrome(test));
    }
    [TestMethod]
    public void checkPalindrome_WordCaseAgnostic_True()
    {
      P_Checker palindrome = new P_Checker();
      string test = "ABba";
      Assert.AreEqual(true, palindrome.checkPalindrome(test));
    }
    [TestMethod]
    public void checkPalindrome_OddNumberedWord_True()
    {
      P_Checker palindrome = new P_Checker();
      string test = "ababa";
      Assert.AreEqual(true, palindrome.checkPalindrome(test));
    }
  }
}