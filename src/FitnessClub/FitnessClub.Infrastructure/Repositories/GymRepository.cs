using System;
using System.Collections.Generic;
using System.Linq;
using FitnessClub.Core;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Infrastructure.Repositories
{
    public class GymRepository : IRepository<Gym>
    {
        private readonly FitnessClubContext db;

        public GymRepository(FitnessClubContext context)
        {
            db = context;
        }

        public void Add(Gym entity)
        {
            db.Gym.Add(entity);
            db.SaveChanges();
        }

        public void Edit(Gym entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Gym Get(int id)
        {
            // The FirstOrDefault method below returns null
            // if there is no room with the specified Id.
            return db.Gym.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Gym> GetAll()
        {
            return db.Gym.ToList();
        }

        public void Remove(int id)
        {
            // The Single method below throws an InvalidOperationException
            // if there is not exactly one room with the specified Id.
            var room = db.Gym.Single(r => r.Id == id);
            db.Gym.Remove(room);
            db.SaveChanges();
        }
    }
}
