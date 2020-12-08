using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleSidesTests
  {
    [TestMethod]
    public void TriangleChecker_OneSideIsNotLargerThanTwoSidesCombined_True()
    {
      TriangleSides testTriangleSides = new TriangleSides();
      Assert.AreEqual(true, testTriangleSides.TriangleChecker(2,2,8));
    }
    public void TriangleChecker_NoSidesAreEqual_True()
    {
      TriangleSides testTriangleSides = new TriangleSides();
      Assert.AreEqual(true, testTriangleSides.TriangleChecker(2,12,5));
    }
    [TestMethod]
    public void TriangleChecker_EqualSides_True()
    {
      TriangleSides testTriangleSides = new TriangleSides();
      Assert.AreEqual(true, testTriangleSides.TriangleChecker(3,3,3));
    } 
    [TestMethod]
    public void TriangleChecker_TwoSidesAreEqual_True()
    {
      TriangleSides testTriangleSides = new TriangleSides();
      Assert.AreEqual(true, testTriangleSides.TriangleChecker(2,2,5));
    }
  }
}