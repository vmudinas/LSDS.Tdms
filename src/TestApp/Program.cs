using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using LSDS.CTM;
using Microsoft.Framework.Configuration;

namespace TestApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Start");
            var tdInfoMsg = new InfoRequest("CM01", "813919292", 20150911083315, "MEOR", "BIC", "LIGHTSPD", "MERE", "TFID", "CTMSERVICE", "B", "TDET", "EXEC", "BIC", "AUTOBKMAXXX", "EXEC", "-893838900000098");
            var conn = new ConnectionManager("https", "ctmct.omgeo.net", "443", "/home/WS/DCILogin", "mudiv01", "Kla1peda17!", "", "", "", "", 30, 10, true);

            var newMsg = conn.SendMsg(tdInfoMsg);
            //newMsg.CtmId = ReturnUniqInt();

            var dbAccess = new Model1("data source=lds-devel4;initial catalog=tdmse_devel_5;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
          
            dbAccess.MyMessage.AddOrUpdate(newMsg);
            dbAccess.SaveChanges();

            Console.WriteLine("End");
        }

        private int ReturnUniqInt()
        {
            var random = new Random();
            return random.Next();

        }
    }
}
