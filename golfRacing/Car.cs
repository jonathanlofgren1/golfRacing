

using System.Drawing;
using System.Xml.Linq;

class Car
{


    public string CarType { get; set; }
    public string CarWheels { get; set; }
    public int CarSpeed { get; set; }

    public Car()
    {
        CarType = "Default";
        CarWheels = "Standard";
        CarSpeed = 10;
    }
    public Car(string carType, string carWheels, int carSpeed)
    {
        CarType = carType;
        CarWheels = carWheels;
        CarSpeed = carSpeed;
    }
    public void PrintInfo()
        {
            Console.WriteLine($"The {CarType} Golf Cart has {CarWheels} wheels with a speed of {CarSpeed}");

        }
   
    
}
