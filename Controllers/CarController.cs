using Microsoft.AspNetCore.Mvc;
using TurboazTask1.Models;
using TurboazTask1.Services.Abstract;

namespace TurboazTask1.Controllers
{
    public class CarController : Controller
    {
        private readonly IAppDataContext _context;

        public CarController(IAppDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Cars);
        }

        public IActionResult Detail(int id)
        {

            if (id == null) return BadRequest();
           Car car= _context.Cars.Find(car=> car.CarId== id);
            if (car == null) return NotFound();
            return View(car);
        }
    }
}
