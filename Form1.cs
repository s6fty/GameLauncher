using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ListedApp = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            OpenFileDialog GameFolder = new OpenFileDialog();
            GameFolder.Title = "Open Application";
            GameFolder.Filter = "Application | *.exe";
            if (GameFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ListViewItem listingapp = new ListViewItem();
                listingapp.Text = GameFolder.SafeFileName;
                Icon GetIcon = Icon.ExtractAssociatedIcon(@GameFolder.FileName);
                listingapp.SubItems.Add("GameFolder.SafeFileName");
                imageList1.Images.Add(GetIcon);
                listingapp.ImageIndex = ListedApp;
                ListedApp++;
                listView1.Items.Add(listingapp);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            int RemovedImage = listView1.FocusedItem.Index;
            imageList1.Images.RemoveAt(RemovedImage);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
