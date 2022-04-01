using CvAsp2.Models;
using CvAsp2.Tool;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model_Data_Acces_Layer.Repository;

namespace CvAsp2.Controllers
{
    public class InfoPersoController : Controller
    {

        private IInfoPersoRepository _perso;
        private ICompétenceRepository _compService;
        private IExpérienceRepository _expService;

        public InfoPersoController(IInfoPersoRepository perso, ICompétenceRepository compService, IExpérienceRepository expService)
        {
            _perso = perso;
            _compService = compService;
            _expService = expService;
        }
        public IActionResult Index(int id = 0)
        {
            IndexViewModel model = new IndexViewModel();

            if (id == 0)
                model.InfoPerso = _perso.GetAll().Select(a => a.ToASP());

            return View(model);
        }
        public IActionResult Instance()
        {
            return Content(_perso.InstanceID.ToString());
        }

        

        [AuthRequired]
        public IActionResult Create()
        {
            InfoPersoForm form = new InfoPersoForm();
            return View(form);
        }

        [HttpPost]
        public IActionResult Create(InfoPersoForm form)
        {
            
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            try
            {
                _perso.Create(form.FormToDAL());
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
            return View(_perso.GetById(id).ToFormView());
        }
        [HttpPost]
        public IActionResult Edit(InfoPersoForm f)
        {
            if (!ModelState.IsValid) return View(f);

            _perso.Update(f.FormToDAL());

            return RedirectToAction("Index");
        }
    }
}