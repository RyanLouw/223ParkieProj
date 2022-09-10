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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void Booking_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from Booking";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            string Ari = "";
            string Pay = "";

            if (checkBox1.Checked == true)
                Pay = "T";
            else
                Pay = "F";


            if (checkBox2.Checked == true)
                Ari = "T";
            else
                Ari = "F";

            conn = new SqlConnection(constr);
             conn.Open();
             String query = "insert into Booking (Booking_Date, Worker_ID,  Booking_Pay,  Guest_Ari,  House_ID,  Guest_ID,  typeID) VALUES (@Date,@Worker,@Pay,@Ari,@Hous,@Guest,@Type)";
             SqlCommand cmd = new SqlCommand(query, conn);


             cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
             cmd.Parameters.AddWithValue("@Worker", numericUpDown2.Value);
             cmd.Parameters.AddWithValue("@Pay", Pay);
             cmd.Parameters.AddWithValue("@Ari", Ari);

             cmd.Parameters.AddWithValue("@Hous", numericUpDown3.Value);
             cmd.Parameters.AddWithValue("@Guest", numericUpDown4.Value);
             cmd.Parameters.AddWithValue("@Type", numericUpDown1.Value);


             cmd.ExecuteNonQuery();
             conn.Close();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {

            //try catch
            conn = new SqlConnection(constr);
            conn.Open();
            string qu = "";
            string Ari = "";
            string Pay = "";

            //moet weer kyk of die plek moontelik is 


            qu = " UPDATE Booking SET Booking_Date = '" + dateTimePicker1.Value + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();


            qu = " UPDATE Booking SET Worker_ID = '" + numericUpDown2.Value + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE Booking SET Booking_Pay = '" + Pay + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd2 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE Booking SET Guest_Ari = '" + Ari + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd3 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();
            //////// 
            qu = " UPDATE Booking SET House_ID = '" + numericUpDown3.Value + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd4 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE Booking SET Guest_ID = '" + numericUpDown4.Value + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd5 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE Booking SET typeID = '" + numericUpDown1.Value + "' WHERE Booking_ID = '" + lbID.Text + "'";
            SqlCommand cmd6 = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void dell_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Booking  WHERE Booking_ID = " + lbID.Text + " ", conn))
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

                string sql = "Select * from Booking ";
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {

        }

        private void Guest_Click(object sender, EventArgs e)
        {

        }
    }
}
