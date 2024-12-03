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
using static System.Windows.Forms.AxHost;

namespace ASD
{
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            ShowAttendance();
            GetEmployees();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Yashasvi Chandupa\Documents\PayRollDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            EmpNameTb.Text = "";
            PresenceTb.Text = "";
            AbsTb.Text = "";
            ExcusedTb.Text = "";
            key = 0;
        }
        private void ShowAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendanceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDGV.DataSource = ds.Tables[0];
            Con.Close();
        }








        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeTb1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCb.ValueMember = "EmpId";
            EmpIdCb.DataSource = dt;
            Con.Close();
        }








        private void GetEmployeeName()
        {
            Con.Open();
            string Query = "Select * from EmployeeTb1 where EmpId=" + EmpIdCb.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                EmpNameTb.Text = dr["EmpName"].ToString();
            }
            Con.Close();
        }








        //save btn
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcusedTb.Text == "" || AbsTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTbl(EmpId,EmpName,DayPres,DayAbs,DayExcused,Period)values(@EI,@EN,@DP,@DA,@DE,@Per)", Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Saved");
                    Con.Close();
                    ShowAttendance();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }










        int key = 0;
        private void AttendanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked
            if (e.RowIndex >= 0) // Ensures it's not the header row
            {
                DataGridViewRow selectedRow = AttendanceDGV.Rows[e.RowIndex];

                // Validate that the required cells are present
                if (selectedRow.Cells.Count >= 7) // Adjust the count based on your columns
                {
                    EmpNameTb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                    EmpIdCb.SelectedItem = selectedRow.Cells[1].Value?.ToString() ?? "";
                    PresenceTb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    AbsTb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                    ExcusedTb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                    AttDate.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
                    
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

        private void EmpIdCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void EmpIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
        }











        //edit btn
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || PresenceTb.Text == "" || ExcusedTb.Text == "" || AbsTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Period = AttDate.Value.Month + "-" + AttDate.Value.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AttendanceTbl Set EmpId=@EI,EmpName=@EN,DayPres=@DP,DayAbs=@DA,DayExcused=@DE,Period=@Per where AttNum=@AttKey", Con);
                    cmd.Parameters.AddWithValue("@EI", EmpIdCb.Text);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTb.Text);
                    cmd.Parameters.AddWithValue("@DP", PresenceTb.Text);
                    cmd.Parameters.AddWithValue("@DA", AbsTb.Text);
                    cmd.Parameters.AddWithValue("@DE", ExcusedTb.Text);
                    cmd.Parameters.AddWithValue("@Per", Period);
                    cmd.Parameters.AddWithValue("@AttKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    ShowAttendance();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from AttendanceTbl Where EmpId=@AttKey", Con);
                    cmd.Parameters.AddWithValue("@AttKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Deleted!");
                    Con.Close();
                    ShowAttendance();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void EmpIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
