namespace Common.Interfaces;

public interface IBooking
{
    public int Odometer { get; init; }
    public int Cost { get; init; }
    public string Date { get; init; }

}
