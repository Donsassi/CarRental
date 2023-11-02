using Common.Interfaces;

namespace Common.Classes;

public class Booking : IBooking
{
    public int Id { get; init; }
    public int PersonId { get; init; }
    public int VehicleId { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; set; }
    public int KmDriven { get; set; }
    public double TotalCost { get; set; }
    public Booking(int id, int personId, int vehicleId, DateTime startDate, int kmDriven, double totalCost) 
        => (Id, PersonId, VehicleId, StartDate, KmDriven, TotalCost)
        = (id, personId, vehicleId, startDate, kmDriven, totalCost);

    public IEnumerable<IBooking> GetBookings()
    {
        throw new NotImplementedException();
    }

}
