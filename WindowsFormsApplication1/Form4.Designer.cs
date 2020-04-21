namespace Tabel
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tbSpecAch = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbFamily = new System.Windows.Forms.TextBox();
            this.tbTabelNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbParentName = new System.Windows.Forms.TextBox();
            this.btSity = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTimeZone = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtStart.Location = new System.Drawing.Point(275, 53);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(312, 27);
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtEnd.Location = new System.Drawing.Point(275, 86);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(312, 27);
            this.dtEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Время начала работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Кремя окончания работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Специальная отметка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Город";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 51);
            this.label5.TabIndex = 43;
            this.label5.Text = "Причина раннего начала работы/\r\nпозднего окончания работы/\r\nособые достижения за " +
    "день";
            // 
            // cbSpec
            // 
            this.cbSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Location = new System.Drawing.Point(275, 170);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(312, 24);
            this.cbSpec.TabIndex = 3;
            // 
            // cbCity
            // 
            this.cbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(275, 200);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(312, 24);
            this.cbCity.TabIndex = 4;
            // 
            // tbSpecAch
            // 
            this.tbSpecAch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpecAch.Location = new System.Drawing.Point(275, 240);
            this.tbSpecAch.Name = "tbSpecAch";
            this.tbSpecAch.Size = new System.Drawing.Size(312, 163);
            this.tbSpecAch.TabIndex = 5;
            this.tbSpecAch.Text = "";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(377, 655);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(123, 32);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbFamily
            // 
            this.tbFamily.Location = new System.Drawing.Point(271, 433);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(312, 22);
            this.tbFamily.TabIndex = 6;
            // 
            // tbTabelNumber
            // 
            this.tbTabelNumber.Location = new System.Drawing.Point(271, 587);
            this.tbTabelNumber.Name = "tbTabelNumber";
            this.tbTabelNumber.Size = new System.Drawing.Size(312, 22);
            this.tbTabelNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Фамилия*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Табельный номер*";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Значения по умолчанию для заполняемого табеля";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "* поля обязательные для заполнения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Имя*";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(271, 461);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(312, 22);
            this.tbName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Отчество*";
            // 
            // tbParentName
            // 
            this.tbParentName.Location = new System.Drawing.Point(271, 489);
            this.tbParentName.Name = "tbParentName";
            this.tbParentName.Size = new System.Drawing.Size(312, 22);
            this.tbParentName.TabIndex = 8;
            // 
            // btSity
            // 
            this.btSity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSity.FlatAppearance.BorderSize = 0;
            this.btSity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSity.Image = ((System.Drawing.Image)(resources.GetObject("btSity.Image")));
            this.btSity.Location = new System.Drawing.Point(599, 200);
            this.btSity.Name = "btSity";
            this.btSity.Size = new System.Drawing.Size(25, 25);
            this.btSity.TabIndex = 66;
            this.btSity.UseVisualStyleBackColor = true;
            this.btSity.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 67;
            this.label12.Text = "Часовой пояс";
            // 
            // cbTimeZone
            // 
            this.cbTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeZone.FormattingEnabled = true;
            this.cbTimeZone.Location = new System.Drawing.Point(275, 129);
            this.cbTimeZone.Name = "cbTimeZone";
            this.cbTimeZone.Size = new System.Drawing.Size(312, 24);
            this.cbTimeZone.TabIndex = 68;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 731);
            this.Controls.Add(this.cbTimeZone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btSity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbParentName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTabelNumber);
            this.Controls.Add(this.tbFamily);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSpecAch);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Значения по умолчанию";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Настройки_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.RichTextBox tbSpecAch;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbFamily;
        private System.Windows.Forms.TextBox tbTabelNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbParentName;
        private System.Windows.Forms.Button btSity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTimeZone;
    }
}