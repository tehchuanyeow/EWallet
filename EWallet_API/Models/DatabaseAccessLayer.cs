using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EWallet_ClassLibrary;

namespace EWallet.Models
{
    public class DatabaseAccessLayer
    {
        private SqlConnection SqlConnection { get; set; }

        public string connectionString { get; set; }


        public DatabaseAccessLayer()
        {
            connectionString = @"Server=tcp:e-wallet-server.database.windows.net,1433;Initial Catalog=E-Wallet;Persist Security Info=False;User ID={EWalletAdmin};Password={password1!};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        //Admin Class
        public List<Admin> QueryAdmin(string query, Dictionary<string, string> arguments)
        {
            SqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlConnection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            SqlCommand sqlCommand = new SqlCommand(query, SqlConnection);

            if (arguments != null)
                foreach (var item in arguments)
                    sqlCommand.Parameters.Add(new SqlParameter(@"@" + item.Key, item.Value));

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Admin> results = new List<Admin>();

            while (sqlDataReader.Read())
            {
                Admin admin = new Admin(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetString(4), sqlDataReader.GetInt32(5));

                results.Add(admin);
            }

            SqlConnection.Close();

            return results;
        }

        //Account Class
        public List<Account> QueryAccount(string query, Dictionary<string, string> arguments)
        {
            SqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlConnection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            SqlCommand sqlCommand = new SqlCommand(query, SqlConnection);

            if (arguments != null)
                foreach (var item in arguments)
                    sqlCommand.Parameters.Add(new SqlParameter(@"@" + item.Key, item.Value));

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Account> results = new List<Account>();

            while (sqlDataReader.Read())
            {
                Account account = new Account(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetFloat(3));

                results.Add(account);
            }

            SqlConnection.Close();

            return results;
        }

        //
        public List<Admin> QueryAdmin(string query, Dictionary<string, string> arguments)
        {
            SqlConnection = new SqlConnection(connectionString);

            try
            {
                SqlConnection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            SqlCommand sqlCommand = new SqlCommand(query, SqlConnection);

            if (arguments != null)
                foreach (var item in arguments)
                    sqlCommand.Parameters.Add(new SqlParameter(@"@" + item.Key, item.Value));

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Admin> results = new List<Admin>();

            while (sqlDataReader.Read())
            {
                Admin admin = new Admin(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetString(4), sqlDataReader.GetInt32(5));

                results.Add(admin);
            }

            SqlConnection.Close();

            return results;
        }

        public void NonQuery(string query, Dictionary<string, string> arguments)
        {
            SqlConnection = new SqlConnection(connectionString);

            try
            {

                SqlConnection.Open();
            }
            catch (SqlException)
            {
                throw;
            }

            SqlCommand sqlCommand = new SqlCommand(query, SqlConnection);


            foreach (var argument in arguments)
                sqlCommand.Parameters.Add(new SqlParameter(@"@" + argument.Key, argument.Value));

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }



            SqlConnection.Close();

        }
    }
}
