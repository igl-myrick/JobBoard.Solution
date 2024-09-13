using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class ListingsController : Controller
  {

    [HttpGet("/listings")]
    public ActionResult Index()
    {
      List<Listing> allListings = Listing.GetAll();
      return View(allListings);
    }

    [HttpGet("/listings/form")]
    public ActionResult Form() 
    {
      return View();
    }

    [HttpPost("/listings")]
    public ActionResult CreateListing(string title, string description, string requirements, string contactInfo)
    {
      Listing newListing = new Listing(title, description, requirements, contactInfo);
      return RedirectToAction("Index");
    }
  }
}