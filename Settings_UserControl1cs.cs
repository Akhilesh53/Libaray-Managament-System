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
    public partial class Settings_UserControl1cs : UserControl
    {

        private static Settings_UserControl1cs  _instance;

        public static Settings_UserControl1cs Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Settings_UserControl1cs();
                }
                return _instance;
            }
        }
        public Settings_UserControl1cs()
        {
            InitializeComponent();
        }

        private void Settings_UserControl1cs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This is a Settings Page");
        }
    }
}
