using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCAtime.Data;
using PCAtime.Models;

namespace PCAtime.Controllers
{
    public class TimesheetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimesheetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Timesheet
        public async Task<IActionResult> Index()
        {
            return View(await _context.TimeSheetEntries.ToListAsync());
        }

        // GET: Timesheet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Timesheet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,TaskDescription,HoursWorked")] TimesheetEntry timesheetEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timesheetEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timesheetEntry);
        }

        // Additional actions for Edit and Details can be added here
    }

}
