namespace DataBase
{
    partial class Signup

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
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.LastName_Box = new System.Windows.Forms.TextBox();
            this.Address_Box = new System.Windows.Forms.TextBox();
            this.PhoneNumber_Box = new System.Windows.Forms.TextBox();
            this.Age_Box = new System.Windows.Forms.NumericUpDown();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Username_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Gender_Box = new System.Windows.Forms.ComboBox();
            this.UserType_Box = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Errors_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Age_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Submit_Button.Location = new System.Drawing.Point(103, 407);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(150, 46);
            this.Submit_Button.TabIndex = 2;
            this.Submit_Button.Text = "Signup";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Reset_Button.Location = new System.Drawing.Point(306, 407);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(150, 46);
            this.Reset_Button.TabIndex = 4;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // FirstName_Box
            // 
            this.FirstName_Box.Location = new System.Drawing.Point(210, 36);
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.Size = new System.Drawing.Size(188, 20);
            this.FirstName_Box.TabIndex = 6;
            // 
            // LastName_Box
            // 
            this.LastName_Box.Location = new System.Drawing.Point(210, 70);
            this.LastName_Box.Name = "LastName_Box";
            this.LastName_Box.Size = new System.Drawing.Size(188, 20);
            this.LastName_Box.TabIndex = 36;
            // 
            // Address_Box
            // 
            this.Address_Box.Location = new System.Drawing.Point(210, 102);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(188, 20);
            this.Address_Box.TabIndex = 19;
            // 
            // PhoneNumber_Box
            // 
            this.PhoneNumber_Box.Location = new System.Drawing.Point(210, 136);
            this.PhoneNumber_Box.Name = "PhoneNumber_Box";
            this.PhoneNumber_Box.Size = new System.Drawing.Size(188, 20);
            this.PhoneNumber_Box.TabIndex = 38;
            // 
            // Age_Box
            // 
            this.Age_Box.Location = new System.Drawing.Point(210, 163);
            this.Age_Box.Name = "Age_Box";
            this.Age_Box.Size = new System.Drawing.Size(100, 20);
            this.Age_Box.TabIndex = 35;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(210, 195);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(188, 20);
            this.Email_Box.TabIndex = 29;
            this.Email_Box.TextChanged += new System.EventHandler(this.Email_Box_TextChanged);
            // 
            // Username_Box
            // 
            this.Username_Box.Location = new System.Drawing.Point(210, 234);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(188, 20);
            this.Username_Box.TabIndex = 27;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(210, 268);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(188, 20);
            this.Password_Box.TabIndex = 28;
            this.Password_Box.UseSystemPasswordChar = true;
            // 
            // Gender_Box
            // 
            this.Gender_Box.ItemHeight = 13;
            this.Gender_Box.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_Box.Location = new System.Drawing.Point(210, 301);
            this.Gender_Box.Name = "Gender_Box";
            this.Gender_Box.Size = new System.Drawing.Size(121, 21);
            this.Gender_Box.TabIndex = 17;
            this.Gender_Box.SelectedIndexChanged += new System.EventHandler(this.Gender_Box_SelectedIndexChanged);
            // 
            // UserType_Box
            // 
            this.UserType_Box.ItemHeight = 13;
            this.UserType_Box.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.UserType_Box.Location = new System.Drawing.Point(210, 332);
            this.UserType_Box.Name = "UserType_Box";
            this.UserType_Box.Size = new System.Drawing.Size(121, 21);
            this.UserType_Box.TabIndex = 30;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label9.Location = new System.Drawing.Point(126, 39);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(57, 13);
            this.Label9.TabIndex = 9;
            this.Label9.Text = "First Name";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label18.Location = new System.Drawing.Point(126, 309);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(42, 13);
            this.Label18.TabIndex = 18;
            this.Label18.Text = "Gender";
            this.Label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label20.Location = new System.Drawing.Point(126, 109);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(45, 13);
            this.Label20.TabIndex = 20;
            this.Label20.Text = "Address";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label21.Location = new System.Drawing.Point(126, 170);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(26, 13);
            this.Label21.TabIndex = 21;
            this.Label21.Text = "Age";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label23.Location = new System.Drawing.Point(126, 241);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(55, 13);
            this.Label23.TabIndex = 23;
            this.Label23.Text = "Username";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label24.Location = new System.Drawing.Point(126, 275);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(53, 13);
            this.Label24.TabIndex = 24;
            this.Label24.Text = "Password";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label25.Location = new System.Drawing.Point(126, 202);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(35, 13);
            this.Label25.TabIndex = 25;
            this.Label25.Text = "E-mail";
            this.Label25.Click += new System.EventHandler(this.Label25_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label33.Location = new System.Drawing.Point(126, 340);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(56, 13);
            this.Label33.TabIndex = 33;
            this.Label33.Text = "User Type";
            // 
            // Errors_Label
            // 
            this.Errors_Label.AutoSize = true;
            this.Errors_Label.Font = new System.Drawing.Font("Nexa-Trial Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errors_Label.ForeColor = System.Drawing.Color.Red;
            this.Errors_Label.Location = new System.Drawing.Point(344, 13);
            this.Errors_Label.Name = "Errors_Label";
            this.Errors_Label.Size = new System.Drawing.Size(0, 25);
            this.Errors_Label.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(126, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(126, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(197, 371);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(223, 20);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an Account ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Signup
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 465);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName_Box);
            this.Controls.Add(this.LastName_Box);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.PhoneNumber_Box);
            this.Controls.Add(this.Age_Box);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.Username_Box);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Gender_Box);
            this.Controls.Add(this.UserType_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Errors_Label);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label33);
            this.Name = "Signup";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Age_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.TextBox LastName_Box;
        private System.Windows.Forms.TextBox Address_Box;
        private System.Windows.Forms.TextBox PhoneNumber_Box;
        private System.Windows.Forms.NumericUpDown Age_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox Username_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.ComboBox Gender_Box;
        private System.Windows.Forms.ComboBox UserType_Box;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.Label Label23;
        private System.Windows.Forms.Label Label24;
        private System.Windows.Forms.Label Label25;
        private System.Windows.Forms.Label Label33;
        private System.Windows.Forms.Label Errors_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

