using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NavigationDrawerPopUpMenu2.classes;
using System.Data;
using MySql.Data.MySqlClient;

namespace NavigationDrawerPopUpMenu2.classes
{
    class Authentication
    {
        private string username;
        private string password;

        Database conn = new Database();

        public Authentication(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // If empty fields
        public Boolean isEmpty()
        {
            bool isEmptyField = false;
            if (this.username.Equals("") || this.password.Equals(""))
            {
                isEmptyField = true;
            }
            else
            {
                isEmptyField = false;
            }

            return isEmptyField;
        }

        // Check username
        public Boolean checkUsername()
        {
            bool isTrue = false;
            try
            {
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = conn.adapter();

                string query = "SELECT * FROM usersinventory WHERE usersName = @username";
                conn.query(query);

                conn.bind("@username", this.username);

                adapter.SelectCommand = conn.cmd();

                adapter.Fill(table);

                if (table.Rows.Count > 0) // Users Found
                {
                    isTrue = true;
                }
                else
                { // No Users Found
                    isTrue = false;
                }

                adapter.Dispose(); // Dispose Adapter
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                isTrue =  false;
            }
            
            return isTrue;

        }
        // Add User
        public void addUser(string privilege)
        {
            try
            {
                conn.Open();
                // Add User
                // Check if user is taken
                // IF NO ERROR 
                string query = "INSERT INTO usersinventory (usersName, usersPass, usersPrevileges) VALUES (@username, @password, @privilege)";
                // Hash/Encrypt Password
                var hashedPwd = BCrypt.Net.BCrypt.HashPassword(this.password);
                conn.query(query);


                conn.bind("@username", this.username);
                conn.bind("@password", hashedPwd);
                conn.bind("@privilege", privilege);
                conn.cmd().Prepare();
                // INSERT NEW USER
                var check = conn.execute();
                if (check == 1)
                {
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                conn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        // Get User Previlages
        public String getUserPrevilages()
        {
            string previleges = "";
            string query = "SELECT * FROM usersinventory WHERE usersName=@username";
            conn.query(query);
            conn.bind("@username", this.username);

            try
            {
                conn.Open();
                MySqlDataReader read = conn.read();
                if (read.Read())
                {
                    previleges = read["usersPrevileges"].ToString();
                }
                read.Close();
                read.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return previleges;
        }

        // Check User Password
        public Boolean checkUserPassword()
        {
            Boolean passwordCorrect = false;
            string pass = "";
            string query = "SELECT * FROM usersinventory WHERE usersName=@username";
            conn.query(query);
            conn.bind("@username", this.username);

            try
            {
                conn.Open();
                MySqlDataReader read = conn.read();
                if (read.Read())
                {
                    pass = read["usersPass"].ToString();
                }
                read.Close();
                read.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Check if users password is equal to db pass
            var checkPwd = BCrypt.Net.BCrypt.Verify(this.password, pass);
            if (checkPwd)
            {
                passwordCorrect = true;
            }
            else {
                passwordCorrect = false;
            }
            // Return Boolean
            return passwordCorrect;
            
        }
    }
}
