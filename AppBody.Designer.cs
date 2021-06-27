namespace management
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.sliding_panel_timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TransactiontabButton = new System.Windows.Forms.Button();
            this.BorrowerstabButton = new System.Windows.Forms.Button();
            this.BookstabButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.togglebutton = new System.Windows.Forms.Button();
            this.titlebar = new System.Windows.Forms.Panel();
            this.logoff = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.slidingpanel.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Interval = 55;
            this.Log_in_Timer.Tick += new System.EventHandler(this.Log_in_Timer_Tick);
            // 
            // sliding_panel_timer
            // 
            this.sliding_panel_timer.Tick += new System.EventHandler(this.sliding_panel_timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.BackgroundImage = global::management.Properties.Resources.images__6__1_;
            this.contentpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(315, 49);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1124, 738);
            this.contentpanel.TabIndex = 3;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.slidingpanel.BackgroundImage = global::management.Properties.Resources.images__5__1_1;
            this.slidingpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slidingpanel.Controls.Add(this.SettingsButton);
            this.slidingpanel.Controls.Add(this.button1);
            this.slidingpanel.Controls.Add(this.TransactiontabButton);
            this.slidingpanel.Controls.Add(this.BorrowerstabButton);
            this.slidingpanel.Controls.Add(this.BookstabButton);
            this.slidingpanel.Controls.Add(this.AboutButton);
            this.slidingpanel.Controls.Add(this.togglebutton);
            this.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidingpanel.ForeColor = System.Drawing.Color.Black;
            this.slidingpanel.Location = new System.Drawing.Point(0, 49);
            this.slidingpanel.Name = "slidingpanel";
            this.slidingpanel.Size = new System.Drawing.Size(315, 738);
            this.slidingpanel.TabIndex = 2;
            this.slidingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slidingpanel_Paint);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Image = global::management.Properties.Resources.settings_1_;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(-3, 407);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(316, 124);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "SETTINGS";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TransactiontabButton
            // 
            this.TransactiontabButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactiontabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactiontabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactiontabButton.ForeColor = System.Drawing.Color.Black;
            this.TransactiontabButton.Image = global::management.Properties.Resources.left_and_right_arrows_1_;
            this.TransactiontabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactiontabButton.Location = new System.Drawing.Point(-3, 289);
            this.TransactiontabButton.Name = "TransactiontabButton";
            this.TransactiontabButton.Size = new System.Drawing.Size(316, 115);
            this.TransactiontabButton.TabIndex = 7;
            this.TransactiontabButton.Text = "TRANSACTION";
            this.TransactiontabButton.UseVisualStyleBackColor = false;
            this.TransactiontabButton.Click += new System.EventHandler(this.TransactiontabButton_Click);
            // 
            // BorrowerstabButton
            // 
            this.BorrowerstabButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowerstabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowerstabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowerstabButton.ForeColor = System.Drawing.Color.Black;
            this.BorrowerstabButton.Image = global::management.Properties.Resources.add_book_1_;
            this.BorrowerstabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowerstabButton.Location = new System.Drawing.Point(-5, 176);
            this.BorrowerstabButton.Name = "BorrowerstabButton";
            this.BorrowerstabButton.Size = new System.Drawing.Size(318, 116);
            this.BorrowerstabButton.TabIndex = 6;
            this.BorrowerstabButton.Text = "BORROWERS";
            this.BorrowerstabButton.UseVisualStyleBackColor = false;
            this.BorrowerstabButton.Click += new System.EventHandler(this.BorrowerstabButton_Click);
            // 
            // BookstabButton
            // 
            this.BookstabButton.BackColor = System.Drawing.Color.Transparent;
            this.BookstabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookstabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookstabButton.ForeColor = System.Drawing.Color.Black;
            this.BookstabButton.Image = global::management.Properties.Resources.books_1_;
            this.BookstabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookstabButton.Location = new System.Drawing.Point(-3, 48);
            this.BookstabButton.Name = "BookstabButton";
            this.BookstabButton.Size = new System.Drawing.Size(318, 122);
            this.BookstabButton.TabIndex = 5;
            this.BookstabButton.Text = "BOOKS";
            this.BookstabButton.UseVisualStyleBackColor = false;
            this.BookstabButton.Click += new System.EventHandler(this.BookstabButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.Black;
            this.AboutButton.Image = global::management.Properties.Resources.info_popup_1_;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(-2, 537);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(315, 104);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "ABOUT";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // togglebutton
            // 
            this.togglebutton.BackColor = System.Drawing.Color.Transparent;
            this.togglebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.togglebutton.Font = new System.Drawing.Font("Ravie", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglebutton.Location = new System.Drawing.Point(0, 3);
            this.togglebutton.Name = "togglebutton";
            this.togglebutton.Size = new System.Drawing.Size(315, 39);
            this.togglebutton.TabIndex = 3;
            this.togglebutton.Text = "Slide";
            this.togglebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.togglebutton.UseVisualStyleBackColor = false;
            this.togglebutton.Click += new System.EventHandler(this.togglebutton_Click);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.Peru;
            this.titlebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlebar.BackgroundImage")));
            this.titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlebar.Controls.Add(this.logoff);
            this.titlebar.Controls.Add(this.minimize);
            this.titlebar.Controls.Add(this.closebutton);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1439, 49);
            this.titlebar.TabIndex = 0;
            this.titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.titlebar_Paint);
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            // 
            // logoff
            // 
            this.logoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoff.BackgroundImage")));
            this.logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoff.Location = new System.Drawing.Point(1313, 12);
            this.logoff.Name = "logoff";
            this.logoff.Size = new System.Drawing.Size(38, 34);
            this.logoff.TabIndex = 2;
            this.logoff.UseVisualStyleBackColor = true;
            this.logoff.Click += new System.EventHandler(this.button3_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(1357, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 34);
            this.minimize.TabIndex = 2;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Location = new System.Drawing.Point(1398, 12);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(41, 34);
            this.closebutton.TabIndex = 1;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::management.Properties.Resources.images__5__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1439, 787);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.slidingpanel);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "App body";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.slidingpanel.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Button logoff;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Button togglebutton;
        private System.Windows.Forms.Timer sliding_panel_timer;
        private System.Windows.Forms.Button TransactiontabButton;
        private System.Windows.Forms.Button BorrowerstabButton;
        private System.Windows.Forms.Button BookstabButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel contentpanel;
    }
}