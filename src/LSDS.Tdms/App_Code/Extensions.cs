using Antlr.Runtime.Misc;
using Microsoft.Data.Entity.Relational;
using Microsoft.Data.Entity.Storage;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Tdms
{
    public static class Extensions
    {
        public static int ConvertToInt(this string source)
        {
            int num2;
            return int.TryParse(source, out num2) ? num2 : num2;
        }

        public static float ConvertToFloat(this string strInt)
        {
            float num2;
            return float.TryParse(strInt, out num2) ? num2 : num2;
        }

        public static byte[] GetBytes(this string str)
        {
            var bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(this byte[] bytes)
        {
            var chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public static int ExecuteSqlCommand(this RelationalDatabase database, string sql)
        {
            var connection = database.Connection;
            var command = connection.DbConnection.CreateCommand();
            command.CommandText = sql;

            try
            {
                connection.Open();

                return command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
        public static int ExecuteSqlCommand(this RelationalDatabase database, string sql, SqlParameter[] paramArray)
        {
            var connection = database.Connection;
            var command = connection.DbConnection.CreateCommand();
            command.CommandText = sql;
            foreach (var item in paramArray)
            {
                command.Parameters.Add(item);
            }

            try
            {
                connection.Open();

                return command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
        public static IDataReader ExecuteSqlCommandModel(this RelationalDatabase database, string sql)
        {
            var connection = database.Connection;
            var command = connection.DbConnection.CreateCommand();
            command.CommandText = sql;

            try
            {
                connection.Open();
                return command.ExecuteReader();
            }
            finally
            {
                connection.Close();
            }
        }
        public  static IEnumerable<T> GetData<T>(IDataReader reader, Func<IDataRecord, T> BuildObject)
        {
            try
            {
                while (reader.Read())
                {
                    yield return BuildObject(reader);
                }
            }
            finally
            {
                reader.Dispose();
            }
        }

    }

}
