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

namespace libraryManager
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthorName.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {

                String bname = txtBookName.Text;
                String bauthor = txtAuthorName.Text;
                String bpubl = txtPublication.Text;
                String bdate = purchaseDate.Text;
                Int64 bprice = Int64.Parse(txtPrice.Text);
                Int64 bquan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-QCJ06K5; database = test; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();

                cmd.CommandText = "INSERT INTO NewBook (bName, bAuthor, bPubl, bDate, bPrice, bQuan) values ('" + bname + "', '" + bauthor + "', '" + bpubl + "', '" + bdate + "', '" + bprice + "', '" + bquan + "') ";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthorName.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            } else
            {
                MessageBox.Show("Please fill out all information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
