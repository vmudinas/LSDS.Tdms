using System;
using System.Collections.Generic;
using System.Linq;
using LSDS.Tdms.Models.TdmsDataModel;
using System.Threading.Tasks;
using LSDS.Tdms.Models;

namespace LSDS.Tdms.Repository
{
    public class Gridster : GenericRepository<tdGridsterModel>
    {
        GenericRepository<tdGridsterModel> rep = new GenericRepository<tdGridsterModel>();
        private TdmsDbContext _context;

        public List<tdGridsterModel> GetGridster(string userName, TdmsDbContext context)
        {
            _context = context;
            var newGridster = new List<tdGridsterModel>();

            var query = _context.Gridster.ToList<tdGridsterModel>().Where(c => c.user_name == userName);
               
                foreach (var value in query)
                {
                    var retriedGridItem = value;
                    _context.Gridster.Update(retriedGridItem);
                    newGridster.Add(retriedGridItem);
                }
            
            return newGridster;
        }

        public void UpdateGridster(List<tdGridsterModel> list, string userName, TdmsDbContext context)
        {
                _context = context;
                _context.Gridster.RemoveRange(_context.Gridster);

                foreach (var gridModel in list)
                {
                    gridModel.user_name = userName;
                    gridModel.id = Guid.NewGuid().ToString();               
                    _context.Gridster.Add(gridModel);
            }
             
        }
    }
}