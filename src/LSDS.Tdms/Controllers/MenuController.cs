using LSDS.Tdms.Models;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSDS.Tdms;
using Microsoft.AspNet.Identity;


namespace LSDS.Tdms.Controllers
{
    public class MenuController : Controller
    {
        // private static readonly Repository _DataAccessLibrary = new Repository();

        private TdmsDbContext _context;
        private readonly ApplicationUser _identity;

        public MenuController(TdmsDbContext context, ApplicationUser identity)
        {
            _context = context;
            _identity = identity;
         
        }

        [AcceptVerbs]
        public JsonResult GetMenu()
        {
            var menuX = _context.GetMenu;
          // var xxx = _identity.UserName;
            var repo = new Repository.Repository(_context);
            var menu =  repo.GetMenu("testuser");

            var menuList = new List <TdmsMenu>();
            var returnTdmsMenuResults = menu;// menu as usp_returnTDMSMenu_Result[] ?? menu.ToArray();
            var tdmsMenuResults = returnTdmsMenuResults as usp_returnTDMSMenu_Result[] ?? returnTdmsMenuResults.ToArray();
            var menuTemp = tdmsMenuResults;


            var menuHome = new TdmsMenu {text = "Home"};

          //  if (Request.Url != null)
          //          menuHome.url = Request.Url.ToString().Replace("Menu/GetMenu", "") + "Home" + "/" + "TdmsPortal";
           

            menuList.Add(menuHome);



            foreach (var item in tdmsMenuResults)
            {
                if (item.item_parent != null) continue;
                var menuR = new TdmsMenu {text = item.item_desc};
                if (item.item_type_desc.ToLower().Contains("view"))
                {
            //        if (Request.Url != null)
           //             menuR.url = Request.Url.ToString().Replace("Menu/GetMenu", "") + item.item_name + "/" + item.item_name;
                }
             //   if (Request.Url != null)
              //      menuR.ImageUrl = Request.Url.ToString().Replace("Menu/GetMenu", "")  + "Images/" + item.item_bitmap;
                    
                    
                menuR.ItemSortCode = item.item_sortcode;
                menuR.ItemParent = item.item_window;
                IEnumerable<usp_returnTDMSMenu_Result> uspReturnTdmsMenuResults = menuTemp as usp_returnTDMSMenu_Result[] ?? menuTemp.ToArray();
                var menuListTemp = AddChild(uspReturnTdmsMenuResults.ToList(), item.item_sortcode);
                if (menuListTemp.ToList().Count > 0)
                {
                    menuR.items = menuListTemp;
                }
                

                menuList.Add(menuR);
            }
        
            return Json(menuList.ToList());
        }

        private List<TdmsMenu> AddChild(List<usp_returnTDMSMenu_Result> menuPare, string itemSourceCode)
        {
            List<usp_returnTDMSMenu_Result> tempMenuList = menuPare;

            var newChildList = new List<TdmsMenu>();
            

            foreach (var item in tempMenuList)
            {
                if (itemSourceCode != item.item_window) continue;
                var newChild = new TdmsMenu {text = item.item_desc};

                if (item.item_type_desc.ToLower().Contains("view"))
                {
                  //  if (Request.Url != null)
                  //      newChild.url = Request.Url.ToString().Replace("Menu/GetMenu", "") + item.item_name + "/" +item.item_name;
                }
               // if (Request.Url != null)
                //    newChild.ImageUrl = Request.Url.ToString().Replace("Menu/GetMenu", "") + "Images/" +
                   //                     item.item_bitmap;


                List<TdmsMenu> menuListTemp = AddChild(tempMenuList, item.item_sortcode);
                if (menuListTemp.ToList().Count > 0)
                {
                    newChild.items = menuListTemp;
                }
                    
                newChild.ItemSortCode = item.item_sortcode;
                newChild.ItemParent = item.item_window;
                newChildList.Add(newChild);
            }
          
            return newChildList;
        }
      

    }
}