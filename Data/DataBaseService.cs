using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace testDemka.Data
{
    public static class DatabaseService
    {
        private static string _DATABASECONNECTION = "Host=localhost;Port=5439;Database='ObuvDB';Username='postgres';Password='1210'";

        public static NpgsqlConnection GetConnection()
        {
            var dataBaseConnection = new NpgsqlConnection(_DATABASECONNECTION);
            try
            {
                dataBaseConnection.Open();
                return dataBaseConnection;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }

        public static DataTable ExecuteQuery(string sql, params NpgsqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (var connection = GetConnection())
            {
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    MessageBox.Show("Ошибка подключения к БД", "Ошибка");
                    return dataTable;
                }

                try
                {
                    using (var cmd = new NpgsqlCommand(sql, connection))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}\nSQL: {sql}", "Ошибка");
                }
            }

            return dataTable;
        }

        public static User GetUserWithRole(string login, string password)
        {
            string sql = @"
            SELECT u.*, r.role as role_name 
            FROM users u
            JOIN roles r ON u.roleID = r.id
            WHERE u.login = @login AND u.password = @password";

            var result = ExecuteQuery(sql,
                new NpgsqlParameter("@login", login),
                new NpgsqlParameter("@password", password));

            return result.Rows.Count > 0 ? User.FromDataRow(result.Rows[0]) : null;
        }
    }
}