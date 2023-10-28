using Microsoft.AspNetCore.Mvc;
using TurboazTask1.Models;
using TurboazTask1.Services.Abstract;

namespace TurboazTask1.Controllers
{
    public class CarModelController : Controller
    {
        private readonly IAppDataContext _context;

        public CarModelController(IAppDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.CarModels);
        }

        public IActionResult Detail(int id)
        {
            if (id == null) return BadRequest();

            List<Car> cars= _context.Cars.FindAll(car=>car.CarModelId==id);

            if(cars==null) return NotFound();

            return View(cars);

        }

    }
}
