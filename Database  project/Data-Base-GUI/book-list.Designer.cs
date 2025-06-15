namespace DataBase
{
    partial class book_list
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Rating_Box = new System.Windows.Forms.NumericUpDown();
            this.Rating = new System.Windows.Forms.Label();
            this.publishdate = new System.Windows.Forms.Label();
            this.PublishDate_Box = new System.Windows.Forms.DateTimePicker();
            this.Publisher_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Author_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Title_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBN_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rating_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(414, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "library";
            // 
            // Rating_Box
            // 
            this.Rating_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating_Box.Location = new System.Drawing.Point(344, 422);
            this.Rating_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Rating_Box.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rating_Box.Name = "Rating_Box";
            this.Rating_Box.Size = new System.Drawing.Size(250, 30);
            this.Rating_Box.TabIndex = 64;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.Location = new System.Drawing.Point(27, 416);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(73, 25);
            this.Rating.TabIndex = 63;
            this.Rating.Text = "Rating";
            // 
            // publishdate
            // 
            this.publishdate.AutoSize = true;
            this.publishdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishdate.Location = new System.Drawing.Point(27, 345);
            this.publishdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publishdate.Name = "publishdate";
            this.publishdate.Size = new System.Drawing.Size(134, 25);
            this.publishdate.TabIndex = 62;
            this.publishdate.Text = "Publish Date";
            // 
            // PublishDate_Box
            // 
            this.PublishDate_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishDate_Box.Location = new System.Drawing.Point(344, 348);
            this.PublishDate_Box.Margin = new System.Windows.Forms.Padding(4);
            this.PublishDate_Box.Name = "PublishDate_Box";
            this.PublishDate_Box.Size = new System.Drawing.Size(370, 30);
            this.PublishDate_Box.TabIndex = 61;
            // 
            // Publisher_Box
            // 
            this.Publisher_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_Box.Location = new System.Drawing.Point(344, 270);
            this.Publisher_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Publisher_Box.Name = "Publisher_Box";
            this.Publisher_Box.Size = new System.Drawing.Size(238, 30);
            this.Publisher_Box.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Publisher";
            // 
            // Author_Box
            // 
            this.Author_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Box.Location = new System.Drawing.Point(344, 199);
            this.Author_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Author_Box.Name = "Author_Box";
            this.Author_Box.Size = new System.Drawing.Size(238, 30);
            this.Author_Box.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Author";
            // 
            // Title_Box
            // 
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Box.Location = new System.Drawing.Point(344, 124);
            this.Title_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(238, 30);
            this.Title_Box.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Title";
            // 
            // ISBN_Box
            // 
            this.ISBN_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_Box.Location = new System.Drawing.Point(344, 497);
            this.ISBN_Box.Margin = new System.Windows.Forms.Padding(4);
            this.ISBN_Box.Name = "ISBN_Box";
            this.ISBN_Box.Size = new System.Drawing.Size(238, 30);
            this.ISBN_Box.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "ISBN";
            // 
            // book_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 760);
            this.Controls.Add(this.Rating_Box);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.publishdate);
            this.Controls.Add(this.PublishDate_Box);
            this.Controls.Add(this.Publisher_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Author_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBN_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "book_list";
            this.Text = "book_list";
            this.Load += new System.EventHandler(this.book_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rating_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Rating_Box;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label publishdate;
        private System.Windows.Forms.DateTimePicker PublishDate_Box;
        private System.Windows.Forms.TextBox Publisher_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Author_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Title_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ISBN_Box;
        private System.Windows.Forms.Label label5;
    }
}