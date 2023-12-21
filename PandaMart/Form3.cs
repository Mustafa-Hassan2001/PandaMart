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
    public partial class Form3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void SIGNUPbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "insert into signup values(@f_name, @l_name,@age, @gender, @address, @email, @password) ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@f_name", FIRSTNAMEtextBox.Text);
            cmd.Parameters.AddWithValue("@l_name", LASTNAMEtextBox.Text);
            cmd.Parameters.AddWithValue("@age", AGEnumericUpDown.Value);
            cmd.Parameters.AddWithValue("@gender", GENDERcomboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@address", ADDRESStextBox.Text);
            cmd.Parameters.AddWithValue("@email", EMAILtextBox.Text);
            cmd.Parameters.AddWithValue("@password", PASSWORDtextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if(a > 0)
            {
                MessageBox.Show("Registered Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Username is : "+ FIRSTNAMEtextBox.Text + "\n \n" + "Password is : "+ PASSWORDtextBox.Text,"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 LoginForm =  new Form2(); 
                LoginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registered Failed !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();


            con.Open();
        }
    }
}
