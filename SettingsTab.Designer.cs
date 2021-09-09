
namespace GameLauncher
{
    public partial class SettingsTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Language = new System.Windows.Forms.ComboBox();
            this.cbox_Theme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Close.Image = global::GameLauncher.Properties.Resources.close_111152;
            this.btn_Close.Location = new System.Drawing.Point(156, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(31, 26);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Language";
            // 
            // cbox_Language
            // 
            this.cbox_Language.FormattingEnabled = true;
            this.cbox_Language.Items.AddRange(new object[] {
            "English",
            "Türkçe",
            "Français"});
            this.cbox_Language.Location = new System.Drawing.Point(82, 56);
            this.cbox_Language.Name = "cbox_Language";
            this.cbox_Language.Size = new System.Drawing.Size(88, 23);
            this.cbox_Language.TabIndex = 8;
            this.cbox_Language.SelectedValueChanged += new System.EventHandler(this.cbox_Language_SelectedValueChanged);
            // 
            // cbox_Theme
            // 
            this.cbox_Theme.FormattingEnabled = true;
            this.cbox_Theme.Items.AddRange(new object[] {
            "Default (Dark)",
            "Default (Light)"});
            this.cbox_Theme.Location = new System.Drawing.Point(82, 99);
            this.cbox_Theme.Name = "cbox_Theme";
            this.cbox_Theme.Size = new System.Drawing.Size(88, 23);
            this.cbox_Theme.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Theme";
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(199, 147);
            this.Controls.Add(this.cbox_Theme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_Language);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsTab";
            this.Text = "SettingsTab";
            this.Load += new System.EventHandler(this.SettingsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbox_Language;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbox_Theme;
    }
}