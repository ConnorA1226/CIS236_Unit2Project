using CIS236_Unit2Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS236_Unit2Project.Controllers;
public class ItemController : Controller
{
    private readonly ApplicationDbContext _context;

    public ItemController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var items = _context.Items.ToList();
        return View(items);
    }
}
