using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class Reverse
  {
    [TestMethod]
    public void GetArray_DisplayInputedName()
    {
      Reverse testReverse = new Reverse();
      Assert.AreEqual("hannah", testReverse.GetArray("hannah"));
    }
  }
}