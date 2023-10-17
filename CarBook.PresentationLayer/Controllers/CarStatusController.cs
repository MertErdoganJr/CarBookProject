﻿using CarBook.BusinessLayer.Abstract;
using CarBook.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.PresentationLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;

        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }

        public IActionResult Index()
        {
            var values = _carStatusService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCarStatus()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TInsert(carStatus);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCarStatus(int id)
        {
            var value = _carStatusService.TGetByID(id);
            _carStatusService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCarStatus(int id)
        {
            var values = _carStatusService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TUpdate(carStatus);
            return RedirectToAction("Index");
        }
    }
}
