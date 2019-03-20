namespace ku_elev
{
    class Elevator
    {
        private bool open;
        private int persons;
        private int weight;
        private int floors;
        private int curr_floor;

	public int getCurr_floor() {
		return this.curr_floor;
	}

	public void setCurr_floor(int curr_floor) {
		this.curr_floor = curr_floor;
	}


	public bool getOpen() {
		return this.open;
	}

	public void isOpen(bool open) {
		this.open = open;
	}


	public int getPersons() {
		return this.persons;
	}

	public void setPersons(int persons) {
		this.persons = persons;
	}

	public int getWeight() {
		return this.weight;
	}

	public void setWeight(int weight) {
		this.weight = weight;
	}

	public int getFloors() {
		return this.floors;
	}

	public void setFloors(int floors) {
		this.floors = floors;
	}


private string direction;

	public string getDirection() {
		return this.direction;
	}

	public void setDirection(string direction) {
		this.direction = direction;
	}




        public Elevator(int floors)
        {
            this.floors = floors;
            direction = "nowhere";
            this.curr_floor = 1;
        }

        //public CreateElevators
    }
}