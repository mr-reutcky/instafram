using instafram.BLL;
using instafram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace instafram.Controllers
{
    public class DmController : Controller
    {
        private readonly DmService _dmService;
        private readonly UserService _userService;
        public DmController(DmService dmService)
        {
            _dmService = dmService;
        }

        // GET: Dm
        public IActionResult Index()
        {
            List<Dm> dms = _dmService.GetDms();
            return View(dms);
        }

        // GET: Dm/Details
        public IActionResult Details(int id)
        {
            var dm = _dmService.GetDm(id);
            if (dm == null)
            {
                return NotFound();
            }
            return View(dm);
        }

        // GET: Dm/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dm/Create
        [HttpPost]
        public IActionResult Create(Dm dm)
        {
            if (ModelState.IsValid)
            {
                _dmService.CreateDm(dm);
                return RedirectToAction(nameof(Index));
            }
            return View(dm);
        }

        // GET: Dm/Edit
        public IActionResult Edit(int id)
        {
            var dm = _dmService.GetDm(id);
            if (dm == null)
            {
                return NotFound();
            }
            return View(dm);
        }

        // POST: Dm/Edit
        [HttpPost]
        public IActionResult Edit(int id, Dm dm)
        {
            if (id != dm.Dmid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _dmService.UpdateDm(dm);
                return RedirectToAction(nameof(Index));
            }
            return View(dm);
        }

        // GET: Dm/Delete
        public IActionResult Delete(int id)
        {
            var dm = _dmService.GetDm(id);
            if (dm == null)
            {
                return NotFound();
            }
            return View(dm);
        }

        // POST: Dm/Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var dm = _dmService.GetDm(id);
            if (dm != null)
            {
                _dmService.DeleteDm(dm);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}