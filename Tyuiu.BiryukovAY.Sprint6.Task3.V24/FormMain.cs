using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BiryukovAY.Sprint6.Task3.V24.Lib;

namespace Tyuiu.BiryukovAY.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DisplayMatrix_BAY(originalMatrix, DataGridViewOriginal_BAY);
        }
    }private void DisplayMatrix_BAY(int[,] matrix, DataGridView dataGridView)
        {
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ButtonProcess_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int[,] resultMatrix = ds.Calculate(originalMatrix);

                DisplayMatrix_BAY(resultMatrix, DataGridViewResult_BAY);

                HighlightSecondRow_BAY();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HighlightSecondRow_BAY()
        {

            if (DataGridViewResult_BAY.RowCount > 1)
            {
                DataGridViewResult_BAY.Rows[1].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                DataGridViewResult_BAY.Rows[1].DefaultCellStyle.Font = new System.Drawing.Font(DataGridViewResult_BAY.Font, System.Drawing.FontStyle.Bold);
            }
        }

        private void ButtonHelp_BAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа обрабатывает матрицу 5x5:\n" +
                "Заменяет четные значения во второй строке на 0.\n\n" +
                "Исходная матрица:\n" +
                "-17  -6  10   5   3\n" +
                "-10 -14  10  -7  -3\n" +
                "-19   9   8 -17  -9\n" +
                "-19  -5  -9 -18  14\n" +
                " 17  12  11  12   2\n\n" +
                "Нажмите 'Выполнить' для обработки.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}