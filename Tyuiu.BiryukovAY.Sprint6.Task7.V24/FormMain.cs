using System;
using Tyuiu.BiryukovAY.Sprint6.Task7.V24.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        private int[,]? originalMatrix;  
        private int[,]? processedMatrix;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_BAY_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataService service = new DataService();
                    originalMatrix = service.GetMatrix(dialog.FileName);

                    ShowMatrix(originalMatrix, DataGridViewIn_BAY);
                    LabelStatus_BAY.Text = "Файл загружен";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void ButtonExecute_BAY_Click(object sender, EventArgs e)
        {
            if (originalMatrix == null)
            {
                MessageBox.Show("Сначала загрузите файл!");
                return;
            }

            DataService service = new DataService();
            processedMatrix = service.ProcessMatrix(originalMatrix);

            ShowMatrix(processedMatrix, DataGridViewOut_BAY);
            LabelStatus_BAY.Text = "Обработка завершена";
        }

        private void ButtonSaveFile_BAY_Click(object sender, EventArgs e)
        {
            if (processedMatrix == null)
            {
                MessageBox.Show("Сначала выполните обработку!");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV files|*.csv";
            dialog.FileName = "OutPutFileTask7.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveMatrixToFile(processedMatrix, dialog.FileName);
                LabelStatus_BAY.Text = "Файл сохранен";
            }
        }

        private void ButtonAbout_BAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Разработчик: Бирюков А.Ю.\n" +
                "Группа: ПКТб-25-1\n" +
                "Тюменский индустриальный университет",
                "О программе");
        }

        private void ShowMatrix(int[,] matrix, DataGridView grid)
        {
            grid.RowCount = matrix.GetLength(0);
            grid.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    grid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void SaveMatrixToFile(int[,] matrix, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    string line = "";
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        line += matrix[i, j] + (j < matrix.GetLength(1) - 1 ? "," : "");
                    }
                    writer.WriteLine(line);
                }
            }
        }
    }
}
