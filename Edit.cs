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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-EBMTG3S; database =CURD_System;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from add_Student where St_ID like '" + textBox1.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                textBox2.Text = DS.Tables[0].Rows[0][1].ToString();
                textBox3.Text = DS.Tables[0].Rows[0][3].ToString();
                textBox4.Text = DS.Tables[0].Rows[0][4].ToString();
                textBox5.Text = DS.Tables[0].Rows[0][5].ToString();
                textBox6.Text = DS.Tables[0].Rows[0][6].ToString();
                textBox7.Text = DS.Tables[0].Rows[0][7].ToString();
                textBox8.Text = DS.Tables[0].Rows[0][8].ToString();
                textBox9.Text = DS.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-EBMTG3S; database =CURD_System;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE add_Student SET St_Name ='"+textBox2.Text+ "' ,Department='" + textBox3.Text + "',Semester='" + textBox4.Text + "',Mobile='" + textBox5.Text + "',Email='" + textBox6.Text + "',Gender='" + textBox7.Text + "',BloodGroup='" + textBox8.Text + "',St_Address='" + textBox9.Text + "' WHERE St_ID ='" + textBox1.Text + "' ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            MessageBox.Show("Update Successfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
