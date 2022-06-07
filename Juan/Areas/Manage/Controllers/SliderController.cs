using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Juan.DAL;

namespace Juan.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {

            var data = _context.Sliders.ToList();

            return View(data);
        }
    }
}
