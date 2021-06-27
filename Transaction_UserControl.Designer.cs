namespace management
{
    partial class Transaction_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.return_button = new System.Windows.Forms.Button();
            this.Borrower_textBox = new System.Windows.Forms.TextBox();
            this.accNo_textbox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.Searchboook_Button = new System.Windows.Forms.Button();
            this.Searchborrower_Button = new System.Windows.Forms.Button();
            this.Br_Id_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Issue_Button = new System.Windows.Forms.Button();
            this.Borrowedby_label2 = new System.Windows.Forms.Label();
            this.Book2_label2 = new System.Windows.Forms.Label();
            this.Borroweby_label1 = new System.Windows.Forms.Label();
            this.Book1_label1 = new System.Windows.Forms.Label();
            this.Borrowedby_label3 = new System.Windows.Forms.Label();
            this.Book_label = new System.Windows.Forms.Label();
            this.LogTrans_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_log_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogTrans_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.return_button.Location = new System.Drawing.Point(735, 390);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(172, 53);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "Return Book\r\n";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Borrower_textBox
            // 
            this.Borrower_textBox.Location = new System.Drawing.Point(383, 104);
            this.Borrower_textBox.Multiline = true;
            this.Borrower_textBox.Name = "Borrower_textBox";
            this.Borrower_textBox.Size = new System.Drawing.Size(335, 32);
            this.Borrower_textBox.TabIndex = 9;
            // 
            // accNo_textbox
            // 
            this.accNo_textbox.Location = new System.Drawing.Point(383, 257);
            this.accNo_textbox.Multiline = true;
            this.accNo_textbox.Name = "accNo_textbox";
            this.accNo_textbox.Size = new System.Drawing.Size(335, 32);
            this.accNo_textbox.TabIndex = 11;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Yellow;
            this.clear_button.Location = new System.Drawing.Point(442, 491);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(212, 43);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Searchboook_Button
            // 
            this.Searchboook_Button.BackColor = System.Drawing.Color.DimGray;
            this.Searchboook_Button.Location = new System.Drawing.Point(452, 312);
            this.Searchboook_Button.Name = "Searchboook_Button";
            this.Searchboook_Button.Size = new System.Drawing.Size(172, 47);
            this.Searchboook_Button.TabIndex = 13;
            this.Searchboook_Button.Text = "Search Book";
            this.Searchboook_Button.UseVisualStyleBackColor = false;
            this.Searchboook_Button.Click += new System.EventHandler(this.Searchboook_Button_Click);
            // 
            // Searchborrower_Button
            // 
            this.Searchborrower_Button.BackColor = System.Drawing.Color.DimGray;
            this.Searchborrower_Button.Location = new System.Drawing.Point(452, 158);
            this.Searchborrower_Button.Name = "Searchborrower_Button";
            this.Searchborrower_Button.Size = new System.Drawing.Size(172, 48);
            this.Searchborrower_Button.TabIndex = 14;
            this.Searchborrower_Button.Text = "Search Borrower";
            this.Searchborrower_Button.UseVisualStyleBackColor = false;
            this.Searchborrower_Button.Click += new System.EventHandler(this.Searchborrower_Button_Click);
            // 
            // Br_Id_label
            // 
            this.Br_Id_label.AutoSize = true;
            this.Br_Id_label.BackColor = System.Drawing.Color.Transparent;
            this.Br_Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Br_Id_label.Location = new System.Drawing.Point(225, 112);
            this.Br_Id_label.Name = "Br_Id_label";
            this.Br_Id_label.Size = new System.Drawing.Size(118, 24);
            this.Br_Id_label.TabIndex = 15;
            this.Br_Id_label.Text = "Borrower Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book Id/ Accession No.";
            // 
            // Issue_Button
            // 
            this.Issue_Button.BackColor = System.Drawing.Color.PaleGreen;
            this.Issue_Button.Location = new System.Drawing.Point(168, 390);
            this.Issue_Button.Name = "Issue_Button";
            this.Issue_Button.Size = new System.Drawing.Size(192, 53);
            this.Issue_Button.TabIndex = 17;
            this.Issue_Button.Text = "Issue Book";
            this.Issue_Button.UseVisualStyleBackColor = false;
            this.Issue_Button.Click += new System.EventHandler(this.Issue_Button_Click);
            // 
            // Borrowedby_label2
            // 
            this.Borrowedby_label2.AutoSize = true;
            this.Borrowedby_label2.BackColor = System.Drawing.Color.Transparent;
            this.Borrowedby_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowedby_label2.Location = new System.Drawing.Point(839, 146);
            this.Borrowedby_label2.Name = "Borrowedby_label2";
            this.Borrowedby_label2.Size = new System.Drawing.Size(61, 20);
            this.Borrowedby_label2.TabIndex = 18;
            this.Borrowedby_label2.Text = "Book2";
            // 
            // Book2_label2
            // 
            this.Book2_label2.AutoSize = true;
            this.Book2_label2.BackColor = System.Drawing.Color.Transparent;
            this.Book2_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book2_label2.Location = new System.Drawing.Point(974, 146);
            this.Book2_label2.Name = "Book2_label2";
            this.Book2_label2.Size = new System.Drawing.Size(125, 20);
            this.Book2_label2.TabIndex = 19;
            this.Book2_label2.Text = "BookId/accNo";
            // 
            // Borroweby_label1
            // 
            this.Borroweby_label1.AutoSize = true;
            this.Borroweby_label1.BackColor = System.Drawing.Color.Transparent;
            this.Borroweby_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borroweby_label1.Location = new System.Drawing.Point(839, 104);
            this.Borroweby_label1.Name = "Borroweby_label1";
            this.Borroweby_label1.Size = new System.Drawing.Size(61, 20);
            this.Borroweby_label1.TabIndex = 20;
            this.Borroweby_label1.Text = "Book1";
            this.Borroweby_label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // Book1_label1
            // 
            this.Book1_label1.AutoSize = true;
            this.Book1_label1.BackColor = System.Drawing.Color.Transparent;
            this.Book1_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book1_label1.Location = new System.Drawing.Point(974, 107);
            this.Book1_label1.Name = "Book1_label1";
            this.Book1_label1.Size = new System.Drawing.Size(131, 20);
            this.Book1_label1.TabIndex = 21;
            this.Book1_label1.Text = "BookId /accNo";
            // 
            // Borrowedby_label3
            // 
            this.Borrowedby_label3.AutoSize = true;
            this.Borrowedby_label3.BackColor = System.Drawing.Color.Transparent;
            this.Borrowedby_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowedby_label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Borrowedby_label3.Location = new System.Drawing.Point(974, 274);
            this.Borrowedby_label3.Name = "Borrowedby_label3";
            this.Borrowedby_label3.Size = new System.Drawing.Size(107, 20);
            this.Borrowedby_label3.TabIndex = 22;
            this.Borrowedby_label3.Text = "Borrower Id";
            // 
            // Book_label
            // 
            this.Book_label.AutoSize = true;
            this.Book_label.BackColor = System.Drawing.Color.Transparent;
            this.Book_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_label.Location = new System.Drawing.Point(821, 272);
            this.Book_label.Name = "Book_label";
            this.Book_label.Size = new System.Drawing.Size(114, 20);
            this.Book_label.TabIndex = 23;
            this.Book_label.Text = "Borrowed by";
            this.Book_label.Click += new System.EventHandler(this.Book_label_Click);
            // 
            // LogTrans_dataGridView1
            // 
            this.LogTrans_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogTrans_dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTrans_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogTrans_dataGridView1.Location = new System.Drawing.Point(106, 695);
            this.LogTrans_dataGridView1.Name = "LogTrans_dataGridView1";
            this.LogTrans_dataGridView1.RowHeadersWidth = 51;
            this.LogTrans_dataGridView1.RowTemplate.Height = 24;
            this.LogTrans_dataGridView1.Size = new System.Drawing.Size(930, 10);
            this.LogTrans_dataGridView1.TabIndex = 24;
            // 
            // show_log_button
            // 
            this.show_log_button.Location = new System.Drawing.Point(838, 628);
            this.show_log_button.Name = "show_log_button";
            this.show_log_button.Size = new System.Drawing.Size(231, 43);
            this.show_log_button.TabIndex = 25;
            this.show_log_button.Text = "SEE PREVIOUS TRANSACTIOS";
            this.show_log_button.UseVisualStyleBackColor = true;
            this.show_log_button.Click += new System.EventHandler(this.show_log_button_Click);
            // 
            // Transaction_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::management.Properties.Resources.images__6__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.show_log_button);
            this.Controls.Add(this.LogTrans_dataGridView1);
            this.Controls.Add(this.Book_label);
            this.Controls.Add(this.Borrowedby_label3);
            this.Controls.Add(this.Book1_label1);
            this.Controls.Add(this.Borroweby_label1);
            this.Controls.Add(this.Book2_label2);
            this.Controls.Add(this.Borrowedby_label2);
            this.Controls.Add(this.Issue_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Br_Id_label);
            this.Controls.Add(this.Searchborrower_Button);
            this.Controls.Add(this.Searchboook_Button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.accNo_textbox);
            this.Controls.Add(this.Borrower_textBox);
            this.Controls.Add(this.return_button);
            this.Name = "Transaction_UserControl";
            this.Size = new System.Drawing.Size(1116, 738);
            this.Load += new System.EventHandler(this.Transaction_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogTrans_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.TextBox Borrower_textBox;
        private System.Windows.Forms.TextBox accNo_textbox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button Searchboook_Button;
        private System.Windows.Forms.Button Searchborrower_Button;
        private System.Windows.Forms.Label Br_Id_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Issue_Button;
        private System.Windows.Forms.Label Borrowedby_label2;
        private System.Windows.Forms.Label Book2_label2;
        private System.Windows.Forms.Label Borroweby_label1;
        private System.Windows.Forms.Label Book1_label1;
        private System.Windows.Forms.Label Borrowedby_label3;
        private System.Windows.Forms.Label Book_label;
        private System.Windows.Forms.DataGridView LogTrans_dataGridView1;
        private System.Windows.Forms.Button show_log_button;
    }
}
