namespace DataBase
{
    partial class AddBook
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ISBN_Box = new System.Windows.Forms.TextBox();
            this.Title_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Author_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Publisher_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Quantity_Box = new System.Windows.Forms.NumericUpDown();
            this.PublishDate_Box = new System.Windows.Forms.DateTimePicker();
            this.publishdate = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Rating_Box = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(132, 345);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(130, 45);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.Location = new System.Drawing.Point(374, 345);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(130, 45);
            this.Reset_Button.TabIndex = 1;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // ISBN_Box
            // 
            this.ISBN_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_Box.Location = new System.Drawing.Point(132, 282);
            this.ISBN_Box.Name = "ISBN_Box";
            this.ISBN_Box.Size = new System.Drawing.Size(180, 26);
            this.ISBN_Box.TabIndex = 3;
            // 
            // Title_Box
            // 
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Box.Location = new System.Drawing.Point(132, 85);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(180, 26);
            this.Title_Box.TabIndex = 5;
            this.Title_Box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Author_Box
            // 
            this.Author_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Box.Location = new System.Drawing.Point(132, 116);
            this.Author_Box.Name = "Author_Box";
            this.Author_Box.Size = new System.Drawing.Size(180, 26);
            this.Author_Box.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // Publisher_Box
            // 
            this.Publisher_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_Box.Location = new System.Drawing.Point(132, 146);
            this.Publisher_Box.Name = "Publisher_Box";
            this.Publisher_Box.Size = new System.Drawing.Size(180, 26);
            this.Publisher_Box.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Publisher";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(10, 176);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(76, 20);
            this.Quantity.TabIndex = 10;
            this.Quantity.Text = "Quantity";
            // 
            // Quantity_Box
            // 
            this.Quantity_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_Box.Location = new System.Drawing.Point(132, 175);
            this.Quantity_Box.Name = "Quantity_Box";
            this.Quantity_Box.Size = new System.Drawing.Size(188, 26);
            this.Quantity_Box.TabIndex = 11;
            // 
            // PublishDate_Box
            // 
            this.PublishDate_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishDate_Box.Location = new System.Drawing.Point(132, 210);
            this.PublishDate_Box.Name = "PublishDate_Box";
            this.PublishDate_Box.Size = new System.Drawing.Size(278, 26);
            this.PublishDate_Box.TabIndex = 12;
            this.PublishDate_Box.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // publishdate
            // 
            this.publishdate.AutoSize = true;
            this.publishdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishdate.Location = new System.Drawing.Point(10, 210);
            this.publishdate.Name = "publishdate";
            this.publishdate.Size = new System.Drawing.Size(111, 20);
            this.publishdate.TabIndex = 13;
            this.publishdate.Text = "Publish Date";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.Location = new System.Drawing.Point(10, 239);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(62, 20);
            this.Rating.TabIndex = 15;
            this.Rating.Text = "Rating";
            this.Rating.Click += new System.EventHandler(this.label6_Click);
            // 
            // Rating_Box
            // 
            this.Rating_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating_Box.Location = new System.Drawing.Point(132, 241);
            this.Rating_Box.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rating_Box.Name = "Rating_Box";
            this.Rating_Box.Size = new System.Drawing.Size(188, 26);
            this.Rating_Box.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Add Book";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 25);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "← Back";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 438);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rating_Box);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.publishdate);
            this.Controls.Add(this.PublishDate_Box);
            this.Controls.Add(this.Quantity_Box);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Publisher_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Author_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBN_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Add_Button);
            this.Name = "AddBook";
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rating_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ISBN_Box;
        private System.Windows.Forms.TextBox Title_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Author_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Publisher_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.NumericUpDown Quantity_Box;
        private System.Windows.Forms.DateTimePicker PublishDate_Box;
        private System.Windows.Forms.Label publishdate;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.NumericUpDown Rating_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}