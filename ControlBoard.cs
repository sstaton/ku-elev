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
                Elevator elevator = new Elevator(num_flo);
                elevators.Push(elevator);
            }
        }
        public string soundOff()
        {
            string soundOffs = "";
            foreach (var elev in elevators)
            {
                soundOffs = soundOffs + "An elevator is going " + elev.getDirection() + " at floor " + elev.getCurr_floor() + "\r\n";
            }
            return soundOffs;
        }
    }
}