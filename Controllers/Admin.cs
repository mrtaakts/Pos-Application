using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using POS.Models;

namespace POS.Controllers {
    public class AdminController : Controller {

        private IUserRepository repository;
        private UserManager<User> userManager;

        public AdminController (UserManager<User> userManager) {
            this.userManager = userManager;
            //repository = repo;
        }
        public IActionResult Index () {
            return View (userManager.Users);
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        public IActionResult Create (User user) {
            // userManager.CreateUser(user);
            return View ();
        }
    }
}