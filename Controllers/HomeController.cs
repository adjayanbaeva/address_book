// using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/contacts")]
      public ActionResult Index()
      {
        Contact newItem = new Item(Request.Query["new-contact"]);
        return View(newContact);
      }

      [HttpGet("/contacts/new")]
      public ActionResult CreateForm()
      {
        return View();
      }




    }
}
