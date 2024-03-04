public class VehicleDatabase
{
    private Dictionary<int, Vehicle> vehicles;

    public VehicleDatabase()
    {
        vehicles = new Dictionary<int, Vehicle>();
    }

    public void AddVehicle(int licensePlate, string owner)
    {
        vehicles[licensePlate] = new Vehicle(licensePlate, owner);
    }

    public Vehicle GetVehicle(int licensePlate)
    {
        if (vehicles.ContainsKey(licensePlate))
            return vehicles[licensePlate];
        else
            return null;
    }
}