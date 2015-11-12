using System;
using LSDS.Tdms.Models;
using LSDS.Tdms.Models.TdmsDataModel;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Framework.DependencyInjection;


namespace LSDS.Tdms.Controllers
{
    public class MenuController : Controller
    {
        // private static readonly Repository _DataAccessLibrary = new Repository();

        private TdmsDbContext _context;
        private readonly ApplicationUser _identity;

        public MenuController(IServiceProvider services)
        {
            _context = services.GetService<TdmsDbContext>();

        }

        [AcceptVerbs]
        public JsonResult GetMenu()
        { 
            //var schema = this.Context.Request.Scheme;

            var menu = _context.Set<usp_returnTDMSMenu_Result>().FromSql("EXEC usp_returnTDMSMenu @p0", User.Identity.Name);
            var menuTemp = menu;
            var menuList = new List <TdmsMenu>();
           
            var menuHome = new TdmsMenu {text = "Home", url = Url.Action("TdmsPortal", "Home") };
            menuList.Add(menuHome);


            foreach (var item in menu.ToList())
            {
                if (item.item_parent != null) continue;
                var menuR = new TdmsMenu {text = item.item_desc};
                if (item.item_type_desc.ToLower().Contains("view"))
                {
                    if (item.item_name != null)
                        menuR.url = Url.Action(item.item_name, item.item_name);
                }
                if (item.item_bitmap != null)
                    menuR.ImageUrl = Url.Content("~/Images/" + item.item_bitmap);


                menuR.ItemSortCode = item.item_sortcode;
                menuR.ItemParent = item.item_window;
                IEnumerable<usp_returnTDMSMenu_Result> uspReturnTdmsMenuResults = menuTemp.ToArray();
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
                    if (item.item_name != null)
                        newChild.url = Url.Action(item.item_name,item.item_name);
                }
                if (item.item_bitmap != null)
                    newChild.ImageUrl = Url.Content("~/Images/" +  item.item_bitmap);


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