namespace Tabel
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SpecialCheck = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSpecAch = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btSaveAll = new System.Windows.Forms.Button();
            this.dtMain = new System.Windows.Forms.DateTimePicker();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btChange = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btDefaulDaySart = new System.Windows.Forms.Button();
            this.btDefaulDayEnd = new System.Windows.Forms.Button();
            this.btDefaultCity = new System.Windows.Forms.Button();
            this.btDefaultSpecCheck = new System.Windows.Forms.Button();
            this.btDefaultAchiv = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиПочтовогоКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.почтовогоКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производственныйКалендарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеВозможностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консольToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вEXELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intranetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNoty = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbPGVR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSetStartTime = new System.Windows.Forms.Button();
            this.btSetEndTime = new System.Windows.Forms.Button();
            this.userControl11 = new Tabel.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDB.ColumnHeadersHeight = 29;
            this.dataGridViewDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewDB.Location = new System.Drawing.Point(-1, 36);
            this.dataGridViewDB.MultiSelect = false;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.RowHeadersVisible = false;
            this.dataGridViewDB.RowHeadersWidth = 51;
            this.dataGridViewDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDB.RowTemplate.Height = 24;
            this.dataGridViewDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDB.Size = new System.Drawing.Size(952, 916);
            this.dataGridViewDB.TabIndex = 100;
            this.dataGridViewDB.TabStop = false;
            this.dataGridViewDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDB_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(964, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Добавление или изменение данных табеля";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1102, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Город";
            // 
            // SpecialCheck
            // 
            this.SpecialCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecialCheck.AutoSize = true;
            this.SpecialCheck.Location = new System.Drawing.Point(1075, 335);
            this.SpecialCheck.Name = "SpecialCheck";
            this.SpecialCheck.Size = new System.Drawing.Size(99, 17);
            this.SpecialCheck.TabIndex = 22;
            this.SpecialCheck.Text = "Спец отметка";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1002, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(964, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Начало работы";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1125, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Конец работы";
            // 
            // tbSpecAch
            // 
            this.tbSpecAch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpecAch.Location = new System.Drawing.Point(995, 468);
            this.tbSpecAch.Name = "tbSpecAch";
            this.tbSpecAch.Size = new System.Drawing.Size(272, 139);
            this.tbSpecAch.TabIndex = 7;
            this.tbSpecAch.Text = "";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1042, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Особые достижения за день";
            // 
            // btSaveAll
            // 
            this.btSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveAll.Location = new System.Drawing.Point(1011, 613);
            this.btSaveAll.Name = "btSaveAll";
            this.btSaveAll.Size = new System.Drawing.Size(193, 63);
            this.btSaveAll.TabIndex = 8;
            this.btSaveAll.Text = "Добавить";
            this.toolTip1.SetToolTip(this.btSaveAll, "Добавляет введенные значения в базу данных табеля");
            this.btSaveAll.UseVisualStyleBackColor = true;
            this.btSaveAll.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dtMain
            // 
            this.dtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMain.Location = new System.Drawing.Point(973, 87);
            this.dtMain.Name = "dtMain";
            this.dtMain.Size = new System.Drawing.Size(266, 22);
            this.dtMain.TabIndex = 1;
            this.dtMain.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbCity
            // 
            this.cbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(995, 308);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(251, 24);
            this.cbCity.TabIndex = 4;
            // 
            // cbSpec
            // 
            this.cbSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Location = new System.Drawing.Point(995, 355);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(285, 24);
            this.cbSpec.TabIndex = 5;
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtStart.Location = new System.Drawing.Point(997, 191);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(110, 27);
            this.dtStart.TabIndex = 2;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.Location = new System.Drawing.Point(1166, 191);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(101, 27);
            this.dtEnd.TabIndex = 3;
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Location = new System.Drawing.Point(1011, 682);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(193, 64);
            this.btChange.TabIndex = 38;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Location = new System.Drawing.Point(1011, 752);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(193, 25);
            this.btDelete.TabIndex = 39;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tmExit
            // 
            this.tmExit.Name = "tmExit";
            this.tmExit.Size = new System.Drawing.Size(122, 24);
            this.tmExit.Text = "Выход";
            this.tmExit.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1255, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 47;
            this.toolTip1.SetToolTip(this.button1, "Редактирование списка городов");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1255, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 51;
            this.toolTip1.SetToolTip(this.button2, "Редактирование списка городов");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDefaulDaySart
            // 
            this.btDefaulDaySart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDefaulDaySart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDefaulDaySart.BackgroundImage")));
            this.btDefaulDaySart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDefaulDaySart.Location = new System.Drawing.Point(960, 187);
            this.btDefaulDaySart.Name = "btDefaulDaySart";
            this.btDefaulDaySart.Size = new System.Drawing.Size(25, 31);
            this.btDefaulDaySart.TabIndex = 104;
            this.toolTip1.SetToolTip(this.btDefaulDaySart, "Сделать по умолчанию.");
            this.btDefaulDaySart.UseVisualStyleBackColor = true;
            this.btDefaulDaySart.Click += new System.EventHandler(this.btDefaulDaySart_Click);
            // 
            // btDefaulDayEnd
            // 
            this.btDefaulDayEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDefaulDayEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDefaulDayEnd.BackgroundImage")));
            this.btDefaulDayEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDefaulDayEnd.Location = new System.Drawing.Point(1135, 187);
            this.btDefaulDayEnd.Name = "btDefaulDayEnd";
            this.btDefaulDayEnd.Size = new System.Drawing.Size(25, 31);
            this.btDefaulDayEnd.TabIndex = 105;
            this.toolTip1.SetToolTip(this.btDefaulDayEnd, "Сделать по умолчанию.");
            this.btDefaulDayEnd.UseVisualStyleBackColor = true;
            this.btDefaulDayEnd.Click += new System.EventHandler(this.btDefaulDayEnd_Click);
            // 
            // btDefaultCity
            // 
            this.btDefaultCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDefaultCity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDefaultCity.BackgroundImage")));
            this.btDefaultCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDefaultCity.Location = new System.Drawing.Point(960, 308);
            this.btDefaultCity.Name = "btDefaultCity";
            this.btDefaultCity.Size = new System.Drawing.Size(25, 31);
            this.btDefaultCity.TabIndex = 106;
            this.toolTip1.SetToolTip(this.btDefaultCity, "Сделать по умолчанию.");
            this.btDefaultCity.UseVisualStyleBackColor = true;
            this.btDefaultCity.Click += new System.EventHandler(this.btDefaultCity_Click);
            // 
            // btDefaultSpecCheck
            // 
            this.btDefaultSpecCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDefaultSpecCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDefaultSpecCheck.BackgroundImage")));
            this.btDefaultSpecCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDefaultSpecCheck.Location = new System.Drawing.Point(960, 351);
            this.btDefaultSpecCheck.Name = "btDefaultSpecCheck";
            this.btDefaultSpecCheck.Size = new System.Drawing.Size(25, 31);
            this.btDefaultSpecCheck.TabIndex = 107;
            this.toolTip1.SetToolTip(this.btDefaultSpecCheck, "Сделать по умолчанию.");
            this.btDefaultSpecCheck.UseVisualStyleBackColor = true;
            this.btDefaultSpecCheck.Click += new System.EventHandler(this.btDefaultSpecCheck_Click);
            // 
            // btDefaultAchiv
            // 
            this.btDefaultAchiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDefaultAchiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDefaultAchiv.BackgroundImage")));
            this.btDefaultAchiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDefaultAchiv.Location = new System.Drawing.Point(960, 525);
            this.btDefaultAchiv.Name = "btDefaultAchiv";
            this.btDefaultAchiv.Size = new System.Drawing.Size(25, 31);
            this.btDefaultAchiv.TabIndex = 108;
            this.toolTip1.SetToolTip(this.btDefaultAchiv, "Сделать по умолчанию.");
            this.btDefaultAchiv.UseVisualStyleBackColor = true;
            this.btDefaultAchiv.Click += new System.EventHandler(this.btDefaultAchiv_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправитьToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.дополнительныеВозможностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1282, 28);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отправитьToolStripMenuItem
            // 
            this.отправитьToolStripMenuItem.Name = "отправитьToolStripMenuItem";
            this.отправитьToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.отправитьToolStripMenuItem.Text = "Отправить";
            this.отправитьToolStripMenuItem.ToolTipText = "Отправка готового табеля.\r\nПримечание: необходимо предварительно настроить почтов" +
    "ый клиент. Настрйки - Почтовый клиент";
            this.отправитьToolStripMenuItem.Click += new System.EventHandler(this.отправитьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПочтовогоКлиентаToolStripMenuItem,
            this.почтовогоКлиентаToolStripMenuItem,
            this.производственныйКалендарьToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиПочтовогоКлиентаToolStripMenuItem
            // 
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Name = "настройкиПочтовогоКлиентаToolStripMenuItem";
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Text = "Значения по умолчаню табельных данных";
            this.настройкиПочтовогоКлиентаToolStripMenuItem.ToolTipText = "Значения по умолчаню будут выставляться полям перед добавлении новой записи в таб" +
    "ель.";
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.настройкиПочтовогоКлиентаToolStripMenuItem_Click);
            // 
            // почтовогоКлиентаToolStripMenuItem
            // 
            this.почтовогоКлиентаToolStripMenuItem.Name = "почтовогоКлиентаToolStripMenuItem";
            this.почтовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.почтовогоКлиентаToolStripMenuItem.Text = "Почтовый клиент";
            this.почтовогоКлиентаToolStripMenuItem.ToolTipText = "Настройки почтового клиента, необходимы для отправки готовго табеля.";
            this.почтовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.почтовогоКлиентаToolStripMenuItem_Click);
            // 
            // производственныйКалендарьToolStripMenuItem
            // 
            this.производственныйКалендарьToolStripMenuItem.Name = "производственныйКалендарьToolStripMenuItem";
            this.производственныйКалендарьToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.производственныйКалендарьToolStripMenuItem.Text = "Производственный календарь";
            this.производственныйКалендарьToolStripMenuItem.ToolTipText = "Производственный календарь необходим для отображения в табеле выходных и празднич" +
    "ных дней.";
            this.производственныйКалендарьToolStripMenuItem.Click += new System.EventHandler(this.производственныйКалендарьToolStripMenuItem_Click);
            // 
            // дополнительныеВозможностиToolStripMenuItem
            // 
            this.дополнительныеВозможностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.консольToolStripMenuItem1,
            this.выгрузитьToolStripMenuItem,
            this.intranetToolStripMenuItem,
            this.справочникКомпанииToolStripMenuItem});
            this.дополнительныеВозможностиToolStripMenuItem.Name = "дополнительныеВозможностиToolStripMenuItem";
            this.дополнительныеВозможностиToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.дополнительныеВозможностиToolStripMenuItem.Text = "Дополнительно";
            // 
            // консольToolStripMenuItem1
            // 
            this.консольToolStripMenuItem1.Name = "консольToolStripMenuItem1";
            this.консольToolStripMenuItem1.Size = new System.Drawing.Size(252, 26);
            this.консольToolStripMenuItem1.Text = "Консоль ";
            this.консольToolStripMenuItem1.ToolTipText = "Позволяет сделать запрос к базе данных SQLlite, в которой храняться данные табеля" +
    ".";
            this.консольToolStripMenuItem1.Click += new System.EventHandler(this.консольToolStripMenuItem1_Click);
            // 
            // выгрузитьToolStripMenuItem
            // 
            this.выгрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem,
            this.вEXELEToolStripMenuItem});
            this.выгрузитьToolStripMenuItem.Name = "выгрузитьToolStripMenuItem";
            this.выгрузитьToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.выгрузитьToolStripMenuItem.Text = "Выгрузить";
            // 
            // дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem
            // 
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Name = "дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem";
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Size = new System.Drawing.Size(412, 26);
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Text = "Для отправки в стороннем почтовом клиенте";
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.ToolTipText = "Позволяет выгрузить табель в отдельный файл формата json, и отправить табель без " +
    "использования встроенного почтового клиента. ";
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Click += new System.EventHandler(this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem_Click);
            // 
            // вEXELEToolStripMenuItem
            // 
            this.вEXELEToolStripMenuItem.Name = "вEXELEToolStripMenuItem";
            this.вEXELEToolStripMenuItem.Size = new System.Drawing.Size(412, 26);
            this.вEXELEToolStripMenuItem.Text = "В Excel";
            this.вEXELEToolStripMenuItem.ToolTipText = "Выгрузка табеля в exel документ.";
            this.вEXELEToolStripMenuItem.Click += new System.EventHandler(this.вEXELEToolStripMenuItem_Click);
            // 
            // intranetToolStripMenuItem
            // 
            this.intranetToolStripMenuItem.Name = "intranetToolStripMenuItem";
            this.intranetToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.intranetToolStripMenuItem.Text = "Внутренний сайт";
            this.intranetToolStripMenuItem.Click += new System.EventHandler(this.intranetToolStripMenuItem_Click);
            // 
            // справочникКомпанииToolStripMenuItem
            // 
            this.справочникКомпанииToolStripMenuItem.Name = "справочникКомпанииToolStripMenuItem";
            this.справочникКомпанииToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.справочникКомпанииToolStripMenuItem.Text = "Справочник компании";
            this.справочникКомпанииToolStripMenuItem.Click += new System.EventHandler(this.справочникКомпанииToolStripMenuItem_Click);
            // 
            // labelNoty
            // 
            this.labelNoty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoty.AutoSize = true;
            this.labelNoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoty.ForeColor = System.Drawing.Color.Red;
            this.labelNoty.Location = new System.Drawing.Point(957, 851);
            this.labelNoty.Name = "labelNoty";
            this.labelNoty.Size = new System.Drawing.Size(0, 18);
            this.labelNoty.TabIndex = 48;
            this.labelNoty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPGVR
            // 
            this.cbPGVR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPGVR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPGVR.FormattingEnabled = true;
            this.cbPGVR.Location = new System.Drawing.Point(995, 407);
            this.cbPGVR.Name = "cbPGVR";
            this.cbPGVR.Size = new System.Drawing.Size(254, 24);
            this.cbPGVR.TabIndex = 6;
            this.cbPGVR.SelectedValueChanged += new System.EventHandler(this.cbPGVR_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1102, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "ПГВР:";
            // 
            // btSetStartTime
            // 
            this.btSetStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetStartTime.Location = new System.Drawing.Point(995, 224);
            this.btSetStartTime.Name = "btSetStartTime";
            this.btSetStartTime.Size = new System.Drawing.Size(112, 50);
            this.btSetStartTime.TabIndex = 101;
            this.btSetStartTime.Text = "Отметить начало";
            this.btSetStartTime.UseVisualStyleBackColor = true;
            this.btSetStartTime.Click += new System.EventHandler(this.btSetStartTime_Click);
            // 
            // btSetEndTime
            // 
            this.btSetEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetEndTime.Location = new System.Drawing.Point(1166, 231);
            this.btSetEndTime.Name = "btSetEndTime";
            this.btSetEndTime.Size = new System.Drawing.Size(101, 44);
            this.btSetEndTime.TabIndex = 102;
            this.btSetEndTime.Text = "Отметить конец";
            this.btSetEndTime.UseVisualStyleBackColor = true;
            this.btSetEndTime.Click += new System.EventHandler(this.btSetEndTime_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(1293, 523);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(301, 264);
            this.userControl11.TabIndex = 49;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1282, 953);
            this.Controls.Add(this.btDefaultAchiv);
            this.Controls.Add(this.btDefaultSpecCheck);
            this.Controls.Add(this.btDefaultCity);
            this.Controls.Add(this.btDefaulDayEnd);
            this.Controls.Add(this.btDefaulDaySart);
            this.Controls.Add(this.btSetEndTime);
            this.Controls.Add(this.btSetStartTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPGVR);
            this.Controls.Add(this.labelNoty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.dtMain);
            this.Controls.Add(this.btSaveAll);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbSpecAch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpecialCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "Form3";
            this.Text = "Ежедневный учет табельного времени";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SpecialCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox tbSpecAch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btSaveAll;
        private System.Windows.Forms.DateTimePicker dtMain;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиПочтовогоКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem почтовогоКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производственныйКалендарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеВозможностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консольToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вEXELEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intranetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникКомпанииToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNoty;
        private UserControl1 userControl11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbPGVR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSetStartTime;
        private System.Windows.Forms.Button btSetEndTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmExit;
        private System.Windows.Forms.Button btDefaulDaySart;
        private System.Windows.Forms.Button btDefaulDayEnd;
        private System.Windows.Forms.Button btDefaultCity;
        private System.Windows.Forms.Button btDefaultSpecCheck;
        private System.Windows.Forms.Button btDefaultAchiv;
    }
}