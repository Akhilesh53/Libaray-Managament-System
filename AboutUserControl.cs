using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class AboutUserControl : UserControl
    {
        private static AboutUserControl _instance;

        public static AboutUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AboutUserControl();
                }
                return _instance;
            }
        }
        public AboutUserControl()
        {
            InitializeComponent();
        }

        private void AboutUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
