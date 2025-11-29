namespace Tyuiu.BiryukovAY.Sprint6.Task6.V3
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
            this.LabelInput_BAY = new System.Windows.Forms.Label();
            this.LabelOutput_BAY = new System.Windows.Forms.Label();
            this.TextBoxIn_BAY = new System.Windows.Forms.TextBox();
            this.TextBoxOut_BAY = new System.Windows.Forms.TextBox();
            this.ButtonExecute_BAY = new System.Windows.Forms.Button();
            this.ButtonHelp_BAY = new System.Windows.Forms.Button();
            this.ButtonGenerateTest_BAY = new System.Windows.Forms.Button();
            this.LabelStatus_BAY = new System.Windows.Forms.Label();
            this.ButtonClear_BAY = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.LabelTitle_BAY.Location = new System.Drawing.Point(12, 10);
            this.LabelTitle_BAY.Name = "LabelTitle_BAY";
            this.LabelTitle_BAY.Size = new System.Drawing.Size(560, 25);
            this.LabelTitle_BAY.Text = "Поиск слов с буквой 'r' в файле";
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
            this.ButtonOpenFile_BAY.Text = "Загрузить файл";
            this.ButtonOpenFile_BAY.Click += new System.EventHandler(this.ButtonOpenFile_BAY_Click);

            this.LabelInput_BAY.Location = new System.Drawing.Point(12, 80);
            this.LabelInput_BAY.Name = "LabelInput_BAY";
            this.LabelInput_BAY.Size = new System.Drawing.Size(250, 20);
            this.LabelInput_BAY.Text = "Ввод (содержимое файла):";
            this.LabelInput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.LabelOutput_BAY.Location = new System.Drawing.Point(282, 80);
            this.LabelOutput_BAY.Name = "LabelOutput_BAY";
            this.LabelOutput_BAY.Size = new System.Drawing.Size(250, 20);
            this.LabelOutput_BAY.Text = "Вывод (слова с буквой 'r'):";
            this.LabelOutput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.TextBoxIn_BAY.Location = new System.Drawing.Point(12, 105);
            this.TextBoxIn_BAY.Multiline = true;
            this.TextBoxIn_BAY.Name = "TextBoxIn_BAY";
            this.TextBoxIn_BAY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxIn_BAY.Size = new System.Drawing.Size(250, 200);
            this.TextBoxIn_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.TextBoxOut_BAY.Location = new System.Drawing.Point(282, 105);
            this.TextBoxOut_BAY.Multiline = true;
            this.TextBoxOut_BAY.Name = "TextBoxOut_BAY";
            this.TextBoxOut_BAY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxOut_BAY.Size = new System.Drawing.Size(250, 200);
            this.TextBoxOut_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.ButtonExecute_BAY.Location = new System.Drawing.Point(12, 315);
            this.ButtonExecute_BAY.Name = "ButtonExecute_BAY";
            this.ButtonExecute_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonExecute_BAY.Text = "Выполнить";
            this.ButtonExecute_BAY.Click += new System.EventHandler(this.ButtonExecute_BAY_Click);

            this.ButtonHelp_BAY.Location = new System.Drawing.Point(142, 315);
            this.ButtonHelp_BAY.Name = "ButtonHelp_BAY";
            this.ButtonHelp_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonHelp_BAY.Text = "Справка";
            this.ButtonHelp_BAY.Click += new System.EventHandler(this.ButtonHelp_BAY_Click);

            this.ButtonGenerateTest_BAY.Location = new System.Drawing.Point(272, 315);
            this.ButtonGenerateTest_BAY.Name = "ButtonGenerateTest_BAY";
            this.ButtonGenerateTest_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonGenerateTest_BAY.Text = "Создать тест-файл";
            this.ButtonGenerateTest_BAY.Click += new System.EventHandler(this.ButtonGenerateTest_BAY_Click);

            this.ButtonClear_BAY.Location = new System.Drawing.Point(402, 315);
            this.ButtonClear_BAY.Name = "ButtonClear_BAY";
            this.ButtonClear_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonClear_BAY.Text = "Очистить";
            this.ButtonClear_BAY.Click += new System.EventHandler(this.ButtonClear_BAY_Click);

            this.LabelStatus_BAY.Location = new System.Drawing.Point(12, 355);
            this.LabelStatus_BAY.Name = "LabelStatus_BAY";
            this.LabelStatus_BAY.Size = new System.Drawing.Size(520, 20);
            this.LabelStatus_BAY.Text = "Готов к работе";
            this.LabelStatus_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.ClientSize = new System.Drawing.Size(544, 385);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.LabelTitle_BAY,
            this.LabelFilePath_BAY,
            this.TextBoxFilePath_BAY,
            this.ButtonOpenFile_BAY,
            this.LabelInput_BAY,
            this.LabelOutput_BAY,
            this.TextBoxIn_BAY,
            this.TextBoxOut_BAY,
            this.ButtonExecute_BAY,
            this.ButtonHelp_BAY,
            this.ButtonGenerateTest_BAY,
            this.ButtonClear_BAY,
            this.LabelStatus_BAY
        });
            this.Name = "MainForm_BAY";
            this.Text = "Поиск слов с буквой 'r'";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelTitle_BAY;
        private System.Windows.Forms.Label LabelFilePath_BAY;
        private System.Windows.Forms.TextBox TextBoxFilePath_BAY;
        private System.Windows.Forms.Button ButtonOpenFile_BAY;
        private System.Windows.Forms.Label LabelInput_BAY;
        private System.Windows.Forms.Label LabelOutput_BAY;
        private System.Windows.Forms.TextBox TextBoxIn_BAY;
        private System.Windows.Forms.TextBox TextBoxOut_BAY;
        private System.Windows.Forms.Button ButtonExecute_BAY;
        private System.Windows.Forms.Button ButtonHelp_BAY;
        private System.Windows.Forms.Button ButtonGenerateTest_BAY;
        private System.Windows.Forms.Button ButtonClear_BAY;
        private System.Windows.Forms.Label LabelStatus_BAY;
    }
