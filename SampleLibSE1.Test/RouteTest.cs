using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLibSE1.Test
{
    [TestClass]
    public class RouteTest
    {
        private const double EPS = 1e-8;

        [Ignore]
        [TestMethod]
        public void AddPointsToRouteTest()
        {
            Location location1 = new Location();
            Location location2 = new Location();
            Route route = new Route();
            const double ExpectedInitialRouteLength = 0.0;
            const double ExpectedRouteLengthAfterOnePoint = 0.0;
            const double ExpectedRouteLengthAfterTwoPoints = 1.0;

            Assert.AreEqual(ExpectedInitialRouteLength, route.Length, EPS);
            route.AddLocation(location1);
            Assert.AreEqual(ExpectedRouteLengthAfterOnePoint, route.Length, EPS);
            route.AddLocation(location2);
            Assert.AreEqual(ExpectedRouteLengthAfterTwoPoints, route.Length, EPS);

        }
    }
}
