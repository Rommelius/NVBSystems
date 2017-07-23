using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NVBSystems
{
    public partial class LogIn : MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void goToMainMenu(object sender, EventArgs e)
        {
            this.Hide();

            MainProgram mainmenu = new MainProgram();
            mainmenu.Show();
        }
    }
}
