using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BiryukovAY.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void InitializeChart_BAY()
        {
            ChartArea_BAY.AxisX.Title = "Индекс элемента";
            ChartArea_BAY.AxisY.Title = "Значение";
            ChartArea_BAY.AxisX.MajorGrid.Enabled = true;
            ChartArea_BAY.AxisY.MajorGrid.Enabled = true;

            SeriesZeros_BAY.ChartType = SeriesChartType.Column;
            SeriesZeros_BAY.Color = System.Drawing.Color.Red;
            SeriesZeros_BAY.Name = "Нулевые значения";
        }

        private void ButtonOpenFile_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл с данными";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    TextBoxFilePath_BAY.Text = filePath;

                    DataService ds = new DataService();
                    allData = ds.LoadFromDataFile(filePath);

                    zeroValues = allData.Where(x => Math.Abs(x) < 0.0001).ToArray();

                    DisplayAllData_BAY();

                    DisplayZeroValues_BAY();

                    PlotChart_BAY();

                    LabelStatus_BAY.Text = $"Загружено элементов: {allData.Length}, Найдено нулей: {zeroValues.Length}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelStatus_BAY.Text = "Ошибка загрузки файла";
            }
        }

        private void DisplayAllData_BAY()
        {
            DataGridViewAllData_BAY.Rows.Clear();
            DataGridViewAllData_BAY.Columns.Clear();

            DataGridViewAllData_BAY.Columns.Add("Index", "Индекс");
            DataGridViewAllData_BAY.Columns.Add("Value", "Значение");

            for (int i = 0; i < allData.Length; i++)
            {
                DataGridViewAllData_BAY.Rows.Add(i + 1, allData[i].ToString("F3"));
            }

            DataGridViewAllData_BAY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DisplayZeroValues_BAY()
        {
            DataGridViewZeros_BAY.Rows.Clear();
            DataGridViewZeros_BAY.Columns.Clear();

            DataGridViewZeros_BAY.Columns.Add("Index", "Индекс в исходных данных");
            DataGridViewZeros_BAY.Columns.Add("Value", "Значение");

            for (int i = 0; i < allData.Length; i++)
            {
                if (Math.Abs(allData[i]) < 0.0001)
                {
                    DataGridViewZeros_BAY.Rows.Add(i + 1, allData[i].ToString("F3"));
                }
            }

            DataGridViewZeros_BAY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PlotChart_BAY()
        {
            SeriesZeros_BAY.Points.Clear();

            if (zeroValues.Length > 0)
            {
                for (int i = 0; i < zeroValues.Length; i++)
                {
                    SeriesZeros_BAY.Points.AddXY(i + 1, zeroValues[i]);
                }
            }
            else
            {
                SeriesZeros_BAY.Points.AddXY(1, 0);
                SeriesZeros_BAY.Points[0].Label = "Нулевые значения не найдены";
            }

            ChartZeros_BAY.ChartAreas[0].RecalculateAxesScale();
        }

        private void ButtonHelp_BAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа выполняет следующие действия:\n" +
                "1. Читает числовые данные из текстового файла\n" +
                "2. Выводит все элементы в первую таблицу\n" +
                "3. Находит и выводит все элементы, равные 0, во вторую таблицу\n" +
                "4. Строит диаграмму по нулевым значениям\n\n" +
                "Вещественные значения округляются до трех знаков после запятой.\n\n" +
                "Для начала работы нажмите 'Выбрать файл' и выберите файл InPutFileTask5V9.txt",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonGenerateTest_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                string testFilePath = "InPutFileTask5V9.txt";
                string[] testData = {
                    "1.2345", "0", "-2.567", "0.000", "3.14159", "0",
                    "5.678", "-1.234", "0", "2.71828", "0.0", "1.618"
                };

                File.WriteAllLines(testFilePath, testData);
                MessageBox.Show($"Тестовый файл создан: {testFilePath}", "Успех",
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