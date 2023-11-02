using Common.Enums;
using Common.Interfaces;

namespace Common.Classes;

public class Car : IVehicle
{
    public int Id { get; init; }
    public string RegNo { get; init; }
    public string Maker { get; init; }
    public int Odometer { get; set; }
    public int CostKm { get; init; }
    public VehicleType VehicleType { get; init; }
    public int CostDay { get; set; }
    public VehicleStatus VehicleStatus { get; set; }

    public Car(int id, string regNo, string maker, int odometer, int costKm, VehicleType vehicleType, int costDay, VehicleStatus vehicleStatus)
        => (Id, RegNo, Maker, Odometer, CostKm, VehicleType, CostDay, VehicleStatus) = (id, regNo, maker, odometer, costKm, vehicleType, costDay, vehicleStatus);

    public IEnumerable<IVehicle> GetVehicle()
    {
        throw new NotImplementedException();
    }

}

