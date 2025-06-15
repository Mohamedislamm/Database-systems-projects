namespace DataBase
{
    partial class AddPublisher
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
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName_Box = new System.Windows.Forms.TextBox();
            this.Add_Author_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Address_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(397, 244);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(102, 28);
            this.Reset_Button.TabIndex = 17;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(257, 244);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(102, 28);
            this.Add_Button.TabIndex = 16;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail";
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(342, 178);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(157, 20);
            this.Email_Box.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name";
            // 
            // LastName_Box
            // 
            this.LastName_Box.Location = new System.Drawing.Point(342, 141);
            this.LastName_Box.Name = "LastName_Box";
            this.LastName_Box.Size = new System.Drawing.Size(157, 20);
            this.LastName_Box.TabIndex = 12;
            // 
            // Add_Author_Label
            // 
            this.Add_Author_Label.AutoSize = true;
            this.Add_Author_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Author_Label.Location = new System.Drawing.Point(263, 14);
            this.Add_Author_Label.Name = "Add_Author_Label";
            this.Add_Author_Label.Size = new System.Drawing.Size(279, 39);
            this.Add_Author_Label.TabIndex = 11;
            this.Add_Author_Label.Text = "Add an Publisher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // FirstName_Box
            // 
            this.FirstName_Box.Location = new System.Drawing.Point(342, 104);
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.Size = new System.Drawing.Size(157, 20);
            this.FirstName_Box.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Address_Box
            // 
            this.Address_Box.Location = new System.Drawing.Point(342, 212);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(157, 20);
            this.Address_Box.TabIndex = 18;
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName_Box);
            this.Controls.Add(this.Add_Author_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName_Box);
            this.Name = "AddPublisher";
            this.Text = "AddPublisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.TextBox LastName_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox Address_Box;
        private System.Windows.Forms.Label Add_Author_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}