namespace WindowsFormsApp1
{
    partial class Cust_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMedicalStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookapointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chnagePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.bookapointmentToolStripMenuItem,
            this.contactGPToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.notificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerGPToolStripMenuItem,
            this.updateMedicalStatusToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // registerGPToolStripMenuItem
            // 
            this.registerGPToolStripMenuItem.Name = "registerGPToolStripMenuItem";
            this.registerGPToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.registerGPToolStripMenuItem.Text = "Register GP";
            // 
            // updateMedicalStatusToolStripMenuItem
            // 
            this.updateMedicalStatusToolStripMenuItem.Name = "updateMedicalStatusToolStripMenuItem";
            this.updateMedicalStatusToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.updateMedicalStatusToolStripMenuItem.Text = "Update medical status";
            // 
            // bookapointmentToolStripMenuItem
            // 
            this.bookapointmentToolStripMenuItem.Name = "bookapointmentToolStripMenuItem";
            this.bookapointmentToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.bookapointmentToolStripMenuItem.Text = "Book apointment";
            this.bookapointmentToolStripMenuItem.Click += new System.EventHandler(this.bookapointmentToolStripMenuItem_Click);
            // 
            // contactGPToolStripMenuItem
            // 
            this.contactGPToolStripMenuItem.Name = "contactGPToolStripMenuItem";
            this.contactGPToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.contactGPToolStripMenuItem.Text = "Contact GP";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDetailsToolStripMenuItem,
            this.chnagePasswordToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medToolStripMenuItem});
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.updateDetailsToolStripMenuItem.Text = "Update details";
            // 
            // medToolStripMenuItem
            // 
            this.medToolStripMenuItem.Name = "medToolStripMenuItem";
            this.medToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.medToolStripMenuItem.Text = "Med";
            // 
            // chnagePasswordToolStripMenuItem
            // 
            this.chnagePasswordToolStripMenuItem.Name = "chnagePasswordToolStripMenuItem";
            this.chnagePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chnagePasswordToolStripMenuItem.Text = "Chnage password";
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.notificationToolStripMenuItem.Text = "Notifications";
            // 
            // Cust_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cust_menu";
            this.Text = "Cust_menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookapointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chnagePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMedicalStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
    }
}