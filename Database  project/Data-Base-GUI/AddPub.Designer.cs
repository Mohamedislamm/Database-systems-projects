namespace DataBase
{
    partial class AddPub
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Add_Author_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PubName_Box = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.Address_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumber_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(30, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 25);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "← Back";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(332, 315);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(102, 28);
            this.Reset_Button.TabIndex = 64;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(192, 315);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(102, 28);
            this.Add_Button.TabIndex = 63;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "E-mail";
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(277, 161);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(157, 20);
            this.Email_Box.TabIndex = 61;
            // 
            // Add_Author_Label
            // 
            this.Add_Author_Label.AutoSize = true;
            this.Add_Author_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Author_Label.Location = new System.Drawing.Point(198, 35);
            this.Add_Author_Label.Name = "Add_Author_Label";
            this.Add_Author_Label.Size = new System.Drawing.Size(279, 39);
            this.Add_Author_Label.TabIndex = 58;
            this.Add_Author_Label.Text = "Add an Publisher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Name";
            // 
            // PubName_Box
            // 
            this.PubName_Box.Location = new System.Drawing.Point(277, 125);
            this.PubName_Box.Name = "PubName_Box";
            this.PubName_Box.Size = new System.Drawing.Size(157, 20);
            this.PubName_Box.TabIndex = 56;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(188, 198);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(45, 13);
            this.Address_label.TabIndex = 67;
            this.Address_label.Text = "Address";
            // 
            // Address_Box
            // 
            this.Address_Box.Location = new System.Drawing.Point(276, 195);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(157, 20);
            this.Address_Box.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Phone Number";
            // 
            // PhoneNumber_Box
            // 
            this.PhoneNumber_Box.Location = new System.Drawing.Point(276, 229);
            this.PhoneNumber_Box.Name = "PhoneNumber_Box";
            this.PhoneNumber_Box.Size = new System.Drawing.Size(157, 20);
            this.PhoneNumber_Box.TabIndex = 68;
            // 
            // AddPub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumber_Box);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.Add_Author_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PubName_Box);
            this.Name = "AddPub";
            this.Text = "AddPub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label Add_Author_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PubName_Box;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox Address_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneNumber_Box;
    }
}