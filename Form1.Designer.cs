
namespace GameLauncher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_AddGame = new System.Windows.Forms.Button();
            this.btn_RemoveGame = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddGame
            // 
            this.btn_AddGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddGame.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_AddGame.Image = global::GameLauncher.Properties.Resources._106230_add_icon__1_;
            this.btn_AddGame.Location = new System.Drawing.Point(40, 59);
            this.btn_AddGame.Name = "btn_AddGame";
            this.btn_AddGame.Size = new System.Drawing.Size(75, 81);
            this.btn_AddGame.TabIndex = 1;
            this.btn_AddGame.Text = "Add\r\ngame\r\n";
            this.btn_AddGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddGame.UseVisualStyleBackColor = false;
            this.btn_AddGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RemoveGame
            // 
            this.btn_RemoveGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_RemoveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveGame.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_RemoveGame.Image = global::GameLauncher.Properties.Resources.close_circle_remove_delete_icon_149506__1_;
            this.btn_RemoveGame.Location = new System.Drawing.Point(40, 157);
            this.btn_RemoveGame.Name = "btn_RemoveGame";
            this.btn_RemoveGame.Size = new System.Drawing.Size(75, 81);
            this.btn_RemoveGame.TabIndex = 3;
            this.btn_RemoveGame.Text = "Remove game";
            this.btn_RemoveGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_RemoveGame.UseVisualStyleBackColor = false;
            this.btn_RemoveGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(140, 59);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 179);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::GameLauncher.Properties.Resources.close_111152;
            this.button3.Location = new System.Drawing.Point(607, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 24);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(652, 289);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_RemoveGame);
            this.Controls.Add(this.btn_AddGame);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddGame;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_RemoveGame;
    }
}

