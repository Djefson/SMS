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
using System.Data.SqlClient;
using System.Configuration;

namespace SMS
{
    /// <summary>
    /// Interaction logic for UserControlInitial.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public UserControlLogin()
        {
            InitializeComponent();
            con.ConnectionString = ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if(VerifyUser(txtUsername.Text,txtPassword.Password))
            {

                MainWindow main = new MainWindow();
                main.Show();
                this.Visibility = Visibility.Hidden;
                
                //MessageBox.Show("Login Successfully", "Congrats", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("UserName or Password is incorect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool VerifyUser(string UserName, string Password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select Status from Users Where UserName='"+UserName+"'and Password='"+Password+"'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                if(Convert.ToBoolean (dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }
    }
}
