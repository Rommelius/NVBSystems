using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace NVBSystems
{
    public partial class MainProgram : MetroForm
    {
        public static List<string> productDescription = new List<string>();
        public static List<string> productPrice = new List<string>();
        public static BindingList<string> currentTransaction = new BindingList<string>();


        public static Array array;
        public MainProgram()
        {
            InitializeComponent();
            LoadButtonCSV();


            posListView.DataSource = currentTransaction;
            currentTransaction.Add("Description".PadRight(25) + "Price(each)".PadRight(15) + "Quantity");


        }

        private void LoadButtonCSV()
        {
            using (var reader = new StreamReader(@"C:\Users\Rommel Lapuz\Desktop\NVBSystems\PriceList.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    productDescription.Add(values[0]);
                    productPrice.Add(values[1]);
                }
            }

            foreach (string line in productDescription)
            {
                MetroButton b = new MetroButton();
                b.Text = line;
                b.Tag = line;
                b.Size = new Size(150, 65);
                b.Theme = MetroFramework.MetroThemeStyle.Dark;
                buttonsLayoutPanel.Controls.Add(b);

                b.Click += new EventHandler(buttonEventListener);
            }
        }

        private void buttonEventListener(object sender, EventArgs e)
        {
            //using (var reader = new StreamReader(@"C:\Users\Rommel Lapuz\Desktop\NVBSystems\DescriptionForButtons.csv"))
            //{
            //    //List<string> listA = new List<string>();
            //    //List<string> listB = new List<string>();
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(',');
            //        buttonsDescriptionFromCSV.Add(values[1]);
            //        //listB.Add(values[1]);
            //    }
            //}


            var b = sender as MetroButton;

            //find the index first
            int index = productDescription.IndexOf(b.Text);

            AskForQuantityForm dg = new AskForQuantityForm();
            dg.ShowDialog();

            currentTransaction.Add(productDescription[index].PadRight(25)+ productPrice[index].PadRight(15) + AskForQuantityForm.quantity);
            //add to ListPanel

            

            combineItemsforQuantity();
        }
        
        private void combineItemsforQuantity()
        {

        }


        private void MainProgram_SizeChanged(object sender, EventArgs e)
        {
            mainMenuLeftPanel.Width = (mainMenuPanel.Width / 100 * 40);
            //posListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }

        //private void posListView_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        if (posListView.FocusedItem.Bounds.Contains(e.Location) == true)
        //        {
        //            deleteContextMenu.Show(Cursor.Position);
        //        }
        //    }
        //}

        //private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    posListView.FocusedItem.Remove();
        //}

        //private void posListView_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        posListView.FocusedItem.Remove();
        //    }
        //}
    }
}
