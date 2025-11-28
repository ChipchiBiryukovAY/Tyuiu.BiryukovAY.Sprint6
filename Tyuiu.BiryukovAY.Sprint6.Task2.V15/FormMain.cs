using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BiryukovAY.Sprint6.Task2.V15
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
            SeriesFunction_BAY.Name = "F(x) = (2sin(x))/(3x+1.2) + cos(x) - 14x";
        }

        private void ButtonCalculate_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                int start = int.Parse(TextBoxStart_BAY.Text);
                int stop = int.Parse(TextBoxStop_BAY.Text);

                DataService ds = new DataService();
                double[] results = ds.GetMassFunction(start, stop);

                FillDataGridView_BAY(start, stop, results);

                PlotGraph_BAY(start, stop, results);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDataGridView_BAY(int start, int stop, double[] results)
        {
            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(int));
            table.Columns.Add("F(x)", typeof(double));

            for (int i = 0; i < results.Length; i++)
            {
                table.Rows.Add(start + i, results[i]);
            }

            DataGridViewResult_BAY.DataSource = table;
            DataGridViewResult_BAY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void ButtonHelp_BAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа табулирует функцию:\n" +
                "F(x) = (2sin(x))/(3x+1.2) + cos(x) - 14x\n\n" +
                "Введите начальное и конечное значения X,\n" +
                "затем нажмите 'Выполнить' для расчета.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}