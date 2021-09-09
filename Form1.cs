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

        public static string Language = "";
        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"bin/GameList.xml"))
            {
                LeoCorpLibrary.Load.ListViewContentXML(listView1, @"bin/GameList.xml");
            }
           
            if (File.Exists(@"bin/Language.txt"))
            {
                StreamReader SRLanguage = new StreamReader(@"bin/Language.txt");
                Language = SRLanguage.ReadToEnd();
            }

            GameLibrary.FileCreator();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            GameLibrary.GameFolder.Title = "Open Application";
            GameLibrary.GameFolder.Filter = "Application | *.exe";
            if (GameLibrary.GameFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ListViewItem listingapp = new ListViewItem();
                listingapp.Text = GameLibrary.GameFolder.SafeFileName;
                Icon GetIcon = Icon.ExtractAssociatedIcon(@GameLibrary.GameFolder.FileName);
                listingapp.SubItems.Add("GameFolder.SafeFileName");
                imageList1.Images.Add(GetIcon);
                listingapp.ImageIndex = GameLibrary.ListedApp; //Image index = Listed Application number
                GameLibrary.ListedApp++;
                listView1.Items.Add(listingapp);
            }
            string SavedDataDir = @"bin";
            if (!Directory.Exists(SavedDataDir))
            {
                Directory.CreateDirectory(SavedDataDir);
            }
            
            Save.ListViewContentXML(listView1, @"bin/GameList.xml");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Focused == false)
            {
                MessageBox.Show("You need to choose something to delete! You can't remove nothing!");
            }
            else
            {
                listView1.FocusedItem.Remove();
            }
            
            Save.ListViewContentXML(listView1, @"bin/GameList.xml");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GameLibrary.GameFolder.FileName); //Opens Application
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            SettingsTab settings = new SettingsTab();
            settings.Show();
        }
    }
}
