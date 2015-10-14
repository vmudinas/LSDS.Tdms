using LSDS.Tdms.Models;
using LSDS.Tdms.Models.Code;
using LSDS.Tdms.Models.TdmsDataModel;
using LSDS.Tdms.Repository;
using Microsoft.AspNet.Http.Internal;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;


namespace LSDS.Tdms.Controllers
{
    public class TDMSTradeSearchController : Controller
    {
        private TdmsDbContext _context;
        public TDMSTradeSearchController(TdmsDbContext context)
        {
            _context = context;
        }
        // private static readonly QuickFindSortRepository _DataAccessLibrary = new QuickFindSortRepository();
        // GET: TDMSTradeSearch
        public IActionResult TDMSTradeSearch()
        {
            return View();
        }
        public IActionResult TradeSearchSave(TdmsTradeListSeachModel model)
        {
            SaveSearch(model.txtPortfolio,model.txtCUSIP,model.txtBrokerFIN,model.txtUserCode,model.txtTradeDate.ToString(), model.txtSettleDate.ToString(), model.txtTranDate.ToString(), model.txtLoadDate.ToString(), model.txtTradeDate1.ToString(), model.txtSettleDate1.ToString(),
                        model.txtTranDate1.ToString(), model.txtLoadDate1.ToString(),model.txtCurrencyCode,model.txtTradeRef,model.txtConfirmRef,model.txtStockSymbol,model.txtBrokerCode,model.txtDTCAgentId,model.txtDTCAgentInternalAccountNo,model.drpTradeRefOp,model.drpConfirmRefOp,model.drpStockSymbolOp
                            ,model.drpBrokerCodeOp,model.drpDTCAgentIdOp,model.drpDTCAgentInternalAccountNoOp,model.drpDeleted,model.drpPortfolioOp,model.drpCUSIPOp,model.drpBrokerFINOp,model.drpUserCodeOp,model.drpMatchStatusOp,model.drpCurrCodeOp,model.drpTransactionCode, model.drpMatchStatus,model.historyArchiveCurrent);
            
            return View();
        }
        [HttpPost]
        public IActionResult QuickTradeSearchSave(FormCollection formCollection)
        {
            //SaveSearch(model.txtPortfolio,model.txtCUSIP,model.txtBrokerFIN,model.txtUserCode,model.txtTradeDate.ToShortDateString(), model.txtSettleDate.ToShortDateString(), model.txtTranDate.ToShortDateString(), model.txtLoadDate.ToShortDateString(), model.txtTradeDate1.ToShortDateString(), model.txtSettleDate1.ToShortDateString(),
            //            model.txtTranDate1.ToShortDateString(), model.txtLoadDate1.ToShortDateString(),model.txtCurrencyCode,model.txtTradeRef,model.txtConfirmRef,model.txtStockSymbol,model.txtBrokerCode,model.txtDTCAgentId,model.txtDTCAgentInternalAccountNo,model.drpTradeRefOp,model.drpConfirmRefOp,model.drpStockSymbolOp
            //                ,model.drpBrokerCodeOp,model.drpDTCAgentIdOp,model.drpDTCAgentInternalAccountNoOp,model.drpDeleted,model.drpPortfolioOp,model.drpCUSIPOp,model.drpBrokerFINOp,model.drpUserCodeOp,model.drpMatchStatusOp,model.drpCurrCodeOp,model.drpTransactionCode, model.drpMatchStatus,model.historyArchiveCurrent);

            var valueList = formCollection.Cast<object>().ToDictionary(item => item.ToString(), item => formCollection[item.ToString()]);
           
// exec usp_SaveQuickFind @user_name = 'testuser',@SourceName='TradeBrowser', @Description = '', @LastUsed=0, @LastUsedToday=0
            var quickFind = SaveQuickFind("TradeBrowser", formCollection["quickFindText"], false, false);
            return View("~/Views/TDMSTradeSearch/TDMSTradeSearch.cshtml");
        }
        
