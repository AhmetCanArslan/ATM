namespace ATM
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label4 = new Label();
            label1 = new Label();
            labelname = new Label();
            labelBakiye = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label5 = new Label();
            button6 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button7 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arboria-Book", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 86);
            label4.Name = "label4";
            label4.Size = new Size(151, 35);
            label4.TabIndex = 0;
            label4.Text = "Hoşgeldin ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 166);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 1;
            label1.Text = "Mevcut Bakiye: ";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Font = new Font("Arboria-Book", 17F, FontStyle.Regular, GraphicsUnit.Point);
            labelname.Location = new Point(166, 86);
            labelname.Name = "labelname";
            labelname.Size = new Size(0, 35);
            labelname.TabIndex = 2;
            // 
            // labelBakiye
            // 
            labelBakiye.AutoSize = true;
            labelBakiye.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelBakiye.Location = new Point(203, 166);
            labelBakiye.Name = "labelBakiye";
            labelBakiye.RightToLeft = RightToLeft.Yes;
            labelBakiye.Size = new Size(0, 30);
            labelBakiye.TabIndex = 3;
            labelBakiye.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 222);
            button1.Name = "button1";
            button1.Size = new Size(104, 53);
            button1.TabIndex = 4;
            button1.Text = "Para Çek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Clicked;
            // 
            // button2
            // 
            button2.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(119, 222);
            button2.Name = "button2";
            button2.Size = new Size(109, 53);
            button2.TabIndex = 5;
            button2.Text = "Para Yatır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Clicked;
            // 
            // button3
            // 
            button3.Font = new Font("Arboria-Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(234, 223);
            button3.Name = "button3";
            button3.Size = new Size(110, 53);
            button3.TabIndex = 6;
            button3.Text = "Kart Oluştur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Clicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 166);
            label2.Name = "label2";
            label2.Size = new Size(43, 30);
            label2.TabIndex = 7;
            label2.Text = "TL";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arboria-Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 26);
            textBox1.TabIndex = 8;
            textBox1.Visible = false;
            textBox1.KeyPress += textBox_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arboria-Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(119, 315);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 26);
            textBox2.TabIndex = 9;
            textBox2.Visible = false;
            textBox2.KeyPress += textBox_KeyPress;
            // 
            // button4
            // 
            button4.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(9, 356);
            button4.Name = "button4";
            button4.Size = new Size(104, 53);
            button4.TabIndex = 10;
            button4.Text = "Onayla";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Clicked;
            // 
            // button5
            // 
            button5.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(119, 356);
            button5.Name = "button5";
            button5.Size = new Size(109, 53);
            button5.TabIndex = 11;
            button5.Text = "Onayla";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Clicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 431);
            label3.Name = "label3";
            label3.Size = new Size(220, 30);
            label3.TabIndex = 12;
            label3.Text = "Mevcut Kart Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(235, 431);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(0, 30);
            label5.TabIndex = 13;
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button6
            // 
            button6.Font = new Font("Arboria-Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(9, 12);
            button6.Name = "button6";
            button6.Size = new Size(100, 53);
            button6.TabIndex = 14;
            button6.Text = "Çıkış Yap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Clicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arboria-Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 291);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 15;
            label6.Text = "Miktar";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arboria-Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(119, 291);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 16;
            label7.Text = "Miktar";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arboria-Book", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(235, 291);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 19;
            label8.Text = "Kart Sayısı";
            label8.Visible = false;
            // 
            // button7
            // 
            button7.Font = new Font("Arboria-Book", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(235, 356);
            button7.Name = "button7";
            button7.Size = new Size(109, 53);
            button7.TabIndex = 18;
            button7.Text = "Onayla";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arboria-Book", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(235, 315);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 26);
            textBox3.TabIndex = 17;
            textBox3.Visible = false;
            textBox3.KeyPress += textBox_KeyPress;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 512);
            Controls.Add(label8);
            Controls.Add(button7);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelBakiye);
            Controls.Add(labelname);
            Controls.Add(label1);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label labelname;
        private Label labelBakiye;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Label label3;
        private Label label5;
        private Button button6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button7;
        private TextBox textBox3;
    }
}