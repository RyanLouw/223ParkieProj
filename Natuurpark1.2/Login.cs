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
    public partial class Login : Form
    {
        Boolean isAdmin = false;
        public Login()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {

            //this.Close();

            if(UsernameTB.Text=="" && wagwoordTB.Text =="")
            {
                //maak boolian true
                Hide();
                Nave form2 = new Nave();
                form2.ShowDialog();
                form2 = null;
                Show();
            }
            
        }

        private void usernameLB_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
