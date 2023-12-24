
namespace Tyuiu.AramaAG.Sprint7.Project.V11
{
    partial class FormReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_AAG = new System.Windows.Forms.Panel();
            this.panelLeft_AAG = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuildDgraph_AAG = new System.Windows.Forms.Button();
            this.buttonBuildDiag1_AAG = new System.Windows.Forms.Button();
            this.buttonBack_AAG = new System.Windows.Forms.Button();
            this.panelRight_AAG = new System.Windows.Forms.Panel();
            this.chartResult_AAG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.groupBoxRadio_AAG = new System.Windows.Forms.GroupBox();
            this.radioButtonGraphg_AAG = new System.Windows.Forms.RadioButton();
            this.radioButtonDiagram_AAG = new System.Windows.Forms.RadioButton();
            this.panelLeft_AAG.SuspendLayout();
            this.panelRight_AAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).BeginInit();
            this.groupBoxRadio_AAG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AAG
            // 
            this.panelTop_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAG.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAG.Name = "panelTop_AAG";
            this.panelTop_AAG.Size = new System.Drawing.Size(1211, 115);
            this.panelTop_AAG.TabIndex = 0;
            // 
            // panelLeft_AAG
            // 
            this.panelLeft_AAG.Controls.Add(this.groupBoxRadio_AAG);
            this.panelLeft_AAG.Controls.Add(this.label2);
            this.panelLeft_AAG.Controls.Add(this.label1);
            this.panelLeft_AAG.Controls.Add(this.buttonBuildDgraph_AAG);
            this.panelLeft_AAG.Controls.Add(this.buttonBuildDiag1_AAG);
            this.panelLeft_AAG.Controls.Add(this.buttonBack_AAG);
            this.panelLeft_AAG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AAG.Location = new System.Drawing.Point(0, 115);
            this.panelLeft_AAG.Name = "panelLeft_AAG";
            this.panelLeft_AAG.Size = new System.Drawing.Size(335, 588);
            this.panelLeft_AAG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Диаграмма стажа работников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBuildDgraph_AAG
            // 
            this.buttonBuildDgraph_AAG.Location = new System.Drawing.Point(204, 120);
            this.buttonBuildDgraph_AAG.Name = "buttonBuildDgraph_AAG";
            this.buttonBuildDgraph_AAG.Size = new System.Drawing.Size(131, 67);
            this.buttonBuildDgraph_AAG.TabIndex = 3;
            this.buttonBuildDgraph_AAG.Text = "Построить";
            this.buttonBuildDgraph_AAG.UseVisualStyleBackColor = true;
            this.buttonBuildDgraph_AAG.Click += new System.EventHandler(this.buttonBuildDgraph_AAG_Click);
            // 
            // buttonBuildDiag1_AAG
            // 
            this.buttonBuildDiag1_AAG.Location = new System.Drawing.Point(204, 36);
            this.buttonBuildDiag1_AAG.Name = "buttonBuildDiag1_AAG";
            this.buttonBuildDiag1_AAG.Size = new System.Drawing.Size(131, 67);
            this.buttonBuildDiag1_AAG.TabIndex = 2;
            this.buttonBuildDiag1_AAG.Text = "Построить";
            this.buttonBuildDiag1_AAG.UseVisualStyleBackColor = true;
            this.buttonBuildDiag1_AAG.Click += new System.EventHandler(this.buttonBuildDiag1_AAG_Click);
            // 
            // buttonBack_AAG
            // 
            this.buttonBack_AAG.Location = new System.Drawing.Point(72, 459);
            this.buttonBack_AAG.Name = "buttonBack_AAG";
            this.buttonBack_AAG.Size = new System.Drawing.Size(184, 67);
            this.buttonBack_AAG.TabIndex = 0;
            this.buttonBack_AAG.Text = "Вернуться";
            this.buttonBack_AAG.UseVisualStyleBackColor = true;
            this.buttonBack_AAG.Click += new System.EventHandler(this.BackClick_AAG);
            // 
            // panelRight_AAG
            // 
            this.panelRight_AAG.Controls.Add(this.chartResult_AAG);
            this.panelRight_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_AAG.Location = new System.Drawing.Point(335, 115);
            this.panelRight_AAG.Name = "panelRight_AAG";
            this.panelRight_AAG.Size = new System.Drawing.Size(876, 588);
            this.panelRight_AAG.TabIndex = 2;
            // 
            // chartResult_AAG
            // 
            this.chartResult_AAG.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartResult_AAG.ChartAreas.Add(chartArea1);
            this.chartResult_AAG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_AAG.Legends.Add(legend1);
            this.chartResult_AAG.Location = new System.Drawing.Point(0, 0);
            this.chartResult_AAG.Name = "chartResult_AAG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_AAG.Series.Add(series1);
            this.chartResult_AAG.Size = new System.Drawing.Size(876, 588);
            this.chartResult_AAG.TabIndex = 0;
            this.chartResult_AAG.Text = "chart1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "График соотношение должности и зарплаты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(335, 115);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 588);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(338, 115);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 588);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(341, 115);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 588);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // groupBoxRadio_AAG
            // 
            this.groupBoxRadio_AAG.Controls.Add(this.radioButtonGraphg_AAG);
            this.groupBoxRadio_AAG.Controls.Add(this.radioButtonDiagram_AAG);
            this.groupBoxRadio_AAG.Location = new System.Drawing.Point(3, 202);
            this.groupBoxRadio_AAG.Name = "groupBoxRadio_AAG";
            this.groupBoxRadio_AAG.Size = new System.Drawing.Size(332, 124);
            this.groupBoxRadio_AAG.TabIndex = 6;
            this.groupBoxRadio_AAG.TabStop = false;
            // 
            // radioButtonGraphg_AAG
            // 
            this.radioButtonGraphg_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonGraphg_AAG.Location = new System.Drawing.Point(3, 62);
            this.radioButtonGraphg_AAG.Name = "radioButtonGraphg_AAG";
            this.radioButtonGraphg_AAG.Size = new System.Drawing.Size(326, 40);
            this.radioButtonGraphg_AAG.TabIndex = 1;
            this.radioButtonGraphg_AAG.TabStop = true;
            this.radioButtonGraphg_AAG.Text = "График";
            this.radioButtonGraphg_AAG.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiagram_AAG
            // 
            this.radioButtonDiagram_AAG.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonDiagram_AAG.Location = new System.Drawing.Point(3, 22);
            this.radioButtonDiagram_AAG.Name = "radioButtonDiagram_AAG";
            this.radioButtonDiagram_AAG.Size = new System.Drawing.Size(326, 40);
            this.radioButtonDiagram_AAG.TabIndex = 0;
            this.radioButtonDiagram_AAG.TabStop = true;
            this.radioButtonDiagram_AAG.Text = "Диаграмма";
            this.radioButtonDiagram_AAG.UseVisualStyleBackColor = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 703);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelRight_AAG);
            this.Controls.Add(this.panelLeft_AAG);
            this.Controls.Add(this.panelTop_AAG);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сводный отчёт";
            this.panelLeft_AAG.ResumeLayout(false);
            this.panelRight_AAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAG)).EndInit();
            this.groupBoxRadio_AAG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAG;
        private System.Windows.Forms.Panel panelLeft_AAG;
        private System.Windows.Forms.Panel panelRight_AAG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAG;
        private System.Windows.Forms.Button buttonBack_AAG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuildDgraph_AAG;
        private System.Windows.Forms.Button buttonBuildDiag1_AAG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.GroupBox groupBoxRadio_AAG;
        private System.Windows.Forms.RadioButton radioButtonGraphg_AAG;
        private System.Windows.Forms.RadioButton radioButtonDiagram_AAG;
    }
}