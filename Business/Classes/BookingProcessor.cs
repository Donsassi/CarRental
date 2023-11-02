using Common.Enums;
using Common.Interfaces;
using Data.Interfaces;
namespace Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;
    public string vehicleStatus = string.Empty;
    public  BookingProcessor(IData db) => _db = db;
    public IEnumerable<IBooking> GetBookings() => _db.GetBookings();
    public IEnumerable<IPerson> GetPersons() => _db.GetPersons();
    public IEnumerable<IVehicle> GetVehicles() => _db.GetVehicles();
    
    public IVehicle GetVehicleById(int id)
    {
        var vehicles = GetVehicles();
        var vehicle = vehicles.FirstOrDefault(x => x.Id == id);
        if (vehicle == null)
        {
            throw new Exception("Vehicle Not Found");
        }
        return vehicle;
    }

    public IPerson GetCustomerById(int id)
    {
        var customers = GetPersons();
        var customer = customers.FirstOrDefault(x => x.Id == id);
        if (customer == null)
        {
            throw new Exception("Customer Not Found");
        }
        return customer;
    }

    public IBooking GetBookingById(int id)
    {
        var bookings = GetBookings();
        var booking = bookings.FirstOrDefault(x => x.Id == id);
        if (booking == null)
        {
            throw new Exception("Booking Not Found");
        }
        return booking;
    }

    public double CalculateCost(int vehicleId, int bookingId, int kmDriven)
    {
        var vehicle = GetVehicleById(vehicleId);
        var booking = GetBookingById(bookingId);
        if (booking.EndDate.HasValue)
        {
            double nrOfDays = (booking.EndDate.Value - booking.StartDate).Days;
            double a = nrOfDays * vehicle.CostDay;
            var b = vehicle.CostKm * kmDriven;
            return a + b;
        }
        throw new Exception("Error Calculating Cost");
    }

    public void ChangeOdometer(int bookingId, int vehicleId, int kmDriven)
    {
        var booking = GetBookingById(bookingId);
        var vehicle = GetVehicleById(vehicleId);
        booking.KmDriven = kmDriven;
        int newOdometer = kmDriven + vehicle.Odometer;
        vehicle.Odometer = newOdometer;
    }

/*    public VehicleStatus GetVehicleStatus(int vehicleId)
    {
        var vehicle = GetVehicleById(vehicleId);
        return vehicle.VehicleStatus;
    }*/
    public void ReturnCar(int bookingId, int vehicleId, int kmDriven)
    {
        var booking = GetBookingById(bookingId);
        var vehicle = GetVehicleById(vehicleId);
        booking.EndDate = DateTime.Now;
        booking.TotalCost = CalculateCost(vehicleId, bookingId, kmDriven);
        ChangeOdometer(bookingId, vehicleId, kmDriven);
        vehicle.VehicleStatus = VehicleStatus.Available;


    }
}
