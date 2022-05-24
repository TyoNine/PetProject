using System;
using System.Collections.Generic;
using System.Linq;
using FitnessClub.Core;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Infrastructure.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly FitnessClubContext db;

        public CustomerRepository(FitnessClubContext context)
        {
            db = context;
        }

        public void Add(Customer entity)
        {
            db.Customer.Add(entity);
            db.SaveChanges();
        }

        public void Edit(Customer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Customer Get(int id)
        {
            return db.Customer.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.Customer.ToList();
        }

        public void Remove(int id)
        {
            var customer = db.Customer.Single(r => r.Id == id);
            db.Customer.Remove(customer);
            db.SaveChanges();
        }
    }
}
