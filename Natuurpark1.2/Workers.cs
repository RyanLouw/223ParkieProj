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
using System.Text.RegularExpressions;

 
namespace Natuurpark1._2
{

    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }
        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Workers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from Workers";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Workers  WHERE Worker_ID = " + lbID.Text + " ", conn))
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

                string sql = "Select * from Workers ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {   
                errorProvider2.SetError(this.textBox2, "Please provide a valid name");
            }
            else 
            {
                errorProvider2.Clear();
               
            }
            
            if (textBox2.Text == "")
            {
                errorProvider3.SetError(this.textBox2, "Please provide a valid surname");
            }
            else
            {
                errorProvider3.Clear();

            }
            if ((textBox1.Text == "") || (textBox2.Text == "") || ((textBox1.Text == "") && (textBox2.Text == "")))
            {
                MessageBox.Show("All fields not selected", "Please Select all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn = new SqlConnection(constr);
                conn.Open();
                String query = "insert into Workers (Worker_Name,Worker_Surname,Worker_StartDate,Worker_Email) VALUES (@Name,@van,@date,@email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@van", textBox2.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider2.SetError(this.textBox2, "Please provide a valid name");
            }
            else
            {
                errorProvider2.Clear();

            }

            if (textBox2.Text == "")
            {
                errorProvider3.SetError(this.textBox2, "Please provide a valid surname");
            }
            else
            {
                errorProvider3.Clear();

            }
            if ((textBox1.Text == "") || (textBox2.Text == "") || ((textBox1.Text == "") && (textBox2.Text == "")))
            {
                MessageBox.Show("All fields not selected", "Please Select all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string qu = "";
                //Price is n float onthou om die try orasl in te sit na als 100 wqerk

                qu = " UPDATE Workers SET Worker_Name = '" + textBox1.Text + "' WHERE Worker_ID = '" + lbID.Text + "'";
                SqlCommand cmd = new SqlCommand(qu, conn);
                cmd.ExecuteNonQuery();


                qu = " UPDATE Workers SET Worker_Surname = '" + textBox2.Text + "' WHERE Worker_ID = '" + lbID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(qu, conn);
                cmd.ExecuteNonQuery();

                qu = " UPDATE Workers SET Worker_StartDate = '" + dateTimePicker1.Value + "' WHERE Worker_ID = '" + lbID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(qu, conn);
                cmd.ExecuteNonQuery();

                qu = " UPDATE Workers SET Worker_Email = '" + textBox3.Text + "' WHERE Worker_ID = '" + lbID.Text + "'";
                SqlCommand cmd3 = new SqlCommand(qu, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show(lbID.Text);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //  dateTimePicker1.Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Validated(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (Regex.IsMatch(textBox3.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBox3, "Please provide a valid email adres");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
