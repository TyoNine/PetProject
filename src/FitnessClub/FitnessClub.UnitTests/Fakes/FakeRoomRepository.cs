using System.Collections.Generic;
using FitnessClub.Core;

namespace FitnessClub.UnitTests.Fakes
{
    public class FakeRoomRepository : IRepository<Gym>
    {
        // This field is exposed so that a unit test can validate that the
        // Add method was invoked.
        public bool addWasCalled = false;

        public void Add(Gym entity)
        {
            addWasCalled = true;
        }

        // This field is exposed so that a unit test can validate that the
        // Edit method was invoked.
        public bool editWasCalled = false;

        public void Edit(Gym entity)
        {
            editWasCalled = true;
        }

        public Gym Get(int id)
        {
            return new Gym { Id = 1, Description = "A" };
        }

        public IEnumerable<Gym> GetAll()
        {
            List<Gym> rooms = new List<Gym>
            {
                new Gym { Id=1, Description="A" },
                new Gym { Id=2, Description="B" },
            };
            return rooms;
        }

        // This field is exposed so that a unit test can validate that the
        // Remove method was invoked.
        public bool removeWasCalled = false;

        public void Remove(int id)
        {
            removeWasCalled = true;
        }
    }
}
