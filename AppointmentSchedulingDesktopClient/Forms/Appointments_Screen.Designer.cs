namespace Appointment_Scheduling_Desktop_App
{
    partial class Appointments_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments_Screen));
            this.Page_Strip = new System.Windows.Forms.ToolStrip();
            this.Home_Button = new System.Windows.Forms.ToolStripButton();
            this.Employees_Button = new System.Windows.Forms.ToolStripButton();
            this.Appointments_Button = new System.Windows.Forms.ToolStripButton();
            this.Services_Button = new System.Windows.Forms.ToolStripButton();
            this.Customers_Button = new System.Windows.Forms.ToolStripButton();
            this.Delete_Appointment_Button = new System.Windows.Forms.Button();
            this.Approve_Appointment_Button = new System.Windows.Forms.Button();
            this.Update_Appointment_Button = new System.Windows.Forms.Button();
            this.appointmentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.Page_Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).BeginInit();
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
            this.Page_Strip.Size = new System.Drawing.Size(97, 519);
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
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
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
            // Delete_Appointment_Button
            // 
            this.Delete_Appointment_Button.BackColor = System.Drawing.Color.IndianRed;
            this.Delete_Appointment_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Delete_Appointment_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Appointment_Button.Location = new System.Drawing.Point(758, 0);
            this.Delete_Appointment_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Delete_Appointment_Button.Name = "Delete_Appointment_Button";
            this.Delete_Appointment_Button.Size = new System.Drawing.Size(74, 519);
            this.Delete_Appointment_Button.TabIndex = 12;
            this.Delete_Appointment_Button.Text = "Delete";
            this.Delete_Appointment_Button.UseVisualStyleBackColor = false;
            // 
            // Approve_Appointment_Button
            // 
            this.Approve_Appointment_Button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Approve_Appointment_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Approve_Appointment_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Approve_Appointment_Button.Location = new System.Drawing.Point(832, 0);
            this.Approve_Appointment_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Approve_Appointment_Button.Name = "Approve_Appointment_Button";
            this.Approve_Appointment_Button.Size = new System.Drawing.Size(101, 519);
            this.Approve_Appointment_Button.TabIndex = 10;
            this.Approve_Appointment_Button.Text = "Approve appointment";
            this.Approve_Appointment_Button.UseVisualStyleBackColor = false;
            // 
            // Update_Appointment_Button
            // 
            this.Update_Appointment_Button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Update_Appointment_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Update_Appointment_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_Appointment_Button.Location = new System.Drawing.Point(667, 0);
            this.Update_Appointment_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Update_Appointment_Button.Name = "Update_Appointment_Button";
            this.Update_Appointment_Button.Size = new System.Drawing.Size(91, 519);
            this.Update_Appointment_Button.TabIndex = 13;
            this.Update_Appointment_Button.Text = "Update appointment";
            this.Update_Appointment_Button.UseVisualStyleBackColor = false;
            // 
            // appointmentDTOBindingSource
            // 
            this.appointmentDTOBindingSource.DataSource = typeof(void);
            // 
            // lstAppointments
            // 
            this.lstAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.ItemHeight = 15;
            this.lstAppointments.Location = new System.Drawing.Point(97, 0);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(570, 519);
            this.lstAppointments.TabIndex = 14;
            // 
            // Appointments_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.Update_Appointment_Button);
            this.Controls.Add(this.Delete_Appointment_Button);
            this.Controls.Add(this.Approve_Appointment_Button);
            this.Controls.Add(this.Page_Strip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Appointments_Screen";
            this.Text = "Appointments";
            this.Page_Strip.ResumeLayout(false);
            this.Page_Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).EndInit();
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
        private System.Windows.Forms.Button Delete_Appointment_Button;
        private System.Windows.Forms.Button Approve_Appointment_Button;
        private System.Windows.Forms.Button Update_Appointment_Button;
        private BindingSource appointmentDTOBindingSource;
        private ListBox lstAppointments;
    }
}