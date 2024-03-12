using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCAtime.Data;

namespace PCAtime.Controllers
{
    public class RolesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Roles.ToListAsync());
        }
    }
}
