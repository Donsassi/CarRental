using Common.Interfaces;

namespace Common.Classes;

public class Customer : IPerson
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Social { get; init; }

    public Customer(int id, string firstName, string lastName, int social) =>
        (Id, FirstName, LastName, Social) = (id, firstName, lastName, social);

    public IEnumerable<IPerson> GetPersons()
    {
        throw new NotImplementedException();
    }
}
