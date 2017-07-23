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
    public partial class AskForQuantityForm : MetroForm
    {
        public static string quantity;
        public int counter;
        public AskForQuantityForm()
        {
            InitializeComponent();
            quantity = quantityLabel.Text;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            counter--;
            quantityLabel.Text=counter.ToString();
            quantity = quantityLabel.Text;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            counter++;
            quantityLabel.Text = counter.ToString();
            quantity = quantityLabel.Text;

        }
    }
}
