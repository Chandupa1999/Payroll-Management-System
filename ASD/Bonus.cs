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
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
            ShowBonus();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Yashasvi Chandupa\Documents\PayRollDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            BNameTb.Text = "";
            BAmountTb.Text = "";
            key = 0;
        }


        private void ShowBonus()
        {
            Con.Open();
            string Query = "Select * from BonusTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BonusDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void Bonus_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BonusTbl(BName,BAmt)values(@Bn,@BA)", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Saved");
                    Con.Close();
                    ShowBonus();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }




        //Pass values to textboxes when click the data in table
        int key = 0;
        private void BonusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ensures it's not the header row
            {
                DataGridViewRow selectedRow = BonusDGV.Rows[e.RowIndex];

                // Validate that the required cells are present
                if (selectedRow.Cells.Count >= 3) // Adjust the count based on your columns
                {
                    BNameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    BAmountTb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";

                    key = string.IsNullOrEmpty(BNameTb.Text) ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value?.ToString());
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






        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BNameTb.Text == "" || BAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update BonusTbl Set BName=@Bn,BAmt=@BA where BId=@BKey", Con);
                    cmd.Parameters.AddWithValue("@BN", BNameTb.Text);
                    cmd.Parameters.AddWithValue("@BA", BAmountTb.Text);
                    cmd.Parameters.AddWithValue("@BKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Saved");
                    Con.Close();
                    ShowBonus();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }





        //Delete Bonus data
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
                    SqlCommand cmd = new SqlCommand("Delete from BonusTbl Where BId=@BKey", Con);
                    cmd.Parameters.AddWithValue("@BKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bonus Deleted!");
                    Con.Close();
                    ShowBonus();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }
    }
}
