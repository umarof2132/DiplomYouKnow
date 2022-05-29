namespace WindowsFormsApp3
{
    partial class Tovar
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLbl.Location = new System.Drawing.Point(67, 150);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(197, 31);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Наименование";
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.qtyLbl.Location = new System.Drawing.Point(67, 191);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(28, 31);
            this.qtyLbl.TabIndex = 2;
            this.qtyLbl.Text = "1";
            // 
            // picBx
            // 
            this.picBx.Image = global::WindowsFormsApp3.Properties.Resources.заглушка;
            this.picBx.Location = new System.Drawing.Point(37, 3);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(166, 132);
            this.picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx.TabIndex = 0;
            this.picBx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(109, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шт";
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.picBx);
            this.Name = "Tovar";
            this.Size = new System.Drawing.Size(235, 251);
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBx;
        public System.Windows.Forms.Label TitleLbl;
        public System.Windows.Forms.Label qtyLbl;
        public System.Windows.Forms.Label label1;
    }
}
