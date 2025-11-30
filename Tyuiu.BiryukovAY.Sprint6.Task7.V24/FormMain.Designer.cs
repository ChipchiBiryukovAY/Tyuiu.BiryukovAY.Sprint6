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

            this.LabelCondition_BAY = new System.Windows.Forms.Label();
            this.LabelCondition_BAY.Location = new System.Drawing.Point(12, 12);
            this.LabelCondition_BAY.Size = new System.Drawing.Size(660, 40);
            this.LabelCondition_BAY.Text = "Условие: Дан файл InPutFileTask7.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в столбце с номером 2 (нумерация начинается с 0) значения 0 на 1. Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";
            this.LabelCondition_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);


            this.DataGridViewIn_BAY = new System.Windows.Forms.DataGridView();
            this.DataGridViewIn_BAY.Location = new System.Drawing.Point(12, 70);
            this.DataGridViewIn_BAY.Size = new System.Drawing.Size(320, 300);
            this.DataGridViewIn_BAY.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewIn_BAY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewIn_BAY.GridColor = System.Drawing.Color.LightGray;
            this.DataGridViewIn_BAY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.DataGridViewIn_BAY.RowHeadersVisible = false;
            this.DataGridViewIn_BAY.ColumnHeadersVisible = false;
            this.DataGridViewIn_BAY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridViewIn_BAY.ReadOnly = true;
            this.DataGridViewIn_BAY.AllowUserToAddRows = false;
            this.DataGridViewIn_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewIn_BAY.AllowUserToResizeColumns = false;
            this.DataGridViewIn_BAY.AllowUserToResizeRows = false;
            this.DataGridViewIn_BAY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewIn_BAY.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewIn_BAY.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridViewIn_BAY.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewIn_BAY.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;

            this.DataGridViewOut_BAY = new System.Windows.Forms.DataGridView();
            this.DataGridViewOut_BAY.Location = new System.Drawing.Point(352, 70);
            this.DataGridViewOut_BAY.Size = new System.Drawing.Size(320, 300);
            this.DataGridViewOut_BAY.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewOut_BAY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewOut_BAY.GridColor = System.Drawing.Color.LightGray;
            this.DataGridViewOut_BAY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.DataGridViewOut_BAY.RowHeadersVisible = false;
            this.DataGridViewOut_BAY.ColumnHeadersVisible = false;
            this.DataGridViewOut_BAY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridViewOut_BAY.ReadOnly = true;
            this.DataGridViewOut_BAY.AllowUserToAddRows = false;
            this.DataGridViewOut_BAY.AllowUserToDeleteRows = false;
            this.DataGridViewOut_BAY.AllowUserToResizeColumns = false;
            this.DataGridViewOut_BAY.AllowUserToResizeRows = false;
            this.DataGridViewOut_BAY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewOut_BAY.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewOut_BAY.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridViewOut_BAY.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewOut_BAY.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;


            this.ButtonOpenFile_BAY = new System.Windows.Forms.Button();
            this.ButtonOpenFile_BAY.Location = new System.Drawing.Point(12, 385);
            this.ButtonOpenFile_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonOpenFile_BAY.Text = "Открыть файл";
            this.ButtonOpenFile_BAY.UseVisualStyleBackColor = true;
            this.ButtonOpenFile_BAY.Click += new System.EventHandler(this.ButtonOpenFile_BAY_Click);


            this.ButtonExecute_BAY = new System.Windows.Forms.Button();
            this.ButtonExecute_BAY.Location = new System.Drawing.Point(142, 385);
            this.ButtonExecute_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonExecute_BAY.Text = "Выполнить";
            this.ButtonExecute_BAY.UseVisualStyleBackColor = true;
            this.ButtonExecute_BAY.Enabled = false;
            this.ButtonExecute_BAY.Click += new System.EventHandler(this.ButtonExecute_BAY_Click);


            this.ButtonSaveFile_BAY = new System.Windows.Forms.Button();
            this.ButtonSaveFile_BAY.Location = new System.Drawing.Point(272, 385);
            this.ButtonSaveFile_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonSaveFile_BAY.Text = "Сохранить";
            this.ButtonSaveFile_BAY.UseVisualStyleBackColor = true;
            this.ButtonSaveFile_BAY.Enabled = false;
            this.ButtonSaveFile_BAY.Click += new System.EventHandler(this.ButtonSaveFile_BAY_Click);

 
            this.ButtonAbout_BAY = new System.Windows.Forms.Button();
            this.ButtonAbout_BAY.Location = new System.Drawing.Point(552, 385);
            this.ButtonAbout_BAY.Size = new System.Drawing.Size(120, 30);
            this.ButtonAbout_BAY.Text = "Справка";
            this.ButtonAbout_BAY.UseVisualStyleBackColor = true;
            this.ButtonAbout_BAY.Click += new System.EventHandler(this.ButtonAbout_BAY_Click);


            this.LabelStatus_BAY = new System.Windows.Forms.Label();
            this.LabelStatus_BAY.Location = new System.Drawing.Point(12, 425);
            this.LabelStatus_BAY.Size = new System.Drawing.Size(660, 25);
            this.LabelStatus_BAY.Text = "Готов к работе";
            this.LabelStatus_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelStatus_BAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


            this.LabelInput_BAY = new System.Windows.Forms.Label();
            this.LabelInput_BAY.Location = new System.Drawing.Point(12, 50);
            this.LabelInput_BAY.Size = new System.Drawing.Size(320, 15);
            this.LabelInput_BAY.Text = "Ввод:";
            this.LabelInput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelInput_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);


            this.LabelOutput_BAY = new System.Windows.Forms.Label();
            this.LabelOutput_BAY.Location = new System.Drawing.Point(352, 50);
            this.LabelOutput_BAY.Size = new System.Drawing.Size(320, 15);
            this.LabelOutput_BAY.Text = "Вывод:";
            this.LabelOutput_BAY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelOutput_BAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.LabelCondition_BAY);
            this.Controls.Add(this.DataGridViewIn_BAY);
            this.Controls.Add(this.DataGridViewOut_BAY);
            this.Controls.Add(this.ButtonOpenFile_BAY);
            this.Controls.Add(this.ButtonExecute_BAY);
            this.Controls.Add(this.ButtonSaveFile_BAY);
            this.Controls.Add(this.ButtonAbout_BAY);
            this.Controls.Add(this.LabelStatus_BAY);
            this.Controls.Add(this.LabelInput_BAY);
            this.Controls.Add(this.LabelOutput_BAY);
            this.Text = "FormMain";
            this.ResumeLayout(false);
        }


        private System.Windows.Forms.Label LabelCondition_BAY;
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
