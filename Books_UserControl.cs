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
    public partial class Books_UserControl : UserControl

    {
        private static Books_UserControl _instance;

        public static Books_UserControl Instance
        {
            get
            {
                if(_instance== null)
                {
                    _instance = new Books_UserControl();
                }
                return _instance;
            }
        }
        
        public Books_UserControl()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|Database1.mdf;Integrated Security=True");


        private void Books_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbookbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchBook_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo ", Searchbooks_textbox.Text);

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

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("   << invalid sql opeartion  \n" + ex);
            }
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showBookData_SP ", con);
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

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
                 catch (Exception ex)
             {
                 MessageBox.Show("   << invalid sql opeartion  \n" + ex);
             }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo ", AccNo_Textbox.Text);
            cmd.Parameters.AddWithValue("@isbn", ISBN_Textbox.Text);
            cmd.Parameters.AddWithValue("@bk_Name ", Name_textbox.Text);
            cmd.Parameters.AddWithValue("@Author", Author_Textbox.Text);
            cmd.Parameters.AddWithValue("@Publisher", Publisher_Textbox.Text) ;
            cmd.Parameters.AddWithValue("@d_id", Deparment_comboBox.Text);


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

            refresh_DataGridView();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Deletedata_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo ", AccNo_Textbox.Text);

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

                refresh_DataGridView();
            }

            catch (Exception ex)
            {
                MessageBox.Show("   << invalid sql opeartion  \n" + ex);
            }







        }

        private void button4_Click(object sender, EventArgs e)
        {
            Searchbooks_textbox.Text = " ";
            AccNo_Textbox.Text = " ";
            Deparment_comboBox.Text = " ";
            ISBN_Textbox.Text = " ";
            Name_textbox.Text = " ";
            Publisher_Textbox.Text = " ";
            Author_Textbox.Text = " ";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
