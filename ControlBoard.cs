using System.Collections.Generic;

namespace ku_elev
{
    class ControlBoard
    {
        private Stack<Elevator> elevators;
        public ControlBoard()
        {
        }
        public ControlBoard(int num_flo, int num_elev)
        {

            elevators = new Stack<Elevator>();
            for (int i = 0; i < num_elev; i++)
            {
                Elevator elevator = new Elevator(num_flo, i);
                elevators.Push(elevator);
            }
        }
        public string soundOff()
        {
            string soundOffs = "";
            foreach (var elev in elevators)
            {
                soundOffs = soundOffs + "Elevator " + elev.getName() + " is going " + elev.getDirection() + " at floor " + elev.getCurr_floor() + ", doors open = " + elev.getOpen() + "\r\n";
            }
            return soundOffs;
        }

        public string elevatorCall(int call_floor, int dest_floor)
        {
            
            foreach (var elevator in elevators)
            {
                
                if (elevator.getDirection() == "nowhere" && elevator.getCurr_floor() == call_floor) 
                {
                    
                    return "Elevator " + elevator.getName() + " serviced your request.";
                }


            }


        }
    }
}