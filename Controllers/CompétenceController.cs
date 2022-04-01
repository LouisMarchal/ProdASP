using CvAsp2.Models;
using CvAsp2.Tool;
using Microsoft.AspNetCore.Mvc;
using Model_Data_Acces_Layer.Repository;

namespace CvAsp2.Controllers
{
    public class CompétenceController : Controller
    {
        private readonly ICompétenceRepository _repo;

        public CompétenceController(ICompétenceRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CompétenceForm form)
        {
            if (!ModelState.IsValid) return View(form);

            _repo.Create(form.Name);

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(_repo.GetById(id).ToFormView());
        }
        [HttpPost]
        public IActionResult Edit(CompétenceForm f)
        {
            if (!ModelState.IsValid) return View(f);

            _repo.Update(f.FormToDAL());

            return RedirectToAction("Index");
        }
    }
}