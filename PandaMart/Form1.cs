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
    public partial class Form1 : Form
    {
        int FinalCost = 0;
        int SrNo = 0;
        int tax = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            getInvoiceID();
            USERtextBox.Text = Form2.username;
            GetItems();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "SR NO.";
            dataGridView1.Columns[1].Name = "ITEMS NAME";
            dataGridView1.Columns[2].Name = "UNIT PRICE";
            dataGridView1.Columns[3].Name = "DISCOUNT PER ITEM";
            dataGridView1.Columns[4].Name = "QUANTITY";
            dataGridView1.Columns[5].Name = "SUB TOTAL";
            dataGridView1.Columns[6].Name = "TAX";
            dataGridView1.Columns[7].Name = "TOTAL PRICE";
        }
        void GetItems()
        {
            SELECTITEMcomboBox.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            String query = "select * from items_tb1";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String item_name = dr.GetString(1);
                 SELECTITEMcomboBox.Items.Add(item_name);

            }
            con.Close();
        }

        void getprice()
        {
            if (SELECTITEMcomboBox.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                String query = "select item_price from items_tb1 where item_name = @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name",SELECTITEMcomboBox.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["Item_price"]);
                }
                UNITPRICEtextBox.Text = price.ToString();
            }
        }

        void getdiscount()
        {
            if (SELECTITEMcomboBox.SelectedItem == null)
            {

            }
            else
            {
                int discount = 0;
                SqlConnection con = new SqlConnection(cs);
                String query = "select item_discount from items_tb1 where item_name = @name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", SELECTITEMcomboBox.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    discount = Convert.ToInt32(data.Rows[0]["Item_discount"]);
                }
                DISCOUNTtextBox.Text = discount.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void USERtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UNITPRICEtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DISCOUNTtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SUBTOTALtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SUBTOTALtextBox.Text) == true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SUBTOTALtextBox.Text);
                if (subTotal >= 10000)
                {
                    tax = (int)(subTotal * 0.15);
                    TAXtextBox.Text = tax.ToString();
                }
                else if (subTotal >= 6000)
                {
                    tax = (int)(subTotal * 0.10);
                    TAXtextBox.Text = tax.ToString();
                }
                else if (subTotal >= 3000)
                {
                    tax = (int)(subTotal * 0.07);
                    TAXtextBox.Text = tax.ToString();
                }
                else if (subTotal >= 1000)
                {
                    tax = (int)(subTotal * 0.05);
                    TAXtextBox.Text = tax.ToString();
                }
                else
                {
                    tax = (int)(subTotal * 0.03);
                    TAXtextBox.Text = tax.ToString();
                }
            }
        }

        private void TAXtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TAXtextBox.Text)==true)
            {

            }
            else
            {
                int subTotal = Convert.ToInt32(SUBTOTALtextBox.Text);
                int tax = Convert.ToInt32(TAXtextBox.Text);
                int TotalCost = subTotal + tax;
                TOTALCOSTtextBox.Text = TotalCost.ToString();
            }
        }

        void AddDataToGridView(string Sr_no, string item_name, string unit_price, string discount, string quantity, string sub_total, string tax, string total_cost)
        {
            String[] row = { Sr_no, item_name, unit_price, discount, quantity, sub_total, tax, total_cost };
            dataGridView1.Rows.Add(row);
        }

        private void TOTALCOSTtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void INVOICEtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FINALCOSTtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHANGEtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SELECTITEMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
            getdiscount();
            QUANTITYtextBox.Enabled = true;
        }

        private void QUANTITYtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QUANTITYtextBox.Text) == true)
            {

            }
            else
            {
                int price = Convert.ToInt32(UNITPRICEtextBox.Text);
                int discount = Convert.ToInt32(DISCOUNTtextBox.Text);
                int quantity = Convert.ToInt32(QUANTITYtextBox.Text);
                int SubTotal = price * quantity;
                SubTotal = SubTotal - discount * quantity;
                SUBTOTALtextBox.Text = SubTotal.ToString();
            }
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            if (SELECTITEMcomboBox.SelectedItem != null)
            {
                AddDataToGridView((++SrNo).ToString(), SELECTITEMcomboBox.SelectedItem.ToString(), UNITPRICEtextBox.Text, DISCOUNTtextBox.Text, QUANTITYtextBox.Text, SUBTOTALtextBox.Text, TAXtextBox.Text, TOTALCOSTtextBox.Text);
                RestControls();
                CalculateFinalCost();
            }
            else
            {
                MessageBox.Show("Please Select an Item !!");
            }
        }

        void RestControls()
        {
            SELECTITEMcomboBox.SelectedItem = null;
            UNITPRICEtextBox.Clear();
            DISCOUNTtextBox.Clear();
            QUANTITYtextBox.Clear();
            SUBTOTALtextBox.Clear();
            TAXtextBox.Clear();
            TOTALCOSTtextBox.Clear();
            FINALCOSTtextBox.Clear();
            AMOUNTPAIDtextBox.Clear();
            CHANGEtextBox.Clear();
            QUANTITYtextBox.Enabled =  false;
            //dataGridView1.Rows.Clear();
        }
        void CalculateFinalCost()
        {
            FinalCost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                FinalCost = FinalCost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            FINALCOSTtextBox.Text = FinalCost.ToString();
        }

        private void AMOUNTPAIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(AMOUNTPAIDtextBox.Text) == true)
            {

            }
            else 
            {
                int AmountPaid = Convert.ToInt32(AMOUNTPAIDtextBox.Text);
                int FCost = Convert.ToInt32(FINALCOSTtextBox.Text.ToString());
                int change = AmountPaid - FCost;
                CHANGEtextBox.Text = change.ToString();
            }
        }

        private void RESETbutton_Click(object sender, EventArgs e)
        {
            RestControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SrNo = 0;
        }

        void getInvoiceID()
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "select invoice_id from order_master";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if(data.Rows.Count < 1 )
            {
                INVOICEtextBox.Text = "1";

            }
            else
            {
                String query2 = "select MAX(invoice_id) from order_master";
                SqlCommand cmd = new SqlCommand(query2, con);   
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                INVOICEtextBox.Text = a.ToString();
                con.Close();
            }
        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "Insert into order_master values(@username, @datetime, @finalcost)";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@invoice_id", INVOICEtextBox.Text);
            cmd.Parameters.AddWithValue("@username", USERtextBox.Text);
            cmd.Parameters.AddWithValue("@datetime",DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@finalcost", FINALCOSTtextBox.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if(a > 0 )
            {
                MessageBox.Show("Insertion Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getInvoiceID();
                RestControls();
            }
            else
            {
                MessageBox.Show("Insertion Failed !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            InsertIntoOderDetails();
        }

        int  getlastInsertedInvoice()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select max(invoice_id) from order_master ";
            SqlCommand cmd =  new SqlCommand(query,con);
            con.Open();
            int MaxInvoiceID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close() ;
            return MaxInvoiceID;
        }

        void InsertIntoOderDetails()
        {
            int a = 0;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    String query = "insert into order_details  values(@invoice_id, @name, @price, @discount,@quantity,  @subtotal, @tax, @finalcost)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@invoice_id", getlastInsertedInvoice());
                    cmd.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@price", dataGridView1.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@discount", dataGridView1.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@tax", dataGridView1.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@finalcost", dataGridView1.Rows[i].Cells[7].Value);
                    con.Open();
                    a = a + cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch { }
            if(a > 0)
            {
                MessageBox.Show("Data Added is Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data Added is Failed !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GetItems();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 adf = new Form4();
            adf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 edf = new Form5();
            edf.ShowDialog();  
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 dsa = new Form6();
            dsa.ShowDialog();
        }
    }
}
