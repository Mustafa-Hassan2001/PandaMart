using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace PandaMart
{
    public partial class Form5 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form5()
        {
            InitializeComponent();
            BindGridView();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "select * from items_tb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }


        private void INSERTNEWITEMbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "update items_tb1 set item_name = @name, item_price = @price, item_discount = @discount where item_id = @ID  ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", IDtextBox.Text);
            cmd.Parameters.AddWithValue("@name", NAMEtextBox.Text);
            cmd.Parameters.AddWithValue("@price", PRICEtextBox.Text);
            cmd.Parameters.AddWithValue("@discount", DISCOUNTtextBox.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Item Updated Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                IDtextBox.Clear();
                NAMEtextBox.Clear();
                PRICEtextBox.Clear();
                DISCOUNTtextBox.Clear();
                NAMEtextBox.Focus();
            }
            else
            {
                MessageBox.Show("Item is not Updated !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrideView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            NAMEtextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PRICEtextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DISCOUNTtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "delete from items_tb1 where item_id = @ID  ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", IDtextBox.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Item Deleted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridView();
                IDtextBox.Clear();
                NAMEtextBox.Clear();
                PRICEtextBox.Clear();
                DISCOUNTtextBox.Clear();
                NAMEtextBox.Focus();
            }
            else
            {
                MessageBox.Show("Item is not Deleted !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
