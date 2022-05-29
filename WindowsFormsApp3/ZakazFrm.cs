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
    public partial class ZakazFrm : Form
    {
        public ZakazFrm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            this.Hide();
            frm.ShowDialog();
            
        }
    }
}
