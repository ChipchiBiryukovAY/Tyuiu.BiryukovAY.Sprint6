using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BiryukovAY.Sprint6.Task7.V24.Lib;

namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ButtonOpenFile_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите CSV файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    TextBoxFilePath_BAY.Text = filePath;

                    DataService ds = new DataService();
                    originalMatrix = ds.GetMatrix(filePath);

                    DisplayMatrixInDataGridView(originalMatrix, DataGridViewIn_BAY);

                    LabelStatus_BAY.Text = $"Файл загружен: {Path.GetFileName(filePath)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelStatus_BAY.Text = "Ошибка загрузки файла";
            }
        }

        private void ButtonExecute_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                if (originalMatrix == null)
                {
                    MessageBox.Show("Сначала загрузите файл!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataService ds = new DataService();
                processedMatrix = ds.ProcessMatrix(originalMatrix);

                DisplayMatrixInDataGridView(processedMatrix, DataGridViewOut_BAY);

                LabelStatus_BAY.Text = "Обработка завершена. Четные элементы во второй строке заменены на 1.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelStatus_BAY.Text = "Ошибка обработки";
            }
        }

        private void ButtonSaveFile_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                if (processedMatrix == null)
                {
                    MessageBox.Show("Сначала выполните обработку матрицы!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить результат в CSV файл";
                saveFileDialog.FileName = "OutPutFileTask7.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveMatrixToCsv(processedMatrix, saveFileDialog.FileName);
                    LabelStatus_BAY.Text = $"Результат сохранен в: {Path.GetFileName(saveFileDialog.FileName)}";

                    MessageBox.Show("Файл успешно сохранен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelStatus_BAY.Text = "Ошибка сохранения файла";
            }
        }

        private void DisplayMatrixInDataGridView(int[,] matrix, DataGridView dataGridView)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowCount = rows;
            dataGridView.ColumnCount = cols;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                    dataGridView.Rows[i].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void SaveMatrixToCsv(int[,] matrix, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(matrix[i, j]);
                        if (j < cols - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        private void ButtonAbout_BAY_Click(object sender, EventArgs e)
        {
            AboutForm_BAY aboutForm = new AboutForm_BAY();
            aboutForm.ShowDialog();
        }

        private void ButtonGenerateTest_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                string testFilePath = "InPutFileTask7V24.csv";
                string[] testData = {
                    "1,2,3,4,5",
                    "6,7,8,9,10",
                    "11,12,13,14,15",
                    "16,17,18,19,20",
                    "21,22,23,24,25"
                };

                File.WriteAllLines(testFilePath, testData);

                TextBoxFilePath_BAY.Text = testFilePath;
                DataService ds = new DataService();
                originalMatrix = ds.GetMatrix(testFilePath);
                DisplayMatrixInDataGridView(originalMatrix, DataGridViewIn_BAY);

                MessageBox.Show($"Тестовый файл создан и загружен: {testFilePath}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания тестового файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}