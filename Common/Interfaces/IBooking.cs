
using Common.Enums;

namespace Common.Interfaces;

public interface IBooking
{ 
    public int Id { get; init; }
    public int PersonId { get; init; }    
    public int  VehicleId { get; init; }  
    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; set; }
    public int KmDriven { get; set; }
    public double TotalCost { get; set; }

    IEnumerable<IBooking> GetBookings();

}

