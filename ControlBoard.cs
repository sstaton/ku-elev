namespace ku_elev
{
    class ControlBoard
    {
        public ControlBoard()
        {
        }
        public ControlBoard(int num_flo, int num_elev)
        {
            Elevator[] elevators = new Elevator[num_elev];
            foreach (var elev in elevators)
            {
                Elevator elev = new Elevator(num_flo);
            }
        }
    }
}