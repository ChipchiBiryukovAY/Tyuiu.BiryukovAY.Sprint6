namespace Tyuiu.BiryukovAY.Sprint6.Task0.V30
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
            this.LabelVarX_BYA = new System.Windows.Forms.Label();
            this.TextBoxVarX_BYA = new System.Windows.Forms.TextBox();
            this.ButtonCalculate_BYA = new System.Windows.Forms.Button();
            this.LabelResult_BYA = new System.Windows.Forms.Label();
            this.TextBoxResult_BYA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.LabelVarX_BYA.AutoSize = true;
            this.LabelVarX_BYA.Location = new System.Drawing.Point(30, 25);
            this.LabelVarX_BYA.Name = "LabelVarX_BYA";
            this.LabelVarX_BYA.Size = new System.Drawing.Size(77, 13);
            this.LabelVarX_BYA.TabIndex = 0;
            this.LabelVarX_BYA.Text = "Переменная X:";
            this.TextBoxVarX_BYA.Location = new System.Drawing.Point(120, 22);
            this.TextBoxVarX_BYA.Name = "TextBoxVarX_BYA";
            this.TextBoxVarX_BYA.Size = new System.Drawing.Size(100, 20);
            this.TextBoxVarX_BYA.TabIndex = 1;
            this.TextBoxVarX_BYA.Text = "3"; 
            this.ButtonCalculate_BYA.Location = new System.Drawing.Point(120, 60);
            this.ButtonCalculate_BYA.Name = "ButtonCalculate_BYA";
            this.ButtonCalculate_BYA.Size = new System.Drawing.Size(100, 30);
            this.ButtonCalculate_BYA.TabIndex = 2;
            this.ButtonCalculate_BYA.Text = "Вычислить";
            this.ButtonCalculate_BYA.UseVisualStyleBackColor = true;
            this.ButtonCalculate_BYA.Click += new System.EventHandler(this.ButtonCalculate_BYA_Click);
            this.LabelResult_BYA.AutoSize = true;
            this.LabelResult_BYA.Location = new System.Drawing.Point(30, 110);
            this.LabelResult_BYA.Name = "LabelResult_BYA";
            this.LabelResult_BYA.Size = new System.Drawing.Size(62, 13);
            this.LabelResult_BYA.TabIndex = 3;
            this.LabelResult_BYA.Text = "Результат:";
            this.TextBoxResult_BYA.Location = new System.Drawing.Point(120, 107);
            this.TextBoxResult_BYA.Name = "TextBoxResult_BYA";
            this.TextBoxResult_BYA.ReadOnly = true;
            this.TextBoxResult_BYA.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult_BYA.TabIndex = 4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.TextBoxResult_BYA);
            this.Controls.Add(this.LabelResult_BYA);
            this.Controls.Add(this.ButtonCalculate_BYA);
            this.Controls.Add(this.TextBoxVarX_BYA);
            this.Controls.Add(this.LabelVarX_BYA);
            this.Name = "MainForm_BYA";
            this.Text = "Вычисление выражения y(x) = x√(x+3)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Label LabelVarX_BYA;
        private System.Windows.Forms.TextBox TextBoxVarX_BYA;
        private System.Windows.Forms.Button ButtonCalculate_BYA;
        private System.Windows.Forms.Label LabelResult_BYA;
        private System.Windows.Forms.TextBox TextBoxResult_BYA;
    }
}

