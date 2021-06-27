using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace management
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUsername()
        {
            con.Open();
            String syntax = "SELECT Prop_value FROM systemTable WHERE  Property= 'username' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();

            String temp = dr[0].ToString();
            con.Close();
            return temp;





        }

        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT Prop_value FROM systemTable WHERE  Property = 'password' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }





        




        private void button1_Click(object sender, EventArgs e)
        {

            

            String Uname = getUsername(), Upass = getPassword(); 
            String name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                //load
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();


            }
            else
            {

                MessageBox.Show("Please enter valid credentials");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
