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
    public partial class House_Type : Form
    {
        public House_Type()
        {
            InitializeComponent();
        }
        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void House_Type_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from House_Type";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //ryan 04/09/2022 Kyk of die push
        //2
        //3
       


        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            String query = "insert into House_Type (Type_Price,Type_Name,Type_Size) VALUES (@Price,@Name,@Size)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Price", float.Parse(typepricetxt.Text));
            cmd.Parameters.AddWithValue("@Name", TypeNAmeTxt.Text);
            cmd.Parameters.AddWithValue("@Size", int.Parse(typezizeupdown.Value.ToString()));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("House Type has been added!","Add done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //del type.
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM House_Type  WHERE TypeID = " + lbID.Text + " ", conn))
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

                string sql = "Select * from House_Type ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            lbID.Text = Convert.ToString(dataGridView1[0, row].Value);
            typepricetxt.Text = Convert.ToString(dataGridView1[1, row].Value);
            TypeNAmeTxt.Text = Convert.ToString(dataGridView1[2, row].Value);
            
        }

        private void TypeNAmeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void typepricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            string qu = "";
            //Price is n float onthou om die try orasl in te sit na als 100 wqerk

            qu = " UPDATE House_Type SET Type_Price = '" + float.Parse(typepricetxt.Text) + "' WHERE TypeID = '" + lbID.Text + "'";
            SqlCommand cmd = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();


            qu = " UPDATE House_Type SET Type_Name = '" + TypeNAmeTxt.Text + "' WHERE TypeID = '" + lbID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE House_Type SET Type_Size = '" + typezizeupdown.Value + "' WHERE TypeID = '" + lbID.Text + "'";
            SqlCommand cmd2 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
