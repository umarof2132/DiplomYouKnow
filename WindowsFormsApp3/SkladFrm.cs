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
using WindowsFormsApp3;

namespace WindowsFormsApp3
{
    public partial class SkladFrm : Form
    {
        Model1 db = new Model1();  
       public List<Sklad> sklad = new List<Sklad>(DatabaseContext.db.Sklad);
        public static List<UserControl> selectedUC = new List<UserControl>();
        public SkladFrm()
        {
            InitializeComponent();
        }

        private void regFrm_Load(object sender, EventArgs e)
        {
            skladBindingSource.DataSource = db.Sklad.ToList();
            GenerateDataCard(sklad);

        }

        private void GenerateDataCard(List<Sklad> sklad)
        {
            foreach (var a in sklad)
            {
                Tovar card = new Tovar();
                card.GenerateData(a);
                flowLayoutPanel1.Controls.Add(card);

                card.Click += new System.EventHandler(this.Card_Click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }
        private void SortListView()
        {
            var listUpdate = DatabaseContext.db.Sklad.ToList();
           

            // Search
            if (searchTextBx.Text != "Введите для поиска" && !string.IsNullOrWhiteSpace(searchTextBx.Text))
            {
                listUpdate = listUpdate.Where(x => x.Title.ToLower().Contains(searchTextBx.Text.ToLower()) || x.Quantity.ToLower().Contains(searchTextBx.Text.ToLower())).ToList();
            }

            // Sort
            if (sortComboBx.Text == "По наименованию")
            {
                if (!descCheckBx.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Title).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Title).ToList();
                }
            }
            if (sortComboBx.Text == "По количеству")
            {
                if (!descCheckBx.Checked)
                {
                    listUpdate = listUpdate.OrderBy(x => x.Quantity).ToList();
                }
                else
                {
                    listUpdate = listUpdate.OrderByDescending(x => x.Quantity).ToList();
                }
            }
            flowLayoutPanel1.Controls.Clear();
            GenerateDataCard(listUpdate);
        }
        private void Card_Click(object sender, EventArgs e)
        {
           UserControl card = sender as UserControl;

            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.Aqua;
                selectedUC.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                selectedUC.Remove(card);
            }
         
        }
        public void Card_DoubleClick(object sender, EventArgs e)
        {
            UserControl card = sender as UserControl;
            selectedUC.Add(card);
            AddForm editForm = new AddForm();
            DialogResult dialogResult = editForm.ShowDialog();
            SortListView();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            AddForm frm = new AddForm();
            frm.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            this.Hide();
            frm.ShowDialog();
        }

        private void searchTextBx_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBx.Text != "Введите для поиска")
            {
                flowLayoutPanel1.Controls.Clear();
                SortListView();
            }
        }

        private void sortComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
                flowLayoutPanel1.Controls.Clear();
                SortListView();
           
        }

        private void descCheckBx_CheckedChanged(object sender, EventArgs e)
        {
            
            
                flowLayoutPanel1.Controls.Clear();
                SortListView();
            
        }
    }
}
