namespace ATM
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TextBoxAd = new TextBox();
            TextBoxTelNo = new TextBox();
            TextBoxSoyad = new TextBox();
            TextBoxTcNo = new TextBox();
            TextBoxEmail = new TextBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            labelTcNo = new Label();
            labelTelNo = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxSifre = new TextBox();
            textBoxSifreTekar = new TextBox();
            labelSifre = new Label();
            labelSifreTekrar = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arboria-Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 0;
            button1.Text = "Önceki Ekran";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 73);
            label1.Name = "label1";
            label1.Size = new Size(36, 24);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(241, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 3;
            label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(236, 155);
            label4.Name = "label4";
            label4.Size = new Size(178, 24);
            label4.TabIndex = 4;
            label4.Text = "Tc Kimlik Numarası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 245);
            label5.Name = "label5";
            label5.Size = new Size(83, 24);
            label5.TabIndex = 5;
            label5.Text = "E-posta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(239, 245);
            label6.Name = "label6";
            label6.Size = new Size(128, 24);
            label6.TabIndex = 6;
            label6.Text = "Doğum Tarihi";
            // 
            // TextBoxAd
            // 
            TextBoxAd.Location = new Point(15, 109);
            TextBoxAd.Name = "TextBoxAd";
            TextBoxAd.Size = new Size(175, 26);
            TextBoxAd.TabIndex = 7;
            TextBoxAd.TextChanged += TextBoxAd_TextChanged;
            TextBoxAd.KeyPress += TextBoxAd_Keypress;
            // 
            // TextBoxTelNo
            // 
            TextBoxTelNo.Location = new Point(15, 191);
            TextBoxTelNo.Name = "TextBoxTelNo";
            TextBoxTelNo.Size = new Size(175, 26);
            TextBoxTelNo.TabIndex = 9;
            TextBoxTelNo.TextChanged += TextBoxTelNo_TextChanged;
            TextBoxTelNo.KeyPress += TextBoxTelNo_Keypress;
            TextBoxTelNo.Validating += TextBoxTelNo_Validating;
            // 
            // TextBoxSoyad
            // 
            TextBoxSoyad.Location = new Point(239, 109);
            TextBoxSoyad.Name = "TextBoxSoyad";
            TextBoxSoyad.Size = new Size(175, 26);
            TextBoxSoyad.TabIndex = 10;
            TextBoxSoyad.TextChanged += TextBoxSoyad_TextChanged;
            TextBoxSoyad.KeyPress += TextBoxAd_Keypress;
            // 
            // TextBoxTcNo
            // 
            TextBoxTcNo.Location = new Point(239, 191);
            TextBoxTcNo.Name = "TextBoxTcNo";
            TextBoxTcNo.Size = new Size(175, 26);
            TextBoxTcNo.TabIndex = 11;
            TextBoxTcNo.TextChanged += TextBoxTcNo_TextChanged;
            TextBoxTcNo.KeyPress += TextBoxTelNo_Keypress;
            TextBoxTcNo.Validating += TextBoxTcNo_Validating;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(15, 282);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(175, 26);
            TextBoxEmail.TabIndex = 12;
            TextBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            TextBoxEmail.Validating += TextBoxEmail_Validating;
            // 
            // button2
            // 
            button2.Font = new Font("Arboria-Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(140, 460);
            button2.Name = "button2";
            button2.Size = new Size(145, 44);
            button2.TabIndex = 14;
            button2.Text = "Kayıt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(239, 282);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 26);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(15, 311);
            label7.Name = "label7";
            label7.Size = new Size(0, 18);
            label7.TabIndex = 16;
            // 
            // labelTcNo
            // 
            labelTcNo.AutoSize = true;
            labelTcNo.ForeColor = Color.Red;
            labelTcNo.Location = new Point(244, 220);
            labelTcNo.Name = "labelTcNo";
            labelTcNo.Size = new Size(0, 18);
            labelTcNo.TabIndex = 17;
            // 
            // labelTelNo
            // 
            labelTelNo.AutoSize = true;
            labelTelNo.ForeColor = Color.Red;
            labelTelNo.Location = new Point(15, 220);
            labelTelNo.Name = "labelTelNo";
            labelTelNo.Size = new Size(0, 18);
            labelTelNo.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 352);
            label8.Name = "label8";
            label8.Size = new Size(50, 24);
            label8.TabIndex = 19;
            label8.Text = "Şifre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(239, 352);
            label9.Name = "label9";
            label9.Size = new Size(107, 24);
            label9.TabIndex = 20;
            label9.Text = "Şifre Tekarı";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(15, 379);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(175, 26);
            textBoxSifre.TabIndex = 21;
            textBoxSifre.UseSystemPasswordChar = true;
            textBoxSifre.TextChanged += textBoxSifre_TextChanged;
            textBoxSifre.Validating += textBoxSifre_Validating;
            // 
            // textBoxSifreTekar
            // 
            textBoxSifreTekar.Location = new Point(239, 379);
            textBoxSifreTekar.Name = "textBoxSifreTekar";
            textBoxSifreTekar.Size = new Size(175, 26);
            textBoxSifreTekar.TabIndex = 22;
            textBoxSifreTekar.UseSystemPasswordChar = true;
            textBoxSifreTekar.TextChanged += textBoxSifreTekar_TextChanged;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.ForeColor = Color.Red;
            labelSifre.Location = new Point(17, 408);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(0, 18);
            labelSifre.TabIndex = 23;
            // 
            // labelSifreTekrar
            // 
            labelSifreTekrar.AutoSize = true;
            labelSifreTekrar.ForeColor = Color.Red;
            labelSifreTekrar.Location = new Point(239, 408);
            labelSifreTekrar.Name = "labelSifreTekrar";
            labelSifreTekrar.Size = new Size(0, 18);
            labelSifreTekrar.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(236, 311);
            label10.Name = "label10";
            label10.Size = new Size(0, 18);
            label10.TabIndex = 25;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 540);
            Controls.Add(label10);
            Controls.Add(labelSifreTekrar);
            Controls.Add(labelSifre);
            Controls.Add(textBoxSifreTekar);
            Controls.Add(textBoxSifre);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelTelNo);
            Controls.Add(labelTcNo);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTcNo);
            Controls.Add(TextBoxSoyad);
            Controls.Add(TextBoxTelNo);
            Controls.Add(TextBoxAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Arboria-Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TextBoxAd;
        private TextBox TextBoxTelNo;
        private TextBox TextBoxSoyad;
        private TextBox TextBoxTcNo;
        private TextBox TextBoxEmail;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label labelTcNo;
        private Label labelTelNo;
        private Label label8;
        private Label label9;
        private TextBox textBoxSifre;
        private TextBox textBoxSifreTekar;
        private Label labelSifre;
        private Label labelSifreTekrar;
        private Label label10;
    }
}