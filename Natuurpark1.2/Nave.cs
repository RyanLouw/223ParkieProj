using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Natuurpark1._2
{
    public partial class Nave : Form
    {
        public Nave()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Hide();
            Booking form2 = new Booking();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void BtnGueste_Click(object sender, EventArgs e)
        {
            Hide();
            Guest form2 = new Guest();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void BtnHouses_Click(object sender, EventArgs e)
        {
            Hide();
            Houses form2 = new Houses();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void BtnAn_Click(object sender, EventArgs e)
        {
            Hide();
            Animals form2 = new Animals();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void BtnWorkers_Click(object sender, EventArgs e)
        {
            Hide();
            Workers form2 = new Workers();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void Nave_Load(object sender, EventArgs e)
        {
            
        }
    }
}
