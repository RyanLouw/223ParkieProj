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


        public void SQLreset(string sql)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            //
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();


            return;
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            /* conn = new SqlConnection(constr);
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
             conn.Close();*/

            SQLreset("Select * from Booking");   //// die sqlreset Function is al die code wat gebruik moet word net die sql moet by gesit word


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
        

        private void Add_Click_1(object sender, EventArgs e)
        {
           // if (kanBook == true)
          //  {
                try
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
                    SQLreset("Select * from Booking");
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }

           // }
           // else 
          //  {
          //      MessageBox.Show("did not check or Fully booked sorry");
          //  }


        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            try
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
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }


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

        bool kanBook = true;
        public int[] housnumberss;
        int ID = 0;
        int knewhous = 0;

        bool chekneshouse = true;

        private void button1_Click(object sender, EventArgs e)
        {
            int AmountOfBookings = 0;
            int AmountOfBeds = 0;
            int AmountOfHous = 0;
            

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from Booking where typeID = '" + numericUpDown1.Value + "' And Booking_Date = '" + dateTimePicker1.Value + "'";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
            AmountOfBookings = dataGridView1.Rows.Count - 1;
            //die bo mag nie gesien word nie 
            MessageBox.Show("Amount of bookings in record for the date and house type: "+AmountOfBookings.ToString());
           


            // kyk of ons n plek het met genoeg slaap plek
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com1;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql1 = "Select * from House_Type";
            com1 = new SqlCommand(sql1, conn);
            adap.SelectCommand = com1;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
            AmountOfBeds= dataGridView1.Rows.Count - 1;


            //die is om te kyk hoeveel kamers ons het met die regte hoeveelheid slaap plek.

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com3;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql3 = "Select * from House where House_typeID = '" + numericUpDown1.Value + "'";
            com3 = new SqlCommand(sql3, conn);
            adap.SelectCommand = com3;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
            AmountOfHous = dataGridView1.Rows.Count - 1;
            MessageBox.Show("This is the amount of houses we have of the type: " + AmountOfHous.ToString());






            /// Kyk wat die folgende hous number is.

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com5;
            adap = new SqlDataAdapter();
            data = new DataSet();
            //string sql = "Select Booking_Number from BOOKING where  Booking_Number=(select max( Booking_Number) From BOOKING )";
            string sql5 = "Select House_ID from Booking where typeID = '" + numericUpDown1.Value + "' And House_ID=(select max( House_ID) From Booking ) And Booking_Date = '" + dateTimePicker1.Value + "'";
            com5 = new SqlCommand(sql5, conn);
            adap.SelectCommand = com5;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            
            SqlDataReader myReader = com5.ExecuteReader();
            while (myReader.Read())
            {
                ID = myReader.GetInt32(0);
            }
            conn.Close();
            myReader.Close();
            MessageBox.Show("Kyk Of dit die mag getal gee" +ID.ToString()+ "and the next to chek is "+(ID+1).ToString());  // die wys die grootse getal.
                                                                             //kyk of daai getal +1 in die DB is.

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com6;
            adap = new SqlDataAdapter();
            data = new DataSet();
            //string sql = "Select Booking_Number from BOOKING where  Booking_Number=(select max( Booking_Number) From BOOKING )";
            string sql6 = "Select * from House where House_num = '" + (ID+1) + "' And House_typeID = '" + numericUpDown1.Value + "'";
            com6 = new SqlCommand(sql6, conn);
            adap.SelectCommand = com6;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";

            SqlDataReader myReader2 = com6.ExecuteReader();

            while (myReader2.Read())
            {
                knewhous = myReader2.GetInt32(0);
            }
            conn.Close();
            MessageBox.Show("Kyk Of dit die mag getal gee"+knewhous.ToString());


           

            // die kyk of die nuwe 

            //die bo mag nie gesien word nie  dus moet alle message box uit gehaal word

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com2;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql2 = "Select * from Booking";
            com2 = new SqlCommand(sql2, conn);
            adap.SelectCommand = com2;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();


           




            bool beds = true;
            bool booked = true;
            if (numericUpDown1.Value> AmountOfBeds)
            {
                MessageBox.Show("We dont have a place with enough beds",  "Not enough beds",MessageBoxButtons.OK,MessageBoxIcon.Warning);//////////////////////////////////////////////////////////kyk spelling
                beds = false;
            }
            if (AmountOfBookings>= AmountOfHous)
            {
                MessageBox.Show("We are fully booked on the date please pick a new day or amount of beds","Fully Booked",MessageBoxButtons.OK,MessageBoxIcon.Warning);//////////////////////////////////////////////////////////kyk spelling
                booked = false;

            }
            if (knewhous == 0)
            {
                //dit wil se daar is nie so een nie 
                MessageBox.Show("fully booked or booking not in order");
                chekneshouse = false;
            }
            else
            {
                numericUpDown3.Value = ID + 1;
            }


            if (beds == false || booked == false || chekneshouse== false)
                kanBook = false;




        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GuestBTN_Click(object sender, EventArgs e)
        {
            Hide();
            Guest form2 = new Guest();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com3;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql3 = "Select * from Booking where Booking_Date >= '" + dateTimePicker1.Value.Date + "'";
            com3 = new SqlCommand(sql3, conn);
            adap.SelectCommand = com3;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();

        }
    }
}
