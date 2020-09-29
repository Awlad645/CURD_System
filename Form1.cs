using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURD_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete ss = new Delete();
            ss.Show();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            if(username=="admin" && password=="12345" )
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
               MessageBox.Show("Invelide UserName or Password", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD na = new ADD();
            na.Show();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search ss = new search();
            ss.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View ss = new View();
            ss.Show();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit ss = new Edit();
            ss.Show();
        }
    }
}
