using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [Route("/hello")]
      public string Hello() { return "Hello friend!"; }
    }
}
