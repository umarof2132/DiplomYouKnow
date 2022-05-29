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
    public partial class PostavshikiFrm : Form
    {
        Model1 db = new Model1();
        public List<Postavshiki> postav = new List<Postavshiki>(DatabaseContext.db.Postavshiki);
        public static List<UserControl> PUC = new List<UserControl>();
        public PostavshikiFrm()
        {
            InitializeComponent();
         
        }
        public void GenerateDatePost(List<Postavshiki> postavshiki)
        {
            foreach (var x in postavshiki)
            {
                PostavshikiCard card = new PostavshikiCard();
                card.GeneratePost(x);
                flowLayoutPanel1.Controls.Add(card);

                card.Click += new System.EventHandler(this.Card_click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            ChangePostFrm frm = new ChangePostFrm();
            frm.ShowDialog();
        }

        private void Card_click(object sender, EventArgs e)
        {
            UserControl card = sender as UserControl;
            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.Aqua;
                PUC.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                PUC.Remove(card);
            }
        }
        public void SearchListView()
        {
            var update = DatabaseContext.db.Postavshiki.ToList();
             //search
             if (searchTxBx.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTxBx.Text))
            {
                update = update.Where(x => x.Title.ToLower().Contains(searchTxBx.Text.ToLower())).ToList();
            }
             flowLayoutPanel1.Controls.Clear();
            GenerateDatePost(update);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            this.Hide();
            frm.ShowDialog();
        }

        private void PostavshikiFrm_Load(object sender, EventArgs e)
        {
            postavshikiBindingSource.DataSource = db.Postavshiki.ToList();
            GenerateDatePost(postav);
        }

        private void searchTxBx_TextChanged(object sender, EventArgs e)
        {
            if (searchTxBx.Text != "Введите для поиска")
            {
                flowLayoutPanel1.Controls.Clear();
                SearchListView();
            }
        }
    }
}
