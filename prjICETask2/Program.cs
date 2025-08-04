namespace prjICETask2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cars car = new Cars("Toyota", "Corolla", "Red", 2020, 20000.0);
            Cars car2 = new Cars("Honda", "Civic", "Blue", 2019, 22000.0);

            // Ass code from kyle
            Console.WriteLine("Car brand: " + car[0] + 
                "\nCar Model: " + car[1] + 
                "\nCar Colour: " + car[2] + 
                "\nCar Year: " + car[3] + 
                "\nCar Price: " + car[4]);

            Console.WriteLine("\nCar brand: " + car2["carBrand"] + 
                "\nCar Model: " + car2["carModel"] + 
                "\nCar Colour: " + car2["carColor"] + 
                "\nCar Year: " + car2["carYear"] + 
                "\nCar Price: " + car2["carPrice"]);

        }
    }
}
