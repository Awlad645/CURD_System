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
    public partial class Delete : Form
    {
        public Delete()
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
                labelName.Text = DS.Tables[0].Rows[0][1].ToString();
                labelDep.Text = DS.Tables[0].Rows[0][3].ToString();
                labelSem.Text = DS.Tables[0].Rows[0][4].ToString();
                labelMob.Text = DS.Tables[0].Rows[0][5].ToString();
                labelEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                labelGender.Text = DS.Tables[0].Rows[0][7].ToString();
                labelBDG.Text = DS.Tables[0].Rows[0][8].ToString();
                labelAdd.Text = DS.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-EBMTG3S; database =CURD_System;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM add_Student WHERE St_ID = '" + textBox1.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Delete Successfully","success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
