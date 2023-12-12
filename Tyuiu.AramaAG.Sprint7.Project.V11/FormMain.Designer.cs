
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
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(1432, 121);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // panelRight_AAG
            // 
            this.panelRight_AAG.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_AAG.Location = new System.Drawing.Point(1045, 121);
            this.panelRight_AAG.Name = "panelRight_AAG";
            this.panelRight_AAG.Size = new System.Drawing.Size(387, 685);
            this.panelRight_AAG.TabIndex = 1;
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 121);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(275, 685);
            this.panelLeft_AAG.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 806);
            this.Controls.Add(this.panelLeft_AAG);
            this.Controls.Add(this.panelRight_AAG);
            this.Controls.Add(this.panelTop_AAG);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.Panel panelRight_AAG;
        private System.Windows.Forms.Panel panelLeft_AAG;
    }
}

