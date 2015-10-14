
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Models.Code;
using Microsoft.Data.Entity;
using LSDS.Tdms.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Framework.DependencyInjection;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Security.Claims;

namespace LSDS.Tdms.Controllers
{
  
    public class LoginController : Controller
    {
        private TdmsDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _applicationDbContext;
        private static bool _databaseChecked;

        public LoginController(TdmsDbContext context, UserManager<ApplicationUser> userManager,
         SignInManager<ApplicationUser> signInManager,
         ApplicationDbContext applicationDbContext)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _applicationDbContext = applicationDbContext;
        }
      

        public  IActionResult  Login()
        {
            ViewBag.Version = _context.Set<UspReturnVersion>().FromSql("Usp_ReturnVersion")?.FirstOrDefault()?.project_name ?? "No Version!";
            return View();
        }
        [Authorize]
        public IActionResult PasswordChange(UserLogin user)
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult Login(UserLogin user)
        {           
    
            if (user.IsValid(user.UserName, user.Password, _context))
            {                
                RemoveFindSortState(user.UserName, _context);

          
                return user.PasswordChange
                            ? View("~/Views/Login/PasswordChange.cshtml", user)
                            : View("~/Views/Home/TdmsPortal.cshtml");
                }
            ModelState.AddModelError("LoginError", "Login data is incorrect!");
            return View(user);
        }

     
        private static void RemoveFindSortState(string userName, TdmsDbContext context)
        {
             var removeStateFindSort = new ReturnQuickFindSort(context);
             removeStateFindSort.RemoveLastUsedTodaySortingForUsername(userName);
             removeStateFindSort.RemoveLastUsedTodayFindUserName(userName);
        }

        [HttpPost]
       public IActionResult Password(UserLogin user)
        {
            if (!ModelState.IsValid) return RedirectToAction("Login", "Login");
            if (!user.IsValid(user.UserName, user.Password,_context)) return RedirectToAction("Login", "Login");

           if (user.NewPassword != user.ConfirmPassword)
            {
                ModelState.AddModelError("ErrorMsg", "Password do not match!");
                return View("~/Views/Login/PasswordChange.cshtml", user);
               
            }
            try
            {
                var passwordResponse = ""; //TDMSControllerBase.ChangePassword(user.UserName, user.NewPassword);
                if (passwordResponse == "")
                {
                    RedirectToAction("TdmsPortal", "Home");
                }
                else
                {
                    ModelState.AddModelError("ErrorMsg", passwordResponse.Replace(@"\r\n",""));
                    return View("~/Views/Login/PasswordChange.cshtml", user);
                }
            }
            catch (System.Exception ex)
            {
                var err = "ERROR: " + ex.Message + "<br/>" + ex.StackTrace;
                ModelState.AddModelError("ErrorMsg", err);
                return View("~/Views/Login/PasswordChange.cshtml", user);
            }
            return RedirectToAction("TdmsPortal", "Home");

        }

        [AllowAnonymous]
        public IActionResult Logout()
        {
            //FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
        
        
    }
}