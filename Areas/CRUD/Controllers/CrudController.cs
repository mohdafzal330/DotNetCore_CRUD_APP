using System.Linq;
using FirstDotNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstDotNetCoreApp.Areas.CRUD.Controllers
{
    [Area("CRUD")]

    public class CrudController : Controller
    {
        private readonly CrudDBContext _context;
        public CrudController(CrudDBContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            return Content("Index content");
        }
        public ActionResult GetDetails(int id)
        {
            var result = _context.Products.Where(r => r.RowStatus == 1).ToList();
            return Json(result);
        }


        public ActionResult InsertProduct()
        {
            var product = new Product
            {
                Name = "Parrot",
                Description = "New Parrot",
                RowStatus = 1
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return Json(product.ProductId);
        }
        public ActionResult DeleteProduct(long id)
        {
            var result = _context.Products.FirstOrDefault(p => p.ProductId == id && p.RowStatus == 1);
            if (result != null)
            {
                result.RowStatus = 0;
                _context.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Json("Success");
        }
    }
}