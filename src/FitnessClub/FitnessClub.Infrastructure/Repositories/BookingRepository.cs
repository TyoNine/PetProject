using FitnessClub.Core;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Infrastructure.Repositories
{
    public class BookingRepository : IRepository<Booking>
    {
        private readonly FitnessClubContext db;

        public BookingRepository(FitnessClubContext context)
        {
            db = context;
        }

        public void Add(Booking entity)
        {
            db.Booking.Add(entity);
            db.SaveChanges();
        }

        public void Edit(Booking entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Booking Get(int id)
        {
            return db.Booking.Include(b => b.Customer).Include(b => b.Gym).FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Booking> GetAll()
        {
            return db.Booking.Include(b => b.Customer).Include(b => b.Gym).ToList();
        }

        public void Remove(int id)
        {
            var booking = db.Booking.FirstOrDefault(b => b.Id == id);
            db.Booking.Remove(booking);
            db.SaveChanges();
        }

    }
}
