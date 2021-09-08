using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeoCorpLibrary;
using System.IO;

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"bin/GameList.xml"))
            {
                LeoCorpLibrary.Load.ListViewContentCustom(listView1, @"bin/GameList.xml");
            }
            
            GameCounter.FileCreator();
        }

        public void button1_Click(object sender, EventArgs e)
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
                listingapp.ImageIndex = GameCounter.ListedApp; //Image index = Listed Application number
                GameCounter.ListedApp++;
                listView1.Items.Add(listingapp);
            }

            string SavedDataDir = @"bin";
            if (!Directory.Exists(SavedDataDir))
            {
                Directory.CreateDirectory(SavedDataDir);
            }

            Save.ListViewContentCustom(listView1, @"bin/GameList.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.FocusedItem.Remove();
            Save.ListViewContentCustom(listView1, @"bin/GameList.xml");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
