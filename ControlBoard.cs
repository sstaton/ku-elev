using System.Collections.Generic;

namespace ku_elev
{
    class ControlBoard
    {
        //Note, there are definitely better collections than the stack to use, it was just easiest for the short time limit
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
                //no need to go
                if (call_floor == dest_floor)
                {
                    return "You're already here!";
                }
                //first unoccupied elevator on the same floor in the stack gets it!
                if (!elevator.getOccupied() && elevator.getDirection() == "nowhere" && elevator.getCurr_floor() == call_floor)
                {
                    elevator.isOpen(false);
                    elevator.isOccupied(true);
                    elevator.setGoing_to_floor(dest_floor);
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
                //look for unoccupied elevators that are already heading to the direction of the calling floor, push them to a stack to be examined for closest
                if (!elevator.getOccupied() &&
                        (elevator.getDirection() == "down" && elevator.getCurr_floor() > call_floor
                            || elevator.getDirection() == "up" && elevator.getCurr_floor() < call_floor))
                {
                    possibles.Push(elevator);
                }
                //has any?
                if (possibles.Count > 0)
                {
                    //TODO foreach, stack.pop, service request with closest elevator utilizing Elevator.distanceFrom method
                    return "TODO name of elevator";
                }
                //look for unoccupied elevators that are not moving next
                if (!elevator.getOccupied() && elevator.getDirection() == "nowhere")
                {
                    possibles.Push(elevator);
                }
                if (possibles.Count > 0)
                {
                    //TODO foreach, stack.pop, service request with closest elevator utilizing Elevator.distanceFrom method
                    return "TODO name of elevator";
                }
                //TODO if you got here, nothing could service them, so move time forward, and try again
                return elevatorCall(call_floor, dest_floor);
            }
            return null;


        }
        public void stepTime()
        {
            //TODO move upward going occupied elevators up until they hit their floor, then open and unoccupy
            //TODO move downward going occupied elevators down until they hit their floor, then open and unoccupy
            //TODO move upward going unoccupied elevators up until they hit their floor, then open and occupy
            //TODO move downward going unoccupied elevators down until they hit their floor, then open and occupy
            //TODO increment floors passed and trips made
        }
    }
}