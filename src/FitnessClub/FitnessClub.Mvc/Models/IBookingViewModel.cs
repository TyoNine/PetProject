using System;
using System.Collections.Generic;
using FitnessClub.Core;

namespace FitnessClub.Mvc.Models
{
    public interface IBookingViewModel
    {
        IEnumerable<Booking> Bookings { get; }
        List<DateTime> FullyOccupiedDates { get; }
        int YearToDisplay { get; set; }
        string GetMonthName(int month);
        bool DateIsOccupied(int year, int month, int day);
    }
}
