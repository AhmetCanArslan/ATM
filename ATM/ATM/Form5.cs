using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ATM
{
    public partial class Form5 : Form
    {
        private string tcNo1;
        private string path = "data.txt";
        private string bilgiler2;

        public Form5(string tcNo)
        {
            InitializeComponent();
            tcNo1 = tcNo;
            FillBlank(tcNo1);
        }
        private void button6_Clicked(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label7.Visible = false;
            button5.Visible = false;

            textBox3.Visible = false;
            label8.Visible = false;
            button7.Visible = false;

            textBox1.Visible = true;
            label6.Visible = true;
            button4.Visible = true;
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label6.Visible = false;
            button4.Visible = false;

            textBox3.Visible = false;
            label8.Visible = false;
            button7.Visible = false;

            textBox2.Visible = true;
            label7.Visible = true;
            button5.Visible = true;
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label7.Visible = false;
            button5.Visible = false;

            textBox1.Visible = false;
            label6.Visible = false;
            button4.Visible = false;

            textBox3.Visible = true;
            label8.Visible = true;
            button7.Visible = true;
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            if (ShowMessage())
            {
                BakiyeGuncelle2(textBox2.Text);
            }
        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            if (ShowMessage())
            {
                BakiyeGuncelle(textBox2.Text);
            }
        }
        private void BakiyeGuncelle(string a)
        {
            try
            {
                // Geçici dosya yolu için bir değişken oluştur
                string tempPath = "temp.txt";

                // Geçici dosyayı oluştur ve yazma modunda aç
                using (StreamWriter writer = new StreamWriter(tempPath))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string? satir; // satir değişkenini nullable olarak tanımla

                        while ((satir = reader.ReadLine()) != null) // Null kabul edilebilir
                        {
                            string[] bilgiler = satir.Split(',');

                            if (bilgiler[3] == tcNo1)
                            {
                                int yeniBakiye = Convert.ToInt32(bilgiler[7]) + Convert.ToInt32(a);
                                bilgiler[7] = yeniBakiye.ToString();
                            }
                            // Dosyayı güncellemek için yaz
                            writer.WriteLine(string.Join(",", bilgiler));
                        }
                        reader.Close();
                    }
                    writer.Close();
                }
                FillBlank2(tcNo1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void BakiyeGuncelle2(string a)
        {
            try
            {
                // Geçici dosya yolu için bir değişken oluştur
                string tempPath = "temp.txt";

                // Geçici dosyayı oluştur ve yazma modunda aç
                using (StreamWriter writer = new StreamWriter(tempPath))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string? satir; // satir değişkenini nullable olarak tanımla

                        while ((satir = reader.ReadLine()) != null) // Null kabul edilebilir
                        {
                            string[] bilgiler = satir.Split(',');

                            if (bilgiler[3] == tcNo1)
                            {
                                int c = Convert.ToInt32(bilgiler[7]);
                                int b = Convert.ToInt32(a);
                                if(c<b)
                                {
                                    MessageBox.Show("Bakiyeniz düşük");
                                }
                                else 
                                {
                                    int yeniBakiye = c - b;
                                    bilgiler[7] = yeniBakiye.ToString();
                                }
                                
                            }
                            // Dosyayı güncellemek için yaz
                            writer.WriteLine(string.Join(",", bilgiler));
                        }
                        reader.Close();
                    }
                    writer.Close();
                }
                FillBlank2(tcNo1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Eğer sayı değilse, olayı işleme alma ve karakteri yok say
                e.Handled = true;
            }
        }

        private bool ShowMessage()
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return result == DialogResult.OK;
        }

        private void FillBlank(string tcNo1)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] bilgiler = satir.Split(',');

                    if (bilgiler.Length > 7 && bilgiler[3] == tcNo1)
                    {
                        labelname.Text = bilgiler[0];

                        if (bilgiler.Length > 7)
                        {
                            labelBakiye.Text = bilgiler[7];
                            int i = 8;
                            int j = 0;
                            while (i < bilgiler.Length && !string.IsNullOrEmpty(bilgiler[i]))
                            {
                                i++;
                                j++;
                            }
                            label5.Text = j.ToString();
                        }
                        else
                        {
                            labelBakiye.Text = "N/A";
                            label5.Text = "N/A";
                        }
                    }
                }
                reader.Close();
            }
        }
        private void FillBlank2(string tcNo1)
        {
            using (StreamReader reader = new StreamReader("temp.txt"))
            {
                string? satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] bilgiler = satir.Split(',');

                    if (bilgiler.Length > 7 && bilgiler[3] == tcNo1)
                    {
                        labelname.Text = bilgiler[0];

                        if (bilgiler.Length > 7)
                        {
                            labelBakiye.Text = bilgiler[7];
                            int i = 8;
                            int j = 0;
                            while (i < bilgiler.Length && !string.IsNullOrEmpty(bilgiler[i]))
                            {
                                i++;
                                j++;
                            }
                            label5.Text = j.ToString();
                        }
                        else
                        {
                            labelBakiye.Text = "N/A";
                            label5.Text = "N/A";
                        }
                    }
                }
                reader.Close();
            }
        }
    }
}
