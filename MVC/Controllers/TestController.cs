using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class TestController : Controller
{
    public string Index()
    {
        return "Test";
    }

    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}
