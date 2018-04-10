using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BusGoesToAllTownDestinations()
        {
            var bus = new Bus();
            bus.GoTo(Destination.BusDepot);
            bus.GoTo(Destination.CityCentre);
            bus.GoTo(Destination.EasternSuburbs);
            bus.GoTo(Destination.MainWharf);
            bus.GoTo(Destination.Northside);
            bus.GoTo(Destination.PortLevy);
            bus.GoTo(Destination.QuailIsland);
            bus.GoTo(Destination.TrainStation);
            Assert.AreEqual(6, bus.DestinationCount);
        }

        [TestMethod]
        public void FerryGoesToAllPorts()
        {
            var ferry = new Ferry();
            ferry.GoTo(Destination.BusDepot);
            ferry.GoTo(Destination.CityCentre);
            ferry.GoTo(Destination.EasternSuburbs);
            ferry.GoTo(Destination.MainWharf);
            ferry.GoTo(Destination.Northside);
            ferry.GoTo(Destination.PortLevy);
            ferry.GoTo(Destination.QuailIsland);
            ferry.GoTo(Destination.TrainStation);
            Assert.AreEqual(3, ferry.PortsVisitedCount);
        }
    }
}
