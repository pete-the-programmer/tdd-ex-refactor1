using System.Linq;
using System.Collections.Generic;

namespace src{
    public class Ferry: Vehicle {
        private int _portCount = 0;

        public bool GoTo(Destination destination){
            if((new[] {
                Destination.MainWharf,
                Destination.PortLevy,
                Destination.QuailIsland})
                .Contains(destination)){

                _portsVisited++;
                return true;
            }
            return false;
        }

        public int PortsVisitedCount{
            get{
                return _portCount;
            }
        }
    }
}