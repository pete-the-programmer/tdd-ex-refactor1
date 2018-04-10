using System.Linq;

namespace src
{
    public class Bus : Vehicle
    {
        private int _destinationCount = 0;

        public bool GoTo(Destination destination)
        {
            if (AcceptableDestinations.Contains(destination))
            {
                _destinationCount++;
                return true;
            }
            return false;
        }

        private Destination[] AcceptableDestinations
        {
            get
            {
                return new Destination[] {
                    Destination.CityCentre,
                    Destination.Northside,
                    Destination.EasternSuburbs,
                    Destination.TrainStation,
                    Destination.BusDepot,
                    Destination.MainWharf
                };
            }
        }

        public int DestinationCount{
            get{
                return _destinationCount;
            }
        }
    }
}