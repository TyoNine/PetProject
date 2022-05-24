using System;
using System.Collections.Generic;

namespace FitnessClub.Core
{
    public interface IBookingManager
    {
        bool CreateBooking(Booking booking);
        int FindAvailableGym(DateTime startDate, DateTime endDate);
        List<DateTime> GetFullyOccupiedDates(DateTime startDate, DateTime endDate);
    }
}
