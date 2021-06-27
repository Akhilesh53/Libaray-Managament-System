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
using System.Xml;

namespace management
{
    public partial class Transaction_UserControl : UserControl
    {
        private static Transaction_UserControl _instance;

        public static Transaction_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transaction_UserControl();
                }
                return _instance;
            }
        }
        public Transaction_UserControl()
        {
            InitializeComponent();
        }

        private void Transaction_UserControl_Load(object sender, EventArgs e)
        {
            show_log_button.Hide();
        }

        

        public string Book1, Book2, Borrower;

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
         SqlDataReader dr;

        private void Searchborrower_Button_Click(object sender, EventArgs e)
        {
            //to get book1 
            con.Open();
            String syntax = "SELECT Book1 FROM Borrowers WHERE br_id= ' "+ Borrower_textBox.Text+ "' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Book1_label1.Text= Book1= dr[0].ToString();
            con.Close();

            //to get book2
            con.Open();
            syntax = "SELECT Book2 FROM Borrowers WHERE br_id= ' " + Borrower_textBox.Text + "' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Book2_label2.Text = Book2 = dr[0].ToString();
            con.Close();




        }

        private void Book_label_Click(object sender, EventArgs e)
        {

        }

        private void Issue_Button_Click(object sender, EventArgs e)
        {
            // see if book is borrowed by someone

           Searchborrower_Button.PerformClick();

            if (Borrower != "")
            {
                //someone has borrowed the book

                MessageBox.Show("Book is always borrowed by some other borrower with borrower id : \n " + Borrower);
                return;

            }


            Searchboook_Button.PerformClick();

            if ((Book1 != "") && (Book2 != ""))
            {
                //someone has borrowed the book

                MessageBox.Show("Borrower has already borrowed max no. of books");
                return;

            }


            try
            {
                if(Book1 == "")
                {
                    // accno must be updated in book 1 slot

                    cmd = new SqlCommand("Transact_update_Book1_SP", con);
                }
                
                else
                {
                    // accno must be updated in book 2 slot

                    cmd = new SqlCommand("Transact_update_Book2_SP", con);
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", accNo_textbox.Text);
                cmd.Parameters.AddWithValue("@br_id", Borrower_textBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
            }


            // Now we also update borrower's id in books table

            cmd = new SqlCommand("Transact_update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@accNo", accNo_textbox.Text);
            cmd.Parameters.AddWithValue("@br_id", Borrower_textBox.Text);


            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
            }
            con.Close();


// update in transaction table

            cmd = new SqlCommand("Transaction_insert_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@bkid", accNo_textbox.Text);
            cmd.Parameters.AddWithValue("@br_id", Borrower_textBox.Text);


            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
            }
            con.Close();





            Searchboook_Button.PerformClick();
            Searchborrower_Button.PerformClick();

            MessageBox.Show(" Successfully issued");


        }

        private void return_button_Click(object sender, EventArgs e)
        {

            // see if book has not been borrowed by someone

            Searchborrower_Button.PerformClick();

            Searchboook_Button.PerformClick();

            if ((accNo_textbox.Text != Book1) && (accNo_textbox.Text != Book2))

            { // borrower had not borrowed that book
                MessageBox.Show(" Borrower has not borrowed the book inputed");
                return;

            }

            // see if borrower had borrowed two books

            try
            {
                if (Book1 == accNo_textbox.Text)
                {
                    // accno must be updated in book 1 slot

                    cmd = new SqlCommand("Transact_update_Book1_SP", con);
                }

                else
                {
                    // accno must be updated in book 2 slot

                    cmd = new SqlCommand("Transact_update_Book2_SP", con);
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", (Object)DBNull.Value);
                cmd.Parameters.AddWithValue("@br_id", Borrower_textBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("  << Invalid sql operation  >> " + ex);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
            }


            // Now we also update borrower's id in books table

            cmd = new SqlCommand("Transact_update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@accNo", accNo_textbox.Text);
            cmd.Parameters.AddWithValue("@br_id", (Object)DBNull.Value);


            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
            }
            con.Close();

            //// we delso update transaction table


            cmd = new SqlCommand("Transaction_delete_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@bkid", accNo_textbox.Text);
            cmd.Parameters.AddWithValue("@br_id", Borrower_textBox.Text);


            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("  << Inbvalid sql operation  >> " + ex);
            }
            con.Close();




            Searchboook_Button.PerformClick();
            Searchborrower_Button.PerformClick();

            MessageBox.Show(" Successfully Returned");
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            accNo_textbox.Text = " ";
            Borrower_textBox.Text = " ";
        }

        private void show_log_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showBorrowerdata_SP", con);
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

                LogTrans_dataGridView1.DataSource = DS.Tables[0];
                this.LogTrans_dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.LogTrans_dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("   << invalid sql opeartion  \n" + ex);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void Searchboook_Button_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string syntax = "SELECT Borrower FROM books WHERE accNo= ' "+ accNo_textbox .Text + "' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Borrowedby_label3.Text = Borrower = dr[0].ToString();
            con.Close();

        }


        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showBorrowerdata_SP ", con);
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

                LogTrans_dataGridView1.DataSource = DS.Tables[0];
                this.LogTrans_dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.LogTrans_dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            catch (Exception ex)
            {
                MessageBox.Show("   << invalid sql opeartion  \n" + ex);
            }

        }

    }
}
