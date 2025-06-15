namespace DataBase
{
    partial class AddAuthor
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
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Author_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FirstName_Box
            // 
            this.FirstName_Box.Location = new System.Drawing.Point(350, 110);
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.Size = new System.Drawing.Size(157, 20);
            this.FirstName_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Add_Author_Label
            // 
            this.Add_Author_Label.AutoSize = true;
            this.Add_Author_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Author_Label.Location = new System.Drawing.Point(271, 20);
            this.Add_Author_Label.Name = "Add_Author_Label";
            this.Add_Author_Label.Size = new System.Drawing.Size(236, 39);
            this.Add_Author_Label.TabIndex = 2;
            this.Add_Author_Label.Text = "Add an Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // LastName_Box
            // 
            this.LastName_Box.Location = new System.Drawing.Point(350, 147);
            this.LastName_Box.Name = "LastName_Box";
            this.LastName_Box.Size = new System.Drawing.Size(157, 20);
            this.LastName_Box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(350, 184);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(157, 20);
            this.Email_Box.TabIndex = 5;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(265, 250);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(102, 28);
            this.Add_Button.TabIndex = 7;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(405, 250);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(102, 28);
            this.Reset_Button.TabIndex = 8;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 25);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "← Back";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 301);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName_Box);
            this.Controls.Add(this.Add_Author_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName_Box);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Add_Author_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}