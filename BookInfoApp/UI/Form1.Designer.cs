namespace BookInfoApp
{
    partial class BookInfoUI
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
            this.addBookGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookListView = new System.Windows.Forms.ListView();
            this.isbnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBookGroupBox.SuspendLayout();
            this.showGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBookGroupBox
            // 
            this.addBookGroupBox.Controls.Add(this.saveButton);
            this.addBookGroupBox.Controls.Add(this.authorTextBox);
            this.addBookGroupBox.Controls.Add(this.isbnTextBox);
            this.addBookGroupBox.Controls.Add(this.bookNameTextBox);
            this.addBookGroupBox.Controls.Add(this.label3);
            this.addBookGroupBox.Controls.Add(this.label2);
            this.addBookGroupBox.Controls.Add(this.label1);
            this.addBookGroupBox.Location = new System.Drawing.Point(58, 37);
            this.addBookGroupBox.Name = "addBookGroupBox";
            this.addBookGroupBox.Size = new System.Drawing.Size(515, 162);
            this.addBookGroupBox.TabIndex = 0;
            this.addBookGroupBox.TabStop = false;
            this.addBookGroupBox.Text = "Add Book";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(424, 127);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(156, 92);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(343, 20);
            this.authorTextBox.TabIndex = 5;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(156, 66);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(343, 20);
            this.isbnTextBox.TabIndex = 4;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(156, 40);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(343, 20);
            this.bookNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.searchButton);
            this.showGroupBox.Controls.Add(this.searchNameTextBox);
            this.showGroupBox.Controls.Add(this.label4);
            this.showGroupBox.Controls.Add(this.bookListView);
            this.showGroupBox.Location = new System.Drawing.Point(58, 229);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Size = new System.Drawing.Size(515, 212);
            this.showGroupBox.TabIndex = 1;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(424, 31);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(272, 31);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.searchNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // bookListView
            // 
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.isbnColumnHeader,
            this.nameColumnHeader,
            this.authorColumnHeader});
            this.bookListView.FullRowSelect = true;
            this.bookListView.GridLines = true;
            this.bookListView.Location = new System.Drawing.Point(16, 74);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(483, 116);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            this.bookListView.SelectedIndexChanged += new System.EventHandler(this.bookListView_SelectedIndexChanged);
            // 
            // isbnColumnHeader
            // 
            this.isbnColumnHeader.Text = "ISBN";
            this.isbnColumnHeader.Width = 81;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumnHeader.Width = 128;
            // 
            // authorColumnHeader
            // 
            this.authorColumnHeader.Text = "Author";
            this.authorColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorColumnHeader.Width = 196;
            // 
            // BookInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 467);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.addBookGroupBox);
            this.Name = "BookInfoUI";
            this.Text = "Book Information UI";
            this.addBookGroupBox.ResumeLayout(false);
            this.addBookGroupBox.PerformLayout();
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addBookGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.ColumnHeader isbnColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader authorColumnHeader;
    }
}

