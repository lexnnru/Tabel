using System;
using System.ComponentModel;
using System.Windows.Forms;
using TabelLibrary;
using TabelLibrary.Data;


namespace Tabel
{
    public partial class SendForm : Form
    {
        Settings s = new Settings(new TabelLibrary.Crypto.Xor());

        Form2 Mail_settings = new Form2();
        Reg triger = new Reg();
        public SendForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = Application.StartupPath + "\\monthtabel" + Tabel_client.Properties.Settings.Default.family + Tabel_client.Properties.Settings.Default.TabelNumber + ".json";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // 
            // получаем выбранный файл
            else
            {
                string filename = openFileDialog1.FileName;
                textBox1.Text = filename;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Ты уверен?",
                            "Подтвердите!", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    triger.write(2);
                    this.Close();
                }
                else if (dr == DialogResult.No)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            triger.write(3);
           
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mail_settings.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           s.Open();

            SendMail mail = new SendMail();
            if (mail.Send(new MailSet(s.saveParam.ToString(), textBox1.Text)))
            {
                triger.write(2);
                MessageBox.Show("Молодец! Жди зарплату!");
                this.Close();
            }
            else
            {
                MessageBox.Show(mail.Error);
            }
        }
    }
}