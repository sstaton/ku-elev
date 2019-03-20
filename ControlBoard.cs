namespace ku_elev
{
    class ControlBoard
    {
        static Elevator[] elevators;
        public ControlBoard()
        {
        }
        public ControlBoard(int num_flo, int num_elev)
        {
            elevators = new Elevator[num_elev];
            foreach (var elev in elevators)
            {
                Elevator elevator = new Elevator(num_flo);
            }
        }
        public string soundOff()
        {
            string soundOffs = "";
            for (int i = 0; i < elevators.Length; i++)
            {                
                soundOffs += "Elevator " + i + " is going " + elevators[i].getDirection() + " at floor " + elevators[i].getCurr_floor();
            }
            return soundOffs;
        }
    }
}