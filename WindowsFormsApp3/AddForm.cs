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


namespace WindowsFormsApp3.Model
{
   
    public partial class AddForm : Form
    {
        Sklad sklad = new Sklad();
        Model1 db = new Model1();
       
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
           skladBindingSource.DataSource = DatabaseContext.db.Sklad.ToList();
        
            foreach (Tovar a in SkladFrm.selectedUC)
            {
                sklad = DatabaseContext.db.Sklad.First(x => x.Title == a.TitleLbl.Text);
                skladBindingSource.DataSource = sklad;
                pictureBox1.ImageLocation = sklad.Photo;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

                DatabaseContext.db.Sklad.Add(sklad);
           
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory + @"\pic\";
          

            DialogResult dialogresult = openFileDialog.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                int num = file.IndexOf("pic");
                file = file.Substring(num);
                pictureBox1.Image = Image.FromFile(file);
                sklad.Photo = file;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
