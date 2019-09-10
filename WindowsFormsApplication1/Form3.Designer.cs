namespace WindowsFormsApplication1
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewDB.Location = new System.Drawing.Point(-1, 36);
            this.dataGridViewDB.MultiSelect = false;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDB.RowTemplate.Height = 24;
            this.dataGridViewDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDB.Size = new System.Drawing.Size(952, 916);
            this.dataGridViewDB.TabIndex = 3;
            this.dataGridViewDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDB_CellContentClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(964, 95);
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
            this.label9.Location = new System.Drawing.Point(974, 190);
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
            this.SpecialCheck.Location = new System.Drawing.Point(970, 248);
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
            this.label5.Location = new System.Drawing.Point(964, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(964, 122);
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
            this.label14.Location = new System.Drawing.Point(1125, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Конец работы";
            // 
            // tbSpecAch
            // 
            this.tbSpecAch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpecAch.Location = new System.Drawing.Point(961, 326);
            this.tbSpecAch.Name = "tbSpecAch";
            this.tbSpecAch.Size = new System.Drawing.Size(285, 180);
            this.tbSpecAch.TabIndex = 27;
            this.tbSpecAch.Text = "";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(964, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Особые достижения за день";
            // 
            // btSaveAll
            // 
            this.btSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveAll.Location = new System.Drawing.Point(1011, 524);
            this.btSaveAll.Name = "btSaveAll";
            this.btSaveAll.Size = new System.Drawing.Size(193, 63);
            this.btSaveAll.TabIndex = 29;
            this.btSaveAll.Text = "Добавить";
            this.toolTip1.SetToolTip(this.btSaveAll, "Добавляет введенные значения в базу данных табеля");
            this.btSaveAll.UseVisualStyleBackColor = true;
            this.btSaveAll.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dtMain
            // 
            this.dtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMain.Location = new System.Drawing.Point(973, 49);
            this.dtMain.Name = "dtMain";
            this.dtMain.Size = new System.Drawing.Size(266, 22);
            this.dtMain.TabIndex = 31;
            this.dtMain.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbCity
            // 
            this.cbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(967, 210);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(273, 24);
            this.cbCity.TabIndex = 32;
            // 
            // cbSpec
            // 
            this.cbSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Location = new System.Drawing.Point(961, 268);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(279, 24);
            this.cbSpec.TabIndex = 33;
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtStart.Location = new System.Drawing.Point(967, 142);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(111, 27);
            this.dtStart.TabIndex = 36;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.Location = new System.Drawing.Point(1128, 142);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(111, 27);
            this.dtEnd.TabIndex = 37;
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Location = new System.Drawing.Point(1011, 593);
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
            this.btDelete.Location = new System.Drawing.Point(1011, 663);
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
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Заполнение табеля.";
            this.notifyIcon1.BalloonTipTitle = "Ежедневное ведение учета табельного времени.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1249, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 47;
            this.toolTip1.SetToolTip(this.button1, "Редактирование списка городов");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.отправитьToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
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
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиПочтовогоКлиентаToolStripMenuItem
            // 
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Name = "настройкиПочтовогоКлиентаToolStripMenuItem";
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Text = "Значения по умолчаню табельных данных";
            this.настройкиПочтовогоКлиентаToolStripMenuItem.ToolTipText = "Значения по умолчаню будут выставляться полям перед добавлении новой записи в таб" +
    "ель.";
            this.настройкиПочтовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.настройкиПочтовогоКлиентаToolStripMenuItem_Click);
            // 
            // почтовогоКлиентаToolStripMenuItem
            // 
            this.почтовогоКлиентаToolStripMenuItem.Name = "почтовогоКлиентаToolStripMenuItem";
            this.почтовогоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.почтовогоКлиентаToolStripMenuItem.Text = "Почтовый клиент";
            this.почтовогоКлиентаToolStripMenuItem.ToolTipText = "Настройки почтового клиента, необходимы для отправки готовго табеля.";
            this.почтовогоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.почтовогоКлиентаToolStripMenuItem_Click);
            // 
            // производственныйКалендарьToolStripMenuItem
            // 
            this.производственныйКалендарьToolStripMenuItem.Name = "производственныйКалендарьToolStripMenuItem";
            this.производственныйКалендарьToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
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
            this.дополнительныеВозможностиToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.дополнительныеВозможностиToolStripMenuItem.Text = "Дополнительно";
            // 
            // консольToolStripMenuItem1
            // 
            this.консольToolStripMenuItem1.Name = "консольToolStripMenuItem1";
            this.консольToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
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
            this.выгрузитьToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.выгрузитьToolStripMenuItem.Text = "Выгрузить";
            // 
            // дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem
            // 
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Name = "дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem";
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Size = new System.Drawing.Size(404, 26);
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Text = "Для отправки в стороннем почтовом клиенте";
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.ToolTipText = "Позволяет выгрузить табель в отдельный файл формата json, и отправить табель без " +
    "использования встроенного почтового клиента. ";
            this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem.Click += new System.EventHandler(this.дляОтправкиВСтороннемПочтовомКлиентеToolStripMenuItem_Click);
            // 
            // вEXELEToolStripMenuItem
            // 
            this.вEXELEToolStripMenuItem.Name = "вEXELEToolStripMenuItem";
            this.вEXELEToolStripMenuItem.Size = new System.Drawing.Size(404, 26);
            this.вEXELEToolStripMenuItem.Text = "В Excel";
            this.вEXELEToolStripMenuItem.ToolTipText = "Выгрузка табеля в exel документ.";
            this.вEXELEToolStripMenuItem.Click += new System.EventHandler(this.вEXELEToolStripMenuItem_Click);
            // 
            // intranetToolStripMenuItem
            // 
            this.intranetToolStripMenuItem.Name = "intranetToolStripMenuItem";
            this.intranetToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.intranetToolStripMenuItem.Text = "Внутренний сайт";
            this.intranetToolStripMenuItem.Click += new System.EventHandler(this.intranetToolStripMenuItem_Click);
            // 
            // справочникКомпанииToolStripMenuItem
            // 
            this.справочникКомпанииToolStripMenuItem.Name = "справочникКомпанииToolStripMenuItem";
            this.справочникКомпанииToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
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
    }
}