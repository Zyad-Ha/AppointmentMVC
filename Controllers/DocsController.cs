using AppointmentMVC.Data;
using AppointmentMVC.Models;
using AppointmentMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentMVC.Controllers
{
    public class DocsController : Controller
    {
        private readonly Context _context;
        public DocsController(Context context)
        {
            _context = context;
        }
        public IActionResult Index2()
        {
            var docs = _context.doctors.ToList();
            return View(docs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            _context.doctors.Add(doctor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index2));
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var DocID = _context.doctors.FirstOrDefault(p => p.Id == id);
            if (DocID == null)
            {
                return NotFound();
            }
            return View(DocID);
        }
        [HttpPost]
        public IActionResult Edit(Doctor doctor)
        {
            _context.doctors.Update(doctor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index2));
        }




        [HttpGet]
        public IActionResult Details(int id)
        {

            var Appo = (from x in _context.appointments
                        where x.DocID == id
                        select new AppoViewModel
                        {
                            Id = x.Id,
                            Doctor = x.Doctor,
                            Patient = x.Patient,
                            AppoDateTime = x.AppoDateTime,
                            DurationByMinuts = x.DurationByMinuts,
                            Status = x.Status,
                        }).ToList();

            var docs = (from x in _context.doctors
                       where x.Id == id
                       select x).FirstOrDefault();

            var ze = new ViewModels.DocsAppoViewModel
            {
                Doctor = docs,
                appoViewModels = Appo

            };

            return View(ze);
        }


        public IActionResult Delete(Doctor doctor)
        {
            var DocID = _context.doctors.FirstOrDefault(x => x.Id == doctor.Id);
            _context.doctors.Remove(DocID);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index2));
        }


    }
}
