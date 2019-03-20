namespace ku_elev
{
    class Elevator
    {
        private int persons;
        private int weight;
        private int floors;
        private bool open;

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


private MoveStatus moving;

	public MoveStatus getMoving() {
		return this.moving;
	}

	public void setMoving(MoveStatus moving) {
		this.moving = moving;
	}


        public Elevator(int floors)
        {
            this.floors = floors;
        }
    }
}