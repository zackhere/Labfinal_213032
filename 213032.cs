using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class ReceptionistController : Controller
{
    private readonly AppDbContext _context;

    public ReceptionistController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Appointments()
    {
        var appointments = _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList();
        return View(appointments);
    }

}
