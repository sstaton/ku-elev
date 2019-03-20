namespace ku_elev
{
    class Elevator
    {
        private bool open;
        private int persons;
        private string name;


        private int weight;
        private int floors;
        private int curr_floor;


	public string getName() {
		return this.name;
	}

	public void setName(string name) {
		this.name = name;
	}	public int getCurr_floor() {
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

    public void upOne()
    {
        if (this.curr_floor < this.floors)
        {
            this.curr_floor++;
        }
    }
    public void downOne()
    {
        if (this.curr_floor > 1)
        {
            this.curr_floor--;
        }
    }




        public Elevator(int floors)
        {
            this.floors = floors;
            direction = "nowhere";
            this.curr_floor = 1;
        }
        public Elevator(int floors, int name)
        {
            this.floors = floors;
            direction = "nowhere";
            this.curr_floor = 1;
            this.name = name;
        }

        //public CreateElevators
    }
}