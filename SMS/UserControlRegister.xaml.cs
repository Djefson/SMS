using Microsoft.Win32;
using SMS.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
using MaterialDesignThemes.Wpf;
using System.Web.UI.WebControls.Adapters;
using MahApps.Metro.Actions;
using System.Configuration;
using System.Runtime.Remoting.Channels;

namespace SMS
{
    /// <summary>
    /// Interaction logic for UserControlRegister.xaml
    /// </summary>
    public partial class UserControlRegister : UserControl
    {
        public UserControlRegister()
        {
            InitializeComponent();
            FillDataGrid();
          
        }

        private void FillDataGrid()
        {
            
            string CmdString = string.Empty;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            {
                CmdString = "SELECT Id, FirstName, LastName, EmailAddress,Phone,Date_of_Birth,FUB_ärandenummer,AUB_ärandenummer,ProfilePicture,CV,ICE_name,ICE_Mobile,ICE_emails_Address,HandläggareId,GroupId,Remark,UserID FROM Student";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Student");
                sda.Fill(dt);
                grdStudent.ItemsSource = dt.DefaultView;
            }
            
        }

        SMSEntities db = new SMSEntities();
        Student tblobj = new Student();
        
        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                textpath.Text = op.FileName;
                Img1.Source = new BitmapImage(new Uri(op.FileName));
                
            }
        }      
        private void BtnUploadImage_Click(object sender, RoutedEventArgs e)
        {
            
            var ProfilePicture = BitmapSourceToByteArray((BitmapSource)Img1.Source);
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("insert into Student values(' ',' ',' ',' ',' ',' ',' ','" + ProfilePicture + "',' ',' ',' ',' ',' ',' ',' ',' ',' ')", con);
            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //if (i > 0)           
            { MessageBox.Show("Image Saved successfully"); }
            File.Copy(textpath.Text, System.IO.Path.Combine(@"C:\Users\djefson\source\repos\SMS\SMS\SMS\SMS\SMS\Images", System.IO.Path.GetFileName(textpath.Text)), true);

        }
        private byte[] BitmapSourceToByteArray(BitmapSource ProfilePicture)
        {
            using (var stream = new MemoryStream())
            {
                var encoder = new PngBitmapEncoder(); 
                encoder.Frames.Add(BitmapFrame.Create(ProfilePicture));
                encoder.Save(stream);
                return stream.ToArray();
            }
        }

        protected void BtnStore_Click(object sender, RoutedEventArgs e)
        {
                          
            SaveFile(txtFilePath.Text);
            MessageBox.Show("File Saved");
        }

        private void SaveFile(string filePath)
        {

            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(filePath).Extension;
 
                db.SaveChanges();
                File.Copy(txtFilePath.Text, System.IO.Path.Combine(@"C:\Users\djefson\source\repos\SMS\SMS\SMS\SMS\SMS\Files", System.IO.Path.GetFileName(txtFilePath.Text)), true);
            }
        }

        private SqlConnectiion GetConnection()
        {
            return new SqlConnectiion("data source=(localdb)\\MSSQLLocalDB;initial catalog=SMS;integrated security=True;MultipleActiveResultSets=True;");
  
        }     

       private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void refresh_Click(object sender, RoutedEventArgs e)

        {
            string CmdString = string.Empty;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            {
                CmdString = "SELECT Id, FirstName, LastName, EmailAddress,Phone,Date_of_Birth,FUB_ärandenummer,AUB_ärandenummer,ProfilePicture,CV,ICE_name,ICE_Mobile,ICE_emails_Address,HandläggareId,GroupId,Remark,UserID FROM Student";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Student");
                sda.Fill(dt);
                grdStudent.ItemsSource = dt.DefaultView;
                
            }          
        }       
             
        private void btnBrowse_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFilePath.Text = dlg.FileName;
        }
     
        private void Btnclear_Click_1(object sender, RoutedEventArgs e)
        {
            txtID.Clear();
            txtFname.Clear();
            txtlname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtFUB.Clear();
            txtAUB.Clear();
            txtICEname.Clear();
            txtphone.Clear();
            datePicker.SelectedDate = null;
            txtICEem.Clear();
            txtICEm.Clear();
            txtHid.Clear();
            txtGRPid.Clear();
            txtRemark.Clear();
            txtUserID.Clear();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            tblobj.Id = Int32.Parse(txtID.Text);
            tblobj.FirstName = txtFname.Text;
            tblobj.LastName = txtlname.Text;
            tblobj.EmailAddress = txtemail.Text;
            tblobj.Phone = txtphone.Text;
            tblobj.Date_of_Birth = datePicker.SelectedDate.Value.Date;
            tblobj.FUB_ärandenummer = txtFUB.Text;
            tblobj.AUB_ärandenummer = txtAUB.Text;
            tblobj.ICE_name = txtICEname.Text;
            tblobj.ICE_Mobile = txtphone.Text;
            tblobj.ICE_emails_Address = txtemail.Text;
            //tblobj.HandläggareId = Int32.Parse(txtHid.Text);
            //tblobj.GroupId = Int32.Parse(txtGRPid.Text);
            tblobj.Remark = txtRemark.Text;
            tblobj.UserID = Int32.Parse(txtUserID.Text);
            db.Students.Add(tblobj);
            db.SaveChanges();
            MessageBox.Show("Data Saved", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);
  
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
        private void Btndupdate_Click(object sender, RoutedEventArgs e)
        {

            con.Open();
            string query = "UPDATE Student SET  FirstName='" + txtFname.Text + "',LastName='" + txtlname.Text + "',EmailAddress='" + txtemail.Text + "',Phone='" + txtphone.Text + "',FUB_ärandenummer='" + txtFUB.Text + "',AUB_ärandenummer='" + txtAUB.Text + "',ICE_name='" + txtICEname.Text + "',ICE_Mobile='" + txtICEm.Text + "',ICE_emails_Address='" + txtICEem.Text + "',Remark='" + txtRemark.Text + "'  WHERE Id =" + Int32.Parse(txtID.Text)+"";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void grdStudent_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {

                txtID.Text = row_selected["Id"].ToString();
                txtFname.Text= row_selected["FirstName"].ToString();
                txtlname.Text = row_selected["LastName"].ToString();
                txtemail.Text = row_selected["EmailAddress"].ToString();
                txtphone.Text = row_selected["Phone"].ToString();
                datePicker.Text = row_selected["Date_of_Birth"].ToString();
                txtFUB.Text = row_selected["FUB_ärandenummer"].ToString();
                txtAUB.Text = row_selected["AUB_ärandenummer"].ToString();
                txtICEname.Text = row_selected["ICE_name"].ToString();
                txtICEm.Text = row_selected["ICE_Mobile"].ToString();
                txtICEem.Text = row_selected["ICE_emails_Address"].ToString();
                txtRemark.Text = row_selected["Remark"].ToString();
                txtUserID.Text = row_selected["UserID"].ToString();
            }

        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Student where ID=@Id",con);
            cmd.Parameters.AddWithValue("@Id",  int.Parse(txtID.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully!!", "Record Deleted", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {


            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Id as int)),0)+1 from Student", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //txtID.Text = dt.Rows[0][0].ToString();
            //con.Close();


            //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True");
            //con.Open();

            //string que = "Select IDENT_CURRENT('Student')"; 
            //SqlCommand com = new SqlCommand(que, con);
            //SqlDataReader sqlReader = com.ExecuteReader();
            //while (sqlReader.Read())
            //{

            //int value = int.Parse(sqlReader[0].ToString()) + 1;
            //txtID.Text = String.Format("{0:}", value);  //Display autogenrated id as 0000 format on textbox
            //}
            //con.Close();
        }

       
    }
    }


