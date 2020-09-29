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

namespace CURD_System
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string id = textID.Text;
            string dep = textDepartment.Text;
            string semester = textSemester.Text;
            Int64 mobile = Int64.Parse(textMobileNo.Text);
            string email = textEmail.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if(isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            
            string blood = textBlood.Text;
            string address = textAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-EBMTG3S; database =CURD_System;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into add_Student(St_Name,St_ID,Department,Semester,Mobile,Email,Gender,BloodGroup,St_Address) values ('" + name + "','" + id + "','" + dep + "','" + semester + "'," + mobile + ",'" + email + "','" + gender + "','" + blood + "','" + address + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            MessageBox.Show("ADD Successfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ADD_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-EBMTG3S; database =CURD_System;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(ADDID) from add_Student";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 n = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (n+1).ToString();

            con.Close();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
