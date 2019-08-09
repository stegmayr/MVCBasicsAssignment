using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCBasicsAssignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactInfo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(int degresCelsius)
        {
            ViewBag.degresCelsius = degresCelsius;
            
            if (degresCelsius <= 28)
            {
                ViewBag.outputMessage = "Your body temperature is below 28 degrees celsius and you have hyperthermia. The fact that you even are able to use this website is incredible. But since you can, seek medical attention at once!";
            }
            else if (degresCelsius <= 35 && degresCelsius > 28)
            {
                ViewBag.outputMessage = "Your body temperature is below avrage. Seek shelter for example inside a house or close to another source of heat like a fireplace.";
            }
            else if (degresCelsius >= 38 && degresCelsius < 42)
            {
                ViewBag.outputMessage = "You have a fever. Make sure to get rest and eat much soup.";
            }
            else if (degresCelsius >= 42)
            {
                ViewBag.outputMessage = "Your body temperature is above 42 degrees celsius and you shuld be dead. But since you can still browse the webb for awnsers, seek medical attention at once!";
            }
            else
            {
                ViewBag.outputMessage = "Your body temperature is normal. Good for you!";
            }

            return View();
        }



    }
}