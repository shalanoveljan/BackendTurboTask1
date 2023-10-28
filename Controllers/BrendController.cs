using Microsoft.AspNetCore.Mvc;
using TurboazTask1.Models;
using TurboazTask1.Services.Abstract;

namespace TurboazTask1.Controllers
{
    public class BrendController : Controller
    {
        private readonly IAppDataContext _context;

        public BrendController(IAppDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Brends);
        }

        public IActionResult Detail(int id)
        {
            if(id==null) return BadRequest();

            List<CarModel> carmodels= _context.CarModels.FindAll(model => model.BrendId == id);

            if(carmodels==null) return NotFound();

            return View(carmodels);
        }
    }
}
