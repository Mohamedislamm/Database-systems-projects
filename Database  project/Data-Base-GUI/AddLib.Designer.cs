namespace DataBase
{
    partial class AddLib
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
            this.Contact_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BranchName_Box = new System.Windows.Forms.TextBox();
            this.Add_Author_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(31, 30);
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
            this.Reset_Button.Location = new System.Drawing.Point(358, 260);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(102, 28);
            this.Reset_Button.TabIndex = 64;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(218, 260);
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
            this.label4.Location = new System.Drawing.Point(215, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Contact Info";
            // 
            // Contact_Box
            // 
            this.Contact_Box.Location = new System.Drawing.Point(303, 184);
            this.Contact_Box.Name = "Contact_Box";
            this.Contact_Box.Size = new System.Drawing.Size(157, 20);
            this.Contact_Box.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Branch Name";
            // 
            // BranchName_Box
            // 
            this.BranchName_Box.Location = new System.Drawing.Point(303, 114);
            this.BranchName_Box.Name = "BranchName_Box";
            this.BranchName_Box.Size = new System.Drawing.Size(157, 20);
            this.BranchName_Box.TabIndex = 59;
            // 
            // Add_Author_Label
            // 
            this.Add_Author_Label.AutoSize = true;
            this.Add_Author_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Author_Label.Location = new System.Drawing.Point(224, 30);
            this.Add_Author_Label.Name = "Add_Author_Label";
            this.Add_Author_Label.Size = new System.Drawing.Size(236, 39);
            this.Add_Author_Label.TabIndex = 58;
            this.Add_Author_Label.Text = "Add an Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(303, 149);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(157, 20);
            this.Address.TabIndex = 56;
            // 
            // AddLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 344);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Contact_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BranchName_Box);
            this.Controls.Add(this.Add_Author_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Name = "AddLib";
            this.Text = "AddLib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Contact_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BranchName_Box;
        private System.Windows.Forms.Label Add_Author_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
    }
}