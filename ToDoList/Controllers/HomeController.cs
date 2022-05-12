using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem =new Item("Add first Item to the To Do List");
      return View(starterItem);
    }
  }
}