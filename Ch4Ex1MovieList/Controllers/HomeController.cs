using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ch4Ex1MovieList.Models;

namespace Ch4Ex1MovieList.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
