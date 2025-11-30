namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.DataGridViewIn_BAY = new System.Windows.Forms.DataGridView();
            this.DataGridViewOut_BAY = new System.Windows.Forms.DataGridView();
            this.ButtonOpenFile_BAY = new System.Windows.Forms.Button();
            this.ButtonExecute_BAY = new System.Windows.Forms.Button();
            this.ButtonSaveFile_BAY = new System.Windows.Forms.Button();
            this.ButtonAbout_BAY = new System.Windows.Forms.Button();
            this.LabelStatus_BAY = new System.Windows.Forms.Label();
            this.LabelInput_BAY = new System.Windows.Forms.Label();
            this.LabelOutput_BAY = new System.Windows.Forms.Label();

            this.DataGridViewIn_BAY.Location = new System.Drawing.Point(20, 40);
            this.DataGridViewIn_BAY.Size = new System.Drawing.Size(250, 200);
            this.DataGridViewIn_BAY.ReadOnly = true;

            this.DataGridViewOut_BAY.Location = new System.Drawing.Point(300, 40);
            this.DataGridViewOut_BAY.Size = new System.Drawing.Size(250, 200);
            this.DataGridViewOut_BAY.ReadOnly = true;

            this.ButtonOpenFile_BAY.Location = new System.Drawing.Point(20, 250);
            this.ButtonOpenFile_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonOpenFile_BAY.Text = "Открыть файл";
            this.ButtonOpenFile_BAY.Click += new System.EventHandler(this.ButtonOpenFile_BAY_Click);

            this.ButtonExecute_BAY.Location = new System.Drawing.Point(130, 250);
            this.ButtonExecute_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonExecute_BAY.Text = "Выполнить";
            this.ButtonExecute_BAY.Click += new System.EventHandler(this.ButtonExecute_BAY_Click);

            this.ButtonSaveFile_BAY.Location = new System.Drawing.Point(240, 250);
            this.ButtonSaveFile_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonSaveFile_BAY.Text = "Сохранить";
            this.ButtonSaveFile_BAY.Click += new System.EventHandler(this.ButtonSaveFile_BAY_Click);

            this.ButtonAbout_BAY.Location = new System.Drawing.Point(450, 250);
            this.ButtonAbout_BAY.Size = new System.Drawing.Size(100, 30);
            this.ButtonAbout_BAY.Text = "Справка";
            this.ButtonAbout_BAY.Click += new System.EventHandler(this.ButtonAbout_BAY_Click);

            this.LabelStatus_BAY.Location = new System.Drawing.Point(20, 290);
            this.LabelStatus_BAY.Size = new System.Drawing.Size(530, 20);
            this.LabelStatus_BAY.Text = "Готов к работе";

            this.LabelInput_BAY.Location = new System.Drawing.Point(20, 15);
            this.LabelInput_BAY.Size = new System.Drawing.Size(250, 20);
            this.LabelInput_BAY.Text = "Исходная матрица";
            this.LabelInput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.LabelOutput_BAY.Location = new System.Drawing.Point(300, 15);
            this.LabelOutput_BAY.Size = new System.Drawing.Size(250, 20);
            this.LabelOutput_BAY.Text = "Обработанная матрица";
            this.LabelOutput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.DataGridViewIn_BAY);
            this.Controls.Add(this.DataGridViewOut_BAY);
            this.Controls.Add(this.ButtonOpenFile_BAY);
            this.Controls.Add(this.ButtonExecute_BAY);
            this.Controls.Add(this.ButtonSaveFile_BAY);
            this.Controls.Add(this.ButtonAbout_BAY);
            this.Controls.Add(this.LabelStatus_BAY);
            this.Controls.Add(this.LabelInput_BAY);
            this.Controls.Add(this.LabelOutput_BAY);
            this.Text = "Обработка матрицы";
        }

        private System.Windows.Forms.DataGridView DataGridViewIn_BAY;
        private System.Windows.Forms.DataGridView DataGridViewOut_BAY;
        private System.Windows.Forms.Button ButtonOpenFile_BAY;
        private System.Windows.Forms.Button ButtonExecute_BAY;
        private System.Windows.Forms.Button ButtonSaveFile_BAY;
        private System.Windows.Forms.Button ButtonAbout_BAY;
        private System.Windows.Forms.Label LabelStatus_BAY;
        private System.Windows.Forms.Label LabelInput_BAY;
        private System.Windows.Forms.Label LabelOutput_BAY;
    }
}
