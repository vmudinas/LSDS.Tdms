using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Tdms;

namespace LSDS.Tdms.Models.TdmsDataModel
{

    public class UserLogin
    {
     
       // [Display(Name = "Version")]
        public string Version { get; set; }

        [Required(ErrorMessage = "User name is required")]
       // [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
       // [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
       // [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
       // [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

       // [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        public bool PasswordChange { get; set; }

        /// <summary>
        ///     Checks if user with given password exists in the database
        /// </summary>
        /// <param name="username">User name</param>
        /// <param name="password">User password</param>
        /// <returns>True if user exist and password is correct</returns>
        public bool IsValid(string username, string password, TdmsDbContext _context)
        {
            //var parameters = new object[]
            //{
            //    new SqlParameter
            //    {
            //        ParameterName = "@user_name",
            //        Value = username
            //    }
            //};
            ////var TdmsDataAccess = new Repository.GenericRepository<usp_returnUserbyUserName_Result>();
            ////var userLogin = TdmsDataAccess.ExecuteStoredProcedure("usp_returnUserbyUserName",parameters);
            ////    var repo = new LSDS.Tdms.Entity();
            ////var userLogin = ""; 

            //var parameterDictionary = new IDictionary
            //{
            //    {"@user_name", username}
            //};


            var userLogin = _context.Set<usp_returnUserbyUserName_Result>().FromSql("EXEC usp_returnUserbyUserName @p0", username).FirstOrDefault(a => a.psw == GetSwcMd5(password) && a.user_status == 0);



            if (userLogin != null)
            {
                LogLoginAttempt(username, true, _context);
                return true;
            }

            LogLoginAttempt(username, false, _context);
            return false;
        }
        public static string GetSwcSh1(string value)
        {
            var algorithm = SHA1.Create();
            var data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            return data.Aggregate("", (current, t) => current + t.ToString("x2").ToUpperInvariant());
        }
        public static string GetSwcMd5(string value)
        {
            var algorithm = MD5.Create();
            var data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            return data.Aggregate("", (current, t) => current + t.ToString("x2").ToUpperInvariant());
        }
        public string ReturnPassword(string username)
        {
            var returnValue = "";

            var parameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "@user_name",
                    Value = username
                }
            };
            var TdmsDataAccess = new Repository.GenericRepository<usp_returnUserbyUserName_Result>();
            var userLogin = TdmsDataAccess.ExecuteStoredProcedure("usp_returnUserbyUserName",
                    parameters);

            foreach (var item in userLogin)
            {
                returnValue = item.psw;
            }

            return returnValue;
        }

        public string ChangePassword(string username)
        {
            //var returnValue = "";
            //using (var dbContext = new EntitiesModel())
            //{
            //    var usrName = new SqlParameter
            //    {
            //        ParameterName = "@user_name",
            //        Value = username
            //    };
            //}
            //return returnValue;
            throw new NotImplementedException();
        }

        private static void LogLoginAttempt(string userId, bool loginSuccess, TdmsDbContext context)
        {

            context.Database.ExecuteSqlCommand("EXEC usp_LogLoginAttempt @user_name, @LoginSuccess   ", userId, loginSuccess);

        }
    }
}
  