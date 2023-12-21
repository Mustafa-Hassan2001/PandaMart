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
    public partial class Form2 : Form
    {
        public static string username = "";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "select * from signup where fname = @user and Password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", USERNAMEtextBox.Text);
            cmd.Parameters.AddWithValue("@pass", PASSWORDtextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = USERNAMEtextBox.Text;
                this.Hide();
                Form1 MainForm = new Form1();
                MainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    PASSWORDtextBox.UseSystemPasswordChar = false;
                    break;
                default:
                    PASSWORDtextBox.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 Signup = new Form3();
            this.Hide();
            Signup.ShowDialog();
        }
    }
}
