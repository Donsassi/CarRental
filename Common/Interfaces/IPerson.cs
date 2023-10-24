using Common.Classes;

namespace Common.Interfaces;

public interface IPerson
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Social { get; init; }

    IEnumerable<IPerson> GetPersons();
}
