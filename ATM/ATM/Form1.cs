namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("temp.txt"))
            {
                File.Delete("data.txt");
                File.Move("temp.txt", "data.txt");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            kartli form3 = new kartli();
            form3.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }
    }
}