namespace NVBSystems
{
    partial class MainProgram
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuPanel = new MetroFramework.Controls.MetroPanel();
            this.buttonsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenuLeftPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.totalPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.posListView = new System.Windows.Forms.ListBox();
            this.deleteContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuPanel.SuspendLayout();
            this.mainMenuLeftPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.deleteContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.buttonsLayoutPanel);
            this.mainMenuPanel.Controls.Add(this.mainMenuLeftPanel);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel.HorizontalScrollbarBarColor = true;
            this.mainMenuPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainMenuPanel.HorizontalScrollbarSize = 10;
            this.mainMenuPanel.Location = new System.Drawing.Point(20, 80);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(873, 510);
            this.mainMenuPanel.TabIndex = 0;
            this.mainMenuPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainMenuPanel.VerticalScrollbarBarColor = true;
            this.mainMenuPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainMenuPanel.VerticalScrollbarSize = 10;
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(473, 510);
            this.buttonsLayoutPanel.TabIndex = 3;
            // 
            // mainMenuLeftPanel
            // 
            this.mainMenuLeftPanel.Controls.Add(this.metroPanel1);
            this.mainMenuLeftPanel.Controls.Add(this.posListView);
            this.mainMenuLeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainMenuLeftPanel.HorizontalScrollbarBarColor = true;
            this.mainMenuLeftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainMenuLeftPanel.HorizontalScrollbarSize = 10;
            this.mainMenuLeftPanel.Location = new System.Drawing.Point(473, 0);
            this.mainMenuLeftPanel.Name = "mainMenuLeftPanel";
            this.mainMenuLeftPanel.Size = new System.Drawing.Size(400, 510);
            this.mainMenuLeftPanel.TabIndex = 2;
            this.mainMenuLeftPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainMenuLeftPanel.VerticalScrollbarBarColor = true;
            this.mainMenuLeftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainMenuLeftPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.totalPriceLabel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 437);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(400, 73);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(75, 20);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total Price:";
            this.totalPriceLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // posListView
            // 
            this.posListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posListView.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posListView.FormattingEnabled = true;
            this.posListView.ItemHeight = 22;
            this.posListView.Location = new System.Drawing.Point(0, 0);
            this.posListView.Name = "posListView";
            this.posListView.Size = new System.Drawing.Size(400, 510);
            this.posListView.TabIndex = 3;
            // 
            // deleteContextMenu
            // 
            this.deleteContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deleteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.deleteContextMenu.Name = "deleteContextMenu";
            this.deleteContextMenu.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 610);
            this.Controls.Add(this.mainMenuPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainProgram";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Resizable = false;
            this.Text = "Carina Fresh Seafood - Main Menu";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MainProgram_SizeChanged);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuLeftPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.deleteContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayoutPanel;
        private MetroFramework.Controls.MetroPanel mainMenuLeftPanel;
        private MetroFramework.Controls.MetroContextMenu deleteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListBox posListView;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel totalPriceLabel;
    }
}

