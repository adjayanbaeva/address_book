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
        return View();
      }

      [HttpGet("/contacts/new")]
      public ActionResult ContactForm()
      {
        return View();
      }

      [HttpPost("/contacts")]
      public ActionResult Create()
      {
        Contact newContact = new Contact(Request.Form["new-contact"]);
        newContact.Save();
        return View("Index", newContact);
      }


    }
}
