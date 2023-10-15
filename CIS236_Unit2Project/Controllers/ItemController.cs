using CIS236_Unit2Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS236_Unit2Project.Controllers;
public class ItemController : Controller
{

    private ItemContext context { get; set; }


    // Action to display the form for adding a new item
    public IActionResult Create()
    {
        return View();
    }

    // POST action to handle the submission of the new item form
    [HttpPost]
    public IActionResult Create(Item item)
    {
        if (ModelState.IsValid)
        {
            context.Items.Add(item);
            context.SaveChanges();
            return RedirectToAction("Index"); // Redirect to the list page
        }
        return View(item);
    }

    // Action to display the form for editing an existing item
    public IActionResult Edit(int id)
    {
        var item = context.Items.Find(id);
        if (item == null)
        {
            return NotFound();
        }
        return View(item);
    }

    // POST action to handle the submission of the edit item form
    [HttpPost]
    public IActionResult Edit(Item item)
    {
        if (ModelState.IsValid)
        {
            context.Items.Update(item);
            context.SaveChanges();
            return RedirectToAction("Index"); // Redirect to the list page
        }
        return View(item);
    }
}
