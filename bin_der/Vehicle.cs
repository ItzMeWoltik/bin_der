public class Vehicle
{
    public int LicensePlate { get; set; }
    public string Owner { get; set; }

    public Vehicle(int licensePlate, string owner)
    {
        LicensePlate = licensePlate;
        Owner = owner;
    }
}