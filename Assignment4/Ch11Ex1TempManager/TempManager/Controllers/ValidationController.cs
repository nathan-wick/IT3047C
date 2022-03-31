using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TempManager.Models;

public class ValidationController : Controller
{
    private TempManagerContext data { get; set; }
    public ValidationController(TempManagerContext ctx) => data = ctx;

    public JsonResult CheckDate(string date)
    {
        var temp = data.Temps.FirstOrDefault(c => c.Date == DateTime.Parse(date));
        if (temp == null)
        {
            return Json(true);
        }
        else return Json("Date already exists");
    }
}
