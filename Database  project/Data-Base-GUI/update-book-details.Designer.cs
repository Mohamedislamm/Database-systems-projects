namespace DataBase
{
    partial class update_book_details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Rating_Box = new System.Windows.Forms.NumericUpDown();
            this.Rating = new System.Windows.Forms.Label();
            this.publishdate = new System.Windows.Forms.Label();
            this.PublishDate_Box = new System.Windows.Forms.DateTimePicker();
            this.Quantity_Box = new System.Windows.Forms.NumericUpDown();
            this.Quantity = new System.Windows.Forms.Label();
            this.Publisher_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Author_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Title_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBN_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rating_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.BookList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Rating_Box);
            this.panel1.Controls.Add(this.Rating);
            this.panel1.Controls.Add(this.publishdate);
            this.panel1.Controls.Add(this.PublishDate_Box);
            this.panel1.Controls.Add(this.Quantity_Box);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.Publisher_Box);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Author_Box);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Title_Box);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ISBN_Box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Reset_Button);
            this.panel1.Controls.Add(this.Add_Button);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 608);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(304, 65);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 32);
            this.SearchButton.TabIndex = 53;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(441, 65);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(342, 108);
            this.BookList.TabIndex = 52;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.BookList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 37);
            this.label5.TabIndex = 51;
            this.label5.Text = "Edit Book";
            // 
            // Rating_Box
            // 
            this.Rating_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rating_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating_Box.Location = new System.Drawing.Point(137, 359);
            this.Rating_Box.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rating_Box.Name = "Rating_Box";
            this.Rating_Box.Size = new System.Drawing.Size(161, 26);
            this.Rating_Box.TabIndex = 50;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.Location = new System.Drawing.Point(21, 361);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(62, 20);
            this.Rating.TabIndex = 49;
            this.Rating.Text = "Rating";
            // 
            // publishdate
            // 
            this.publishdate.AutoSize = true;
            this.publishdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishdate.Location = new System.Drawing.Point(21, 316);
            this.publishdate.Name = "publishdate";
            this.publishdate.Size = new System.Drawing.Size(111, 20);
            this.publishdate.TabIndex = 48;
            this.publishdate.Text = "Publish Date";
            // 
            // PublishDate_Box
            // 
            this.PublishDate_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishDate_Box.Location = new System.Drawing.Point(137, 311);
            this.PublishDate_Box.Name = "PublishDate_Box";
            this.PublishDate_Box.Size = new System.Drawing.Size(278, 26);
            this.PublishDate_Box.TabIndex = 47;
            // 
            // Quantity_Box
            // 
            this.Quantity_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_Box.Location = new System.Drawing.Point(137, 255);
            this.Quantity_Box.Name = "Quantity_Box";
            this.Quantity_Box.Size = new System.Drawing.Size(161, 26);
            this.Quantity_Box.TabIndex = 46;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(21, 257);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(76, 20);
            this.Quantity.TabIndex = 45;
            this.Quantity.Text = "Quantity";
            // 
            // Publisher_Box
            // 
            this.Publisher_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Publisher_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_Box.Location = new System.Drawing.Point(137, 210);
            this.Publisher_Box.Name = "Publisher_Box";
            this.Publisher_Box.Size = new System.Drawing.Size(161, 26);
            this.Publisher_Box.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Publisher";
            // 
            // Author_Box
            // 
            this.Author_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Author_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Box.Location = new System.Drawing.Point(137, 164);
            this.Author_Box.Name = "Author_Box";
            this.Author_Box.Size = new System.Drawing.Size(161, 26);
            this.Author_Box.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Author";
            // 
            // Title_Box
            // 
            this.Title_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Box.Location = new System.Drawing.Point(137, 115);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(161, 26);
            this.Title_Box.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Title";
            // 
            // ISBN_Box
            // 
            this.ISBN_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISBN_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_Box.Location = new System.Drawing.Point(137, 68);
            this.ISBN_Box.Name = "ISBN_Box";
            this.ISBN_Box.Size = new System.Drawing.Size(161, 26);
            this.ISBN_Box.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "ISBN";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.Location = new System.Drawing.Point(196, 412);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(130, 45);
            this.Reset_Button.TabIndex = 36;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(26, 412);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(130, 45);
            this.Add_Button.TabIndex = 35;
            this.Add_Button.Text = "Submit Edits";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 25);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "← Back";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 55;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_book_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 496);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "update_book_details";
            this.Text = "update_book_details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rating_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Rating_Box;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label publishdate;
        private System.Windows.Forms.DateTimePicker PublishDate_Box;
        private System.Windows.Forms.NumericUpDown Quantity_Box;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox Publisher_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Author_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Title_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ISBN_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}