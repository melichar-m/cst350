using activity1_mmelichar.Models;
using activity1_mmelichar.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;

namespace activity1_mmelichar.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsDAO _repository;

        public ProductsController()
        {
            _repository = new ProductsDAO();
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(_repository.AllProducts());
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult SearchResults(string searchTerm)
        {
            List<ProductModel> productList = _repository.SearchProducts(searchTerm);
            return View("Index", productList);
        }

        public ActionResult SearchForm()
        {
            return View();
        }

        public ActionResult ShowOneProduct(int Id)
        {
            return View(_repository.GetProductById(Id));
        }

        public ActionResult Welcome()
        {
            ViewBag.name = "Mike";
            ViewBag.secretNumber = 2313;
            return View();
        }
        [HttpPost]
        public ActionResult ProcessEdit(ProductModel product)
        {
            //Debug.WriteLine("UpdateProduct method called");
            //if (ModelState.IsValid)
            //{
                _repository.Update(product);
                return View("Index",_repository.AllProducts());
            //}

            // If the model is not valid, redisplay the edit form
            //return View("Edit", product);
        }
        public ActionResult ShowEditForm(int id)
        {
            //Debug.WriteLine("GetEditProduct method called");

            return View(_repository.GetProductById(id));
        }
        public ActionResult Delete(ProductModel product)
        {
            _repository.Delete(product);
            return RedirectToAction("Index");
        }

    }
}
