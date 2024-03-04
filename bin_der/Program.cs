using System;

class Program
{
    static void Main(string[] args)
    {
        VehicleDatabase database = new VehicleDatabase();

        database.AddVehicle(1234, "John Doe");
        database.AddVehicle(5678, "Jane Smith");
        database.AddVehicle(9012, "Bob Johnson");

        while (true)
        {
            Console.Write("Enter a license plate number (or 'q' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            int licensePlate;
            if (int.TryParse(input, out licensePlate))
            {
                Vehicle vehicle = database.GetVehicle(licensePlate);
                if (vehicle != null)
                {
                    Console.WriteLine($"Wanted vehicle detected: License Plate {vehicle.LicensePlate}, Owner {vehicle.Owner}");
                }
                else
                {
                    Console.WriteLine("Vehicle not found in the database.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid license plate number.");
            }
        }
    }
}