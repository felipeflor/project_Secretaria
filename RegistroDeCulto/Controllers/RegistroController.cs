using Microsoft.AspNetCore.Mvc;
using RegistroDeCulto.Data;
using RegistroDeCulto.Models;

namespace ResumeManager.Controllers
{
    public class RegistroController : Controller
    {
        private readonly RegistroDbContext _context;
        public RegistroController(RegistroDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Culto> culto;
            culto = _context.Culto.ToList();
            return View(culto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Culto culto = new Culto();
            /*applicant.Experiences.Add(new Experience() { Id = 1 });
            applicant.Experiences.Add(new Experience() { Id = 2 });
            applicant.Experiences.Add(new Experience() { Id = 3 });*/
            return View(culto);
        }
        [HttpPost]
        public IActionResult Create(Culto culto)
        {

            _context.Add(culto);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}