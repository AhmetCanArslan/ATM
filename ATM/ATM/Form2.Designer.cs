namespace ATM
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_Keypress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 1;
            label1.Text = "TC No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arboria-Book", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 3;
            label2.Text = "Şifreniz";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(110, 155);
            button1.Name = "button1";
            button1.Size = new Size(94, 63);
            button1.TabIndex = 4;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 155);
            button2.Name = "button2";
            button2.Size = new Size(94, 63);
            button2.TabIndex = 5;
            button2.Text = "Şifremi unuttum";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arboria-Book", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(110, 7);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Önceki Ekran";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 230);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kartsız";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}