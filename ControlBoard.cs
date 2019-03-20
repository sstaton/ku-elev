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
                Elevator elevator = new Elevator(num_flo, i.ToString());
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
            Stack<Elevator> possibles = new Stack<Elevator>();

            foreach (var elevator in elevators)
            {
                if (call_floor == dest_floor)
                {
                    return "You're already here!";
                }
                if (elevator.getDirection() == "nowhere" && elevator.getCurr_floor() == call_floor)
                {
                    elevator.isOpen(false);
                    elevator.isOccupied(true);
                    if (dest_floor > call_floor)
                    {
                        elevator.setDirection("up");
                    }
                    else
                    {
                        elevator.setDirection("down");
                    }
                    return "Elevator " + elevator.getName() + " serviced your request.";
                }


            }


        }
        public void stepTime()
        {
            //TODO move upward going occupied elevators up until they hit their floor, then open and unoccupy
            //TODO move downward going occupied elevators down until they hit their floor, then open and unoccupy
            //TODO move upward going unoccupied elevators up until they hit their floor, then open and occupy
            //TODO move downward going unoccupied elevators down until they hit their floor, then open and occupy
        }
    }
}