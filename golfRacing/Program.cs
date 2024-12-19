class Program
{

    public static void Main(string[] args)
    {
        List<Car> cars = [new Car(), new Car("Sport", "Speedy", 20)];
        Console.WriteLine("Welcome to Golf Cart Racing!");
        Console.WriteLine("Please choose your vehicle");

        string input = "";
        for (int i = 0; i < cars.Count; i++)
        {
            Console.Write(i + 1 + ": ");
            cars[i].PrintInfo();
        }
        input = Console.ReadLine();


        if (input == "1")
        {
            Console.WriteLine("You have chosen the default car.");
        }
        else if (input == "2")
        {
            Console.WriteLine("You have chosen the speedy car");
            
            
        }

        
        

        Competitor player;


        Competitor bot1 = new Competitor();
        Competitor bot2 = new Competitor(cars[1], new Driver());

        {
          
        }
    }
}
    
      

 
