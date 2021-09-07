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

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loading game list
            LeoCorpLibrary.Load.ListViewContentXML(listView1, "GameList.xml");
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
            Save.ListViewContentXML(listView1, "GameList.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //removing will be here thing 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
