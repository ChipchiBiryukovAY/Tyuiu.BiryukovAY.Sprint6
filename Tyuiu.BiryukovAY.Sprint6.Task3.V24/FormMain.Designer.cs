namespace Tyuiu.BiryukovAY.Sprint6.Task3.V24
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
            this.LabelOriginal_BAY = new System.Windows.Forms.Label();
            this.LabelResult_BAY = new System.Windows.Forms.Label();
            this.DataGridViewOriginal_BAY = new System.Windows.Forms.DataGridView();
            this.DataGridViewResult_BAY = new System.Windows.Forms.DataGridView();
            this.ButtonProcess_BAY = new System.Windows.Forms.Button();
            this.ButtonHelp_BAY = new System.Windows.Forms.Button();
            this.LabelTask_BAY = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOriginal_BAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResult_BAY)).BeginInit();
            this.SuspendLayout();

            this.LabelTask_BAY.Location = new System.Drawing.Point(12, 10);
            this.LabelTask_BAY.Name = "LabelTask_BAY";
            this.LabelTask_BAY.Size = new System.Drawing.Size(460, 30);
            this.LabelTask_BAY.Text = "Дан массив 5 на 5 элементов. Заменить четные значения во второй строке на 0.";
            this.LabelTask_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTask_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.LabelOriginal_BAY.Location = new System.Drawing.Point(12, 50);
            this.LabelOriginal_BAY.Name = "LabelOriginal_BAY";
            this.LabelOriginal_BAY.Size = new System.Drawing.Size(220, 20);
            this.LabelOriginal_BAY.Text = "Исходная матрица:";
            this.LabelOriginal_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.LabelResult_BAY.Location = new System.Drawing.Point(252, 50);
            this.LabelResult_BAY.Name = "LabelResult_BAY";
            this.LabelResult_BAY.Size = new System.Drawing.Size(220, 20);
            this.LabelResult_BAY.Text = "Результат:";
            this.LabelResult_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.DataGridViewOriginal_BAY.Location = new System.Drawing.Point(12, 75);
            this.DataGridViewOriginal_BAY.Name = "DataGridViewOriginal_BAY";
            this.DataGridViewOriginal_BAY.Size = new System.Drawing.Size(220, 150);
            this.DataGridViewOriginal_BAY.AllowUserToAddRows = false;
            this.DataGridViewOriginal_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewOriginal_BAY.ReadOnly = true;
            this.DataGridViewOriginal_BAY.RowHeadersVisible = false;
            this.DataGridViewOriginal_BAY.ColumnHeadersVisible = false;

            this.DataGridViewResult_BAY.Location = new System.Drawing.Point(252, 75);
            this.DataGridViewResult_BAY.Name = "DataGridViewResult_BAY";
            this.DataGridViewResult_BAY.Size = new System.Drawing.Size(220, 150);
            this.DataGridViewResult_BAY.AllowUserToAddRows = false;
            this.DataGridViewResult_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewResult_BAY.ReadOnly = true;
            this.DataGridViewResult_BAY.RowHeadersVisible = false;
            this.DataGridViewResult_BAY.ColumnHeadersVisible = false;

            this.ButtonProcess_BAY.Location = new System.Drawing.Point(12, 240);
            this.ButtonProcess_BAY.Name = "ButtonProcess_BAY";
            this.ButtonProcess_BAY.Size = new System.Drawing.Size(220, 30);
            this.ButtonProcess_BAY.Text = "Выполнить";
            this.ButtonProcess_BAY.Click += new System.EventHandler(this.ButtonProcess_BAY_Click);

            this.ButtonHelp_BAY.Location = new System.Drawing.Point(252, 240);
            this.ButtonHelp_BAY.Name = "ButtonHelp_BAY";
            this.ButtonHelp_BAY.Size = new System.Drawing.Size(220, 30);
            this.ButtonHelp_BAY.Text = "Справка";
            this.ButtonHelp_BAY.Click += new System.EventHandler(this.ButtonHelp_BAY_Click);

            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
            this.LabelTask_BAY,
            this.LabelOriginal_BAY,
            this.LabelResult_BAY,
            this.DataGridViewOriginal_BAY,
            this.DataGridViewResult_BAY,
            this.ButtonProcess_BAY,
            this.ButtonHelp_BAY
        });
            this.Name = "MainForm_BAY";
            this.Text = "Обработка матрицы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOriginal_BAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResult_BAY)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LabelTask_BAY;
        private System.Windows.Forms.Label LabelOriginal_BAY;
        private System.Windows.Forms.Label LabelResult_BAY;
        private System.Windows.Forms.DataGridView DataGridViewOriginal_BAY;
        private System.Windows.Forms.DataGridView DataGridViewResult_BAY;
        private System.Windows.Forms.Button ButtonProcess_BAY;
        private System.Windows.Forms.Button ButtonHelp_BAY;
    }