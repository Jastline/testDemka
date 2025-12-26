using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace testDemka.Data
{
    public static class DatabaseService
    {
        private static string _dataBaseConnection = "Host=localhost,Port=5439,Database='ObuvDB',Username='postgres',Password='1210'";

        public static NpgsqlConnection GetConnection()
        {
            var dataBaseConnection = new NpgsqlConnection(_dataBaseConnection);
            try
            {
                dataBaseConnection.Open();
                return dataBaseConnection;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return dataBaseConnection;
            }
        }
    }
}