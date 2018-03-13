using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;



namespace SQLCRD
{
    public partial class Form1 : Form
    {

        string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\DotNetPro\SQLCRD\SQLCRD\SQLCRD.mdf;Integrated Security=True";
        int BlogId;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            viewAll();
            btn_delete.Enabled = false;
           
        }
        private void viewAll()
        {
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("viewAll", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(ConString))
            {
               
                conn.Open();
                SqlCommand cmd = new SqlCommand("addEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BlogId", BlogId);
                cmd.Parameters.AddWithValue("@Title", txtbox_title.Text.Trim());
                cmd.Parameters.AddWithValue("@Author", txtbox_author.Text.Trim());
                cmd.Parameters.AddWithValue("@Description", txtbox_description.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Succesfully saved!");
                btn_save.Text = "ADD";
                viewAll();
                clear();


            }

        }
        private void clear()
        {
            txtbox_author.Text = txtbox_title.Text = txtbox_description.Text = "";
            BlogId = 0;
            btn_delete.Enabled = false;
            btn_save.Text = "ADD";
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                if (dgv.CurrentRow.Index != -1)
                {
                    txtbox_title.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txtbox_author.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    txtbox_description.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    BlogId = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                    btn_save.Text = "UPDATE";
                    btn_delete.Enabled = true;

                }
                

            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
            private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("deleteId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BlogId", dgv.CurrentRow.Cells[0].Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Succesfully deleted!");
                viewAll();
                clear();
            }
        }

        
    }
}
