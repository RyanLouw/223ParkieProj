using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
static class isAdmin
{
    public static Boolean isAdm = false;
}
namespace Natuurpark1._2
{


    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {

            //this.Close();

            if (UsernameTB.Text == "admin" && wagwoordTB.Text == "admin")
            {
                isAdmin.isAdm = true;
                Hide();
                Nave form2 = new Nave();
                form2.ShowDialog();
                form2 = null;
                Show();
            }

            else
            {
                isAdmin.isAdm = false;
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
