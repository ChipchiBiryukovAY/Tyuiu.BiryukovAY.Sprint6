using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.BiryukovAY.Sprint6.Task1.V22.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task1.V22
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
            this.LabelStart_BAY = new Label();
            this.LabelStop_BAY = new Label();
            this.TextBoxStart_BAY = new TextBox();
            this.TextBoxStop_BAY = new TextBox();
            this.ButtonCalculate_BAY = new Button();
            this.TextBoxResult_BAY = new TextBox();
            this.SuspendLayout();

            this.LabelStart_BAY.Location = new Point(12, 20);
            this.LabelStart_BAY.Name = "LabelStart_BAY";
            this.LabelStart_BAY.Size = new Size(100, 20);
            this.LabelStart_BAY.Text = "Старт шага:";

            this.LabelStop_BAY.Location = new Point(12, 50);
            this.LabelStop_BAY.Name = "LabelStop_BAY";
            this.LabelStop_BAY.Size = new Size(100, 20);
            this.LabelStop_BAY.Text = "Конец шага:";

            this.TextBoxStart_BAY.Location = new Point(120, 17);
            this.TextBoxStart_BAY.Name = "TextBoxStart_BAY";
            this.TextBoxStart_BAY.Size = new Size(100, 20);

            this.TextBoxStop_BAY.Location = new Point(120, 47);
            this.TextBoxStop_BAY.Name = "TextBoxStop_BAY";
            this.TextBoxStop_BAY.Size = new Size(100, 20);

            this.ButtonCalculate_BAY.Location = new Point(12, 80);
            this.ButtonCalculate_BAY.Name = "ButtonCalculate_BAY";
            this.ButtonCalculate_BAY.Size = new Size(208, 30);
            this.ButtonCalculate_BAY.Text = "Выполнить";
            this.ButtonCalculate_BAY.Click += ButtonCalculate_BAY_Click;

            this.TextBoxResult_BAY.Location = new Point(12, 120);
            this.TextBoxResult_BAY.Multiline = true;
            this.TextBoxResult_BAY.Name = "TextBoxResult_BAY";
            this.TextBoxResult_BAY.ScrollBars = ScrollBars.Vertical;
            this.TextBoxResult_BAY.Size = new Size(208, 200);

            this.ClientSize = new Size(232, 333);
            this.Controls.AddRange(new Control[] {
            this.LabelStart_BAY,
            this.LabelStop_BAY,
            this.TextBoxStart_BAY,
            this.TextBoxStop_BAY,
            this.ButtonCalculate_BAY,
            this.TextBoxResult_BAY
        });
            this.Name = "MainForm_BAY";
            this.Text = "Табулирование функции";
            this.ResumeLayout(false);
        }

        private Label LabelStart_BAY;
        private Label LabelStop_BAY;
        private TextBox TextBoxStart_BAY;
        private TextBox TextBoxStop_BAY;
        private Button ButtonCalculate_BAY;
        private TextBox TextBoxResult_BAY;
    }