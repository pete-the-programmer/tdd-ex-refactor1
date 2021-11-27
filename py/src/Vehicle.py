from typing import List

from .Destination import Destination


class Vehicle:
    @property
    def destinations(self) -> List[Destination]:
        return []
