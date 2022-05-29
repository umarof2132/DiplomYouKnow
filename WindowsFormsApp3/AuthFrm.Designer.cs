namespace WindowsFormsApp3
{
    partial class authFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.loginTxBox = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.passTxBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passShow = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passShow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(515, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(265, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Регистрация";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // loginTxBox
            // 
            this.loginTxBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginTxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTxBox.Location = new System.Drawing.Point(260, 166);
            this.loginTxBox.Name = "loginTxBox";
            this.loginTxBox.Size = new System.Drawing.Size(396, 44);
            this.loginTxBox.TabIndex = 3;
            // 
            // loginLbl
            // 
            this.loginLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(129, 174);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(105, 36);
            this.loginLbl.TabIndex = 5;
            this.loginLbl.Text = "Логин";
            // 
            // PassLbl
            // 
            this.PassLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.Location = new System.Drawing.Point(109, 223);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassLbl.Size = new System.Drawing.Size(125, 36);
            this.PassLbl.TabIndex = 6;
            this.PassLbl.Text = "Пароль";
            // 
            // passTxBox
            // 
            this.passTxBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passTxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTxBox.Location = new System.Drawing.Point(260, 223);
            this.passTxBox.Name = "passTxBox";
            this.passTxBox.Size = new System.Drawing.Size(396, 44);
            this.passTxBox.TabIndex = 7;
            this.passTxBox.UseSystemPasswordChar = true;
            this.passTxBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.loginTxBox);
            this.panel1.Controls.Add(this.loginLbl);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.passShow);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PassLbl);
            this.panel1.Controls.Add(this.passTxBox);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 543);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(286, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вход в систему";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.forbidden_159816_128;
            this.pictureBox1.Location = new System.Drawing.Point(767, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.leaf_149774_1280;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // passShow
            // 
            this.passShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passShow.Image = global::WindowsFormsApp3.Properties.Resources._1200px_PICOL_icon_View_svg;
            this.passShow.Location = new System.Drawing.Point(662, 231);
            this.passShow.Name = "passShow";
            this.passShow.Size = new System.Drawing.Size(38, 36);
            this.passShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passShow.TabIndex = 8;
            this.passShow.TabStop = false;
            this.passShow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // authFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 472);
            this.MinimumSize = new System.Drawing.Size(800, 472);
            this.Name = "authFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox loginTxBox;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox passTxBox;
        private System.Windows.Forms.PictureBox passShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

