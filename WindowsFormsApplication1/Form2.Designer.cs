namespace Tabel
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.smtpserver = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(95, 12);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(554, 22);
            this.from.TabIndex = 0;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(95, 51);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(554, 22);
            this.to.TabIndex = 1;
            // 
            // smtpserver
            // 
            this.smtpserver.Location = new System.Drawing.Point(95, 91);
            this.smtpserver.Name = "smtpserver";
            this.smtpserver.Size = new System.Drawing.Size(554, 22);
            this.smtpserver.TabIndex = 2;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(95, 132);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(554, 22);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(95, 179);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(554, 22);
            this.password.TabIndex = 4;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(95, 216);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(554, 22);
            this.subject.TabIndex = 5;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(95, 259);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(554, 22);
            this.message.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "SmtpServer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Message:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Загрузить настройки из Active Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(655, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(670, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.smtpserver);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Настройки почтового клиента";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox smtpserver;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}