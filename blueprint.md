intake a string
create a array from string

testArray[r,a,c,e,c,a,r]

simpleArray[a,a]
simpleArray2[a,b]

array.split('');
for (i=0; i < array.length/2; i++)
{
  if array[i] != array[array.length-1-i]
  {
    return false;
  }
}
return true;

[TestMethod]
    public void IsValidTriangle_NoTwoLengthsAreLessThanTheThird_True()
    {
      P_Checker palindrome = new P_Checker();
      char testArray = [a,a];
      string test = "aa";
      Assert.AreEqual(true, testTriangle.IsValidTriangle(test));
    }