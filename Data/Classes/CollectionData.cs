using Common.Classes;
using Common.Enums;
using Common.Interfaces;
using Data.Interfaces;

namespace Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new()
    {
         new Customer(1,"John", "Doe", 19860525),
         new Customer(6,"Jane", "Doe", 19600116),
         new Customer(5,"Stefan","Larsson", 20010215),
         new Customer(6,"Bengt", "Gunnarsson", 19720914),
         new Customer(5,"Gösta", "Ekblad", 19620426),
         new Customer(6,"Peter", "Forsberg", 19760411)
    };

    readonly List<IVehicle> _vehicles = new()
    {
        new Car(1,"AAA111", "Tesla", 2430, 5,VehicleType.Sedan, 200, VehicleStatus.Booked ),
        new Car(1,"AAA111", "Audi", 223, 4,VehicleType.Kombi, 125, VehicleStatus.Available ),
        new Car(1,"AAA111", "Bmw", 24340, 2,VehicleType.Sedan, 115, VehicleStatus.Available ),
        new Car(1,"AAA111", "Kia", 64345, 2,VehicleType.Van, 55, VehicleStatus.Available ),
        new Car(1,"AAA111", "Saab", 54343, 1,VehicleType.Kombi, 35, VehicleStatus.Available ),
        new Car(1,"AAA111", "Yamaha", 430, 55,VehicleType.Motorcycle, 250, VehicleStatus.Booked ),
        new Car(1,"AAA111", "Kawasaki", 42130, 50,VehicleType.Motorcycle, 250, VehicleStatus.Available )
    };

    readonly List<IBooking> _bookings = new List<IBooking>(); // rätt ? 

    public CollectionData() => SeedData();

    void SeedData()
    {

    }
    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IVehicle> GetVehicles() => _vehicles;


}
