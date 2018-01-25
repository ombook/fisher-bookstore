using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("hello world");
        }
    }

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About Controller's Index action.");
        }

        public IActionResult History()
        {
            return Content("This is the About Controller's History action.");
        }

        public IActionResult Location()
        {
            return Content("This is the About Controller's Location action.");
        }
    }

    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Books controller's Index action.");
        }

        public IActionResult New()
        {
            return Content("This is the Books controller's New action.");
        }
    }

    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Authors controller's Index action.");
        }

        public IActionResult Featured()
        {
            return Content("This is the Authors controller's Featured action.");
        }
    }

    public class OfferingsController : Controller
    {
        [Route("Products")]
        [Route("Products/Index")]
        
        public IActionResult Products()
        {
            return Content("This is the products page.");
        }

        [Route("Services")]
        [Route("Services/Index")]

        public IActionResult Services()
        {
            return Content("This is the services page.");
        }
    }
}