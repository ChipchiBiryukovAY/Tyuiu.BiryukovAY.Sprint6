using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BiryukovAY.Sprint6.Task0.V30.Lib;

namespace Tyuiu.BiryukovAY.Sprint6.Task0.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(TextBoxVarX_BYA.Text);

                DataService ds = new DataService();
                double result = ds.Calculate(x);
                TextBoxResult_BYA.Text = result.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введите целое число в поле X.", "Ошибка ввода",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
