using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeoCorpLibrary;
using System.IO;

namespace GameLauncher
{

    public static class GameLibrary
    {
        public static int ListedApp { get; set; }

        public static OpenFileDialog GameFolder = new OpenFileDialog();
        public static void FileCreator()
        {
            if (!File.Exists("bin/ExistingGameCount.txt"))
            {
                StreamWriter GameCount = new StreamWriter("bin/ExistingGameCount.txt"); //creating game count
                GameCount.Dispose();
            }
            else
            {
                StreamReader StreamApp = new StreamReader("bin/ExistingGameCount.txt"); //reading game count
                ListedApp = Convert.ToInt32(StreamApp.ReadLine());
                StreamApp.Dispose();
            }
        }

        public static StreamWriter SWLanguage = new StreamWriter(@"bin/Language.txt");
        public static void Language_TR()
        {
            Form1 frm = new Form1();
            frm.btn_AddGame.Text = "Oyun Ekle";
            frm.btn_RemoveGame.Text = "Oyun Kaldır";
            SettingsTab settings = new SettingsTab();
            settings.label1.Text = "Dil";
            settings.label2.Text = "Tema";
            SWLanguage.Flush();
            SWLanguage.Write("TR");
        }

        public static void Language_EN()
        {
            Form1 frm = new Form1();
            frm.btn_AddGame.Text = "Add Game";
            frm.btn_RemoveGame.Text = "Remove Game";
            SettingsTab settings = new SettingsTab();
            settings.label1.Text = "Language";
            settings.label2.Text = "Theme";
            SWLanguage.Flush();
            SWLanguage.Write("EN");

        }

        public static void Language_FR()
        {
            Form1 frm = new Form1();
            frm.btn_AddGame.Text = "Ajouter un jeu";
            frm.btn_RemoveGame.Text = "Supprimer le jeu";
            SettingsTab settings = new SettingsTab();
            settings.label1.Text = "Langue";
            settings.label2.Text = "Thème";
            SWLanguage.Flush();
            SWLanguage.Write("FR");
        }

    }
}    
    

