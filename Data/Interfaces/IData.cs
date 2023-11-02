using Common.Interfaces;
namespace Data.Interfaces;

public interface IData
{
    IEnumerable<IPerson> GetPersons();
    IEnumerable<IVehicle> GetVehicles();
    IEnumerable<IBooking> GetBookings();
 
}
