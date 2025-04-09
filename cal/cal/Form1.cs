namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double totals = firstnum + secondnum;
            string operation = "Addition";
            MessageBox.Show("The result of " + operation + " is: " + totals);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double totals = firstnum - secondnum;
            string operation = "Subtraction";
            MessageBox.Show("The result of " + operation + " is: " + totals);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double totals = firstnum * secondnum;
            string operation = "Multiplcation";
            MessageBox.Show("The result of " + operation + " is: " + totals);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double totals = firstnum / secondnum;
            string operation = "Division";
            MessageBox.Show("The result of " + operation + " is: " + totals);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double totals = firstnum % secondnum;
            string operation = "Modulo";
            MessageBox.Show("The result of " + operation + " is: " + totals);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
