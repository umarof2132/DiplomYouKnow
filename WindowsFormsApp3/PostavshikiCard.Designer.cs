namespace WindowsFormsApp3
{
    partial class PostavshikiCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adrlbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.postavshikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adrlbl
            // 
            this.adrlbl.AutoSize = true;
            this.adrlbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adrlbl.Location = new System.Drawing.Point(19, 71);
            this.adrlbl.Name = "adrlbl";
            this.adrlbl.Size = new System.Drawing.Size(102, 31);
            this.adrlbl.TabIndex = 0;
            this.adrlbl.Text = "Address";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLbl.Location = new System.Drawing.Point(19, 102);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(78, 31);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "Email";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.Location = new System.Drawing.Point(19, 40);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(83, 31);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = "Phone";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(19, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(64, 31);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Title";
            // 
            // postavshikiBindingSource
            // 
            this.postavshikiBindingSource.DataSource = typeof(WindowsFormsApp3.Model.Postavshiki);
            // 
            // PostavshikiCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.adrlbl);
            this.Name = "PostavshikiCard";
            this.Size = new System.Drawing.Size(793, 156);
            this.Load += new System.EventHandler(this.PostavshikiCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postavshikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource postavshikiBindingSource;
        private System.Windows.Forms.Label adrlbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label titleLbl;
    }
}
