
namespace Tyuiu.AramaAG.Sprint7.Project.V11
{
    partial class FormMain
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
            this.panelTop_AAG = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelRight_AAG = new System.Windows.Forms.Panel();
            this.panelLeft_AAG = new System.Windows.Forms.Panel();
            this.dataGridViewStaff_AAG = new System.Windows.Forms.DataGridView();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HausAddres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Controls.Add(this.textBox1);
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(1717, 121);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 86);
            this.textBox1.TabIndex = 4;
            // 
            // panelRight_AAG
            // 
            this.panelRight_AAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_AAG.Location = new System.Drawing.Point(1330, 121);
            this.panelRight_AAG.Name = "panelRight_AAG";
            this.panelRight_AAG.Size = new System.Drawing.Size(387, 847);
            this.panelRight_AAG.TabIndex = 1;
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 121);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(275, 847);
            this.panelLeft_AAG.TabIndex = 2;
            // 
            // dataGridViewStaff_AAG
            // 
            this.dataGridViewStaff_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff_AAG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Familia,
            this.NameS,
            this.LastName,
            this.HausAddres,
            this.Birhday,
            this.Staff,
            this.DateOpen,
            this.Staz,
            this.Education});
            this.dataGridViewStaff_AAG.Location = new System.Drawing.Point(281, 213);
            this.dataGridViewStaff_AAG.Name = "dataGridViewStaff_AAG";
            this.dataGridViewStaff_AAG.RowHeadersVisible = false;
            this.dataGridViewStaff_AAG.RowHeadersWidth = 62;
            this.dataGridViewStaff_AAG.RowTemplate.Height = 28;
            this.dataGridViewStaff_AAG.Size = new System.Drawing.Size(1002, 518);
            this.dataGridViewStaff_AAG.TabIndex = 3;
            // 
            // Familia
            // 
            this.Familia.HeaderText = "Фамилия";
            this.Familia.MinimumWidth = 8;
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            this.Familia.Width = 150;
            // 
            // NameS
            // 
            this.NameS.HeaderText = "Имя";
            this.NameS.MinimumWidth = 8;
            this.NameS.Name = "NameS";
            this.NameS.ReadOnly = true;
            this.NameS.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Отчество";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 150;
            // 
            // HausAddres
            // 
            this.HausAddres.HeaderText = "Домашний адрес";
            this.HausAddres.MinimumWidth = 8;
            this.HausAddres.Name = "HausAddres";
            this.HausAddres.ReadOnly = true;
            this.HausAddres.Width = 150;
            // 
            // Birhday
            // 
            this.Birhday.HeaderText = "день рождения";
            this.Birhday.MinimumWidth = 8;
            this.Birhday.Name = "Birhday";
            this.Birhday.ReadOnly = true;
            this.Birhday.Width = 150;
            // 
            // Staff
            // 
            this.Staff.HeaderText = "Должность";
            this.Staff.MinimumWidth = 8;
            this.Staff.Name = "Staff";
            this.Staff.ReadOnly = true;
            this.Staff.Width = 150;
            // 
            // DateOpen
            // 
            this.DateOpen.HeaderText = "Дата зачисления";
            this.DateOpen.MinimumWidth = 8;
            this.DateOpen.Name = "DateOpen";
            this.DateOpen.ReadOnly = true;
            this.DateOpen.Width = 150;
            // 
            // Staz
            // 
            this.Staz.HeaderText = "Стаж";
            this.Staz.MinimumWidth = 8;
            this.Staz.Name = "Staz";
            this.Staz.ReadOnly = true;
            this.Staz.Width = 150;
            // 
            // Education
            // 
            this.Education.HeaderText = "Образование";
            this.Education.MinimumWidth = 8;
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            this.Education.Width = 150;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 968);
            this.Controls.Add(this.dataGridViewStaff_AAG);
            this.Controls.Add(this.panelLeft_AAG);
            this.Controls.Add(this.panelRight_AAG);
            this.Controls.Add(this.panelTop_AAG);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_AAG.ResumeLayout(false);
            this.panelTop_AAG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff_AAG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.Panel panelRight_AAG;
        private System.Windows.Forms.Panel panelLeft_AAG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewStaff_AAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HausAddres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
    }
}

