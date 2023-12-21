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
    public partial class Form4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void INSERTNEWITEMbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "insert into items_tb1 values(@name, @price, @discount) ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", NAMEtextBox.Text);
            cmd.Parameters.AddWithValue("@price", PRICEtextBox.Text);
            cmd.Parameters.AddWithValue("@discount", DISCOUNTtextBox.Text);
          
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Item Added Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NAMEtextBox.Clear();
                PRICEtextBox.Clear();
                DISCOUNTtextBox.Clear();
                NAMEtextBox.Focus();
            }
            else
            {
                MessageBox.Show("Item not Added !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
