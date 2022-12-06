namespace Appointment_Scheduling_Desktop_App
{
    partial class Login_Screen
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
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Welcome_Label.Location = new System.Drawing.Point(362, 112);
            this.Welcome_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(173, 38);
            this.Welcome_Label.TabIndex = 4;
            this.Welcome_Label.Text = "Welcome!";
            this.Welcome_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(370, 159);
            this.Email_Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(177, 23);
            this.Email_Box.TabIndex = 0;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(370, 189);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '1';
            this.Password_Box.Size = new System.Drawing.Size(177, 23);
            this.Password_Box.TabIndex = 1;
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_Button.Location = new System.Drawing.Point(414, 219);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(88, 27);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Log in";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.Welcome_Label);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Email_Box);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login_Screen";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Button Login_Button;
    }
}

