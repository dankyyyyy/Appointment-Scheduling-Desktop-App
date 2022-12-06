namespace Appointment_Scheduling_Desktop_App
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.Page_Strip = new System.Windows.Forms.ToolStrip();
            this.Home_Button = new System.Windows.Forms.ToolStripButton();
            this.Employees_Button = new System.Windows.Forms.ToolStripButton();
            this.Appointments_Button = new System.Windows.Forms.ToolStripButton();
            this.Services_Button = new System.Windows.Forms.ToolStripButton();
            this.Customers_Button = new System.Windows.Forms.ToolStripButton();
            this.Update_Customer_Button = new System.Windows.Forms.Button();
            this.Delete_Customer_Button = new System.Windows.Forms.Button();
            this.Approve_Customer_Button = new System.Windows.Forms.Button();
            this.accountDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerBox = new System.Windows.Forms.ListBox();
            this.Page_Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDAOBindingSource)).BeginInit();
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
            // 
            // Update_Customer_Button
            // 
            this.Update_Customer_Button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Update_Customer_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Update_Customer_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_Customer_Button.Location = new System.Drawing.Point(667, 0);
            this.Update_Customer_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Update_Customer_Button.Name = "Update_Customer_Button";
            this.Update_Customer_Button.Size = new System.Drawing.Size(91, 519);
            this.Update_Customer_Button.TabIndex = 16;
            this.Update_Customer_Button.Text = "Update customer";
            this.Update_Customer_Button.UseVisualStyleBackColor = false;
            // 
            // Delete_Customer_Button
            // 
            this.Delete_Customer_Button.BackColor = System.Drawing.Color.IndianRed;
            this.Delete_Customer_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Delete_Customer_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Customer_Button.Location = new System.Drawing.Point(758, 0);
            this.Delete_Customer_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Delete_Customer_Button.Name = "Delete_Customer_Button";
            this.Delete_Customer_Button.Size = new System.Drawing.Size(74, 519);
            this.Delete_Customer_Button.TabIndex = 15;
            this.Delete_Customer_Button.Text = "Delete";
            this.Delete_Customer_Button.UseVisualStyleBackColor = false;
            // 
            // Approve_Customer_Button
            // 
            this.Approve_Customer_Button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Approve_Customer_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Approve_Customer_Button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Approve_Customer_Button.Location = new System.Drawing.Point(832, 0);
            this.Approve_Customer_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Approve_Customer_Button.Name = "Approve_Customer_Button";
            this.Approve_Customer_Button.Size = new System.Drawing.Size(101, 519);
            this.Approve_Customer_Button.TabIndex = 14;
            this.Approve_Customer_Button.Text = "Add customer";
            this.Approve_Customer_Button.UseVisualStyleBackColor = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.Update_Customer_Button);
            this.Controls.Add(this.Delete_Customer_Button);
            this.Controls.Add(this.Approve_Customer_Button);
            this.Controls.Add(this.Page_Strip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Page_Strip.ResumeLayout(false);
            this.Page_Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDAOBindingSource)).EndInit();
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
        private Button Update_Customer_Button;
        private Button Delete_Customer_Button;
        private Button Approve_Customer_Button;
        private BindingSource accountDAOBindingSource;
        private ListBox CustomerBox;
    }
}