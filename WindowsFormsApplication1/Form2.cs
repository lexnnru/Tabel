using System;
using System.Drawing;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;

using TabelLibrary.Crypto;
using TabelLibrary;
using TabelLibrary.Data;

namespace Tabel
{ 

    public partial class Form2 : Form
    {
        Settings s = new Settings(new TabelLibrary.Crypto.Xor() );
        public Form2()
        {
        
            InitializeComponent();
            string user = SystemInformation.UserName;
            password.UseSystemPasswordChar = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
            
           Settings s = new Settings(new Xor());
            s.Open();
            from.Text = s.saveParam.from;
            to.Text = s.saveParam.to;
            smtpserver.Text = s.saveParam.smtp;
            username.Text = s.saveParam.username;
            subject.Text = s.saveParam.subject;
            message.Text = s.saveParam.message;
            password.Text = s.saveParam.password;
            var foto = (Application.StartupPath + "\\foto.jpg");
            if (File.Exists(Application.StartupPath + "\\foto.jpg"))
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\foto.jpg");
            }
       }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show("Сохранить?", "Внимание!", MessageBoxButtons.OKCancel);
            if (ok == DialogResult.OK)
            {
                try
                {     
                    Settings s = new Settings(new Xor());
                SaveParam param = new SaveParam();
                param.from = from.Text;
                param.to = to.Text;
                param.smtp = smtpserver.Text;
                param.username = username.Text;
                param.subject = subject.Text;
                param.message = message.Text;
                param.password = password.Text;
                s.Save(param);
                   this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else this.Close();
        }

    private void button1_Click(object sender, EventArgs e)
    {
            if (File.Exists(Application.StartupPath + "\\foto.jpg")==true)
                {
                pictureBox1.Image.Dispose();
                File.Delete(Application.StartupPath + "\\foto.jpg");
            }

            string error;
        Ad ad = new Ad();
        TabelLibrary.Data.DataAd data = ad.Getsettings(out error);
        if (error == "")
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\foto.jpg");

            from.Text = data.Email;
            to.Text = data.EmailBoss;
            smtpserver.Text = "smtp.sintek-nn.ru";
            username.Text = data.Email;
            password.Text = "";
            subject.Text = "Табель от " + data.FullName;
            message.Text = "Табель от " + data.FullName;
        }
        else
        {
            MessageBox.Show(error);
        }
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.UseSystemPasswordChar = false;

            }
            else password.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
