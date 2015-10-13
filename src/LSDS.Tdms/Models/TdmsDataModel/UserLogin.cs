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


            var userLogin = _context.UserByUserName.FromSql<usp_returnUserbyUserName_Result>("EXEC usp_returnUserbyUserName @p0", username)?.Where(a=> a.psw == GetSwcMD5(password) && a.user_status == 0).FirstOrDefault();



            if (userLogin != null)
            {
                LogLoginAttempt(username, true, _context);
                return true;
            }

            LogLoginAttempt(username, false, _context);
            return false;
        }
        public static string GetSwcSH1(string value)
        {
            SHA1 algorithm = SHA1.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
        }
        public static string GetSwcMD5(string value)
        {
            MD5 algorithm = MD5.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
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

            var parameters = new[]
            {
                new SqlParameter
                {
                    ParameterName = "user_name",
                    Value = userId
                },
                new SqlParameter
                {
                    ParameterName = "LoginSuccess",
                    Value = loginSuccess
                }
            };
            context.Database.AsRelational().ExecuteSqlCommand("EXEC usp_LogLoginAttempt @user_name, @LoginSuccess   ", parameters);

        }
    }
}
  