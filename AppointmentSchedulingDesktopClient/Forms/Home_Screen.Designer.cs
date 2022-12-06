namespace Appointment_Scheduling_Desktop_App
{
    partial class Home_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Screen));
            this.Page_Strip = new System.Windows.Forms.ToolStrip();
            this.Home_Button = new System.Windows.Forms.ToolStripButton();
            this.Employees_Button = new System.Windows.Forms.ToolStripButton();
            this.Appointments_Button = new System.Windows.Forms.ToolStripButton();
            this.Services_Button = new System.Windows.Forms.ToolStripButton();
            this.Customers_Button = new System.Windows.Forms.ToolStripButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Page_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page_Strip
            // 
            this.Page_Strip.Dock = System.Windows.Forms.DockStyle.Left;
            this.Page_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home_Button,
            this.Employees_Button,
            this.Appointments_Button,
            this.Services_Button,
            this.Customers_Button});
            this.Page_Strip.Location = new System.Drawing.Point(0, 0);
            this.Page_Strip.Name = "Page_Strip";
            this.Page_Strip.Size = new System.Drawing.Size(97, 471);
            this.Page_Strip.TabIndex = 4;
            this.Page_Strip.Text = "Page_Strip";
            // 
            // Home_Button
            // 
            this.Home_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Home_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(94, 21);
            this.Home_Button.Text = "Home";
            // 
            // Employees_Button
            // 
            this.Employees_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Employees_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Employees_Button.Image = ((System.Drawing.Image)(resources.GetObject("Employees_Button.Image")));
            this.Employees_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Employees_Button.Name = "Employees_Button";
            this.Employees_Button.Size = new System.Drawing.Size(94, 21);
            this.Employees_Button.Text = "Employees";
            this.Employees_Button.Click += new System.EventHandler(this.Employees_Button_Click);
            // 
            // Appointments_Button
            // 
            this.Appointments_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Appointments_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Appointments_Button.Image = ((System.Drawing.Image)(resources.GetObject("Appointments_Button.Image")));
            this.Appointments_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Appointments_Button.Name = "Appointments_Button";
            this.Appointments_Button.Size = new System.Drawing.Size(94, 21);
            this.Appointments_Button.Text = "Appointments";
            this.Appointments_Button.Click += new System.EventHandler(this.Appointments_Button_Click);
            // 
            // Services_Button
            // 
            this.Services_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Services_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Services_Button.Image = ((System.Drawing.Image)(resources.GetObject("Services_Button.Image")));
            this.Services_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Services_Button.Name = "Services_Button";
            this.Services_Button.Size = new System.Drawing.Size(94, 21);
            this.Services_Button.Text = "Services";
            this.Services_Button.Click += new System.EventHandler(this.Services_Button_Click);
            // 
            // Customers_Button
            // 
            this.Customers_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Customers_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customers_Button.Image = ((System.Drawing.Image)(resources.GetObject("Customers_Button.Image")));
            this.Customers_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Customers_Button.Name = "Customers_Button";
            this.Customers_Button.Size = new System.Drawing.Size(94, 21);
            this.Customers_Button.Text = "Customers";
            this.Customers_Button.Click += new System.EventHandler(this.Customers_Button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthCalendar1.Location = new System.Drawing.Point(615, 0);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // Home_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 471);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Page_Strip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home_Screen";
            this.Text = "Home";
            this.Page_Strip.ResumeLayout(false);
            this.Page_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Page_Strip;
        private System.Windows.Forms.ToolStripButton Home_Button;
        private System.Windows.Forms.ToolStripButton Employees_Button;
        private System.Windows.Forms.ToolStripButton Appointments_Button;
        private System.Windows.Forms.ToolStripButton Services_Button;
        private System.Windows.Forms.ToolStripButton Customers_Button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}