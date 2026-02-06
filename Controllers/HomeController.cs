using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission_6_Nelson.Models;

namespace Mission_6_Nelson.Controllers;

public class HomeController : Controller
{

    private MovieFormContext _context;

    public HomeController(MovieFormContext temp)
    {
        _context = temp;
    }
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
    }

    [HttpGet]
    public IActionResult MovieForm()
    {
        return View();
    }
    
    // Redirects to a confirmation page rather than a blank form.
    [HttpPost]
    public IActionResult MovieForm(Movie response)
    {
        _context.Movies.Add(response); // Add record to the Database
        _context.SaveChanges(); // Commit the changes to the Database

        return View("Confirmation", response);
    }
}