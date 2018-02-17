using System.Collections.Generic;
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
        List<Contact> allContacts = Item.GetAll();
        return View("Index", allContacts);
      }

      [HttpGet("/{id}")]
      public ActionResult Details(int id)
      {
        Contact contact = Contact.Find(id);
        return View(contact);
      }

      [HttpPost("/contacts/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }


    }
}