        public int GetUserGroupId()
        {
            
            //try
            //{
            //    var userGroup = -1;

            //    var userDs = new UserDS();
            //    var userDalc = new UserDalc(User.Identity.Name);

            //    userDalc.GetUserByUserId(userDs, User.Identity.Name);

            //    if (userDs.Tables["sxapplication_user"].Rows.Count > 0 && userDs.Tables["sxapplication_user"].Rows[0]["tdUserGroupId"] != DBNull.Value)
            //        Int32.TryParse(userDs.Tables["sxapplication_user"].Rows[0]["tdUserGroupId"].ToString(), out userGroup);

            //    return userGroup;
            //}
            //catch (System.Exception e)
            //{
            //   EventLog.CreateEventSource("TDMS",e.Message);
            //}
            return 0;
        }
        private void SaveSearch( string txtPortfolio, string txtCusip, string txtBrokerFin, string txtUserCode, string txtTradeDate, string txtSettleDate, string txtTranDate, string txtLoadDate, string txtTradeDate1, string txtSettleDate1, string txtTranDate1, string txtLoadDate1, string txtCurrencyCode, string txtTradeRef, string txtConfirmRef, string txtStockSymbol, string txtBrokerCode, 
            string txtDtcAgentId, string txtDtcAgentInternalAccountNo, string  drpTradeRefOp, string drpConfirmRefOp, string drpStockSymbolOp, string drpBrokerCodeOp, string drpDtcAgentIdOp
        , string drpDtcAgentInternalAccountNoOp, string drpDeleted, string drpPortfolioOp, string drpCusipOp, string drpBrokerFinOp, string drpUserCodeOp, string drpMatchStatusOp, string drpCurrCodeOp, string drpTransactionCode, string drpMatchStatus, string historyArchiveCurrent)
        {
         //   var findSort = new ReturnQuickFindSort();
         //   findSort.RemoveLastUsedTodayFindAll(User.Identity.Name, "TradeBrowser");
         //   findSort.RemoveLastSearchFindQuery(User.Identity.Name, "TradeBrowser");

         //   var quickfindId = 0;

         //   #region TAVITA commented: never access

         //   // bool blExistingQF = false;

         //   #endregion
         //   string strQueryString = "";
         //   //Return Quickfind Data for user/source
         //   //TDMSControllerNavGraph.SourceName = "TradeBrowser";
         ////   var controler = new TDMSControllerNavGraph {SourceName = "TradeBrowser"};
         // //  var quickfindDs = controler.GetQuickfind(User.Identity.Name, "TradeBrowser");
         //   var dvQuickfind = new DataView(quickfindDs.Tables["Quickfind"])
         //   {
         //       RowFilter = "Description = 'Last Search'"
         //   };

         //   //while (dvQuickfind.Count > 0)
         //   //{
         //   //    dvQuickfind[0].Delete();
         //   //}

         //   //If no search exists, create a new one and return the indentity on update,
         //   //else clear the queries
         //   if (dvQuickfind.Count > 0)
         //   {
         //       #region TAVITA commented: never access
         //       // blExistingQF = true;
         //       #endregion
         //       quickfindId = System.Int32.Parse(dvQuickfind[0]["QuickfindID"].ToString());
         //       findSort.SetLastUsedTodayFind(User.Identity.Name, "TradeBrowser", "Last Search");
         //   }
         //   else
         //   {
         //       var qRow = quickfindDs.Tables["Quickfind"].NewRow();
         //       //qRow["Description"] = "Search Result";
         //       qRow["Description"] = "Last Search";
         //       qRow["SourceName"] = "TradeBrowser";
         //      // qRow["tdUserGroupId"] = GetUserGroupId();
         //       qRow["user_name"] = User.Identity.Name;
         //       qRow["SystemQF"] = 1;
         //       qRow["LastUsed"] = 1;
         //       qRow["LastUsedToday"] =1;
         //       quickfindDs.Tables["Quickfind"].Rows.Add(qRow);

         //       //Update Database and retrieve Identity
         //       controler.UpdateQuickfind(quickfindDs);
         //       //quickfindDS = TDMSControllerNavGraph.GetQuickfind(this.TDMSUser);
         //       var dvQf = new DataView(quickfindDs.Tables["Quickfind"])
         //       {
         //           RowFilter = "Description = 'Last Search'"
         //       };
         //       quickfindId = int.Parse(dvQuickfind[0]["QuickfindID"].ToString());
         //   }

         //   //Delete Existing Queries
         //   var dvQuickfindQuery = new DataView(quickfindDs.Tables["Quickfind_Query"])
         //   {
         //       RowFilter = "QuickfindID = " + quickfindId.ToString()
         //   };
         //   while (dvQuickfindQuery.Count > 0)
         //   {
         //       dvQuickfindQuery[0].Delete();
         //   }

         //   //Add the Query from the screen

         //   //Add a Search Indicator - Used to indicate that Trade History Data is OK
         //   var queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //   queryRow["QuickfindID"] = quickfindId;
         //   queryRow["QueryString"] = "Search = 1";
         //   queryRow["QF_ColumnName"] = "Search";
         //   queryRow["QF_Operator"] = "=";
         //   queryRow["QF_Value1"] = "1";
         //   quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);

         //   if (!string.IsNullOrWhiteSpace(txtPortfolio))
         //   {
              
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "PortNo " + drpPortfolioOp;

         //           switch (drpPortfolioOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtPortfolio;

         //           switch (drpPortfolioOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }

         //           queryRow["QueryString"] = strQueryString;
         //           queryRow["QF_ColumnName"] = "PortNo";
         //           queryRow["QF_Operator"] = drpPortfolioOp;
         //           queryRow["QF_Value1"] = txtPortfolio;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
                
         //   }

         //   if (!string.IsNullOrWhiteSpace(txtCusip))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "CUSIP " + drpCusipOp;

         //           switch (drpCusipOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtCusip;

         //           switch (drpCusipOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }

         //           queryRow["QueryString"] = strQueryString;

         //           queryRow["QF_ColumnName"] = "CUSIP";
         //           queryRow["QF_Operator"] = drpCusipOp;
         //           queryRow["QF_Value1"] = txtCusip;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
              
         //   }

          
         //       if (!string.IsNullOrWhiteSpace(txtCurrencyCode))
         //   {
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "CurrencyCode " + drpCurrCodeOp + "'";

         //           if (drpCurrCodeOp.ToLower() == "like")
         //               strQueryString += "%";

         //           strQueryString += txtCurrencyCode;

         //           if (drpCurrCodeOp.ToLower() == "like")
         //               strQueryString += "%";

         //           strQueryString += "'";

         //           queryRow["QueryString"] = strQueryString;

         //           queryRow["QF_ColumnName"] = "CurrencyCode";
         //           queryRow["QF_Operator"] = drpCurrCodeOp;
         //           queryRow["QF_Value1"] = txtCurrencyCode;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
         //       }



         //       if (!string.IsNullOrWhiteSpace(txtTradeDate) && !txtTradeDate.Contains("1/1/0001"))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;



         //           if (!string.IsNullOrWhiteSpace(txtTradeDate1))
         //            queryRow["QueryString"] = "((Traded = '" + txtTradeDate + "' OR Traded > '" + txtTradeDate + "') AND (Traded = '" + txtTradeDate1 + "' OR Traded < '" + txtTradeDate1 + "'))";
         //           else if (!string.IsNullOrWhiteSpace(txtTradeDate) && !string.IsNullOrWhiteSpace(txtTradeDate1))
         //               queryRow["QueryString"] = "(Traded = '" + txtTradeDate1 + "' OR Traded < '" + txtTradeDate1 + "')";
         //           else
         //               queryRow["QueryString"] = "(Traded = '" + txtTradeDate + "' OR Traded > '" + txtTradeDate + "')";

         //           queryRow["QF_ColumnName"] = "Traded";
         //           //queryRow["QF_Operator"] = drpTradeDateOp.SelectedItem.Value;
         //           queryRow["QF_Operator"] = "range";
         //           queryRow["QF_Value1"] = txtTradeDate;
         //           queryRow["QF_Value2"] = txtTradeDate1;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
             
         //   }
         //       if (!string.IsNullOrWhiteSpace(txtSettleDate) && !txtSettleDate.Contains("1/1/0001"))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;




         //           if (!string.IsNullOrWhiteSpace(txtSettleDate))
         //               queryRow["QueryString"] = "((Settlement = '" + txtSettleDate + "' OR Settlement > '" + txtSettleDate + "') AND (Settlement = '" + txtSettleDate1 + "' OR Settlement < '" + txtSettleDate1 + "'))";
         //           else if (!string.IsNullOrWhiteSpace(txtSettleDate) && !string.IsNullOrWhiteSpace(txtSettleDate1))
         //               queryRow["QueryString"] = "(Settlement = '" + txtSettleDate1 + "' OR Settlement < '" + txtSettleDate1 + "')";
         //           else
         //               queryRow["QueryString"] = "(Settlement = '" + txtSettleDate + "' OR Settlement > '" + txtSettleDate + "')";


         //           queryRow["QF_ColumnName"] = "Settlement";
         //           //queryRow["QF_Operator"] = drpSettleDateOp.SelectedItem.Value;
         //           queryRow["QF_Operator"] = "range";
         //           queryRow["QF_Value1"] = txtSettleDate;
         //           queryRow["QF_Value2"] = txtSettleDate1;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
              
         //   }

          
         //       if (!string.IsNullOrWhiteSpace(txtTranDate) && !txtTranDate.Contains("1/1/0001"))
         //   {
                
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           if (!string.IsNullOrWhiteSpace(txtTranDate1))
         //               queryRow["QueryString"] = "((TranDate = '" + txtTranDate + "' OR TranDate > '" + txtTranDate + "') AND (TranDate = '" + txtTranDate1 + "' OR TranDate < '" + txtTranDate1 + "'))";
         //           else if (!string.IsNullOrWhiteSpace(txtTranDate) && !string.IsNullOrWhiteSpace(txtTranDate1))
         //               queryRow["QueryString"] = "(TranDate = '" + txtTranDate1 + "' OR TranDate < '" + txtTranDate1 + "')";
         //           else
         //               queryRow["QueryString"] = "(TranDate = '" + txtTranDate + "' OR TranDate > '" + txtTranDate + "')";


         //           queryRow["QF_ColumnName"] = "TranDate";
         //           //queryRow["QF_Operator"] = drpSettleDateOp.SelectedItem.Value;
         //           queryRow["QF_Operator"] = "range";
         //           queryRow["QF_Value1"] = txtTranDate;
         //           queryRow["QF_Value2"] = txtTranDate1;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
             
         //   }
         //   /**LoadDate****************************/

         //       if (!string.IsNullOrWhiteSpace(txtLoadDate) && !txtLoadDate.Contains("1/1/0001"))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           if (!string.IsNullOrWhiteSpace(txtLoadDate1))
         //               queryRow["QueryString"] = "((TransactionLoadDate = '" + txtLoadDate + "' OR TransactionLoadDate > '" + txtLoadDate + "') AND (TransactionLoadDate = '" + txtLoadDate1 + "' OR TransactionLoadDate < '" + txtLoadDate1 + "'))";
         //           else if (!string.IsNullOrWhiteSpace(txtLoadDate) && !string.IsNullOrWhiteSpace(txtLoadDate1))
         //               queryRow["QueryString"] = "(TransactionLoadDate = '" + txtLoadDate1 + "' OR TransactionLoadDate < '" + txtLoadDate1 + "')";
         //           else
         //               queryRow["QueryString"] = "(TransactionLoadDate = '" + txtLoadDate + "' OR TransactionLoadDate > '" + txtLoadDate + "')";


         //           queryRow["QF_ColumnName"] = "TransactionLoadDate";
         //           //queryRow["QF_Operator"] = drpSettleDateOp.SelectedItem.Value;
         //           queryRow["QF_Operator"] = "range";
         //           queryRow["QF_Value1"] = txtLoadDate;
         //           queryRow["QF_Value2"] = txtLoadDate1;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
               
         //   }
         //   /**************************************/
         //   if (drpTransactionCode != "Select")
         //   {
         //       queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //       queryRow["QuickfindID"] = quickfindId;
         //       queryRow["QueryString"] = "mTransactionCode = '" + drpTransactionCode + "'";
         //       queryRow["QF_ColumnName"] = "mTransactionCode";
         //       queryRow["QF_Operator"] = "=";
         //       queryRow["QF_Value1"] = drpTransactionCode;
         //       quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);

         //   }

        
         //       if (!string.IsNullOrWhiteSpace(txtBrokerFin))
         //   {
              
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "BFIN " + drpBrokerFinOp;

         //           switch (drpBrokerFinOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtBrokerFin;

         //           switch (drpBrokerFinOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           queryRow["QueryString"] = strQueryString;

         //           queryRow["QF_ColumnName"] = "BFIN";
         //           queryRow["QF_Operator"] = drpBrokerFinOp;
         //           queryRow["QF_Value1"] = txtBrokerFin;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
               
         //   }


         
         //       if (!string.IsNullOrWhiteSpace(txtUserCode))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "UserCode " + drpUserCodeOp;

         //           switch (drpUserCodeOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtUserCode;

         //           switch (drpUserCodeOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           queryRow["QueryString"] = strQueryString;

         //           queryRow["QF_ColumnName"] = "UserCode";
         //           queryRow["QF_Operator"] = drpUserCodeOp;
         //           queryRow["QF_Value1"] = txtUserCode;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
               
         //   }


         //   if (!string.IsNullOrWhiteSpace(txtTradeRef))
         //   {
              
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "TdRef " + drpTradeRefOp;

         //           switch (drpTradeRefOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtTradeRef;

         //           switch (drpTradeRefOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }

         //           queryRow["QueryString"] = strQueryString;
         //           queryRow["QF_ColumnName"] = "TdRef";
         //           queryRow["QF_Operator"] = drpTradeRefOp;
         //           queryRow["QF_Value1"] = txtTradeRef;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
               
         //   }
       
         //       if (!string.IsNullOrWhiteSpace(txtConfirmRef))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;


         //           strQueryString = "ConfirmRefNo " + drpConfirmRefOp;

         //           switch (drpConfirmRefOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtConfirmRef;

         //           switch (drpConfirmRefOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }

         //           queryRow["QueryString"] = strQueryString;

         //           queryRow["QF_ColumnName"] = "ConfirmRefNo";
         //           queryRow["QF_Operator"] = drpConfirmRefOp;
         //           queryRow["QF_Value1"] = txtConfirmRef;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
             
         //   }

         //   if (!string.IsNullOrWhiteSpace(txtStockSymbol))
         //   {
            
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "Ticker " + drpStockSymbolOp;

         //           switch (drpStockSymbolOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtStockSymbol;

         //           switch (drpStockSymbolOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }

         //           queryRow["QueryString"] = strQueryString;
         //           queryRow["QF_ColumnName"] = "Ticker";
         //           queryRow["QF_Operator"] = drpStockSymbolOp;
         //           queryRow["QF_Value1"] = txtStockSymbol;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
               
         //   }

         //   if (!string.IsNullOrWhiteSpace(txtBrokerCode))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "BCode " + drpBrokerCodeOp;

         //           switch (drpBrokerCodeOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "'%";
         //                   break;

         //               case "in":
         //                   strQueryString += "('";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           strQueryString += txtBrokerCode;

         //           switch (drpBrokerCodeOp.ToLower())
         //           {
         //               case "like":
         //                   strQueryString += "%'";
         //                   break;

         //               case "in":
         //                   strQueryString = strQueryString.Replace(",", "','");
         //                   strQueryString += "')";
         //                   break;

         //               default:
         //                   strQueryString += "'";
         //                   break;
         //           }
         //           queryRow["QueryString"] = strQueryString;
         //           queryRow["QF_ColumnName"] = "BCode";
         //           queryRow["QF_Operator"] = drpBrokerCodeOp;
         //           queryRow["QF_Value1"] = txtBrokerCode;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
              
         //   }

         //  if (!string.IsNullOrWhiteSpace(txtDtcAgentId))
         //   {

         //       queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //       queryRow["QuickfindID"] = quickfindId;

         //       strQueryString = "DTCAgentId " + drpDtcAgentIdOp + "'";

         //       if (drpDtcAgentIdOp.ToLower() == "like")
         //           strQueryString += "%";

         //       strQueryString += txtDtcAgentId;

         //       if (drpDtcAgentIdOp.ToLower() == "like")
         //           strQueryString += "%";

         //       strQueryString += "'";
         //       queryRow["QueryString"] = strQueryString;
         //       queryRow["QF_ColumnName"] = "DTCAgentId";
         //       queryRow["QF_Operator"] = drpDtcAgentIdOp;
         //       queryRow["QF_Value1"] = txtDtcAgentId;
         //       quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
         //   }

         //   if (!string.IsNullOrWhiteSpace(txtDtcAgentInternalAccountNo))
         //   {
               
         //           queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //           queryRow["QuickfindID"] = quickfindId;

         //           strQueryString = "DTCAgentInternalAccountNo " + drpDtcAgentInternalAccountNoOp + "'";

         //           if (drpDtcAgentInternalAccountNoOp.ToLower() == "like")
         //               strQueryString += "%";

         //           strQueryString += txtDtcAgentInternalAccountNo;

         //           if (drpDtcAgentInternalAccountNoOp.ToLower() == "like")
         //               strQueryString += "%";

         //           strQueryString += "'";
         //           queryRow["QueryString"] = strQueryString;
         //           queryRow["QF_ColumnName"] = "DTCAgentInternalAccountNo";
         //           queryRow["QF_Operator"] = drpDtcAgentInternalAccountNoOp;
         //           queryRow["QF_Value1"] = txtDtcAgentInternalAccountNo;
         //           quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
               
         //   }

         //   if (drpMatchStatus != "Select")
         //   {
         //       queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //       queryRow["QuickfindID"] = quickfindId;
         //       queryRow["QueryString"] = "Status " + drpMatchStatusOp + " '" + drpMatchStatus + "'";
         //       queryRow["QF_ColumnName"] = "Status";
         //       queryRow["QF_Operator"] = drpMatchStatusOp;
         //       queryRow["QF_Value1"] = drpMatchStatus;
         //       quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
         //   }

         //   if (drpDeleted != "Yes")
         //   {
         //       queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //       queryRow["QuickfindID"] = quickfindId;
         //       queryRow["QueryString"] = "Deleted = '" + drpDeleted + "'";
         //       queryRow["QF_ColumnName"] = "Deleted";
         //       queryRow["QF_Operator"] = "=";
         //       queryRow["QF_Value1"] = drpDeleted;
         //       quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
         //   }

         //   if (historyArchiveCurrent == "Archive")
         //   {
         //       queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //       queryRow["QuickfindID"] = quickfindId;
         //       queryRow["QueryString"] = "Archived = 1";
         //       queryRow["QF_ColumnName"] = "Archived";
         //       queryRow["QF_Operator"] = "=";
         //       queryRow["QF_Value1"] = "1";
         //       quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
         //   }


         //   if (historyArchiveCurrent == "History")
         //   {
         //       queryRow = quickfindDs.Tables["Quickfind_Query"].NewRow();
         //       queryRow["QuickfindID"] = quickfindId;
         //       queryRow["QueryString"] = "History = 1";
         //       queryRow["QF_ColumnName"] = "History";
         //       queryRow["QF_Operator"] = "=";
         //       queryRow["QF_Value1"] = "1";
         //       quickfindDs.Tables["Quickfind_Query"].Rows.Add(queryRow);
         //   }
         
         //   //Update the Quickfind Tables
         //   var strReturn = controler.UpdateQuickfind(quickfindDs);
        }

        private IEnumerable<QuickfindMC> SaveQuickFind(string source, string description, bool lastUsed, bool lastUsedToday)
        {
            var rep = new QuickFindSortRepository(_context);
            return rep.SaveQuickFind(User.Identity.Name, source, description,
                lastUsed, lastUsedToday);

        }
      

    }
}