using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class SettingsTab : Form
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {  
            if (Form1.Language == "TR")
            {
                cbox_Language.Text = "Türkçe";
            }
            if (Form1.Language == "EN")
            {
                cbox_Language.Text = "English";
            }
            if (Form1.Language == "FR")
            {
                cbox_Language.Text = "Français";
            }
        }
        private void cbox_Language_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbox_Language.SelectedIndex == 1)
            {
                GameLibrary.Language_EN();
            }
            if (cbox_Language.SelectedIndex == 2)
            {
                GameLibrary.Language_TR();
            }
            if (cbox_Language.SelectedIndex == 3)
            {
                GameLibrary.Language_FR();
            }
        }

      
    }
}
