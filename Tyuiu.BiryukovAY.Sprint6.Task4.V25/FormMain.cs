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
using Tyuiu.BiryukovAY.Sprint6.Task4.V25.Lib;

namespace Tyuiu.BiryukovAY.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void InitializeChart_BAY()
        {
            ChartArea_BAY.AxisX.Title = "Ось X";
            ChartArea_BAY.AxisY.Title = "Ось Y";
            ChartArea_BAY.AxisX.MajorGrid.Enabled = true;
            ChartArea_BAY.AxisY.MajorGrid.Enabled = true;

            SeriesFunction_BAY.ChartType = SeriesChartType.Line;
            SeriesFunction_BAY.Color = System.Drawing.Color.Blue;
            SeriesFunction_BAY.BorderWidth = 2;
            SeriesFunction_BAY.Name = "F(x) = cos(x) + 2x - 3x*sin(x)";
        }

        private void ButtonCalculate_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                int start = int.Parse(TextBoxStart_BAY.Text);
                int stop = int.Parse(TextBoxStop_BAY.Text);

                DataService ds = new DataService();
                double[] results = ds.GetMassFunction(start, stop);

                DisplayResultsInTextBox_BAY(start, stop, results);

                PlotGraph_BAY(start, stop, results);

                SaveToFile_BAY(start, stop, results);

                MessageBox.Show("Расчет завершен успешно!\nРезультаты сохранены в файл OutPutFileTask4V25.txt",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResultsInTextBox_BAY(int start, int stop, double[] results)
        {
            TextBoxResult_BAY.Clear();
            TextBoxResult_BAY.AppendText("Результат табулирования функции:\r\n");
            TextBoxResult_BAY.AppendText("F(x) = cos(x) + 2x - 3x*sin(x)\r\n");
            TextBoxResult_BAY.AppendText($"Диапазон: от {start} до {stop}\r\n");
            TextBoxResult_BAY.AppendText("-----------------------------\r\n");
            TextBoxResult_BAY.AppendText("|   X   |   F(x)   |\r\n");
            TextBoxResult_BAY.AppendText("-----------------------------\r\n");

            for (int i = 0; i < results.Length; i++)
            {
                TextBoxResult_BAY.AppendText($"|  {start + i,3}  |  {results[i],7:F2}  |\r\n");
            }
            TextBoxResult_BAY.AppendText("-----------------------------\r\n");
        }

        private void PlotGraph_BAY(int start, int stop, double[] results)
        {
            SeriesFunction_BAY.Points.Clear();

            for (int i = 0; i < results.Length; i++)
            {
                SeriesFunction_BAY.Points.AddXY(start + i, results[i]);
            }

            ChartFunction_BAY.ChartAreas[0].RecalculateAxesScale();
        }

        private void SaveToFile_BAY(int start, int stop, double[] results)
        {
            string filePath = "OutPutFileTask4V25.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Результат табулирования функции:");
                writer.WriteLine("F(x) = cos(x) + 2x - 3x*sin(x)");
                writer.WriteLine($"Диапазон: от {start} до {stop}");
                writer.WriteLine("-----------------------------");
                writer.WriteLine("|   X   |   F(x)   |");
                writer.WriteLine("-----------------------------");

                for (int i = 0; i < results.Length; i++)
                {
                    writer.WriteLine($"|  {start + i,3}  |  {results[i],7:F2}  |");
                }
                writer.WriteLine("-----------------------------");
            }
        }

        private void ButtonHelp_BAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа табулирует функцию:\n" +
                "F(x) = cos(x) + 2x - 3x*sin(x)\n\n" +
                "Введите начальное и конечное значения X,\n" +
                "затем нажмите 'Выполнить' для расчета.\n\n" +
                "Результаты будут:\n" +
                "- Выведены в текстовое поле\n" +
                "- Построены на графике\n" +
                "- Сохранены в файл OutPutFileTask4V25.txt",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}