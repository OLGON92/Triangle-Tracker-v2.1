using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle; 

namespace Triangle.Test
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_ChecksIfItsTriangle_True()
    {
      TriangleTracker testTriangleSide = new TriangleTracker();
      Assert.AreEqual(true, testTriangleSide.IsTriangle(1, 2, 1));
    }
  }
}