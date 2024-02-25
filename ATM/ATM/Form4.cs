using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form4 : Form
    {

        private const string path = "data.txt";
        private int dateT = 0;
        public Form4()
        {
            InitializeComponent();
            TextBoxAd.MaxLength = 15;
            TextBoxSoyad.MaxLength = 15;
            TextBoxTelNo.MaxLength = 11;
            TextBoxTcNo.MaxLength = 11;



            if (label10.Text == "" && dateT == 1 && labelSifreTekrar.Text == "" && labelSifre.Text == "" && labelTcNo.Text == "" && labelTelNo.Text == "" && label7.Text == "" && !string.IsNullOrEmpty(TextBoxAd.Text) && !string.IsNullOrEmpty(TextBoxSoyad.Text) && !string.IsNullOrEmpty(TextBoxTelNo.Text) && !string.IsNullOrEmpty(TextBoxTcNo.Text) && !string.IsNullOrEmpty(textBoxSifre.Text) && !string.IsNullOrEmpty(textBoxSifreTekar.Text))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
        private void TextBoxAd_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }      
        private void TextBoxTelNo_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Eğer sayı değilse, olayı işleme alma ve karakteri yok say
                e.Handled = true;
            }
        }       
        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            // E-posta adresinin @ sembolü içerip içermediğini kontrol et
            if (!TextBoxEmail.Text.Contains("@"))
            {
                label7.Text = "E-postanız @ içermelidir";
                e.Cancel = true; // Doğrulama işlemi başarısız oldu, işlemi iptal et
                return;
            }
            else
                label7.Text = "";

            // E-posta adresinin .com uzantısını içerip içermediğini kontrol et
            if (!TextBoxEmail.Text.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
            {
                label7.Text = "E-postanız .com ile bitmelidir";
                e.Cancel = true; // Doğrulama işlemi başarısız oldu, işlemi iptal et
            }
            else
                label7.Text = "";
        }
        private void TextBoxTcNo_Validating(object sender, CancelEventArgs e)
        {
            if (TextBoxTcNo.Text.Length != 11)
            {
                labelTcNo.Text = "Lütfen 11 hane giriniz";
            }
            else
                labelTcNo.Text = "";
        }
        private void TextBoxTelNo_Validating(object sender, CancelEventArgs e)
        {
            if (TextBoxTelNo.Text.Length != 11)
            {
                labelTelNo.Text = "Lütfen 11 hane giriniz";
            }
            else
                labelTelNo.Text = "";
        }
        private void textBoxSifre_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSifre.Text.Length < 8)
            {
                labelSifre.Text = "Lütfen Min 8 karakter giriniz";
            }
            else
                labelSifre.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = TextBoxAd.Text;
                string soyad = TextBoxSoyad.Text;
                string telNo = TextBoxTelNo.Text;
                string tcNo = TextBoxTcNo.Text;
                string eMail = TextBoxEmail.Text;
                string sifre = textBoxSifre.Text;
                DateTime date = dateTimePicker1.Value;

                if (!CheckIfExists(tcNo))
                {
                    Kaydet(ad, soyad, sifre, telNo, eMail, tcNo, date);

                    TextBoxAd.Clear();
                    TextBoxSoyad.Clear();
                    TextBoxTelNo.Clear();
                    TextBoxTcNo.Clear();
                    TextBoxEmail.Clear();
                    textBoxSifre.Clear();
                    textBoxSifreTekar.Clear();
                    DialogResult result = MessageBox.Show("Hesabınız Oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK || result == DialogResult.None)
                    {
                        this.Hide(); // Form4'ü gizleme
                        Form1 form1 = new Form1();
                        form1.ShowDialog(); // Form1'i gösterme
                        this.Close(); // Form4'ü kapatma
                    }

                }
                else
                {
                    MessageBox.Show("Zaten Böyle Bir Kullanıcı Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckIfExists(string tcNo)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string? satir;
                        while ((satir = reader.ReadLine()) != null)
                        {
                            string[] bilgiler = satir.Split(',');

                            if (bilgiler.Length >= 4 && bilgiler[3] == tcNo)
                            {
                                return true; // Kullanıcı zaten varsa true döndür
                            }
                        }
                        reader.Dispose();
                    }
                }
                return false; // Kullanıcı yoksa false döndür
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Hata durumunda da false döndür
            }
        }
        private void Kaydet(string isim, string soyisim, string sifre, string telefon, string eposta, string tcNo, DateTime dogumTarihi)
        {

            try
            {               
                // Dosya varsa, yeni kaydı ekler
                if (File.Exists(path))
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{isim},{soyisim},{sifre},{telefon},{eposta},{tcNo},{dogumTarihi:yyyy-MM-dd},0,0");// 1. sıfır bakiye 2. sıfır kart no
                        writer.Close();
                    }
                }
                else
                {
                    // Dosya yoksa yeni dosya oluşturur ve içine kaydı yazar
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine($"{isim},{soyisim},{sifre},{telefon},{eposta},{tcNo},{dogumTarihi:yyyy-MM-dd},0,0");
                        writer.Dispose();
                    }
                }                                 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;
            DateTime bugun = DateTime.Now;

            // Yaş hesaplamak için seçilen tarih ile bugünkü tarih arasındaki farkı al
            TimeSpan fark = bugun - secilenTarih;

            // Farkı yıla çevir ve yaş kontrolü yap
            int yas = (int)(fark.TotalDays / 365.25);

            if (yas < 18)
            {
                label10.Text = "18 ve üstü olmalısınız";
            }
            else
            {
                label10.Text = "";
                dateT = 1;
            }

        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Her bir textbox'ta gerekli kontrolleri yaparak butonun aktif olup olmadığını kontrol et
            bool conditionsMet = label10.Text == "" && dateT == 1 && labelSifreTekrar.Text == "" && labelSifre.Text == "" && labelTcNo.Text == "" && labelTelNo.Text == "" && label7.Text == "" && !string.IsNullOrEmpty(TextBoxAd.Text) && !string.IsNullOrEmpty(TextBoxSoyad.Text) && !string.IsNullOrEmpty(TextBoxTelNo.Text) && !string.IsNullOrEmpty(TextBoxTcNo.Text) && !string.IsNullOrEmpty(textBoxSifre.Text) && !string.IsNullOrEmpty(textBoxSifreTekar.Text);

            // Butonun aktiflik durumunu güncelle
            button2.Enabled = conditionsMet;
        }
        private void TextBoxAd_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void TextBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void TextBoxTelNo_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void TextBoxTcNo_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            TextBox_TextChanged(sender, e);
        }

        private void textBoxSifreTekar_TextChanged(object sender, EventArgs e)
        {

            if (textBoxSifreTekar.Text == textBoxSifre.Text)
            {
                labelSifreTekrar.Text = "";
            }
            else
            {
                labelSifreTekrar.Text = "Şifreler Uyuşmuyor";
            }
            TextBox_TextChanged(sender, e);


        }

    }
}
