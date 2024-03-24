using System;

class Program
{
    static void Main(string[] args)
    {

        Car car1 = new Car("Corolla", "Toyota", 2019, 60.0, 5, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("Silverado", "Chevrolet", 2018, 90.0, 2000, "Pickup", true);
        Motorcycle motorcycle1 = new Motorcycle("Sportster", "Harley-Davidson", 2020, 45.0, 1200, "Petrol", true);

        Console.WriteLine("Car Details:");
        car1.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck1.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle1.DisplayDetails();
        Console.WriteLine();

        RentalAgency agency = new RentalAgency(15);

        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(motorcycle1);

        Console.WriteLine("Renting out the motorcycle...");
        agency.RentVehicle("Sportster");

        Console.WriteLine($"Total Revenue: ${agency.TotalRevenue}");
    }
}
