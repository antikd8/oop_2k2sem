namespace lab2
{
    partial class FlatForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Минск");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Могилев");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Гомель");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Беларусь", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Колорадо");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Вайоминг");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Техас");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("США", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Киев");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Львов");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Одесса");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Украина", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Нюрбург");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Франкфурт");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Берлин");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Германия", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Москва");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Санкт-Петербург");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Владивосток");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Россия", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Страна", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16,
            treeNode20});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelFootage = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.checkBoxKitchen = new System.Windows.Forms.CheckBox();
            this.checkBoxLivingRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxBathroom = new System.Windows.Forms.CheckBox();
            this.checkBoxBalcony = new System.Windows.Forms.CheckBox();
            this.checkBoxBasement = new System.Windows.Forms.CheckBox();
            this.trackBarFootage = new System.Windows.Forms.TrackBar();
            this.labelYear = new System.Windows.Forms.Label();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.numericUpDownFloor = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.textBoxNumberFlat = new System.Windows.Forms.TextBox();
            this.textBoxNumberHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelFlatNumber = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelDistrict = new System.Windows.Forms.Label();
            this.treeViewCountry = new System.Windows.Forms.TreeView();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.buttonOutputFlatInfo = new System.Windows.Forms.Button();
            this.textBoxFlatInfo = new System.Windows.Forms.TextBox();
            this.buttonClearInfo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCostFlat = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.buttonAutoFill = new System.Windows.Forms.Button();
            this.labelBucks = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearchAmountRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortYear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortFootage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearched = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).BeginInit();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о квартире";
            // 
            // labelFootage
            // 
            this.labelFootage.AutoSize = true;
            this.labelFootage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFootage.Location = new System.Drawing.Point(78, 89);
            this.labelFootage.Name = "labelFootage";
            this.labelFootage.Size = new System.Drawing.Size(169, 25);
            this.labelFootage.TabIndex = 1;
            this.labelFootage.Text = "Метраж:     (м^2)";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRooms.Location = new System.Drawing.Point(78, 184);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(199, 25);
            this.labelRooms.TabIndex = 3;
            this.labelRooms.Text = "Количество комнат";
            // 
            // checkBoxKitchen
            // 
            this.checkBoxKitchen.AutoSize = true;
            this.checkBoxKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxKitchen.Location = new System.Drawing.Point(84, 264);
            this.checkBoxKitchen.Name = "checkBoxKitchen";
            this.checkBoxKitchen.Size = new System.Drawing.Size(87, 29);
            this.checkBoxKitchen.TabIndex = 5;
            this.checkBoxKitchen.Text = "Кухня";
            this.checkBoxKitchen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLivingRoom
            // 
            this.checkBoxLivingRoom.AutoSize = true;
            this.checkBoxLivingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxLivingRoom.Location = new System.Drawing.Point(84, 298);
            this.checkBoxLivingRoom.Name = "checkBoxLivingRoom";
            this.checkBoxLivingRoom.Size = new System.Drawing.Size(122, 29);
            this.checkBoxLivingRoom.TabIndex = 6;
            this.checkBoxLivingRoom.Text = "Гостиная";
            this.checkBoxLivingRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxBathroom
            // 
            this.checkBoxBathroom.AutoSize = true;
            this.checkBoxBathroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBathroom.Location = new System.Drawing.Point(84, 332);
            this.checkBoxBathroom.Name = "checkBoxBathroom";
            this.checkBoxBathroom.Size = new System.Drawing.Size(185, 29);
            this.checkBoxBathroom.TabIndex = 7;
            this.checkBoxBathroom.Text = "Ванная комната";
            this.checkBoxBathroom.UseVisualStyleBackColor = true;
            // 
            // checkBoxBalcony
            // 
            this.checkBoxBalcony.AutoSize = true;
            this.checkBoxBalcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBalcony.Location = new System.Drawing.Point(84, 368);
            this.checkBoxBalcony.Name = "checkBoxBalcony";
            this.checkBoxBalcony.Size = new System.Drawing.Size(100, 29);
            this.checkBoxBalcony.TabIndex = 8;
            this.checkBoxBalcony.Text = "Балкон";
            this.checkBoxBalcony.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasement
            // 
            this.checkBoxBasement.AutoSize = true;
            this.checkBoxBasement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBasement.Location = new System.Drawing.Point(84, 404);
            this.checkBoxBasement.Name = "checkBoxBasement";
            this.checkBoxBasement.Size = new System.Drawing.Size(103, 29);
            this.checkBoxBasement.TabIndex = 9;
            this.checkBoxBasement.Text = "Подвал";
            this.checkBoxBasement.UseVisualStyleBackColor = true;
            // 
            // trackBarFootage
            // 
            this.trackBarFootage.AllowDrop = true;
            this.trackBarFootage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.trackBarFootage.Location = new System.Drawing.Point(69, 116);
            this.trackBarFootage.Maximum = 300;
            this.trackBarFootage.Minimum = 1;
            this.trackBarFootage.Name = "trackBarFootage";
            this.trackBarFootage.Size = new System.Drawing.Size(194, 56);
            this.trackBarFootage.TabIndex = 10;
            this.trackBarFootage.TickFrequency = 50;
            this.trackBarFootage.Value = 1;
            this.trackBarFootage.Scroll += new System.EventHandler(this.trackBarFootage_Scroll);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYear.Location = new System.Drawing.Point(77, 455);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(150, 25);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Год постройки";
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CalendarMonthBackground = System.Drawing.Color.LightYellow;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(84, 491);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(75, 26);
            this.dateTimePickerYear.TabIndex = 12;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaterial.Location = new System.Drawing.Point(79, 541);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(155, 25);
            this.labelMaterial.TabIndex = 13;
            this.labelMaterial.Text = "Тип материала";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Кирпич",
            "Дерево",
            "Блоки",
            "Бетонные плиты"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(84, 572);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(157, 28);
            this.comboBoxMaterial.TabIndex = 14;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFloor.Location = new System.Drawing.Point(77, 617);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(65, 25);
            this.labelFloor.TabIndex = 15;
            this.labelFloor.Text = "Этаж";
            // 
            // numericUpDownFloor
            // 
            this.numericUpDownFloor.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownFloor.Location = new System.Drawing.Point(84, 645);
            this.numericUpDownFloor.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFloor.Name = "numericUpDownFloor";
            this.numericUpDownFloor.Size = new System.Drawing.Size(88, 26);
            this.numericUpDownFloor.TabIndex = 16;
            this.numericUpDownFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.textBoxIndex);
            this.groupBoxAddress.Controls.Add(this.labelIndex);
            this.groupBoxAddress.Controls.Add(this.comboBoxDistrict);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberFlat);
            this.groupBoxAddress.Controls.Add(this.textBoxNumberHouse);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.labelFlatNumber);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.labelDistrict);
            this.groupBoxAddress.Controls.Add(this.treeViewCountry);
            this.groupBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxAddress.Location = new System.Drawing.Point(377, 48);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(623, 296);
            this.groupBoxAddress.TabIndex = 17;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес квартиры";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxIndex.Location = new System.Drawing.Point(275, 172);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.ShortcutsEnabled = false;
            this.textBoxIndex.Size = new System.Drawing.Size(145, 26);
            this.textBoxIndex.TabIndex = 34;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelIndex.Location = new System.Drawing.Point(273, 149);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(70, 20);
            this.labelIndex.TabIndex = 33;
            this.labelIndex.Text = "Индекс";
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
            this.comboBoxDistrict.Location = new System.Drawing.Point(275, 47);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(146, 28);
            this.comboBoxDistrict.TabIndex = 32;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // textBoxNumberFlat
            // 
            this.textBoxNumberFlat.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberFlat.Location = new System.Drawing.Point(456, 106);
            this.textBoxNumberFlat.Name = "textBoxNumberFlat";
            this.textBoxNumberFlat.ShortcutsEnabled = false;
            this.textBoxNumberFlat.Size = new System.Drawing.Size(145, 26);
            this.textBoxNumberFlat.TabIndex = 11;
            this.textBoxNumberFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberFlat_KeyPress);
            // 
            // textBoxNumberHouse
            // 
            this.textBoxNumberHouse.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxNumberHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNumberHouse.Location = new System.Drawing.Point(457, 40);
            this.textBoxNumberHouse.Name = "textBoxNumberHouse";
            this.textBoxNumberHouse.ShortcutsEnabled = false;
            this.textBoxNumberHouse.Size = new System.Drawing.Size(145, 26);
            this.textBoxNumberHouse.TabIndex = 10;
            this.textBoxNumberHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberHouse_KeyPress);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStreet.Location = new System.Drawing.Point(275, 104);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.ShortcutsEnabled = false;
            this.textBoxStreet.Size = new System.Drawing.Size(145, 26);
            this.textBoxStreet.TabIndex = 9;
            this.textBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreet_KeyPress);
            // 
            // labelFlatNumber
            // 
            this.labelFlatNumber.AutoSize = true;
            this.labelFlatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFlatNumber.Location = new System.Drawing.Point(452, 83);
            this.labelFlatNumber.Name = "labelFlatNumber";
            this.labelFlatNumber.Size = new System.Drawing.Size(150, 20);
            this.labelFlatNumber.TabIndex = 8;
            this.labelFlatNumber.Text = "Номер квартиры";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHouse.Location = new System.Drawing.Point(452, 17);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(113, 20);
            this.labelHouse.TabIndex = 7;
            this.labelHouse.Text = "Номер дома";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStreet.Location = new System.Drawing.Point(271, 83);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(60, 20);
            this.labelStreet.TabIndex = 3;
            this.labelStreet.Text = "Улица";
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDistrict.Location = new System.Drawing.Point(271, 21);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(60, 20);
            this.labelDistrict.TabIndex = 1;
            this.labelDistrict.Text = "Район";
            // 
            // treeViewCountry
            // 
            this.treeViewCountry.BackColor = System.Drawing.Color.LightYellow;
            this.treeViewCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeViewCountry.Location = new System.Drawing.Point(27, 47);
            this.treeViewCountry.Name = "treeViewCountry";
            treeNode1.Name = "Minsk";
            treeNode1.Text = "Минск";
            treeNode2.Name = "Mogilev";
            treeNode2.Text = "Могилев";
            treeNode3.Name = "Gomel";
            treeNode3.Text = "Гомель";
            treeNode4.Name = "Belarus";
            treeNode4.Text = "Беларусь";
            treeNode5.Name = "Colorado";
            treeNode5.Text = "Колорадо";
            treeNode6.Name = "Wayoming";
            treeNode6.Text = "Вайоминг";
            treeNode7.Name = "Texas";
            treeNode7.Text = "Техас";
            treeNode8.Name = "USA";
            treeNode8.Text = "США";
            treeNode9.Name = "Kiev";
            treeNode9.Text = "Киев";
            treeNode10.Name = "Lviv";
            treeNode10.Text = "Львов";
            treeNode11.Name = "Odessa";
            treeNode11.Text = "Одесса";
            treeNode12.Name = "Ukraine";
            treeNode12.Text = "Украина";
            treeNode13.Name = "Nurburg";
            treeNode13.Text = "Нюрбург";
            treeNode14.Name = "Frankfurt";
            treeNode14.Text = "Франкфурт";
            treeNode15.Name = "Berlin";
            treeNode15.Text = "Берлин";
            treeNode16.Name = "Germany";
            treeNode16.Text = "Германия";
            treeNode17.Name = "Moscow";
            treeNode17.Text = "Москва";
            treeNode18.Name = "SPB";
            treeNode18.Text = "Санкт-Петербург";
            treeNode19.Name = "Vladivostok";
            treeNode19.Text = "Владивосток";
            treeNode20.Name = "Russia";
            treeNode20.Text = "Россия";
            treeNode21.Name = "Country";
            treeNode21.Text = "Страна";
            this.treeViewCountry.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.treeViewCountry.Size = new System.Drawing.Size(214, 213);
            this.treeViewCountry.TabIndex = 0;
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.BackColor = System.Drawing.Color.LightYellow;
            this.numericUpDownRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownRooms.Location = new System.Drawing.Point(82, 220);
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
            this.numericUpDownRooms.TabIndex = 21;
            this.numericUpDownRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOutputFlatInfo
            // 
            this.buttonOutputFlatInfo.BackColor = System.Drawing.Color.LightGreen;
            this.buttonOutputFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOutputFlatInfo.Location = new System.Drawing.Point(377, 359);
            this.buttonOutputFlatInfo.Name = "buttonOutputFlatInfo";
            this.buttonOutputFlatInfo.Size = new System.Drawing.Size(269, 85);
            this.buttonOutputFlatInfo.TabIndex = 22;
            this.buttonOutputFlatInfo.Text = "Вывести информацию о квартире";
            this.buttonOutputFlatInfo.UseVisualStyleBackColor = false;
            this.buttonOutputFlatInfo.Click += new System.EventHandler(this.buttonOutputInfo_Click);
            this.buttonOutputFlatInfo.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonOutputFlatInfo.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // textBoxFlatInfo
            // 
            this.textBoxFlatInfo.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxFlatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxFlatInfo.Location = new System.Drawing.Point(377, 456);
            this.textBoxFlatInfo.Multiline = true;
            this.textBoxFlatInfo.Name = "textBoxFlatInfo";
            this.textBoxFlatInfo.ReadOnly = true;
            this.textBoxFlatInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFlatInfo.Size = new System.Drawing.Size(269, 274);
            this.textBoxFlatInfo.TabIndex = 23;
            // 
            // buttonClearInfo
            // 
            this.buttonClearInfo.BackColor = System.Drawing.Color.LightGreen;
            this.buttonClearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonClearInfo.Location = new System.Drawing.Point(234, 783);
            this.buttonClearInfo.Name = "buttonClearInfo";
            this.buttonClearInfo.Size = new System.Drawing.Size(163, 58);
            this.buttonClearInfo.TabIndex = 24;
            this.buttonClearInfo.Text = "ОЧИСТИТЬ";
            this.buttonClearInfo.UseVisualStyleBackColor = false;
            this.buttonClearInfo.Click += new System.EventHandler(this.buttonClearInfo_Click);
            this.buttonClearInfo.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonClearInfo.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(654, 783);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(169, 58);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "СОХРАНИТЬ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // labelCostFlat
            // 
            this.labelCostFlat.AutoSize = true;
            this.labelCostFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCostFlat.Location = new System.Drawing.Point(79, 691);
            this.labelCostFlat.Name = "labelCostFlat";
            this.labelCostFlat.Size = new System.Drawing.Size(213, 25);
            this.labelCostFlat.TabIndex = 27;
            this.labelCostFlat.Text = "Стоимость квартиры";
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCost.Location = new System.Drawing.Point(82, 719);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(100, 26);
            this.textBoxCost.TabIndex = 28;
            // 
            // buttonAutoFill
            // 
            this.buttonAutoFill.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAutoFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonAutoFill.Location = new System.Drawing.Point(413, 783);
            this.buttonAutoFill.Name = "buttonAutoFill";
            this.buttonAutoFill.Size = new System.Drawing.Size(217, 58);
            this.buttonAutoFill.TabIndex = 29;
            this.buttonAutoFill.Text = "АВТОЗАПОЛНЕНИЕ";
            this.buttonAutoFill.UseVisualStyleBackColor = false;
            this.buttonAutoFill.Click += new System.EventHandler(this.buttonAutoFill_Click);
            this.buttonAutoFill.MouseEnter += new System.EventHandler(this.buttonAutoFill_MouseEnter);
            this.buttonAutoFill.MouseLeave += new System.EventHandler(this.buttonAutoFill_MouseLeave);
            // 
            // labelBucks
            // 
            this.labelBucks.AutoSize = true;
            this.labelBucks.BackColor = System.Drawing.Color.Transparent;
            this.labelBucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBucks.Location = new System.Drawing.Point(188, 720);
            this.labelBucks.Name = "labelBucks";
            this.labelBucks.Size = new System.Drawing.Size(23, 25);
            this.labelBucks.TabIndex = 30;
            this.labelBucks.Text = "$";
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearch,
            this.toolStripMenuItemSort,
            this.toolStripMenuItemSave});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1361, 28);
            this.menuStripMain.TabIndex = 32;
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearchYear,
            this.toolStripMenuItemSearchDistrict,
            this.toolStripMenuItemSearchAmountRooms});
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(66, 24);
            this.toolStripMenuItemSearch.Text = "Поиск";
            // 
            // toolStripMenuItemSearchYear
            // 
            this.toolStripMenuItemSearchYear.Name = "toolStripMenuItemSearchYear";
            this.toolStripMenuItemSearchYear.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItemSearchYear.Text = "По году";
            this.toolStripMenuItemSearchYear.Click += new System.EventHandler(this.toolStripMenuItemSearchYear_Click);
            // 
            // toolStripMenuItemSearchDistrict
            // 
            this.toolStripMenuItemSearchDistrict.Name = "toolStripMenuItemSearchDistrict";
            this.toolStripMenuItemSearchDistrict.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItemSearchDistrict.Text = "По району";
            this.toolStripMenuItemSearchDistrict.Click += new System.EventHandler(this.toolStripMenuItemSearchDistrict_Click);
            // 
            // toolStripMenuItemSearchAmountRooms
            // 
            this.toolStripMenuItemSearchAmountRooms.Name = "toolStripMenuItemSearchAmountRooms";
            this.toolStripMenuItemSearchAmountRooms.Size = new System.Drawing.Size(215, 26);
            this.toolStripMenuItemSearchAmountRooms.Text = "По кол-ву комнат";
            this.toolStripMenuItemSearchAmountRooms.Click += new System.EventHandler(this.toolStripMenuItemSearchAmountRooms_Click);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSortYear,
            this.toolStripMenuItemSortFootage,
            this.toolStripMenuItemSortPrice});
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemSort.Text = "Сортировать по:";
            // 
            // toolStripMenuItemSortYear
            // 
            this.toolStripMenuItemSortYear.Name = "toolStripMenuItemSortYear";
            this.toolStripMenuItemSortYear.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSortYear.Text = "Году";
            this.toolStripMenuItemSortYear.Click += new System.EventHandler(this.toolStripMenuItemSortYear_Click);
            // 
            // toolStripMenuItemSortFootage
            // 
            this.toolStripMenuItemSortFootage.Name = "toolStripMenuItemSortFootage";
            this.toolStripMenuItemSortFootage.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSortFootage.Text = "Метражу";
            this.toolStripMenuItemSortFootage.Click += new System.EventHandler(this.toolStripMenuItemSortFootage_Click);
            // 
            // toolStripMenuItemSortPrice
            // 
            this.toolStripMenuItemSortPrice.Name = "toolStripMenuItemSortPrice";
            this.toolStripMenuItemSortPrice.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSortPrice.Text = "Цене";
            this.toolStripMenuItemSortPrice.Click += new System.EventHandler(this.toolStripMenuItemSortPrice_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuItemSave.Text = "О программе";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // textBoxSearched
            // 
            this.textBoxSearched.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSearched.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSearched.Location = new System.Drawing.Point(689, 456);
            this.textBoxSearched.Multiline = true;
            this.textBoxSearched.Name = "textBoxSearched";
            this.textBoxSearched.ReadOnly = true;
            this.textBoxSearched.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearched.Size = new System.Drawing.Size(311, 274);
            this.textBoxSearched.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(695, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Результат поискового запроса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1033, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Результат сортировки:";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSorted.Location = new System.Drawing.Point(1038, 95);
            this.textBoxSorted.Multiline = true;
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.ReadOnly = true;
            this.textBoxSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSorted.Size = new System.Drawing.Size(243, 635);
            this.textBoxSorted.TabIndex = 37;
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1361, 925);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearched);
            this.Controls.Add(this.labelBucks);
            this.Controls.Add(this.buttonAutoFill);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostFlat);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClearInfo);
            this.Controls.Add(this.textBoxFlatInfo);
            this.Controls.Add(this.buttonOutputFlatInfo);
            this.Controls.Add(this.numericUpDownRooms);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.numericUpDownFloor);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.trackBarFootage);
            this.Controls.Add(this.checkBoxBasement);
            this.Controls.Add(this.checkBoxBalcony);
            this.Controls.Add(this.checkBoxBathroom);
            this.Controls.Add(this.checkBoxLivingRoom);
            this.Controls.Add(this.checkBoxKitchen);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelFootage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FlatForm";
            this.Text = "Квартира";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).EndInit();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFootage;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.CheckBox checkBoxKitchen;
        private System.Windows.Forms.CheckBox checkBoxLivingRoom;
        private System.Windows.Forms.CheckBox checkBoxBathroom;
        private System.Windows.Forms.CheckBox checkBoxBalcony;
        private System.Windows.Forms.CheckBox checkBoxBasement;
        private System.Windows.Forms.TrackBar trackBarFootage;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.NumericUpDown numericUpDownFloor;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TreeView treeViewCountry;
        private System.Windows.Forms.Label labelFlatNumber;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.Button buttonOutputFlatInfo;
        private System.Windows.Forms.TextBox textBoxFlatInfo;
        private System.Windows.Forms.Button buttonClearInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCostFlat;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonAutoFill;
        private System.Windows.Forms.TextBox textBoxNumberFlat;
        private System.Windows.Forms.TextBox textBoxNumberHouse;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelBucks;
        public System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortFootage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSortPrice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchYear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchDistrict;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearchAmountRooms;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSearched;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxSorted;
    }
}

