﻿using System;
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
    public partial class Animal_Type : Form
    {
        public Animal_Type()
        {
            InitializeComponent();
        }
        public SqlConnection conn;
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public DataSet data;
        public SqlDataReader datar;
        string constr = @"Data Source=RYAN-PC;Initial Catalog=Park;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string v="";

            if (radioButton1.Checked == true)
                v = "T";
            else
                v = "F";
            //add of a an type
           conn = new SqlConnection(constr);
             conn.Open();
             String query = "insert into Animal_Type (AType_Name,AType_Endangered) VALUES (@Name,@Endangered)";
             SqlCommand cmd = new SqlCommand(query, conn);
             cmd.Parameters.AddWithValue("@Name", AnimalTypeName.Text);
             cmd.Parameters.AddWithValue("@Endangered", v);
             cmd.ExecuteNonQuery();
             conn.Close();
            
        }

        private void Animal_Type_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand com;
            adap = new SqlDataAdapter();
            data = new DataSet();
            string sql = "Select * from Animal_Type";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(data, "Lys");
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Lys";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Animal_Type  WHERE Animal_TypeID = " + lbID.Text + " ", conn))
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

                string sql = "Select * from Animal_Type ";
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
            string v = "";

            if (radioButton1.Checked == true)
                v = "T";
            else
                v = "F";

            conn = new SqlConnection(constr);
            conn.Open();
            string qu = "";
            qu = " UPDATE Animal_Type SET Animal_Type = '" + AnimalTypeName.Text + "' WHERE Animal_TypeID = '" + lbID.Text + "'";
            SqlCommand cmd = new SqlCommand(qu, conn);
            cmd.ExecuteNonQuery();

            qu = " UPDATE Animal_Type SET AType_Endangered = '" + v + "' WHERE Animal_TypeID = '" + lbID.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qu, conn);
            cmd1.ExecuteNonQuery();

           
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            AnimalTypeName.Text = Convert.ToString(dataGridView1[1,row].Value);
            lbID.Text = Convert.ToString(dataGridView1[0, row].Value);
            if (Convert.ToString(dataGridView1[2, row].Value) == "T")
            {
                radioButton1.Checked = true;
            }
            else
                radioButton1.Checked = false;

            MessageBox.Show(lbID.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
