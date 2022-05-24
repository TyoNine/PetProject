using System.Linq;
using FitnessClub.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Mvc.Controllers
{
    public class GymsController : Controller
    {
        private IRepository<Gym> repository;

        public GymsController(IRepository<Gym> repos)
        {
            repository = repos;
        }

        // GET: Gyms
        public IActionResult Index()
        {
            return View(repository.GetAll().ToList());
        }

        // GET: Gyms/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gym gym = repository.Get(id.Value);
            if (gym == null)
            {
                return NotFound();
            }

            return View(gym);
        }

        // GET: Gyms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gyms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Description")] Gym gym)
        {
            if (ModelState.IsValid)
            {
                repository.Add(gym);
                return RedirectToAction(nameof(Index));
            }
            return View(gym);
        }

        // GET: Gyms/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gym gym = repository.Get(id.Value);
            if (gym == null)
            {
                return NotFound();
            }
            return View(gym);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Description")] Gym gym)
        {
            if (id != gym.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repository.Edit(gym);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (repository.Get(gym.Id) == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gym);
        }

        // GET: Rooms/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gym gym = repository.Get(id.Value);
            if (gym == null)
            {
                return NotFound();
            }

            return View(gym);
        }

        // POST: Gyms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id > 0)
                repository.Remove(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
