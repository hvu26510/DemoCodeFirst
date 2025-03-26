using DemoCodeFirst.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCodeFirst.Controllers
{
    public class ChuyenNganhController : Controller
    {
        private QLSVDbContext _context;
        public ChuyenNganhController(QLSVDbContext context)
        {
            _context = context;
        }
        // GET: ChuyenNganhController
        public ActionResult Index()
        {
            return View(_context.chuyenNganhs.ToList());
        }

        // GET: ChuyenNganhController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChuyenNganhController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChuyenNganhController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChuyenNganhController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChuyenNganhController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChuyenNganhController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChuyenNganhController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
