using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Components.Models;

namespace MVC_Components.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var cards = new List<CardViewModel>
        {
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
            new CardViewModel
            {
                Title = "Welcome Card",
                Content = "This is a sample card component demonstrating reusable UI in MVC.",
                Footer = "Last updated: " + DateTime.Now.ToString("MMM dd, yyyy"),
                CssClass = "card-success",
                ActionUrl = "/Home/Privacy",
                ActionText = "Learn More"
            },
        };

        string exampleString = "This is an example string to demonstrate string interpolation in C#.";

        ViewBag.ExampleString = exampleString;
        ViewBag.Cards = cards;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
