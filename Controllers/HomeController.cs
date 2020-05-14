using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pos.ViewModel;
using POS.Models;
using Mapster;
using Microsoft.AspNetCore.Authorization;

namespace pos.Controllers
{
    public class HomeController : Controller
    {
        public UserManager<User> UserManager;
        public SignInManager<User> SignInManager;
        public HomeController(UserManager<User> UserManager, SignInManager<User> signInManager)
        {

            this.UserManager = UserManager;
            this.SignInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogIn(string ReturnUrl)
        {

            TempData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult admin()
        {
            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel userLogin)
        {

            if (ModelState.IsValid)
            {
                User user = await UserManager.FindByEmailAsync(userLogin.Email);
                if (user != null)
                {
                    await SignInManager.SignOutAsync(); // önceki cookieyi siliyor

                    Microsoft.AspNetCore.Identity.SignInResult result = await SignInManager.PasswordSignInAsync(user, userLogin.Password, userLogin.RememberMe, false);

                    if (result.Succeeded)
                    {
                        if (TempData["ReturnUrl"] != null)
                        {
                            return Redirect(TempData["ReturnUrl"].ToString());
                        }
                        return RedirectToAction("Admin", "Home");
                    }


                }

                else
                {
                    ModelState.AddModelError("", "geçersiz email Adresi veya şifresi");
                }

            }

            return View(userLogin);
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> SignUp(UserViewModel UserViewModel)
        {

            if (ModelState.IsValid)
            {
                User user = new User();
                user = UserViewModel.Adapt<User>();
                IdentityResult result = await UserManager.CreateAsync(user, UserViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("LogIn");
                }
                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }
            }
            return View(UserViewModel);

        }

        [Authorize]
        public IActionResult settings()
        {
            User user = UserManager.FindByNameAsync(User.Identity.Name).Result;
            UserViewModel userViewModel= new UserViewModel();
            userViewModel.UserName= user.UserName;
            userViewModel.Email= user.Email;
            userViewModel.PhoneNumber= user.PhoneNumber;
            

            
            return View(userViewModel);
        }
        

        [Authorize]
        public IActionResult ChangeUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUser(UserChangeViewModel userChangeViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = UserManager.FindByNameAsync(User.Identity.Name).Result;

                user.UserName= userChangeViewModel.UserName;
                user.PhoneNumber= userChangeViewModel.PhoneNumber;
                user.Email= userChangeViewModel.Email; 
                IdentityResult result = await UserManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    await UserManager.UpdateSecurityStampAsync(user);
                    await SignInManager.SignOutAsync();
                    await SignInManager.SignInAsync(user,true);
                    ViewBag.success="true";
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }

                
            }

            return View(userChangeViewModel);
        }
        public IActionResult PasswordChange()
        {
            return View();
        }
        
        [Authorize]
        [HttpPost]
        public IActionResult PasswordChange(PasswordChangeViewModel passwordChangeViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = UserManager.FindByNameAsync(User.Identity.Name).Result;



                bool exist = UserManager.CheckPasswordAsync(user, passwordChangeViewModel.PasswordOld).Result;
                if (exist)
                {
                    IdentityResult result = UserManager.ChangePasswordAsync
                    (user, passwordChangeViewModel.PasswordOld, passwordChangeViewModel.PasswordNew).Result;

                    if (result.Succeeded)
                    {
                        UserManager.UpdateSecurityStampAsync(user);
                        SignInManager.SignOutAsync();
                        SignInManager.PasswordSignInAsync(user,passwordChangeViewModel.PasswordNew,true,false);
                        ViewBag.success = true;
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Eski Şifreniz Yanlış");
                }







            }
            return View(passwordChangeViewModel);
        }

        public IActionResult LogOut()
        {
            SignInManager.SignOutAsync();
            return RedirectToAction("Anasayfa","Product");
        }
    
       
    }
}