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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void reportBTN_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql;
            if (amountOfbeds.Value==0)
            {
                 sql = "select * from Booking where  Booking_Date >= '" + startdate.Value + "' And Booking_Date <= '" + enddate.Value + "'";
            }
            else
            {
                sql = "select * from Booking where  Booking_Date >= '" + startdate.Value + "' And Booking_Date <= '" + enddate.Value + "'And typeID = '" + amountOfbeds.Value + "'";
            }
          
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            
            SqlDataReader myReader = com.ExecuteReader();

            string ID = "";
            string date = "";
            string woorker = "";
            string pay = "";
            string ari = "";
            string house = "";
            string guest = "";
            richTextBox1.AppendText( "ID\tDate\t\t\twoorker\tpayde\tarived\thouse number\tgeustid\t");
            string newfile = "ID\tDate\t\t\twoorker\tpayde\tarived\thouse number\tgeustid\t";
            while (myReader.Read())
            {
                ID = myReader.GetInt32(0).ToString();

                date = myReader.GetValue(1).ToString();
                woorker = myReader.GetInt32(2).ToString();
                pay = myReader.GetString(3);
                ari = myReader.GetString(4);
                house = myReader.GetInt32(5).ToString();
                guest = myReader.GetInt32(6).ToString();

                MessageBox.Show(ID);
                string txtt = ("\n" + ID + "\t" + date + "\t" + woorker + "\t" + pay + "\t" + ari + "\t" + house + "\t\t" + guest);
                richTextBox1.AppendText(txtt);
                newfile =newfile + txtt;
                /* try
                 {
                     System.IO.File.WriteAllText(@"report.txt", txtt);
                     Console.WriteLine("String written to file successfully.");
                 }
                 catch (Exception err)
                 {
                     Console.WriteLine(err.Message);
                 }*/
                try
                {
                    using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@"C:\Users\user\OneDrive\Desktop\2022\223\223ParkieProj\report.txt"))
                    {
                        
                            file.WriteLine(newfile);
                        
                        
                    }
                    Console.WriteLine("Lines written to file successfully.");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }

            }
            conn.Close();

            /*conn = new SqlConnection(constr);

            string sql = "select * from Booking where  Booking_Date >= '" + startdate.Value + "' And Booking_Date <= '" + enddate.Value + "'";

            comm = new SqlCommand(sql, conn);

            

            try

            {

                conn.Open();

                //reader = cmd.ExecuteReader();
                SqlDataReader myReader = comm.ExecuteReader();
                // reads the data and fills the combo box and listbox

                while (myReader.Read())
                {
                    int Reportsize = 0;
                    string txt = RoomID(Reportsize).ToString() \t BookDate(Reportsize).ToString();
                    RitchTextbox1.append(txt);

                    ID = myReader.GetInt32(Reportsize);
                    Reportsize++;

                }
                conn.Close();
                myReader.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            conn.Close();*/

        }

        private void Report_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "select * from Booking ";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();

        }
    }
    
}
