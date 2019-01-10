using System.Linq;
using System.Collections.Generic;

namespace src{
    public class Ferry: Vehicle {
        private List<Destination> _portsVisited = new List<Destination>();

        public bool GoTo(Destination destination){
            if((new[] {
                Destination.MainWharf,
                Destination.PortLevy,
                Destination.QuailIsland})
                .Contains(destination)){

                _portsVisited.Add(destination);
                return true;
            }
            return false;
        }

        public int PortsVisitedCount{
            get{
                return _portsVisited.Count();
            }
        }
    }
}