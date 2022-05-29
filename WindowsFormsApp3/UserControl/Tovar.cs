using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3
{
    public partial class Tovar : UserControl
    {
        public Tovar()
        {
            InitializeComponent();
        }

   public void GenerateData(Sklad a)
        {
            picBx.ImageLocation = a.Photo;
            TitleLbl.Text = a.Title;
            qtyLbl.Text = a.Quantity;
            
        }
    }
}
