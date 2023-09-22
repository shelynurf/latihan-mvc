using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;
public class HellowWorldController : Controller
{

    [HttpGet("/helloworld")]
    public string Index()
    {
        return "HELLO WORLD";
    }

    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}