using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Database
    {
        // CONFIG
        private const string DB_SERVER = "127.0.0.1";
        private const string DB_PORT = "3306";
        private const string DB_USER = "root";
        private const string DB_PASS = "";
        private const string DB_NAME = "iantestinventory";

        // MYSQL
        private MySqlConnection conn;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;
        private MySqlDataAdapter adp;

        public Database()
        {
            // Init Connection
            this.conn = new MySqlConnection($"datasource = {DB_SERVER}; port = {DB_PORT}; username = {DB_USER}; password = {DB_PASS}; database = {DB_NAME};");
        }

        // Query a SQL Statement
        public void query(string sql)
        {
            this.commandDatabase = new MySqlCommand(sql, this.conn);
            commandDatabase.CommandTimeout = 60;
        }

        // Return sql command
        public int execute() {
            return this.commandDatabase.ExecuteNonQuery();
        }

        // Execute Reader
        public MySqlDataReader read()
        {
            return this.reader = this.commandDatabase.ExecuteReader();
        }

        // Sql Adapter
        public MySqlDataAdapter adapter() {
            return this.adp = new MySqlDataAdapter(this.commandDatabase);
        }

        // Open the Database Conn
        public void Open()
        {
            this.conn.Open();
        }

        // Close the Database Conn
        public void Close()
        {
            this.conn.Close();
        }
    }
}
