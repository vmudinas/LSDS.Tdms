using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tdms.Controllers
{
    public class MenuController : Controller
    {
        private static readonly Repository _DataAccessLibrary = new Repository();

        [AcceptVerbs]
        public async Task<JsonResult> GetMenu()
        {
            var menu = await _DataAccessLibrary.GetMenu(User.Identity.Name);

            var menuList = new List <TdmsMenu>();
            var returnTdmsMenuResults = menu as usp_returnTDMSMenu_Result[] ?? menu.ToArray();
            var menuTemp = returnTdmsMenuResults;


            var menuHome = new TdmsMenu {text = "Home"};

          //  if (Request.Url != null)
          //          menuHome.url = Request.Url.ToString().Replace("Menu/GetMenu", "") + "Home" + "/" + "TdmsPortal";
           

            menuList.Add(menuHome);



            foreach (var item in returnTdmsMenuResults)
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