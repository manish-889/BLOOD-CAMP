namespace BLOOD_CAMP
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonarDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deceraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new XanderUI.XUIButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donarToolStripMenuItem,
            this.searchDonarToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.deleteDonarToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donarToolStripMenuItem
            // 
            this.donarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonarToolStripMenuItem,
            this.updateDonarToolStripMenuItem,
            this.allDonarDetailsToolStripMenuItem});
            this.donarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donarToolStripMenuItem.Image")));
            this.donarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donarToolStripMenuItem.Name = "donarToolStripMenuItem";
            this.donarToolStripMenuItem.Size = new System.Drawing.Size(102, 64);
            this.donarToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonarToolStripMenuItem
            // 
            this.addNewDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonarToolStripMenuItem.Image")));
            this.addNewDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDonarToolStripMenuItem.Name = "addNewDonarToolStripMenuItem";
            this.addNewDonarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addNewDonarToolStripMenuItem.Text = "Add New Donor";
            this.addNewDonarToolStripMenuItem.Click += new System.EventHandler(this.addNewDonarToolStripMenuItem_Click);
            // 
            // updateDonarToolStripMenuItem
            // 
            this.updateDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDonarToolStripMenuItem.Image")));
            this.updateDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateDonarToolStripMenuItem.Name = "updateDonarToolStripMenuItem";
            this.updateDonarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.updateDonarToolStripMenuItem.Text = "Update Donor";
            this.updateDonarToolStripMenuItem.Click += new System.EventHandler(this.updateDonarToolStripMenuItem_Click);
            // 
            // allDonarDetailsToolStripMenuItem
            // 
            this.allDonarDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonarDetailsToolStripMenuItem.Image")));
            this.allDonarDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allDonarDetailsToolStripMenuItem.Name = "allDonarDetailsToolStripMenuItem";
            this.allDonarDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.allDonarDetailsToolStripMenuItem.Text = "All Donor Details";
            this.allDonarDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDonarDetailsToolStripMenuItem_Click);
            // 
            // searchDonarToolStripMenuItem
            // 
            this.searchDonarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.bloodGroupToolStripMenuItem});
            this.searchDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchDonarToolStripMenuItem.Image")));
            this.searchDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchDonarToolStripMenuItem.Name = "searchDonarToolStripMenuItem";
            this.searchDonarToolStripMenuItem.Size = new System.Drawing.Size(140, 64);
            this.searchDonarToolStripMenuItem.Text = "Search Donor";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationToolStripMenuItem.Image")));
            this.locationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodGroupToolStripMenuItem.Image")));
            this.bloodGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.bloodGroupToolStripMenuItem.Text = "Blood Group";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.deceraseToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(97, 64);
            this.stockToolStripMenuItem.Text = "stock";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increaseToolStripMenuItem.Image")));
            this.increaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.increaseToolStripMenuItem.Text = "Increase";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // deceraseToolStripMenuItem
            // 
            this.deceraseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deceraseToolStripMenuItem.Image")));
            this.deceraseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deceraseToolStripMenuItem.Name = "deceraseToolStripMenuItem";
            this.deceraseToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.deceraseToolStripMenuItem.Text = "Decrease";
            this.deceraseToolStripMenuItem.Click += new System.EventHandler(this.deceraseToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // deleteDonarToolStripMenuItem
            // 
            this.deleteDonarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDonarToolStripMenuItem1});
            this.deleteDonarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonarToolStripMenuItem.Image")));
            this.deleteDonarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonarToolStripMenuItem.Name = "deleteDonarToolStripMenuItem";
            this.deleteDonarToolStripMenuItem.Size = new System.Drawing.Size(138, 64);
            this.deleteDonarToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonarToolStripMenuItem1
            // 
            this.deleteDonarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonarToolStripMenuItem1.Image")));
            this.deleteDonarToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonarToolStripMenuItem1.Name = "deleteDonarToolStripMenuItem1";
            this.deleteDonarToolStripMenuItem1.Size = new System.Drawing.Size(147, 26);
            this.deleteDonarToolStripMenuItem1.Text = "Delete Donor";
            this.deleteDonarToolStripMenuItem1.Click += new System.EventHandler(this.deleteDonarToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(117, 64);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ButtonImage")));
            this.btnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.btnExit.ButtonText = "X";
            this.btnExit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnExit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.CornerRadius = 5;
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnExit.HoverTextColor = System.Drawing.Color.Silver;
            this.btnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(765, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.TextColor = System.Drawing.Color.Black;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDonarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDonarDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deceraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonarToolStripMenuItem1;
        private XanderUI.XUIButton btnExit;
    }
}