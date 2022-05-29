using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkladFrm frm = new SkladFrm();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PostavshikiFrm form4 = new PostavshikiFrm();  
            this.Hide();
            form4.ShowDialog();
            
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            ZakazFrm form5 = new ZakazFrm(); 
             this.Hide();
            form5.ShowDialog();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            authFrm frm = new authFrm();
            this.Hide();
            frm.Show();
        }
    }
}
