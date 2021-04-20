using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string constr;



            // for the connection to 
            // sql server database
            SqlConnection con;
            constr = @"Data Source=DESKTOP-DE0LGOL\SAMEER;Initial Catalog=collegedb;Integrated Security=True";
            con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_student", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Deleting tab
            string constr;



            // for the connection to 
            // sql server database
            SqlConnection con;
            constr = @"Data Source=DESKTOP-DE0LGOL\SAMEER;Initial Catalog=collegedb;Integrated Security=True";
            con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from tbl_student where  std_id=31", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Console.WriteLine("Deleted Successfully",dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

     
        //private void button2_Click(object sender, EventArgs e)
        //{

        //    //Deleting tab
        //    string constr;



        //    // for the connection to 
        //    // sql server database
        //    SqlConnection con;
        //    constr = @"Data Source=DESKTOP-DE0LGOL\SAMEER;Initial Catalog=collegedb;Integrated Security=True";
        //    con = new SqlConnection(constr);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Delete from tbl_student where  roll_no=786", con);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();

        //    dataGridView1.DataSource = dt;
        //    con.Close();
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    //inserting tab
        //    string constr;



        //    // for the connection to 
        //    // sql server database
        //    SqlConnection con;
        //    constr = @"Data Source=DESKTOP-DE0LGOL\SAMEER;Initial Catalog=collegedb;Integrated Security=True";
        //    con = new SqlConnection(constr);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("insert into tbl_student values(30,786,'bunty',2,973922,'male','bunty@gmail.com')", con);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    con.Close();

        //}
    }
}