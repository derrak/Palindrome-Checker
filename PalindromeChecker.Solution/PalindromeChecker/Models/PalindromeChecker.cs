namespace PalindromeChecker
{
  public class P_Checker
  {
    public bool checkPalindrome(string word) {
      char[] array = word.ToLower().ToCharArray();
      for (int i=0; i<array.Length/2; i++) {
        if (array[i] != array[array.Length-1-i]) {
          return false;
        }
      }
      return true;
    }
  }
}