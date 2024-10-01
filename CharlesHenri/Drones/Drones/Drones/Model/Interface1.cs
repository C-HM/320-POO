using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    internal interface Interface1
    {
        public enum EvacuationState
        {
            Free,           // No limits applied
            Evacuating,     // Limits known, moving out of the zone
            Evacuated       // Limits known, out of the zone
        }

        public interface IExpellable
        {
            // Signal the limits of the no-fly zone 
            // Return true if the drone is already outside the zone
            bool Evacuate(System.Drawing.Rectangle zone);

            // Terminate the no-fly zone
            void FreeFlight();

            // Interrogate the drone
            EvacuationState GetEvacuationState();
        }

    }
}
