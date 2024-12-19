class Driver
{
    public string DriverName { get; set; }
    public int DriverSafety { get; set; }
    public int DriverSpeed {  get; set; }


    
    
    public Driver()
    {
        DriverName = "John";
        DriverSafety = 10;
        DriverSpeed = 10;
    }
    public Driver(string driverName, int driverSafety, int driverSpeed)
    {
        DriverName = driverName;
        DriverSafety = driverSafety;
        DriverSpeed = driverSpeed;

    }
}