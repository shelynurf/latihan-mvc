using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;
public class HelloWorldController : Controller
{

    // [HttpGet("/helloworld")]
    public IActionResult Index()
    {
        return View();
    }

    // http://localhost:5237/HelloWorld/Welcome?name=Rick
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome( string name, int numTimes = 1)
    {
        // return "This is the Welcome action method...";
        ViewData["Message"] = "Hello" + name;
        ViewData["Numtimes"] = numTimes;
        return View();
        // return HtmlEncoder.Default.Encode($"Hello {name}, NumTImes is : {numTimes}");
    }


    //http://localhost:5237/HelloWorld/Welcome/3?name=Rick
    // public Iact Welcome( string name, int ID = 1)
    // {
    //     // return "This is the Welcome action method...";
    //     return HtmlEncoder.Default.Encode($"Hello {name}, ID : {ID}");
    // }
}