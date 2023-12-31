﻿using Common.Enums;

namespace Common.Interfaces;

public interface IVehicle
{
    public int Id { get; init; }
    public string RegNo { get; init; }
    public string Maker { get; init; }
    public int Odometer { get; set; }
    public int CostKm { get; init; }
    public VehicleType VehicleType { get; init; }
    public int CostDay { get; set; }
    public VehicleStatus VehicleStatus { get; set; }
   
  IEnumerable<IVehicle> GetVehicle();
}
