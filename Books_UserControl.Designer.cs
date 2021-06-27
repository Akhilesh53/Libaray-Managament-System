namespace management
{
    partial class Books_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.searchbookbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbooks_textbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.AddNew_Button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.AccNo_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Author_Textbox = new System.Windows.Forms.TextBox();
            this.Publisher_Textbox = new System.Windows.Forms.TextBox();
            this.ISBN_Textbox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Deparment_comboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.BackColor = System.Drawing.Color.Honeydew;
            this.searchbookbutton.Location = new System.Drawing.Point(422, 121);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(261, 41);
            this.searchbookbutton.TabIndex = 0;
            this.searchbookbutton.Text = "Search Books";
            this.searchbookbutton.UseVisualStyleBackColor = false;
            this.searchbookbutton.Click += new System.EventHandler(this.searchbookbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 136);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Searchbooks_textbox
            // 
            this.Searchbooks_textbox.BackColor = System.Drawing.Color.White;
            this.Searchbooks_textbox.Location = new System.Drawing.Point(339, 61);
            this.Searchbooks_textbox.Multiline = true;
            this.Searchbooks_textbox.Name = "Searchbooks_textbox";
            this.Searchbooks_textbox.Size = new System.Drawing.Size(441, 32);
            this.Searchbooks_textbox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Id";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Salmon;
            this.delete_button.Location = new System.Drawing.Point(609, 349);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(181, 41);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNew_Button
            // 
            this.AddNew_Button.BackColor = System.Drawing.Color.PaleGreen;
            this.AddNew_Button.Location = new System.Drawing.Point(38, 349);
            this.AddNew_Button.Name = "AddNew_Button";
            this.AddNew_Button.Size = new System.Drawing.Size(187, 41);
            this.AddNew_Button.TabIndex = 6;
            this.AddNew_Button.Text = "Add new";
            this.AddNew_Button.UseVisualStyleBackColor = false;
            this.AddNew_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.PeachPuff;
            this.update_button.Location = new System.Drawing.Point(328, 349);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(172, 41);
            this.update_button.TabIndex = 7;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.BackColor = System.Drawing.Color.Yellow;
            this.clear_Button.Location = new System.Drawing.Point(883, 349);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(167, 41);
            this.clear_Button.TabIndex = 8;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = false;
            this.clear_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // AccNo_Textbox
            // 
            this.AccNo_Textbox.Location = new System.Drawing.Point(153, 495);
            this.AccNo_Textbox.Multiline = true;
            this.AccNo_Textbox.Name = "AccNo_Textbox";
            this.AccNo_Textbox.Size = new System.Drawing.Size(307, 33);
            this.AccNo_Textbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Acc No.";
            // 
            // Author_Textbox
            // 
            this.Author_Textbox.Location = new System.Drawing.Point(743, 645);
            this.Author_Textbox.Multiline = true;
            this.Author_Textbox.Name = "Author_Textbox";
            this.Author_Textbox.Size = new System.Drawing.Size(307, 33);
            this.Author_Textbox.TabIndex = 11;
            this.Author_Textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Publisher_Textbox
            // 
            this.Publisher_Textbox.Location = new System.Drawing.Point(153, 646);
            this.Publisher_Textbox.Multiline = true;
            this.Publisher_Textbox.Name = "Publisher_Textbox";
            this.Publisher_Textbox.Size = new System.Drawing.Size(307, 33);
            this.Publisher_Textbox.TabIndex = 12;
            // 
            // ISBN_Textbox
            // 
            this.ISBN_Textbox.Location = new System.Drawing.Point(743, 566);
            this.ISBN_Textbox.Multiline = true;
            this.ISBN_Textbox.Name = "ISBN_Textbox";
            this.ISBN_Textbox.Size = new System.Drawing.Size(307, 33);
            this.ISBN_Textbox.TabIndex = 13;
            this.ISBN_Textbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(153, 566);
            this.Name_textbox.Multiline = true;
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(307, 33);
            this.Name_textbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(644, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Publisher";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(644, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(46, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(605, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Department";
            // 
            // Deparment_comboBox
            // 
            this.Deparment_comboBox.FormattingEnabled = true;
            this.Deparment_comboBox.Location = new System.Drawing.Point(743, 504);
            this.Deparment_comboBox.Name = "Deparment_comboBox";
            this.Deparment_comboBox.Size = new System.Drawing.Size(307, 24);
            this.Deparment_comboBox.Sorted = true;
            this.Deparment_comboBox.TabIndex = 21;
            this.Deparment_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Books_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::management.Properties.Resources.images__6__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Deparment_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.ISBN_Textbox);
            this.Controls.Add(this.Publisher_Textbox);
            this.Controls.Add(this.Author_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccNo_Textbox);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.AddNew_Button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searchbooks_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbookbutton);
            this.Name = "Books_UserControl";
            this.Size = new System.Drawing.Size(1118, 738);
            this.Load += new System.EventHandler(this.Books_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbookbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Searchbooks_textbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button AddNew_Button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.TextBox AccNo_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Author_Textbox;
        private System.Windows.Forms.TextBox Publisher_Textbox;
        private System.Windows.Forms.TextBox ISBN_Textbox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Deparment_comboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
