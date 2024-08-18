using Microsoft.AspNetCore.Mvc;
using dz_geometry.Models;
using dz_geometry.Services;

public class GeometryController : Controller
{
    private readonly ISquareService _squareService;
    private readonly IRectangleService _rectangleService;
    private readonly ICircleService _circleService;

    public GeometryController(ISquareService squareService, IRectangleService rectangleService, ICircleService circleService)
    {
        _squareService = squareService;
        _rectangleService = rectangleService;
        _circleService = circleService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Square()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Square(Square model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Area = _squareService.CalculateArea(model);
            ViewBag.Perimeter = _squareService.CalculatePerimeter(model);
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult Rectangle()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Rectangle(Rectangle model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Area = _rectangleService.CalculateArea(model);
            ViewBag.Perimeter = _rectangleService.CalculatePerimeter(model);
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult Circle()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Circle(Circle model)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Area = _circleService.CalculateArea(model);
            ViewBag.Perimeter = _circleService.CalculatePerimeter(model);
        }
        return View(model);
    }
}
