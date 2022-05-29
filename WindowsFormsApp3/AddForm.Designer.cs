namespace WindowsFormsApp3.Model
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articleLabel1;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label titleLabel1;
            this.saveBtn = new System.Windows.Forms.Button();
            this.panelTextAdd = new System.Windows.Forms.Panel();
            this.panelPicAdd = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            articleLabel1 = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            this.panelTextAdd.SuspendLayout();
            this.panelPicAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // articleLabel1
            // 
            articleLabel1.AutoSize = true;
            articleLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            articleLabel1.Location = new System.Drawing.Point(63, 23);
            articleLabel1.Name = "articleLabel1";
            articleLabel1.Size = new System.Drawing.Size(123, 31);
            articleLabel1.TabIndex = 13;
            articleLabel1.Text = "Артикуль";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            quantityLabel1.Location = new System.Drawing.Point(37, 140);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(149, 31);
            quantityLabel1.TabIndex = 15;
            quantityLabel1.Text = "Количество";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            titleLabel1.Location = new System.Drawing.Point(6, 81);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(180, 31);
            titleLabel1.TabIndex = 17;
            titleLabel1.Text = "Наименование";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.saveBtn.Location = new System.Drawing.Point(369, 233);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(151, 55);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTextAdd
            // 
            this.panelTextAdd.Controls.Add(this.articleTextBox);
            this.panelTextAdd.Controls.Add(this.quantityTextBox);
            this.panelTextAdd.Controls.Add(this.titleTextBox);
            this.panelTextAdd.Controls.Add(this.backBtn);
            this.panelTextAdd.Controls.Add(this.saveBtn);
            this.panelTextAdd.Controls.Add(articleLabel1);
            this.panelTextAdd.Controls.Add(titleLabel1);
            this.panelTextAdd.Controls.Add(quantityLabel1);
            this.panelTextAdd.Location = new System.Drawing.Point(-5, -5);
            this.panelTextAdd.Name = "panelTextAdd";
            this.panelTextAdd.Size = new System.Drawing.Size(540, 320);
            this.panelTextAdd.TabIndex = 19;
            // 
            // panelPicAdd
            // 
            this.panelPicAdd.Controls.Add(this.pictureBox1);
            this.panelPicAdd.Controls.Add(this.changeBtn);
            this.panelPicAdd.Location = new System.Drawing.Point(531, 10);
            this.panelPicAdd.Name = "panelPicAdd";
            this.panelPicAdd.Size = new System.Drawing.Size(391, 297);
            this.panelPicAdd.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.заглушка;
            this.pictureBox1.Location = new System.Drawing.Point(14, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.changeBtn.Location = new System.Drawing.Point(148, 218);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(151, 55);
            this.changeBtn.TabIndex = 8;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.backBtn.Location = new System.Drawing.Point(17, 233);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(151, 55);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // articleTextBox
            // 
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Article", true));
            this.articleTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.articleTextBox.Location = new System.Drawing.Point(205, 24);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(294, 39);
            this.articleTextBox.TabIndex = 20;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Quantity", true));
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.quantityTextBox.Location = new System.Drawing.Point(205, 141);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(294, 39);
            this.quantityTextBox.TabIndex = 22;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.titleTextBox.Location = new System.Drawing.Point(205, 81);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(294, 39);
            this.titleTextBox.TabIndex = 24;
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataSource = typeof(WindowsFormsApp3.Model.Sklad);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 315);
            this.Controls.Add(this.panelPicAdd);
            this.Controls.Add(this.panelTextAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panelTextAdd.ResumeLayout(false);
            this.panelTextAdd.PerformLayout();
            this.panelPicAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private System.Windows.Forms.Panel panelTextAdd;
        private System.Windows.Forms.Panel panelPicAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}