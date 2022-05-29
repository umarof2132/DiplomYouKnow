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
    public partial class PostavshikiCard : UserControl
    {
        
      
        public PostavshikiCard()
        {
            InitializeComponent();
        }

        

        public void GeneratePost(Postavshiki p)
        {
            titleLbl.Text = "Название: " +  p.Title;
            phoneLbl.Text = "Телефон: " + p.Phone;
            emailLbl.Text = "Почта: " + p.Email;
            adrlbl.Text = "Адресс: " + p.Address;
        }

        private void PostavshikiCard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
