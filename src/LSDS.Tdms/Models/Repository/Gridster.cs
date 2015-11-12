using System;
using System.Collections.Generic;
using System.Linq;
using LSDS.Tdms.Models.TdmsDataModel;
using System.Threading.Tasks;

namespace LSDS.Tdms.Repository
{
    public class Gridster : GenericRepository<tdGridsterModel>
    {
        GenericRepository<tdGridsterModel> rep = new GenericRepository<tdGridsterModel>();
        public List<tdGridsterModel> GetGridster(string userName)
        {
            var newGridster = new List<tdGridsterModel>();
          
                var query = rep.GetAll().Where(c => c.user_name == userName);
               
                foreach (var value in query)
                {
                    var retriedGridItem = value;
                    rep.Edit(retriedGridItem);
                    newGridster.Add(retriedGridItem);
                }
            
            return newGridster;
        }

        public async void UpdateGridster(List<tdGridsterModel> list, string userName)
        {
           
                var query = rep.GetAll().Where(c => c.user_name == userName);  //Perform a bulk delete operation
                foreach(var item in query)
                {
                     await rep.DeleteAsync(item);
                }         
         

                foreach (var gridModel in list)
                {
                    gridModel.user_name = userName;
                    gridModel.id = Guid.NewGuid().ToString();
                    await rep.InsertAsync(gridModel);
                }
             
        }
    }
}