class Competitor {
    public Car CompetitorCar { get; set; }
    public Driver CompetitorDriver { get; set; }

    public Competitor() {
        CompetitorCar = new Car();
        CompetitorDriver = new Driver();
    }

    public Competitor(Car car, Driver driver)
    {
        CompetitorCar = car;
        CompetitorDriver = driver;
        
    }


    public int GetTime() {
        int time = 100;
        time -= CompetitorCar.CarSpeed;
        return time;
    }

}
