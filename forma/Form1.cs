namespace forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez_a;
            int rez_b;
            bool success1 = int.TryParse(pirmas.Text, out rez_a);
            bool success2 = int.TryParse(antras.Text, out rez_b);

            int rez;
            rez = rez_a * rez_b;
            suma.Text = rez.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "Ar norite nutraukti ðià operacijà?";
            string title = "Uþdaryti langà";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_nespausk.Text = "Sakiau gi nespausti..";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}