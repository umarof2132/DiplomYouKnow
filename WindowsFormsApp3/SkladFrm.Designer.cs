namespace WindowsFormsApp3
{
    partial class SkladFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkladFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.descCheckBx = new System.Windows.Forms.CheckBox();
            this.sortComboBx = new System.Windows.Forms.ComboBox();
            this.searchTextBx = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.descCheckBx);
            this.panel1.Controls.Add(this.sortComboBx);
            this.panel1.Controls.Add(this.searchTextBx);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 623);
            this.panel1.TabIndex = 2;
            // 
            // descCheckBx
            // 
            this.descCheckBx.AutoSize = true;
            this.descCheckBx.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.descCheckBx.Location = new System.Drawing.Point(860, 74);
            this.descCheckBx.Name = "descCheckBx";
            this.descCheckBx.Size = new System.Drawing.Size(194, 35);
            this.descCheckBx.TabIndex = 8;
            this.descCheckBx.Text = "По Убыванию";
            this.descCheckBx.UseVisualStyleBackColor = true;
            this.descCheckBx.CheckedChanged += new System.EventHandler(this.descCheckBx_CheckedChanged);
            // 
            // sortComboBx
            // 
            this.sortComboBx.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.sortComboBx.FormattingEnabled = true;
            this.sortComboBx.Items.AddRange(new object[] {
            "По наименованию",
            "По количеству"});
            this.sortComboBx.Location = new System.Drawing.Point(500, 72);
            this.sortComboBx.Name = "sortComboBx";
            this.sortComboBx.Size = new System.Drawing.Size(321, 39);
            this.sortComboBx.TabIndex = 7;
            this.sortComboBx.SelectedIndexChanged += new System.EventHandler(this.sortComboBx_SelectedIndexChanged);
            // 
            // searchTextBx
            // 
            this.searchTextBx.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.searchTextBx.Location = new System.Drawing.Point(36, 72);
            this.searchTextBx.Name = "searchTextBx";
            this.searchTextBx.Size = new System.Drawing.Size(437, 39);
            this.searchTextBx.TabIndex = 6;
            this.searchTextBx.TextChanged += new System.EventHandler(this.searchTextBx_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1042, 344);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.backBtn.Location = new System.Drawing.Point(12, 533);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(208, 78);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.button1.Location = new System.Drawing.Point(822, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Склад";
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataSource = typeof(WindowsFormsApp3.Model.Sklad);
            // 
            // SkladFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 623);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkladFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.regFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox sortComboBx;
        private System.Windows.Forms.TextBox searchTextBx;
        private System.Windows.Forms.CheckBox descCheckBx;
    }
}