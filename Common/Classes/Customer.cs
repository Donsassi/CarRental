using Common.Interfaces;

namespace Common.Classes;

public class Customer : IPerson
{
    public int Id { get; init; }
    public int BookingId { get; init; } 
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Social { get; init; }

    public Customer(int id, int bookingId, string firstName, string lastName, int social) =>
        (Id, BookingId, FirstName, LastName, Social) = (id, bookingId, firstName, lastName, social);

    public IEnumerable<IPerson> GetPersons()
    {
        throw new NotImplementedException();
    }

 }
