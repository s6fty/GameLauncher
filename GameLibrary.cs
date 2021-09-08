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
            }
            else
            {
                StreamReader StreamApp = new StreamReader("bin/ExistingGameCount.txt"); //reading game count
                ListedApp = Convert.ToInt32(StreamApp.ReadLine());
            }
        }


    }
}

