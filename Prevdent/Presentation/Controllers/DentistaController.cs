using Prevdent.Application.DTOs;
using Prevdent.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FraudWatch_WebApp.Presentation.Controllers;

public class DentistaController : Controller
{
    private readonly IDentistaApplicationService _dentistaApplicationService;

    public DentistaController(IDentistaApplicationService dentistaApplicationService)
    {
        _dentistaApplicationService = dentistaApplicationService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var dentistas = _dentistaApplicationService.GetAll();

        return View(dentistas);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DentistaDTO dentistaDTO)
    {
        if (ModelState.IsValid)
        {
            _dentistaApplicationService.Add(dentistaDTO);

            return RedirectToAction("Index");
        }

        return View(dentistaDTO);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        var dentista = _dentistaApplicationService.GetById(id);

        return View(dentista);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var dentista = _dentistaApplicationService.GetById(id);

        return View(dentista);
    }

    [HttpPost]
    public IActionResult DeleteForm(int id)
    {
        var dentista = _dentistaApplicationService.DeleteById(id);

        if (dentista == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var dentista = _dentistaApplicationService.GetById(id);

        return View(dentista);
    }

    [HttpPost]
    public IActionResult Edit(int id, DentistaDTO dentistaDTO)
    {
        if (ModelState.IsValid)
        {
            _dentistaApplicationService.Update(id, dentistaDTO);

            return RedirectToAction("Index");
        }

        return View(dentistaDTO);
    }

}
