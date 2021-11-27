from .Vehicle import Vehicle
from .Destination import Destination


class Bus(Vehicle):
    def __init__(self):
        self.__destinationCount = 0

    def __acceptable_destinations(self):
        return [
            Destination.CityCentre,
            Destination.Northside,
            Destination.EasternSuburbs,
            Destination.TrainStation,
            Destination.BusDepot,
            Destination.MainWharf,
        ]

    def go_to(self, destination: Destination) -> bool:
        if destination in self.__acceptable_destinations():
            self.__destinationCount = self.__destinationCount + 1
            return True
        return False

    def destination_count(self): return self.__destinationCount
