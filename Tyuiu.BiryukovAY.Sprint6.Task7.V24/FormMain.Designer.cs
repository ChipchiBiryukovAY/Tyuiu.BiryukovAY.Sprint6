namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24
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
            this.LabelTitle_BAY = new System.Windows.Forms.Label();
            this.LabelFilePath_BAY = new System.Windows.Forms.Label();
            this.TextBoxFilePath_BAY = new System.Windows.Forms.TextBox();
            this.ButtonOpenFile_BAY = new System.Windows.Forms.Button();
            this.ButtonExecute_BAY = new System.Windows.Forms.Button();
            this.ButtonSaveFile_BAY = new System.Windows.Forms.Button();
            this.ButtonAbout_BAY = new System.Windows.Forms.Button();
            this.ButtonGenerateTest_BAY = new System.Windows.Forms.Button();
            this.LabelInput_BAY = new System.Windows.Forms.Label();
            this.LabelOutput_BAY = new System.Windows.Forms.Label();
            this.DataGridViewIn_BAY = new System.Windows.Forms.DataGridView();
            this.DataGridViewOut_BAY = new System.Windows.Forms.DataGridView();
            this.LabelStatus_BAY = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIn_BAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOut_BAY)).BeginInit();
            this.SuspendLayout();

            this.LabelTitle_BAY.Location = new System.Drawing.Point(12, 10);
            this.LabelTitle_BAY.Name = "LabelTitle_BAY";
            this.LabelTitle_BAY.Size = new System.Drawing.Size(560, 25);
            this.LabelTitle_BAY.Text = "Обработка матрицы: замена четных элементов во второй строке на 1";
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

            this.ButtonOpenFile_BAY.Location = new System.Drawing.Point(12, 75);
            this.ButtonOpenFile_BAY.Name = "ButtonOpenFile_BAY";
            this.ButtonOpenFile_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonOpenFile_BAY.Text = "Открыть файл";
            this.ButtonOpenFile_BAY.Click += new System.EventHandler(this.ButtonOpenFile_BAY_Click);

            this.ButtonExecute_BAY.Location = new System.Drawing.Point(122, 75);
            this.ButtonExecute_BAY.Name = "ButtonExecute_BAY";
            this.ButtonExecute_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonExecute_BAY.Text = "Выполнить";
            this.ButtonExecute_BAY.Click += new System.EventHandler(this.ButtonExecute_BAY_Click);

            this.ButtonSaveFile_BAY.Location = new System.Drawing.Point(232, 75);
            this.ButtonSaveFile_BAY.Name = "ButtonSaveFile_BAY";
            this.ButtonSaveFile_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonSaveFile_BAY.Text = "Сохранить в файл";
            this.ButtonSaveFile_BAY.Click += new System.EventHandler(this.ButtonSaveFile_BAY_Click);

            this.ButtonAbout_BAY.Location = new System.Drawing.Point(472, 75);
            this.ButtonAbout_BAY.Name = "ButtonAbout_BAY";
            this.ButtonAbout_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonAbout_BAY.Text = "Справка";
            this.ButtonAbout_BAY.Click += new System.EventHandler(this.ButtonAbout_BAY_Click);

            this.ButtonGenerateTest_BAY.Location = new System.Drawing.Point(362, 75);
            this.ButtonGenerateTest_BAY.Name = "ButtonGenerateTest_BAY";
            this.ButtonGenerateTest_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonGenerateTest_BAY.Text = "Создать тест";
            this.ButtonGenerateTest_BAY.Click += new System.EventHandler(this.ButtonGenerateTest_BAY_Click);

            this.LabelInput_BAY.Location = new System.Drawing.Point(12, 115);
            this.LabelInput_BAY.Name = "LabelInput_BAY";
            this.LabelInput_BAY.Size = new System.Drawing.Size(270, 20);
            this.LabelInput_BAY.Text = "Исходная матрица:";
            this.LabelInput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.LabelOutput_BAY.Location = new System.Drawing.Point(302, 115);
            this.LabelOutput_BAY.Name = "LabelOutput_BAY";
            this.LabelOutput_BAY.Size = new System.Drawing.Size(270, 20);
            this.LabelOutput_BAY.Text = "Обработанная матрица:";
            this.LabelOutput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.DataGridViewIn_BAY.Location = new System.Drawing.Point(12, 140);
            this.DataGridViewIn_BAY.Name = "DataGridViewIn_BAY";
            this.DataGridViewIn_BAY.Size = new System.Drawing.Size(270, 200);
            this.DataGridViewIn_BAY.AllowUserToAddRows = false;
            this.DataGridViewIn_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewIn_BAY.ReadOnly = true;
            this.DataGridViewIn_BAY.RowHeadersVisible = false;
            this.DataGridViewIn_BAY.ColumnHeadersVisible = false;

            this.DataGridViewOut_BAY.Location = new System.Drawing.Point(302, 140);
            this.DataGridViewOut_BAY.Name = "DataGridViewOut_BAY";
            this.DataGridViewOut_BAY.Size = new System.Drawing.Size(270, 200);
            this.DataGridViewOut_BAY.AllowUserToAddRows = false;
            this.DataGridViewOut_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewOut_BAY.ReadOnly = true;
            this.DataGridViewOut_BAY.RowHeadersVisible = false;
            this.DataGridViewOut_BAY.ColumnHeadersVisible = false;

            this.LabelStatus_BAY.Location = new System.Drawing.Point(12, 350);
            this.LabelStatus_BAY.Name = "LabelStatus_BAY";
            this.LabelStatus_BAY.Size = new System.Drawing.Size(560, 20);
            this.LabelStatus_BAY.Text = "Готов к работе";
            this.LabelStatus_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.LabelTitle_BAY,
            this.LabelFilePath_BAY,
            this.TextBoxFilePath_BAY,
            this.ButtonOpenFile_BAY,
            this.ButtonExecute_BAY,
            this.ButtonSaveFile_BAY,
            this.ButtonAbout_BAY,
            this.ButtonGenerateTest_BAY,
            this.LabelInput_BAY,
            this.LabelOutput_BAY,
            this.DataGridViewIn_BAY,
            this.DataGridViewOut_BAY,
            this.LabelStatus_BAY
        });
            this.Name = "MainForm_BAY";
            this.Text = "Обработка матрицы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIn_BAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOut_BAY)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelTitle_BAY;
        private System.Windows.Forms.Label LabelFilePath_BAY;
        private System.Windows.Forms.TextBox TextBoxFilePath_BAY;
        private System.Windows.Forms.Button ButtonOpenFile_BAY;
        private System.Windows.Forms.Button ButtonExecute_BAY;
        private System.Windows.Forms.Button ButtonSaveFile_BAY;
        private System.Windows.Forms.Button ButtonAbout_BAY;
        private System.Windows.Forms.Button ButtonGenerateTest_BAY;
        private System.Windows.Forms.Label LabelInput_BAY;
        private System.Windows.Forms.Label LabelOutput_BAY;
        private System.Windows.Forms.DataGridView DataGridViewIn_BAY;
        private System.Windows.Forms.DataGridView DataGridViewOut_BAY;
        private System.Windows.Forms.Label LabelStatus_BAY;
    }
}
