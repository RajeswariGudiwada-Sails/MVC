using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<Studentmodel> students = new List<Studentmodel>();
        public IActionResult Index()
        {
           
            return View(students);

        }
        public IActionResult Register()
        {
            var sdtVM = new Studentmodel();
            return View(sdtVM);

        }
        public IActionResult registation(Studentmodel studentmodel)
        {

            students.Add(studentmodel);
            return RedirectToAction(nameof(Index));

        }


        public IActionResult Hello()
        {
            return View();
        }
    }
}
