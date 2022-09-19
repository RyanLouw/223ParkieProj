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


namespace Natuurpark1._2
{
    public partial class Houses : Form
    {
        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Houses()
        {
            InitializeComponent();
        }

        private void Houses_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            //SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;


            //string sql = "SELECT * from House left JOIN House_Type on House_Type.TypeID = House.House_typeID"; // die join werk moet nog net die naam laat wys 
            string sql = "SELECT House.House_num , House.House_typeID  , House_Type.Type_Name from House JOIN House_Type on House_Type.TypeID = House.House_typeID"; // die join werk moet nog net die naam laat wys 
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            String query = "insert into House (House_typeID) VALUES (@House_type)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@House_type", numericUpDown2.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            House_Type form2 = new House_Type();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM House  WHERE House_num = " + lbID.Text + " ", conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                conn = new SqlConnection(constr);
                conn.Open();

                SqlCommand com;
                adap = new SqlDataAdapter();
                data = new DataSet();

                string sql = "SELECT House.House_num , House.House_typeID  , House_Type.Type_Name from House JOIN House_Type on House_Type.TypeID = House.House_typeID";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(data, "Lys");
                dataGridView1.DataSource = data;
                dataGridView1.DataMember = "Lys"; conn.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            string qu = "";
            qu = " UPDATE House SET House_typeID = '" + numericUpDown2.Value + "' WHERE House_num = '" + lbID.Text + "'";
            SqlCommand cmd = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
           
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show(lbID.Text);
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TypesBtn_Click(object sender, EventArgs e)
        {
            Hide();
            House_Type form2 = new House_Type();
            form2.ShowDialog();
            form2 = null;
            Show();
        }
    }
}
