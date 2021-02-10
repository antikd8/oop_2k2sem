namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.comboBoxOriginal = new System.Windows.Forms.ComboBox();
            this.labelCalculator = new System.Windows.Forms.Label();
            this.textBoxConverted = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxConverted = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.BackColor = System.Drawing.Color.OldLace;
            this.textBoxOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.textBoxOriginal.Location = new System.Drawing.Point(50, 144);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(175, 26);
            this.textBoxOriginal.TabIndex = 1;
            this.textBoxOriginal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOriginal_KeyDown);
            this.textBoxOriginal.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOriginal_Validating);
            // 
            // comboBoxOriginal
            // 
            this.comboBoxOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxOriginal.FormattingEnabled = true;
            this.comboBoxOriginal.Items.AddRange(new object[] {
            "Миллиметр (мм)",
            "Сантиметр (см)"});
            this.comboBoxOriginal.Location = new System.Drawing.Point(50, 179);
            this.comboBoxOriginal.Name = "comboBoxOriginal";
            this.comboBoxOriginal.Size = new System.Drawing.Size(175, 30);
            this.comboBoxOriginal.TabIndex = 3;
            // 
            // labelCalculator
            // 
            this.labelCalculator.AutoSize = true;
            this.labelCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.labelCalculator.Location = new System.Drawing.Point(199, 27);
            this.labelCalculator.Name = "labelCalculator";
            this.labelCalculator.Size = new System.Drawing.Size(355, 36);
            this.labelCalculator.TabIndex = 4;
            this.labelCalculator.Text = "Калькулятор размеров";
            // 
            // textBoxConverted
            // 
            this.textBoxConverted.BackColor = System.Drawing.Color.OldLace;
            this.textBoxConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.textBoxConverted.Location = new System.Drawing.Point(494, 141);
            this.textBoxConverted.Name = "textBoxConverted";
            this.textBoxConverted.Size = new System.Drawing.Size(205, 26);
            this.textBoxConverted.TabIndex = 5;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.White;
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.buttonConvert.Location = new System.Drawing.Point(262, 157);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(203, 41);
            this.buttonConvert.TabIndex = 7;
            this.buttonConvert.Text = "ПЕРЕВЕСТИ";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.button1_Click);
            this.buttonConvert.MouseLeave += new System.EventHandler(this.buttonConvert_MouseLeave);
            this.buttonConvert.MouseHover += new System.EventHandler(this.buttonConvert_MouseHover);
            // 
            // comboBoxConverted
            // 
            this.comboBoxConverted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxConverted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxConverted.FormattingEnabled = true;
            this.comboBoxConverted.Items.AddRange(new object[] {
            "США (US)",
            "Европа (EUR)",
            "Россия (RUS)",
            "Великобритания (UK)"});
            this.comboBoxConverted.Location = new System.Drawing.Point(494, 179);
            this.comboBoxConverted.Name = "comboBoxConverted";
            this.comboBoxConverted.Size = new System.Drawing.Size(205, 30);
            this.comboBoxConverted.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(73, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Длина стопы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(527, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Размер обуви";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Tomato;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonExit.Location = new System.Drawing.Point(555, 339);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 47);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "ВЫХОД";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(752, 413);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxConverted);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxConverted);
            this.Controls.Add(this.labelCalculator);
            this.Controls.Add(this.comboBoxOriginal);
            this.Controls.Add(this.textBoxOriginal);
            this.MaximumSize = new System.Drawing.Size(770, 460);
            this.MinimumSize = new System.Drawing.Size(770, 460);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.ComboBox comboBoxOriginal;
        private System.Windows.Forms.Label labelCalculator;
        private System.Windows.Forms.TextBox textBoxConverted;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxConverted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
    }
}

