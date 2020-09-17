using SMS.EntityModel;
using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace SMS
{
    /// <summary>
    /// Interaction logic for UserControlRegister.xaml
    /// </summary>
    public partial class UserControlquestions : UserControl
    {
      
        public UserControlquestions()
        {
            InitializeComponent();
            fillcombobox();
        }
        SMSEntities Db = new SMSEntities();
        Question Var = new Question();

        private void Add_Click(object sender, RoutedEventArgs e)
        {
           
            Var.Id = Int32.Parse(txtId.Text); 
            Var.question = txtquestion.Text;
            Var.Option1 = bool.Parse(txtoptionA.Text);
            Var.Option2 = bool.Parse(txtoptionB.Text);
            Var.Option3 = bool.Parse(txtoptionC.Text);
            Var.Option4 = bool.Parse(txtoptionD.Text);
            Var.CorrectOption = txtcorrect.Text;
            Var.Explanation = txtexpl.Text;
            Var.SubjectID = Int32.Parse(txtsbId.Text);
            Var.Exam_name = cmbname.SelectedValue.ToString();
            Db.Questions.Add(Var);
            Db.SaveChanges();
            MessageBox.Show("Data Saved", "Successfully", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        void UserControlquestions_Load(object sender, EventArgs e)
        {
           
        }
        public void fillcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SMS; Integrated Security = True");
            string sql = "select Exam_name from Exams";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader(); 
                while(myreader.Read())
                {
                    string name = myreader.GetString(0);
                    cmbname.Items.Add(name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}

    


