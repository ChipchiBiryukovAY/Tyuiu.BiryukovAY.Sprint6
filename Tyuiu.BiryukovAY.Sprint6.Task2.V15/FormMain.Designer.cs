using System;
using Tyuiu.BiryukovAY.Sprint6.Task2.V15.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task2.V15
{
    partial class FormMain
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.LabelStart_BAY = new System.Windows.Forms.Label();
            this.LabelStop_BAY = new System.Windows.Forms.Label();
            this.TextBoxStart_BAY = new System.Windows.Forms.TextBox();
            this.TextBoxStop_BAY = new System.Windows.Forms.TextBox();
            this.ButtonCalculate_BAY = new System.Windows.Forms.Button();
            this.ButtonHelp_BAY = new System.Windows.Forms.Button();
            this.DataGridViewResult_BAY = new System.Windows.Forms.DataGridView();
            this.ChartFunction_BAY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartArea_BAY = chartArea1;
            this.SeriesFunction_BAY = series1;

            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResult_BAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFunction_BAY)).BeginInit();
            this.SuspendLayout();

            this.LabelStart_BAY.Location = new System.Drawing.Point(12, 15);
            this.LabelStart_BAY.Name = "LabelStart_BAY";
            this.LabelStart_BAY.Size = new System.Drawing.Size(100, 20);
            this.LabelStart_BAY.Text = "Старт шага:";
            this.LabelStart_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.LabelStop_BAY.Location = new System.Drawing.Point(12, 45);
            this.LabelStop_BAY.Name = "LabelStop_BAY";
            this.LabelStop_BAY.Size = new System.Drawing.Size(100, 20);
            this.LabelStop_BAY.Text = "Конец шага:";
            this.LabelStop_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.TextBoxStart_BAY.Location = new System.Drawing.Point(118, 15);
            this.TextBoxStart_BAY.Name = "TextBoxStart_BAY";
            this.TextBoxStart_BAY.Size = new System.Drawing.Size(80, 20);
            this.TextBoxStart_BAY.Text = "-5";

            this.TextBoxStop_BAY.Location = new System.Drawing.Point(118, 45);
            this.TextBoxStop_BAY.Name = "TextBoxStop_BAY";
            this.TextBoxStop_BAY.Size = new System.Drawing.Size(80, 20);
            this.TextBoxStop_BAY.Text = "5";

            this.ButtonCalculate_BAY.Location = new System.Drawing.Point(220, 15);
            this.ButtonCalculate_BAY.Name = "ButtonCalculate_BAY";
            this.ButtonCalculate_BAY.Size = new System.Drawing.Size(100, 25);
            this.ButtonCalculate_BAY.Text = "Выполнить";
            this.ButtonCalculate_BAY.Click += new System.EventHandler(this.ButtonCalculate_BAY_Click);

            this.ButtonHelp_BAY.Location = new System.Drawing.Point(220, 45);
            this.ButtonHelp_BAY.Name = "ButtonHelp_BAY";
            this.ButtonHelp_BAY.Size = new System.Drawing.Size(100, 25);
            this.ButtonHelp_BAY.Text = "Справка";
            this.ButtonHelp_BAY.Click += new System.EventHandler(this.ButtonHelp_BAY_Click);

            this.DataGridViewResult_BAY.Location = new System.Drawing.Point(12, 80);
            this.DataGridViewResult_BAY.Name = "DataGridViewResult_BAY";
            this.DataGridViewResult_BAY.Size = new System.Drawing.Size(308, 200);
            this.DataGridViewResult_BAY.AllowUserToAddRows = false;
            this.DataGridViewResult_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewResult_BAY.ReadOnly = true;

            this.ChartFunction_BAY.Location = new System.Drawing.Point(12, 290);
            this.ChartFunction_BAY.Name = "ChartFunction_BAY";
            this.ChartFunction_BAY.Size = new System.Drawing.Size(308, 200);

            chartArea1.Name = "ChartArea_BAY";
            this.ChartFunction_BAY.ChartAreas.Add(chartArea1);

            series1.ChartArea = "ChartArea_BAY";
            series1.Name = "SeriesFunction_BAY";
            this.ChartFunction_BAY.Series.Add(series1);

            this.ClientSize = new System.Drawing.Size(334, 511);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.LabelStart_BAY,
            this.LabelStop_BAY,
            this.TextBoxStart_BAY,
            this.TextBoxStop_BAY,
            this.ButtonCalculate_BAY,
            this.ButtonHelp_BAY,
            this.DataGridViewResult_BAY,
            this.ChartFunction_BAY
        });
            this.Name = "MainForm_BAY";
            this.Text = "Табулирование функции";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResult_BAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFunction_BAY)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelStart_BAY;
        private System.Windows.Forms.Label LabelStop_BAY;
        private System.Windows.Forms.TextBox TextBoxStart_BAY;
        private System.Windows.Forms.TextBox TextBoxStop_BAY;
        private System.Windows.Forms.Button ButtonCalculate_BAY;
        private System.Windows.Forms.Button ButtonHelp_BAY;
        private System.Windows.Forms.DataGridView DataGridViewResult_BAY;
    }