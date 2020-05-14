using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using POS.Models;

namespace POS.Controllers {
    public class ProductController : Controller {
        private IProductRepository repository;

        public ProductController (IProductRepository repo) {
            repository = repo;
        }

        [HttpGet]
        public IActionResult Index () {
            return View ();
        }
        [HttpGet]
        public IActionResult Anasayfa () {
            return View ();
        }

        [HttpGet]
        public IActionResult List () {
            return View (repository.Products);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create () {
            return View ();
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create (Product product, List<IFormFile> Image) {
            TryValidateModel (product);
            if (ModelState.IsValid) {

                foreach (var item in Image) {

                    using (var stream = new MemoryStream ()) {
                        await item.CopyToAsync (stream);
                        product.Image = stream.ToArray ();

                    }
                }

                repository.CreateProduct (product);
                return RedirectToAction ("List");
            }
            return View ("Create");
        }

       
        public IActionResult Delete (int id) {
            repository.DeleteProduct (id);
            return RedirectToAction ("List");

        }

    
        
    }
}