using SMS.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.IO;
using Microsoft.Win32;
using System.Configuration;



namespace SMS
{
    /// <summary>
    /// Interaction logic for UserControlInitial.xaml
    /// </summary>
    public partial class UserControlTeachers : UserControl
    {
        public UserControlTeachers()
        {
            InitializeComponent();
            FillDataGrid(); 
        }

        SMSEntities db = new SMSEntities();
        Teacher tblobj = new Teacher();
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            tblobj.Id = Int32.Parse(txtId.Text);
            tblobj.FirstName = txtFname.Text;
            tblobj.LastName = txtlname.Text;
            tblobj.Email = txtemail.Text;
            tblobj.PersonNumber =txtpn.Text;
            tblobj.Phone_Number = txtemail.Text;
            tblobj.UserId = Int32.Parse(txtuser.Text); ;           
            db.Teachers.Add(tblobj);
            db.SaveChanges();
            MessageBox.Show("Data Saved", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void FillDataGrid()
        {

            string CmdString = string.Empty;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            {
                CmdString = "SELECT Id, FirstName, LastName,PersonNumber,Email,Phone_Number,UserId FROM Teacher";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Teacher");
                sda.Fill(dt);
                grdteacher.ItemsSource = dt.DefaultView;
            }

        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            string CmdString = string.Empty;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            {
                CmdString = "SELECT Id, FirstName, LastName,PersonNumber,Email,Phone_Number,UserId FROM Teacher";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Teacher");
                sda.Fill(dt);
                grdteacher.ItemsSource = dt.DefaultView;

            }
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
        
        private void Btndupdate_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            string query = "UPDATE Teacher SET  FirstName='" + txtFname.Text + "',LastName='" + txtlname.Text + "',PersonNumber='" + txtpn.Text + "',Email='" + txtemail.Text + "',Phone_Number='" + txtphone.Text + "',UserId='" + txtuser.Text + "'  WHERE Id =" + Int32.Parse(txtId.Text) + "";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
        }
     
        private void grdteacher_SelectedCellsChanged_1(object sender, SelectedCellsChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {

                txtId.Text = row_selected["Id"].ToString();
                txtFname.Text = row_selected["FirstName"].ToString();
                txtlname.Text = row_selected["LastName"].ToString();
                txtpn.Text = row_selected["PersonNumber"].ToString();
                txtemail.Text = row_selected["Email"].ToString();
                txtphone.Text = row_selected["Phone_Number"].ToString();
                txtuser.Text = row_selected["UserId"].ToString();
            }

        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtId.Clear();
            txtFname.Clear();
            txtlname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtuser.Clear();
            txtpn.Clear();
                  
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Teacher where ID=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully!!", "Record Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            searchData(txtsearch.Text);

        }

        public void searchData(string valueToFind)
        {

            string searchQuery = "SELECT * FROM Teacher where CONCAT(FirstName,LastName) LIKE '" + valueToFind+"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grdteacher.ItemsSource = table.DefaultView;
        }
    }
}
