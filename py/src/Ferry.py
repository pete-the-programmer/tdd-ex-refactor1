from .Vehicle import Vehicle
from .Destination import Destination


class Ferry(Vehicle):
    def __init__(self):
        self.__portCount = 0

    def go_to(self, destination: Destination) -> bool:
        if destination in [Destination.MainWharf, Destination.PortLevy, Destination.QuailIsland]:
            self.__portCount = self.__portCount + 1
            return True
        return False

    def ports_visited_count(self): return self.__portCount
