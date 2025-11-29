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

namespace Tyuiu.BiryukovAY.Sprint6.Task6.V3
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
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    TextBoxFilePath_BAY.Text = currentFilePath;

                    string fileContent = File.ReadAllText(currentFilePath);
                    TextBoxIn_BAY.Text = fileContent;

                    LabelStatus_BAY.Text = $"Файл загружен: {Path.GetFileName(currentFilePath)}";
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
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    MessageBox.Show("Сначала выберите файл!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!File.Exists(currentFilePath))
                {
                    MessageBox.Show("Файл не существует!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataService ds = new DataService();
                string result = ds.CollectTextFromFile(currentFilePath);

                TextBoxOut_BAY.Text = result;
                LabelStatus_BAY.Text = $"Обработка завершена. Найдено слов: {result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelStatus_BAY.Text = "Ошибка обработки файла";
            }
        }

        private void ButtonHelp_BAY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа выполняет следующие действия:\n" +
                "1. Загружает текстовый файл через диалог выбора файла\n" +
                "2. Отображает содержимое файла в левом текстовом поле\n" +
                "3. Находит все слова, содержащие букву 'r' (без учета регистра)\n" +
                "4. Выводит найденные слова в правом текстовом поле\n\n" +
                "Слова разделяются пробелами и знаками пунктуации.\n" +
                "Поиск выполняется без учета регистра (r и R считаются одинаково).",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonGenerateTest_BAY_Click(object sender, EventArgs e)
        {
            try
            {
                string testFilePath = "InPutFileTask6V3.txt";
                string[] testData = {
                    "Hello world from Russia!",
                    "Programming is great and fun.",
                    "This text contains words with letter r.",
                    "Apple, banana, cherry, orange.",
                    "Red car, green tree, blue sky.",
                    "Without any relevant letters here.",
                    "Another example with words: program, computer, server."
                };

                File.WriteAllLines(testFilePath, testData);

                currentFilePath = testFilePath;
                TextBoxFilePath_BAY.Text = currentFilePath;
                TextBoxIn_BAY.Text = File.ReadAllText(currentFilePath);

                MessageBox.Show($"Тестовый файл создан и загружен: {testFilePath}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания тестового файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClear_BAY_Click(object sender, EventArgs e)
        {
            TextBoxIn_BAY.Clear();
            TextBoxOut_BAY.Clear();
            TextBoxFilePath_BAY.Clear();
            currentFilePath = "";
            LabelStatus_BAY.Text = "Готов к работе";
        }
    }
}