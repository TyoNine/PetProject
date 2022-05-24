using System;

namespace FitnessClub.Core
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public int GymId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
