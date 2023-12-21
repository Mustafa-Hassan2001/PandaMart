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
    public partial class Form6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form6()
        {
            InitializeComponent();
            BindGridView();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "sp_getBothTableData";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda  = new SqlDataAdapter(cmd);  
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SEARCHbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                String query = "sp_getBothTableDataByInvoice";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoiceID", SEARCHtextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.SelectCommand.Parameters.AddWithValue("@invoiceID", SEARCHbutton.Text);
                sda.SelectCommand = cmd;
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch
            {

            }
        }
    }
}
