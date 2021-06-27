namespace management
{
    partial class Borrower_UserControl
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.br_id_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.br_id_label = new System.Windows.Forms.Label();
            this.Borrower_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Borrower_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(587, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // br_id_textBox
            // 
            this.br_id_textBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.br_id_textBox.Location = new System.Drawing.Point(435, 168);
            this.br_id_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.br_id_textBox.Multiline = true;
            this.br_id_textBox.Name = "br_id_textBox";
            this.br_id_textBox.Size = new System.Drawing.Size(154, 30);
            this.br_id_textBox.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // br_id_label
            // 
            this.br_id_label.AutoSize = true;
            this.br_id_label.BackColor = System.Drawing.Color.Transparent;
            this.br_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_id_label.Location = new System.Drawing.Point(327, 173);
            this.br_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.br_id_label.Name = "br_id_label";
            this.br_id_label.Size = new System.Drawing.Size(111, 25);
            this.br_id_label.TabIndex = 4;
            this.br_id_label.Text = "Borrower Id";
            this.br_id_label.Click += new System.EventHandler(this.br_id_label_Click);
            // 
            // Borrower_dataGridView
            // 
            this.Borrower_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Borrower_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Borrower_dataGridView.Location = new System.Drawing.Point(285, 243);
            this.Borrower_dataGridView.Name = "Borrower_dataGridView";
            this.Borrower_dataGridView.RowHeadersWidth = 51;
            this.Borrower_dataGridView.RowTemplate.Height = 24;
            this.Borrower_dataGridView.Size = new System.Drawing.Size(461, 107);
            this.Borrower_dataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "All the details of Borrower";
            // 
            // Borrower_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::management.Properties.Resources.images__6__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Borrower_dataGridView);
            this.Controls.Add(this.br_id_label);
            this.Controls.Add(this.br_id_textBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Borrower_UserControl";
            this.Size = new System.Drawing.Size(1281, 738);
            this.Load += new System.EventHandler(this.Borrower_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Borrower_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox br_id_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label br_id_label;
        private System.Windows.Forms.DataGridView Borrower_dataGridView;
        private System.Windows.Forms.Label label1;
    }
}
