using AppointmentMVC.Data;
using AppointmentMVC.Models;
using AppointmentMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Permissions;

namespace AppointmentMVC.Controllers
{
    public class AppoController : Controller
    {
        private readonly Context _context;
        public AppoController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var appos =
            _context.appointments.ToList();
            return View(appos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            var exists = _context.appointments
                .Any(s => s.AppoDateTime == appointment.AppoDateTime);

            if (exists)
            {
                return Conflict("This date alrady exist");
            }

            _context.appointments.Add(appointment);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var apooID = _context.appointments.FirstOrDefault(p=>p.Id == id);
            if (apooID == null)
            {
                return NotFound();
            }
            return View(apooID);
        }
        [HttpPost]
        public IActionResult Edit(Appointment appointment)
        {
            _context.appointments.Update(appointment);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var appoID = _context.appointments.Find(id);
            return View(appoID);
        }


        public IActionResult Delete(Appointment appointment)
        {
            var appoID = _context.appointments.FirstOrDefault(x=>x.Id == appointment.Id);
            _context.appointments.Remove(appoID);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }





    }
}
