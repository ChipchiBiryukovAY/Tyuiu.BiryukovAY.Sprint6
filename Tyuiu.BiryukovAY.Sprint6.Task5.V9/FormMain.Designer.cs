namespace Tyuiu.BiryukovAY.Sprint6.Task5.V9
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

            this.LabelTitle_BAY = new System.Windows.Forms.Label();
            this.LabelFilePath_BAY = new System.Windows.Forms.Label();
            this.TextBoxFilePath_BAY = new System.Windows.Forms.TextBox();
            this.ButtonOpenFile_BAY = new System.Windows.Forms.Button();
            this.ButtonHelp_BAY = new System.Windows.Forms.Button();
            this.ButtonGenerateTest_BAY = new System.Windows.Forms.Button();
            this.LabelAllData_BAY = new System.Windows.Forms.Label();
            this.LabelZeros_BAY = new System.Windows.Forms.Label();
            this.DataGridViewAllData_BAY = new System.Windows.Forms.DataGridView();
            this.DataGridViewZeros_BAY = new System.Windows.Forms.DataGridView();
            this.ChartZeros_BAY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelStatus_BAY = new System.Windows.Forms.Label();
            this.ChartArea_BAY = chartArea1;
            this.SeriesZeros_BAY = series1;

            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllData_BAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewZeros_BAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartZeros_BAY)).BeginInit();
            this.SuspendLayout();

            this.LabelTitle_BAY.Location = new System.Drawing.Point(12, 10);
            this.LabelTitle_BAY.Name = "LabelTitle_BAY";
            this.LabelTitle_BAY.Size = new System.Drawing.Size(560, 25);
            this.LabelTitle_BAY.Text = "Анализ данных: поиск нулевых элементов и построение диаграммы";
            this.LabelTitle_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTitle_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.LabelFilePath_BAY.Location = new System.Drawing.Point(12, 45);
            this.LabelFilePath_BAY.Name = "LabelFilePath_BAY";
            this.LabelFilePath_BAY.Size = new System.Drawing.Size(100, 20);
            this.LabelFilePath_BAY.Text = "Путь к файлу:";
            this.LabelFilePath_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.TextBoxFilePath_BAY.Location = new System.Drawing.Point(118, 45);
            this.TextBoxFilePath_BAY.Name = "TextBoxFilePath_BAY";
            this.TextBoxFilePath_BAY.Size = new System.Drawing.Size(300, 20);
            this.TextBoxFilePath_BAY.ReadOnly = true;

            this.ButtonOpenFile_BAY.Location = new System.Drawing.Point(424, 45);
            this.ButtonOpenFile_BAY.Name = "ButtonOpenFile_BAY";
            this.ButtonOpenFile_BAY.Size = new System.Drawing.Size(100, 25);
            this.ButtonOpenFile_BAY.Text = "Выбрать файл";
            this.ButtonOpenFile_BAY.Click += new System.EventHandler(this.ButtonOpenFile_BAY_Click);

            this.ButtonHelp_BAY.Location = new System.Drawing.Point(424, 80);
            this.ButtonHelp_BAY.Name = "ButtonHelp_BAY";
            this.ButtonHelp_BAY.Size = new System.Drawing.Size(100, 25);
            this.ButtonHelp_BAY.Text = "Справка";
            this.ButtonHelp_BAY.Click += new System.EventHandler(this.ButtonHelp_BAY_Click);

            this.ButtonGenerateTest_BAY.Location = new System.Drawing.Point(318, 80);
            this.ButtonGenerateTest_BAY.Name = "ButtonGenerateTest_BAY";
            this.ButtonGenerateTest_BAY.Size = new System.Drawing.Size(100, 25);
            this.ButtonGenerateTest_BAY.Text = "Создать тест-файл";
            this.ButtonGenerateTest_BAY.Click += new System.EventHandler(this.ButtonGenerateTest_BAY_Click);

            this.LabelAllData_BAY.Location = new System.Drawing.Point(12, 115);
            this.LabelAllData_BAY.Name = "LabelAllData_BAY";
            this.LabelAllData_BAY.Size = new System.Drawing.Size(250, 20);
            this.LabelAllData_BAY.Text = "Все данные из файла:";
            this.LabelAllData_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.LabelZeros_BAY.Location = new System.Drawing.Point(282, 115);
            this.LabelZeros_BAY.Name = "LabelZeros_BAY";
            this.LabelZeros_BAY.Size = new System.Drawing.Size(250, 20);
            this.LabelZeros_BAY.Text = "Элементы, равные 0:";
            this.LabelZeros_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.DataGridViewAllData_BAY.Location = new System.Drawing.Point(12, 140);
            this.DataGridViewAllData_BAY.Name = "DataGridViewAllData_BAY";
            this.DataGridViewAllData_BAY.Size = new System.Drawing.Size(250, 150);
            this.DataGridViewAllData_BAY.AllowUserToAddRows = false;
            this.DataGridViewAllData_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewAllData_BAY.ReadOnly = true;
            this.DataGridViewAllData_BAY.RowHeadersVisible = false;

            this.DataGridViewZeros_BAY.Location = new System.Drawing.Point(282, 140);
            this.DataGridViewZeros_BAY.Name = "DataGridViewZeros_BAY";
            this.DataGridViewZeros_BAY.Size = new System.Drawing.Size(250, 150);
            this.DataGridViewZeros_BAY.AllowUserToAddRows = false;
            this.DataGridViewZeros_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewZeros_BAY.ReadOnly = true;
            this.DataGridViewZeros_BAY.RowHeadersVisible = false;

            this.ChartZeros_BAY.Location = new System.Drawing.Point(12, 300);
            this.ChartZeros_BAY.Name = "ChartZeros_BAY";
            this.ChartZeros_BAY.Size = new System.Drawing.Size(520, 200);

            chartArea1.Name = "ChartArea_BAY";
            this.ChartZeros_BAY.ChartAreas.Add(chartArea1);

            series1.ChartArea = "ChartArea_BAY";
            series1.Name = "SeriesZeros_BAY";
            this.ChartZeros_BAY.Series.Add(series1);

            this.LabelStatus_BAY.Location = new System.Drawing.Point(12, 510);
            this.LabelStatus_BAY.Name = "LabelStatus_BAY";
            this.LabelStatus_BAY.Size = new System.Drawing.Size(520, 20);
            this.LabelStatus_BAY.Text = "Выберите файл для анализа";
            this.LabelStatus_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.ClientSize = new System.Drawing.Size(544, 541);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.LabelTitle_BAY,
            this.LabelFilePath_BAY,
            this.TextBoxFilePath_BAY,
            this.ButtonOpenFile_BAY,
            this.ButtonHelp_BAY,
            this.ButtonGenerateTest_BAY,
            this.LabelAllData_BAY,
            this.LabelZeros_BAY,
            this.DataGridViewAllData_BAY,
            this.DataGridViewZeros_BAY,
            this.ChartZeros_BAY,
            this.LabelStatus_BAY
        });
            this.Name = "MainForm_BAY";
            this.Text = "Анализ данных - поиск нулевых элементов";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllData_BAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewZeros_BAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartZeros_BAY)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelTitle_BAY;
        private System.Windows.Forms.Label LabelFilePath_BAY;
        private System.Windows.Forms.TextBox TextBoxFilePath_BAY;
        private System.Windows.Forms.Button ButtonOpenFile_BAY;
        private System.Windows.Forms.Button ButtonHelp_BAY;
        private System.Windows.Forms.Button ButtonGenerateTest_BAY;
        private System.Windows.Forms.Label LabelAllData_BAY;
        private System.Windows.Forms.Label LabelZeros_BAY;
        private System.Windows.Forms.DataGridView DataGridViewAllData_BAY;
        private System.Windows.Forms.DataGridView DataGridViewZeros_BAY;
        private System.Windows.Forms.Label LabelStatus_BAY;
    }