namespace NVBSystems
{
    partial class LogIn
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rommelBtn = new MetroFramework.Controls.MetroTile();
            this.annieBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.rommelBtn);
            this.metroPanel1.Controls.Add(this.annieBtn);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(718, 438);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rommelBtn
            // 
            this.rommelBtn.ActiveControl = null;
            this.rommelBtn.Location = new System.Drawing.Point(182, 32);
            this.rommelBtn.Name = "rommelBtn";
            this.rommelBtn.Size = new System.Drawing.Size(173, 106);
            this.rommelBtn.Style = MetroFramework.MetroColorStyle.Silver;
            this.rommelBtn.TabIndex = 5;
            this.rommelBtn.Text = "Rommel";
            this.rommelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rommelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rommelBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.rommelBtn.UseSelectable = true;
            this.rommelBtn.Click += new System.EventHandler(this.goToMainMenu);
            // 
            // annieBtn
            // 
            this.annieBtn.ActiveControl = null;
            this.annieBtn.Location = new System.Drawing.Point(3, 32);
            this.annieBtn.Name = "annieBtn";
            this.annieBtn.Size = new System.Drawing.Size(173, 106);
            this.annieBtn.Style = MetroFramework.MetroColorStyle.Silver;
            this.annieBtn.TabIndex = 4;
            this.annieBtn.Text = "Annie";
            this.annieBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.annieBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.annieBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.annieBtn.UseSelectable = true;
            this.annieBtn.Click += new System.EventHandler(this.goToMainMenu);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(263, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Please select the user from the following:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 538);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LogIn";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Resizable = false;
            this.Text = "Carina Fresh Seafood - Log In Screen";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile rommelBtn;
        private MetroFramework.Controls.MetroTile annieBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}