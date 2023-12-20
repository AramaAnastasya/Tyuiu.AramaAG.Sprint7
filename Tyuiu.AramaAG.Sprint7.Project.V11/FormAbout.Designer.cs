
namespace Tyuiu.AramaAG.Sprint7.Project.V11
{
    partial class FormAbout
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
            this.labelInfo_AAG = new System.Windows.Forms.Label();
            this.buttonOK_AAG = new System.Windows.Forms.Button();
            this.pictureBoxOne_AAG = new System.Windows.Forms.PictureBox();
            this.textBoxText_AAG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_AAG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_AAG
            // 
            this.labelInfo_AAG.AutoSize = true;
            this.labelInfo_AAG.Location = new System.Drawing.Point(108, 12);
            this.labelInfo_AAG.Name = "labelInfo_AAG";
            this.labelInfo_AAG.Size = new System.Drawing.Size(0, 20);
            this.labelInfo_AAG.TabIndex = 6;
            // 
            // buttonOK_AAG
            // 
            this.buttonOK_AAG.Location = new System.Drawing.Point(404, 226);
            this.buttonOK_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK_AAG.Name = "buttonOK_AAG";
            this.buttonOK_AAG.Size = new System.Drawing.Size(99, 39);
            this.buttonOK_AAG.TabIndex = 5;
            this.buttonOK_AAG.Text = "Ок";
            this.buttonOK_AAG.UseVisualStyleBackColor = true;
            this.buttonOK_AAG.Click += new System.EventHandler(this.buttonOK_AAG_Click);
            // 
            // pictureBoxOne_AAG
            // 
            this.pictureBoxOne_AAG.Image = global::Tyuiu.AramaAG.Sprint7.Project.V11.Properties.Resources.Iam;
            this.pictureBoxOne_AAG.Location = new System.Drawing.Point(24, 48);
            this.pictureBoxOne_AAG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxOne_AAG.Name = "pictureBoxOne_AAG";
            this.pictureBoxOne_AAG.Size = new System.Drawing.Size(135, 177);
            this.pictureBoxOne_AAG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOne_AAG.TabIndex = 4;
            this.pictureBoxOne_AAG.TabStop = false;
            // 
            // textBoxText_AAG
            // 
            this.textBoxText_AAG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxText_AAG.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxText_AAG.Location = new System.Drawing.Point(204, 79);
            this.textBoxText_AAG.Multiline = true;
            this.textBoxText_AAG.Name = "textBoxText_AAG";
            this.textBoxText_AAG.ReadOnly = true;
            this.textBoxText_AAG.Size = new System.Drawing.Size(299, 140);
            this.textBoxText_AAG.TabIndex = 7;
            this.textBoxText_AAG.TabStop = false;
            this.textBoxText_AAG.Text = "Программа для сотрудника отдела кадров для просмотра и редактирования данных сотр" +
    "удников.\r\nВыполнила: студентка Арама А.Г. СМАРТб 23-1";
            this.textBoxText_AAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.textBoxText_AAG);
            this.Controls.Add(this.labelInfo_AAG);
            this.Controls.Add(this.buttonOK_AAG);
            this.Controls.Add(this.pictureBoxOne_AAG);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_AAG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_AAG;
        private System.Windows.Forms.Button buttonOK_AAG;
        private System.Windows.Forms.PictureBox pictureBoxOne_AAG;
        private System.Windows.Forms.TextBox textBoxText_AAG;
    }
}