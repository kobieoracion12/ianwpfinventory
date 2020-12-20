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
                conn.Open();
                string query = "SELECT * FROM usersinventory WHERE usersName = @username AND userStatus = @status";
                conn.query(query);
                conn.bind("@username", this.username);
                conn.bind("@status", "Active");
                conn.cmd().Prepare();
                MySqlDataReader dr = conn.read();
                if (dr.HasRows)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                isTrue = false;
                MessageBox.Show("Something went wrong when trying to login, try again later\n" +ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            return isTrue;

        }

        // Add User
        public void addUser(string privilege, string accNumber)
        {
            try
            {
                conn.Open();
                // Add User
                // Check if user is taken
                // IF NO ERROR 
                string query = "INSERT INTO usersinventory (acc_no, usersName, usersPass, usersPrevileges) VALUES (@acc_no, @username, @password, @privilege)";
                // Hash/Encrypt Password
                var hashedPwd = BCrypt.Net.BCrypt.HashPassword(this.password);
                conn.query(query);

                conn.bind("@acc_no", accNumber);
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
                conn.Close();
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
                conn.Close();
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

                // Check if users password is equal to db pass
                var checkPwd = BCrypt.Net.BCrypt.Verify(this.password, pass);
                if (checkPwd)
                {
                    passwordCorrect = true;
                }
                else
                {
                    passwordCorrect = false;
                }

            }
            catch (Exception)
            {
                conn.Close();
            }
            // Return Boolean
            return passwordCorrect;
        }

        public Boolean checkUserPasswordByAccNo(string accNo)
        {
            Boolean passwordCorrect = false;
            string pass = "";
            string query = "SELECT * FROM usersinventory WHERE acc_no=@accNo";
            conn.query(query);
            conn.bind("@accNo", accNo);

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

                // Check if users password is equal to db pass
                var checkPwd = BCrypt.Net.BCrypt.Verify(this.password, pass);
                if (checkPwd)
                {
                    passwordCorrect = true;
                }
                else
                {
                    passwordCorrect = false;
                }

            }
            catch (Exception)
            {
                conn.Close();
            }
            // Return Boolean
            return passwordCorrect;
        }

        public String getFullName(string accNo)
        {

            string firstName = "";
            string lastName = "";

            string query = "SELECT * FROM client_information WHERE accNo = @accNo ";
            conn.query(query);
            conn.bind("@accNo", accNo);

            try
            {
                conn.Open();
                MySqlDataReader read = conn.read();
                if (read.Read())
                {
                    firstName = read["firstName"].ToString();
                    lastName = read["lastName"].ToString();
                }
                read.Close();
                read.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButton.OK, MessageBoxImage.Error);
                conn.Close();
            }

            return firstName + "" + lastName;
        }

        public String getAccNo(string usn)
        {
            string accNo = "";

            string query = "SELECT * FROM usersinventory WHERE usersName = @usn";
            conn.query(query);
            conn.bind("@usn", usn);

            try
            {
                conn.Open();
                MySqlDataReader read = conn.read();
                if (read.Read())
                {
                    accNo = read["acc_no"].ToString();
                }
                read.Close();
                read.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButton.OK, MessageBoxImage.Error);
                conn.Close();
            }

            return accNo;
        }

        public void addTimeInOut(object timeIn, string accNo)
        {
            try
            {
                conn.Open();
                // Add User
                // Check if user is taken
                // IF NO ERROR 
                string query = "UPDATE usersinventory SET usersTimein = @timein, usersTimeout = @timeout WHERE acc_no = @accno";
                // Hash/Encrypt Password
                conn.query(query);

                conn.bind("@timein", timeIn);
                conn.bind("@timeout", DateTime.Now);
                conn.bind("@accno", accNo);

                conn.cmd().Prepare();
                // INSERT NEW USER
                var check = conn.execute();
                if (check == 1)
                {
                    MessageBox.Show("Timein/Timeout Saved", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
               
                conn.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                conn.Close();
            }
        }
    }
}
