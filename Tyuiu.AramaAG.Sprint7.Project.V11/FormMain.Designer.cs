
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
            this.panelRight_AAG = new System.Windows.Forms.Panel();
            this.panelLeft_AAG = new System.Windows.Forms.Panel();
            this.CreateReport_AAG = new System.Windows.Forms.Button();
            this.dataGridViewStaff_AAG = new System.Windows.Forms.DataGridView();
            this.OpenFileDialogData_AAG = new System.Windows.Forms.OpenFileDialog();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HausAddres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birhday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOpenData_AAG = new System.Windows.Forms.Button();
            this.panelLeftTop_AAG = new System.Windows.Forms.Panel();
            this.panelLeftButtom_AAG = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelCenter_AAG = new System.Windows.Forms.Panel();
            this.buttonEditData_AGG = new System.Windows.Forms.Button();
            this.panelRightTop_AAG = new System.Windows.Forms.Panel();
            this.buttonSaveEdit_AGG = new System.Windows.Forms.Button();
            this.saveFileDialogData_AAG = new System.Windows.Forms.SaveFileDialog();
            this.panelLeftTop2_AAG = new System.Windows.Forms.Panel();
            this.panelRight_AAG.SuspendLayout();
            this.panelLeft_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff_AAG)).BeginInit();
            this.panelLeftTop_AAG.SuspendLayout();
            this.panelLeftButtom_AAG.SuspendLayout();
            this.panelCenter_AAG.SuspendLayout();
            this.panelRightTop_AAG.SuspendLayout();
            this.panelLeftTop2_AAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(1924, 121);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // panelRight_AAG
            // 
            this.panelRight_AAG.Controls.Add(this.panelLeftTop2_AAG);
            this.panelRight_AAG.Controls.Add(this.panelRightTop_AAG);
            this.panelRight_AAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_AAG.Location = new System.Drawing.Point(1718, 121);
            this.panelRight_AAG.Name = "panelRight_AAG";
            this.panelRight_AAG.Size = new System.Drawing.Size(206, 847);
            this.panelRight_AAG.TabIndex = 1;
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Controls.Add(this.panelLeftButtom_AAG);
            this.panelLeft_AAG.Controls.Add(this.panelLeftTop_AAG);
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 121);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(207, 847);
            this.panelLeft_AAG.TabIndex = 2;
            // 
            // CreateReport_AAG
            // 
            this.CreateReport_AAG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateReport_AAG.Location = new System.Drawing.Point(0, 43);
            this.CreateReport_AAG.Name = "CreateReport_AAG";
            this.CreateReport_AAG.Size = new System.Drawing.Size(207, 57);
            this.CreateReport_AAG.TabIndex = 0;
            this.CreateReport_AAG.Text = "Создать отчёт";
            this.CreateReport_AAG.UseVisualStyleBackColor = true;
            this.CreateReport_AAG.Click += new System.EventHandler(this.CreateReportClick_AAG);
            // 
            // dataGridViewStaff_AAG
            // 
            this.dataGridViewStaff_AAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff_AAG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Familia,
            this.NameS,
            this.LastName,
            this.HausAddres,
            this.Phone,
            this.Birhday,
            this.Staff,
            this.DateOpen,
            this.Staz,
            this.Education});
            this.dataGridViewStaff_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStaff_AAG.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStaff_AAG.Name = "dataGridViewStaff_AAG";
            this.dataGridViewStaff_AAG.RowHeadersVisible = false;
            this.dataGridViewStaff_AAG.RowHeadersWidth = 62;
            this.dataGridViewStaff_AAG.RowTemplate.Height = 28;
            this.dataGridViewStaff_AAG.Size = new System.Drawing.Size(1508, 847);
            this.dataGridViewStaff_AAG.TabIndex = 3;
            // 
            // OpenFileDialogData_AAG
            // 
            this.OpenFileDialogData_AAG.FileName = "openFileDialog1";
            // 
            // Familia
            // 
            this.Familia.HeaderText = "Фамилия";
            this.Familia.MinimumWidth = 8;
            this.Familia.Name = "Familia";
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
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 150;
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
            // buttonOpenData_AAG
            // 
            this.buttonOpenData_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenData_AAG.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenData_AAG.Name = "buttonOpenData_AAG";
            this.buttonOpenData_AAG.Size = new System.Drawing.Size(207, 100);
            this.buttonOpenData_AAG.TabIndex = 1;
            this.buttonOpenData_AAG.Text = "Открыть данные";
            this.buttonOpenData_AAG.UseVisualStyleBackColor = true;
            this.buttonOpenData_AAG.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // panelLeftTop_AAG
            // 
            this.panelLeftTop_AAG.Controls.Add(this.buttonOpenData_AAG);
            this.panelLeftTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop_AAG.Name = "panelLeftTop_AAG";
            this.panelLeftTop_AAG.Size = new System.Drawing.Size(207, 100);
            this.panelLeftTop_AAG.TabIndex = 2;
            // 
            // panelLeftButtom_AAG
            // 
            this.panelLeftButtom_AAG.Controls.Add(this.CreateReport_AAG);
            this.panelLeftButtom_AAG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeftButtom_AAG.Location = new System.Drawing.Point(0, 747);
            this.panelLeftButtom_AAG.Name = "panelLeftButtom_AAG";
            this.panelLeftButtom_AAG.Size = new System.Drawing.Size(207, 100);
            this.panelLeftButtom_AAG.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(207, 121);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 847);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panelCenter_AAG
            // 
            this.panelCenter_AAG.Controls.Add(this.dataGridViewStaff_AAG);
            this.panelCenter_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter_AAG.Location = new System.Drawing.Point(210, 121);
            this.panelCenter_AAG.Name = "panelCenter_AAG";
            this.panelCenter_AAG.Size = new System.Drawing.Size(1508, 847);
            this.panelCenter_AAG.TabIndex = 5;
            // 
            // buttonEditData_AGG
            // 
            this.buttonEditData_AGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditData_AGG.Location = new System.Drawing.Point(0, 0);
            this.buttonEditData_AGG.Name = "buttonEditData_AGG";
            this.buttonEditData_AGG.Size = new System.Drawing.Size(206, 100);
            this.buttonEditData_AGG.TabIndex = 0;
            this.buttonEditData_AGG.Text = "Редактировать данные";
            this.buttonEditData_AGG.UseVisualStyleBackColor = true;
            this.buttonEditData_AGG.Click += new System.EventHandler(this.EditDataClick);
            // 
            // panelRightTop_AAG
            // 
            this.panelRightTop_AAG.Controls.Add(this.buttonEditData_AGG);
            this.panelRightTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRightTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelRightTop_AAG.Name = "panelRightTop_AAG";
            this.panelRightTop_AAG.Size = new System.Drawing.Size(206, 100);
            this.panelRightTop_AAG.TabIndex = 1;
            // 
            // buttonSaveEdit_AGG
            // 
            this.buttonSaveEdit_AGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveEdit_AGG.Enabled = false;
            this.buttonSaveEdit_AGG.Location = new System.Drawing.Point(0, 0);
            this.buttonSaveEdit_AGG.Name = "buttonSaveEdit_AGG";
            this.buttonSaveEdit_AGG.Size = new System.Drawing.Size(206, 69);
            this.buttonSaveEdit_AGG.TabIndex = 2;
            this.buttonSaveEdit_AGG.Text = "Сохранить";
            this.buttonSaveEdit_AGG.UseVisualStyleBackColor = true;
            this.buttonSaveEdit_AGG.Click += new System.EventHandler(this.ClickSaveData);
            // 
            // panelLeftTop2_AAG
            // 
            this.panelLeftTop2_AAG.Controls.Add(this.buttonSaveEdit_AGG);
            this.panelLeftTop2_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop2_AAG.Location = new System.Drawing.Point(0, 100);
            this.panelLeftTop2_AAG.Name = "panelLeftTop2_AAG";
            this.panelLeftTop2_AAG.Size = new System.Drawing.Size(206, 69);
            this.panelLeftTop2_AAG.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 968);
            this.Controls.Add(this.panelCenter_AAG);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_AAG);
            this.Controls.Add(this.panelRight_AAG);
            this.Controls.Add(this.panelTop_AAG);
            this.MinimumSize = new System.Drawing.Size(1918, 1024);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelRight_AAG.ResumeLayout(false);
            this.panelLeft_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff_AAG)).EndInit();
            this.panelLeftTop_AAG.ResumeLayout(false);
            this.panelLeftButtom_AAG.ResumeLayout(false);
            this.panelCenter_AAG.ResumeLayout(false);
            this.panelRightTop_AAG.ResumeLayout(false);
            this.panelLeftTop2_AAG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.Panel panelRight_AAG;
        private System.Windows.Forms.Panel panelLeft_AAG;
        private System.Windows.Forms.DataGridView dataGridViewStaff_AAG;
        private System.Windows.Forms.Button CreateReport_AAG;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogData_AAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HausAddres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birhday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.Panel panelLeftButtom_AAG;
        private System.Windows.Forms.Panel panelLeftTop_AAG;
        private System.Windows.Forms.Button buttonOpenData_AAG;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelCenter_AAG;
        private System.Windows.Forms.Panel panelRightTop_AAG;
        private System.Windows.Forms.Button buttonEditData_AGG;
        private System.Windows.Forms.Button buttonSaveEdit_AGG;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData_AAG;
        private System.Windows.Forms.Panel panelLeftTop2_AAG;
    }
}

