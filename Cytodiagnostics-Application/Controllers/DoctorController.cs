using Cytodiagnostics_Application.Data;
using Cytodiagnostics_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cytodiagnostics_Application.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DoctorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var doctors = _db.Doctors.ToList();
            return View(doctors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Doctor model)
        {
            if (ModelState.IsValid)
            {
                _db.Doctors.Add(model);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }
    }
}
