from unittest import TestCase
from src import Bus, Ferry, Destination


class TestDestinations(TestCase):
    def test_bus_goes_to_all_town_destinations(self):
        bus = Bus()
        bus.go_to(Destination.BusDepot)
        bus.go_to(Destination.CityCentre)
        bus.go_to(Destination.EasternSuburbs)
        bus.go_to(Destination.MainWharf)
        bus.go_to(Destination.Northside)
        bus.go_to(Destination.PortLevy)
        bus.go_to(Destination.QuailIsland)
        bus.go_to(Destination.TrainStation)
        self.assertEqual(6, bus.destination_count())

    def test_ferry_goes_to_all_ports(self):
        ferry = Ferry()
        ferry.go_to(Destination.BusDepot)
        ferry.go_to(Destination.CityCentre)
        ferry.go_to(Destination.EasternSuburbs)
        ferry.go_to(Destination.MainWharf)
        ferry.go_to(Destination.Northside)
        ferry.go_to(Destination.PortLevy)
        ferry.go_to(Destination.QuailIsland)
        ferry.go_to(Destination.TrainStation)
        self.assertEqual(3, ferry.ports_visited_count())
