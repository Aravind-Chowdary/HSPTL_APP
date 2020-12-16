namespace WindowsFormsApp1
{
    partial class staff_menu
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
            this.checkemailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkapointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customervistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoNeedCheckupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkPatientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.checkemailToolStripMenuItem,
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
            this.checkapointmentToolStripMenuItem,
            this.customervistToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // checkemailToolStripMenuItem
            // 
            this.checkemailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoNeedCheckupToolStripMenuItem,
            this.checkPatientDetailsToolStripMenuItem});
            this.checkemailToolStripMenuItem.Name = "checkemailToolStripMenuItem";
            this.checkemailToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.checkemailToolStripMenuItem.Text = "Check Patients";
            this.checkemailToolStripMenuItem.Click += new System.EventHandler(this.checkemailToolStripMenuItem_Click);
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.notificationToolStripMenuItem.Text = "Notification";
            // 
            // checkapointmentToolStripMenuItem
            // 
            this.checkapointmentToolStripMenuItem.Name = "checkapointmentToolStripMenuItem";
            this.checkapointmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkapointmentToolStripMenuItem.Text = "check_apointment";
            // 
            // customervistToolStripMenuItem
            // 
            this.customervistToolStripMenuItem.Name = "customervistToolStripMenuItem";
            this.customervistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customervistToolStripMenuItem.Text = "Customer_vist";
            // 
            // whoNeedCheckupToolStripMenuItem
            // 
            this.whoNeedCheckupToolStripMenuItem.Name = "whoNeedCheckupToolStripMenuItem";
            this.whoNeedCheckupToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.whoNeedCheckupToolStripMenuItem.Text = "Who need checkup";
            // 
            // checkPatientDetailsToolStripMenuItem
            // 
            this.checkPatientDetailsToolStripMenuItem.Name = "checkPatientDetailsToolStripMenuItem";
            this.checkPatientDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.checkPatientDetailsToolStripMenuItem.Text = "check patient details";
            // 
            // staff_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "staff_menu";
            this.Text = "staff_main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkemailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkapointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customervistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoNeedCheckupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkPatientDetailsToolStripMenuItem;
    }
}