using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;
using NavigationDrawerPopUpMenu2.classes;

namespace NavigationDrawerPopUpMenu2.usercontrols
{
    public partial class usc_user_overview : UserControl
    {
        Database conn = new Database();
        public usc_user_overview()
        {
            InitializeComponent();
            fetchData();
        }

        // Fetch data from database
        public void fetchData()
        {
            conn.Close();
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT acc_no, usersName FROM usersinventory ORDER BY usersName ASC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("stock_out");
                // Fill the datatable
                adapter.Fill(dt);
                listviewAccounts.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                // Close Connection
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Fetch Users Info
        public void fetchInfo()
        {
            try
            {
                conn.Close();
                if (accNumber.Text.Length > 0)
                {
                    string searchId = accNumber.Text;
                    string query = "SELECT firstName, lastName, accCreated FROM client_information WHERE accNo = '" + searchId + "'";
                    conn.query(query); //CMD 
                    conn.Open();
                    MySqlDataReader dr = conn.read();
                    if (dr.Read())
                    {
                        userFirst.Text = dr.GetValue(0).ToString();
                        userLast.Text = dr.GetValue(1).ToString();
                        userCreated.Text = dr.GetValue(2).ToString();
                        dr.Close();
                        dr.Dispose(); // Dispose
                    }
                    conn.Close();
                }
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Fetch Users Data
        public void fetchUser()
        {
            try
            {
                
                conn.Close();
                string searchId = accNumber.Text;
                string query = "SELECT usersName, usersPrevileges, userStatus FROM usersinventory WHERE acc_no = '" + searchId + "'";
                conn.query(query); //CMD 
                conn.Open();
                MySqlDataReader dr = conn.read();
                if (dr.Read())
                {
                    accUser.Text = dr.GetValue(0).ToString();
                    accPriv.Text = dr.GetValue(1).ToString();
                    accStatus.Text = dr.GetValue(2).ToString();
                    dr.Close();
                    dr.Dispose(); // Dispose
                }
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Fires Data Collection
        private void accNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (accNumber.Text.Length > 0)
            {
                accUser.IsEnabled = true;
                accPriv.IsEnabled = true;
                userFirst.IsEnabled = true;
                userLast.IsEnabled = true;

                fetchUser();
                fetchInfo();
            }
        }

        // Button Handler
        private void accStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (accStatus.Text.Length > 0)
            {
                switch (accStatus.Text)
                {
                    case "Active":
                        saveButton.IsEnabled = true;
                        actButton.IsEnabled = false;
                        deacButton.IsEnabled = true;
                        delButton.IsEnabled = true;
                        break;
                    case "Deactivated":
                        saveButton.IsEnabled = true;
                        actButton.IsEnabled = true;
                        deacButton.IsEnabled = false;
                        delButton.IsEnabled = true;
                        break;
                    case "Pending":
                        saveButton.IsEnabled = true;
                        actButton.IsEnabled = true;
                        deacButton.IsEnabled = true;
                        delButton.IsEnabled = true;
                        break;
                    case null:
                        saveButton.IsEnabled = true;
                        actButton.IsEnabled = true;
                        deacButton.IsEnabled = true;
                        delButton.IsEnabled = true;
                        break;
                }
            }
        }

        // Clear Function
        public void Clear()
        {
            accNumber.Clear();
            userFirst.Clear();
            userLast.Clear();
            accUser.Clear();
            accStatus.Clear();
            accPriv.Text = "";
            userCreated.Text = "";
        }

        // Activate Button
        private void actButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Updates User Information
                string updateActive = "UPDATE usersinventory SET userStatus = @status WHERE acc_no = @no";
                conn.query(updateActive);
                conn.Open();
                conn.bind("@no", accNumber.Text);
                conn.bind("@status", "Active");
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("Account Activated!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    fetchUser();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Save Button
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Update Account Information
                string updateUsers = "UPDATE usersinventory SET usersName = @user, usersPrevileges = @priv, userStatus = @status WHERE acc_no = @no";
                conn.query(updateUsers);
                conn.Open();
                conn.bind("@no", accNumber.Text);
                conn.bind("@user", accUser.Text);
                conn.bind("@priv", accPriv.Text);
                conn.bind("@status", accStatus.Text);
                conn.cmd().Prepare();
                conn.execute();
                conn.Close();

                // Updates User Information
                string updateInfo = "UPDATE client_information SET firstName = @first, lastName = @last WHERE accNo = @no";
                conn.query(updateInfo);
                conn.Open();
                conn.bind("@no", accNumber.Text);
                conn.bind("@first", userFirst.Text);
                conn.bind("@last", userLast.Text);
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("Information Updated!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    fetchData();
                    Clear();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Deactivate Button
        private void deacButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Updates User Information
                string updateActive = "UPDATE usersinventory SET userStatus = @status WHERE acc_no = @no";
                conn.query(updateActive);
                conn.Open();
                conn.bind("@no", accNumber.Text);
                conn.bind("@status", "Deactivated");
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("Account Deactivated!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    fetchUser();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Delete Button
        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Delete Client Information
                string deleteInfo = "DELETE FROM client_information WHERE accNo = @no";
                conn.query(deleteInfo);
                conn.Open();
                conn.bind("@no", accNumber.Text);
                conn.cmd().Prepare();
                conn.execute();
                conn.Close();

                // Delete Account Information
                string updateActive = "DELETE FROM usersinventory WHERE acc_no = @no";
                conn.query(updateActive);
                conn.Open();
                conn.bind("@no", accNumber.Text);
                conn.cmd().Prepare();
                var success = conn.execute();
                if (success > 0)
                {
                    MessageBox.Show("Account Deleted!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    fetchUser();
                    fetchData();
                    fetchInfo();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                conn.Close();
                MessageBox.Show(x.Message);
            }
        }

        // Search Function
        private void entrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = entrySearch.Text;
            conn.Close();
            try
            {
                // Open Connection
                conn.Open();
                // Query Statement
                string query = "SELECT acc_no, usersName FROM usersinventory WHERE acc_no LIKE '%" + search + "%' OR usersName LIKE '%" + search + "%' ORDER BY usersName ASC";
                // Mysql Command
                conn.query(query);
                // Execute
                conn.execute();
                // Adapter
                MySqlDataAdapter adapter = conn.adapter();
                //  Datatable
                DataTable dt = new DataTable("usersinventory");
                // Fill the datatable
                adapter.Fill(dt);
                listviewAccounts.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                adapter.Dispose(); // Dispose Adapter
                                   // Close Connection
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
