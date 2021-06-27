using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace management
{
    public partial class Borrower_UserControl : UserControl
    {
        private static Borrower_UserControl _instance;

        public static Borrower_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrower_UserControl();
                }
                return _instance;
            }
        }
        public Borrower_UserControl()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|Database1.mdf;Integrated Security=True");



        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchBorrower_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   << invalid sql opeartion  \n" + ex);
                }
                con.Close();

                Borrower_dataGridView.DataSource = DS.Tables[0];
                this.Borrower_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Borrower_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Borrower_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Borrower_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Borrower_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            catch (Exception ex)
            {
                MessageBox.Show("   << invalid sql opeartion  \n" + ex);
            }

        }





        private void Borrower_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Searchborrower_Button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("searchBorrower_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@br_id", br_id_textBox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd); 
                DataSet DS = new DataSet();

                DA.Fill(DS);



                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   << invalid sql opeartion  \n" + ex);
                }
                con.Close();


                Borrower_dataGridView.DataSource = DS.Tables[0];
                this.Borrower_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Borrower_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Borrower_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Borrower_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.Borrower_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("   << invalid sql opeartion  \n" + ex);
            }
        }

        private void br_id_label_Click(object sender, EventArgs e)
        {

        }
    }
}
