using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace management
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lparam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        public AppBody()

        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();

        }

        private void Log_in_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;

            }
            else
            {
                Log_in_Timer.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {

                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            
        }


         private void button1_Click(object sender, EventArgs e)
        {

        }

        private void titlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            App obj = new App();
            this.Hide();
            obj.Show();


        }




        private void expandSlidingpanelGUI()
        {
            //GUI adjustmemnts for adding

            BookstabButton.Text = " BOOKS ";
            BorrowerstabButton.Text = " BORROWERS";
            TransactiontabButton.Text = " TRANSACTION";
            SettingsButton.Text = "SETTINGS";
            AboutButton.Text = " ABOUT";
            button1.Show();

            BookstabButton.Image = null;
            BorrowerstabButton.Image = null;
            TransactiontabButton.Image = null;
            SettingsButton.Image = null;
            AboutButton.Image = null;


        }


        private void retractSlidingpanelGUI()
        {
            //GUI adjustmemnts for adding

            BookstabButton.Text = "";
            BorrowerstabButton.Text = "";
            TransactiontabButton.Text = "";
            SettingsButton.Text = "";
            AboutButton.Text = "";

            BookstabButton.Image = Properties.Resources.books_1_;
            BorrowerstabButton.Image =Properties.Resources.add_book_1_;
            TransactiontabButton.Image = Properties.Resources.left_and_right_arrows_1_;
            SettingsButton.Image = Properties.Resources.settings_1_;
            AboutButton.Image = Properties.Resources.info_popup_1_;
            button1.Hide();



        }



        //CODE FOR EXPANDING AND RETRACTING
        bool IsSlidingpannelExpanded;
        const int Maxsliderwidth =225;
        const int Minsliderwidth =120;


        private void togglebutton_Click(object sender, EventArgs e)
        {
            if(IsSlidingpannelExpanded)
            {
                //retract the pannel
                retractSlidingpanelGUI();

            }
            sliding_panel_timer.Start();

        }

        private void sliding_panel_timer_Tick(object sender, EventArgs e)
        {
            if (IsSlidingpannelExpanded)
            {
                //retract the pannel
                slidingpanel.Width -= 30;
                if(slidingpanel.Width<=Minsliderwidth)
                {
                    //stop retract
                    IsSlidingpannelExpanded = false;
                    sliding_panel_timer.Stop();

                    this.Refresh();

                }
            }
            else
            {
                //expand the panel
                slidingpanel.Width += 30;
                if (slidingpanel.Width >= Maxsliderwidth)
                {
                    //stop expand
                    IsSlidingpannelExpanded = true;
                    sliding_panel_timer.Stop();
                    expandSlidingpanelGUI();


                    this.Refresh();

                }

            }
        }

        private void BookstabButton_Click(object sender, EventArgs e)
        {
            if( !contentpanel.Controls.Contains(Books_UserControl.Instance))
            {
                contentpanel.Controls.Add(Books_UserControl.Instance);
                Books_UserControl.Instance.Dock = DockStyle.Fill;
                Books_UserControl.Instance.BringToFront();
            }

            else
            {
                Books_UserControl.Instance.BringToFront();
            }
        }

        private void slidingpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(AboutUserControl.Instance))
            {
                contentpanel.Controls.Add(AboutUserControl.Instance);
                AboutUserControl.Instance.Dock = DockStyle.Fill;
                AboutUserControl.Instance.BringToFront();
            }

            else
            {
                AboutUserControl.Instance.BringToFront();
            }
        }



        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Settings_UserControl1cs.Instance))
            {
                contentpanel.Controls.Add(Settings_UserControl1cs.Instance);
                Settings_UserControl1cs.Instance.Dock = DockStyle.Fill;
                Settings_UserControl1cs.Instance.BringToFront();
            }

            else
            {
                Settings_UserControl1cs.Instance.BringToFront();
            }

        }


        private void TransactiontabButton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Transaction_UserControl.Instance))
            {
                contentpanel.Controls.Add(Transaction_UserControl.Instance);
                Transaction_UserControl.Instance.Dock = DockStyle.Fill;
                Transaction_UserControl.Instance.BringToFront();
            }

            else
            {
                Transaction_UserControl.Instance.BringToFront();
            }
        }

        private void BorrowerstabButton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Borrower_UserControl.Instance))
            {
                contentpanel.Controls.Add(Borrower_UserControl.Instance);
                Borrower_UserControl.Instance.Dock = DockStyle.Fill;
                Borrower_UserControl.Instance.BringToFront();
            }

            else
            {
                Borrower_UserControl.Instance.BringToFront();
            }
        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
