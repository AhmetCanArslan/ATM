using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form2 : Form
    {
        private string path = "data.txt";
        public Form2()
        {
            InitializeComponent();
            textBox1.MaxLength = 11;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OturumAc(textBox1.Text, textBox2.Text);
        }
        private void OturumAc(string tcNo, string sifre)
        {
            bool kullaniciBulundu = false;

            // Dosya varsa, TC no'ya göre bilgileri kontrol et
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string? satir; // satir değişkenini nullable olarak tanımla
                    while ((satir = reader.ReadLine()) != null) // Null kabul edilebilir
                    {
                        string[] bilgiler = satir.Split(',');

                        if (bilgiler.Length >= 4 && bilgiler[3] == tcNo)
                        {
                            kullaniciBulundu = true;

                            if (bilgiler[2] == sifre)
                            {
                                Form5 form5 = new Form5(tcNo);
                                this.Hide();
                                form5.ShowDialog();
                                break; // Kullanıcı bulundu ve şifre doğru, döngüden çık
                            }
                            else
                            {
                                MessageBox.Show("Şifre yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break; // Kullanıcı bulundu ancak şifre yanlış, döngüden çık
                            }
                        }
                    }

                    if (!kullaniciBulundu)
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11 && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }
        private void textBox1_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Eğer sayı değilse, olayı işleme alma ve karakteri yok say
                e.Handled = true;
            }
        }
    }
}
