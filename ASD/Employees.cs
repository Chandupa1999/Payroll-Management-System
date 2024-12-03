using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ASD
{
    //OOP Concept - Inheritance
    //The Employees class inherits from the Form clas
    public partial class Employees : Form
    {

        //OOP Concept - Constructor
        //The constructor Employees() initializes the form and calls the ShowEmployee()
        //method to display data when the form is loaded
        public Employees()
        {
            InitializeComponent();
            ShowEmployee();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Yashasvi Chandupa\Documents\PayRollDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            EmpNameTb.Text = "";
            EmpAddTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpSalTb.Text = "";
            EmpGenCb.SelectedIndex = 0;
            EmpPosCb.SelectedIndex = 0;
            EmpQualCb.SelectedIndex = 0;
            key = 0;
        }


        private void ShowEmployee()
        {
            //OOP Concept - Error Handling
            Con.Open();
            string Query = "Select * from EmployeeTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }






        //SAve button

        //OOP Concept - Polymorphism (Event Handling)
        //Polymorphism is demonstrated through event handling methods.Different events(like button clicks or DataGridView cell clicks) trigger different behaviors
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTb1(EmpName,EmpGen,EmpDOB,EmpPhone,EmpAdd,EmpPos,JoinDate,EmpQual,EmpBasSal)values(@EN,@EG,@ED,@EP,@EA,@EPos,@JD,@EQ,@EBS)", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved");
                    Con.Close();
                    ShowEmployee();
                    Clear();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }






        //OOP Concept - Encapsulation
        //key variable is used internally to track the selected employee's ID
        int key = 0;
        //private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
        //    EmpGenCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
        //    EmpDOB.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
        //    EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
        //    EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
        //    EmpPosCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[6].Value.ToString();
        //    JDate.Text = EmployeeDGV.SelectedRows[0].Cells[7].Value.ToString();
        //    EmpQualCb.SelectedItem = EmployeeDGV.SelectedRows[0].Cells[8].Value.ToString();
        //    EmpSalTb.Text = EmployeeDGV.SelectedRows[0].Cells[9].Value.ToString();

        //    if(EmpNameTb.Text == "")
        //    {
        //        key = 0;
        //    }
        //    else
        //    {
        //        key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
        //    }
        //}

        private void EmployeeDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked
            if (e.RowIndex >= 0) // Ensures it's not the header row
            {
                DataGridViewRow selectedRow = EmployeeDGV.Rows[e.RowIndex];

                // Validate that the required cells are present
                if (selectedRow.Cells.Count >= 10) // Adjust the count based on your columns
                {
                    EmpNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    EmpGenCb.SelectedItem = selectedRow.Cells[2].Value?.ToString() ?? "";
                    EmpDOB.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    EmpPhoneTb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                    EmpAddTb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                    EmpPosCb.SelectedItem = selectedRow.Cells[6].Value?.ToString() ?? "";
                    JDate.Text = selectedRow.Cells[7].Value?.ToString() ?? "";
                    EmpQualCb.SelectedItem = selectedRow.Cells[8].Value?.ToString() ?? "";
                    EmpSalTb.Text = selectedRow.Cells[9].Value?.ToString() ?? "";

                    key = string.IsNullOrEmpty(EmpNameTb.Text) ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value?.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid row structure or insufficient columns.");
                }
            }
            else
            {
                MessageBox.Show("Please click on a valid row.");
            }
        }







        //Edit Button
        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpAddTb.Text == "" || EmpSalTb.Text == "" || EmpQualCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTb1 Set EmpName=@EN,EmpGen=@EG,EmpDOB=@ED,EmpPhone=@EP,EmpAdd=@EA,EmpPos=@EPos,JoinDate=@JD,EmpQual=@EQ,EmpBasSal=@EBS where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EG", EmpGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddTb.Text);
                    cmd.Parameters.AddWithValue("@EPos", EmpPosCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@JD", JDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EQ", EmpQualCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EBS", EmpSalTb.Text);
                    cmd.Parameters.AddWithValue("@EmpKey", key); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    Con.Close();
                    ShowEmployee();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }







        //Delete Button
        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information"); 
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeTb1 Where EmpId=@EmpKey", Con);
                    cmd.Parameters.AddWithValue("@EmpKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted!");
                    Con.Close();
                    ShowEmployee();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Bonus Obj = new Bonus();
            Obj.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
