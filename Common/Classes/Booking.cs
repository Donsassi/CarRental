using Common.Interfaces;

namespace Common.Classes;

public class Booking : IBooking
{
    public int MyProperty { get; set; }
    public int Odometer { get; init; }
    public int Cost { get; init; }
    public string Date { get; init; }
}
