using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleSidesTests
  {
    [TestMethod]
    public void TriangleChecker_EqualSides_True()
    {
      TriangleSides testTriangleSides = new TriangleSides();
      Assert.AreEqual(true, testTriangleSides.TriangleChecker(3,3,3));
    }    
  }
}