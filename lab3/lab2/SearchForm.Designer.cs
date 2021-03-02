
namespace lab2
{
    partial class SearchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.labelSearchYear = new System.Windows.Forms.Label();
            this.labelSearchDistrict = new System.Windows.Forms.Label();
            this.labelSearchRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelYear = new System.Windows.Forms.Panel();
            this.panelDistrict = new System.Windows.Forms.Panel();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.treeViewResult = new System.Windows.Forms.TreeView();
            this.panelYear.SuspendLayout();
            this.panelDistrict.SuspendLayout();
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchYear
            // 
            this.labelSearchYear.AutoSize = true;
            this.labelSearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchYear.Location = new System.Drawing.Point(12, 12);
            this.labelSearchYear.Name = "labelSearchYear";
            this.labelSearchYear.Size = new System.Drawing.Size(146, 25);
            this.labelSearchYear.TabIndex = 0;
            this.labelSearchYear.Text = "Поиск по году:";
            // 
            // labelSearchDistrict
            // 
            this.labelSearchDistrict.AutoSize = true;
            this.labelSearchDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchDistrict.Location = new System.Drawing.Point(12, 12);
            this.labelSearchDistrict.Name = "labelSearchDistrict";
            this.labelSearchDistrict.Size = new System.Drawing.Size(169, 25);
            this.labelSearchDistrict.TabIndex = 1;
            this.labelSearchDistrict.Text = "Поиск по району:";
            // 
            // labelSearchRooms
            // 
            this.labelSearchRooms.AutoSize = true;
            this.labelSearchRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchRooms.Location = new System.Drawing.Point(12, 1);
            this.labelSearchRooms.Name = "labelSearchRooms";
            this.labelSearchRooms.Size = new System.Drawing.Size(153, 50);
            this.labelSearchRooms.TabIndex = 2;
            this.labelSearchRooms.Text = "Поиск по \r\nкол-ву комнат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат поиска:";
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.dateTimePickerYear);
            this.panelYear.Controls.Add(this.labelSearchYear);
            this.panelYear.Location = new System.Drawing.Point(51, 26);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(200, 100);
            this.panelYear.TabIndex = 8;
            // 
            // panelDistrict
            // 
            this.panelDistrict.Controls.Add(this.comboBoxDistrict);
            this.panelDistrict.Controls.Add(this.labelSearchDistrict);
            this.panelDistrict.Location = new System.Drawing.Point(51, 116);
            this.panelDistrict.Name = "panelDistrict";
            this.panelDistrict.Size = new System.Drawing.Size(200, 100);
            this.panelDistrict.TabIndex = 9;
            // 
            // panelRooms
            // 
            this.panelRooms.Controls.Add(this.numericUpDownRooms);
            this.panelRooms.Controls.Add(this.labelSearchRooms);
            this.panelRooms.Location = new System.Drawing.Point(51, 210);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(200, 100);
            this.panelRooms.TabIndex = 10;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.AutoCompleteCustomSource.AddRange(new string[] {
            "Ленинский",
            "Первомайский",
            "Пушкинский",
            "Якубовского",
            "Казимировка"});
            this.comboBoxDistrict.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "Ленинский",
            "Первомайский",
            "Спутник",
            "Казимировка",
            "Пушкинский",
            "-Добавить-"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(17, 50);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(146, 28);
            this.comboBoxDistrict.TabIndex = 33;
            this.comboBoxDistrict.TextChanged += new System.EventHandler(this.comboBoxDistrict_TextChanged);
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownRooms.Location = new System.Drawing.Point(17, 60);
            this.numericUpDownRooms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRooms.Name = "numericUpDownRooms";
            this.numericUpDownRooms.Size = new System.Drawing.Size(89, 26);
            this.numericUpDownRooms.TabIndex = 22;
            this.numericUpDownRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(17, 49);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(89, 26);
            this.dateTimePickerYear.TabIndex = 23;
            // 
            // treeViewResult
            // 
            this.treeViewResult.BackColor = System.Drawing.Color.LightYellow;
            this.treeViewResult.Location = new System.Drawing.Point(349, 64);
            this.treeViewResult.Name = "treeViewResult";
            this.treeViewResult.Size = new System.Drawing.Size(252, 231);
            this.treeViewResult.TabIndex = 11;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(640, 337);
            this.Controls.Add(this.treeViewResult);
            this.Controls.Add(this.panelRooms);
            this.Controls.Add(this.panelDistrict);
            this.Controls.Add(this.panelYear);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Поисковая форма";
            this.panelYear.ResumeLayout(false);
            this.panelYear.PerformLayout();
            this.panelDistrict.ResumeLayout(false);
            this.panelDistrict.PerformLayout();
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchYear;
        private System.Windows.Forms.Label labelSearchDistrict;
        private System.Windows.Forms.Label labelSearchRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.Panel panelDistrict;
        private System.Windows.Forms.Panel panelRooms;
        public System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.TreeView treeViewResult;
    }
}