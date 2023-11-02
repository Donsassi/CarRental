using Common.Classes;
using Common.Enums;
using Common.Interfaces;
using Data.Interfaces;

namespace Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new()
    {
         new Customer(1001, 0 ,"Jarmo", "Trulli", 19860525),
         new Customer(1002, 0, "Sebastian", "Loeb", 19600116),
         new Customer(1003, 0, "Stefan","Larsson", 20010215),
         new Customer(1004, 0, "Bengt", "Gunnarsson", 19720914),
         new Customer(1005, 0, "Gösta", "Ekblad", 19620426),
         new Customer(1006, 0, "Peter", "Forsberg", 19760411)
    };

    readonly List<IVehicle> _vehicles = new()
    {
        new Car(1, "AAA111", "Tesla", 2400, 5,VehicleType.Sedan, 200, VehicleStatus.Available ),
        new Car(2,"BBB222", "Audi", 223, 4,VehicleType.Kombi, 125, VehicleStatus.Booked ),
        new Car(3,"CCC333", "Bmw", 24340, 2,VehicleType.Sedan, 115, VehicleStatus.Available ),
        new Car(4,"DDD444", "Kia", 64345, 2,VehicleType.Van, 55, VehicleStatus.Available ),
        new Car(5,"EEE555", "Saab", 54343, 1,VehicleType.Kombi, 35, VehicleStatus.Available ),
        new Car(6,"FFF666", "Yamaha", 430, 55,VehicleType.Motorcycle, 250, VehicleStatus.Available ),
        new Car(7,"GGG777", "Kawasaki", 42130, 50,VehicleType.Motorcycle, 250, VehicleStatus.Available )
    };

    readonly List<IBooking> _bookings = new()
    {
        new Booking(1, 1001, 1, new DateTime (2023, 10, 15), 2500, 4000)
        {
            EndDate = new DateTime (2023, 10, 20)
        },
        new Booking(2, 1002, 2, new DateTime(2023, 10, 20), 0, 0),
    };



    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IVehicle> GetVehicles() => _vehicles;

    public IVehicle GetVehicleById(int id)
    {
        throw new NotImplementedException();
    }

    public IBooking GetBookingById(int id)
    {
        throw new NotImplementedException();
    }

    public IPerson GetCustomerById(int id)
    {
        throw new NotImplementedException();
    }

    public IVehicle GetVechicleStatus(int id)
    {
        throw new NotImplementedException();
    }
}


