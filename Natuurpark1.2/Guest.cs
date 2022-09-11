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
{//start of something new 
    //1
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            lbID.Text = Convert.ToString(dataGridView1[0, row].Value);
            NameTXT.Text = Convert.ToString(dataGridView1[1, row].Value);
            VanTXT.Text = Convert.ToString(dataGridView1[2, row].Value);
            Emailtxt.Text = Convert.ToString(dataGridView1[3, row].Value);

        }

        private void Guest_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from Guests ";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add new guest
            conn = new SqlConnection(constr);
            conn.Open();
            String query = "insert into Guests (Guest_Name,Guest_Surname,Guest_Email) VALUES (@Name,@LastName,@Email)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", NameTXT.Text);
            cmd.Parameters.AddWithValue("@LastName", VanTXT.Text);
            cmd.Parameters.AddWithValue("@Email", Emailtxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            //net ref
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Guests  WHERE Guest_ID = " + lbID.Text + " ", conn))
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

                string sql = "Select * from Guests ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            string qu = "";
            qu = " UPDATE Guests SET Guest_Name = '" + NameTXT.Text + "' WHERE Guest_ID = '" + lbID.Text + "'";
            SqlCommand cmd = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();


            qu = " UPDATE Guests SET Guest_Surname = '" + VanTXT.Text + "' WHERE Guest_ID = '" + lbID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE Guests SET Guest_Email = '" + Emailtxt.Text + "' WHERE Guest_ID = '" + lbID.Text + "'";
            SqlCommand cmd2 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void NameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from Guests WHERE Guest_Email  = '" + Emailtxt.Text + "'";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
            //MessageBox.Show((dataGridView1.Rows.Count-1).ToString());
            //
        }
    }
    
}
