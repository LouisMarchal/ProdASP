using CvAsp2.Models;
using CvAsp2.Tool;
using Microsoft.AspNetCore.Mvc;
using Model_Data_Acces_Layer.Repository;

namespace CvAsp2.Controllers
{
    public class ExpérienceController : Controller
    {
        private readonly IExpérienceRepository _service;

        public ExpérienceController(IExpérienceRepository service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(ExpérienceForm form)
        {

            if (!ModelState.IsValid)
            {
                return View(form);
            }

            try
            {
                _service.Create(form.FormToDAL());
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(form);
            }
        }
        public IActionResult Edit(int id)
        {
            return View(_service.GetById(id).ToFormView());
        }
        [HttpPost]
        public IActionResult Edit(ExpérienceForm f)
        {
            if (!ModelState.IsValid) return View(f);

            _service.Update(f.FormToDAL());

            return RedirectToAction("Index");
        }
    }
}