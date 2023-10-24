﻿
using Common.Interfaces;
using Data.Interfaces;

namespace Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

 
    public IEnumerable<IPerson> GetCustomers()
    {
        return _db.GetPersons();
    }

    public IEnumerable<IVehicle> GetVehicles()
    {
        return _db.GetVehicles();
    } 

    public IEnumerable<IBooking> GetBookings()
    {
        return _db.GetBookings();
    }

}