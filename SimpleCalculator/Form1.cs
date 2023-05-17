namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            string operand1 = textBox1.Text;
            string operand2 = textBox2.Text;
            decimal.TryParse(operand1, out num1);
            decimal.TryParse(operand2, out num2);
            decimal res = num1 + num2;
            textBox3.Text = res.ToString();
            listBox1.Items.Add(num1.ToString() + " + " + num2.ToString() + " = " + res.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            string operand1 = textBox1.Text;
            string operand2 = textBox2.Text;
            decimal.TryParse(operand1, out num1);
            decimal.TryParse(operand2, out num2);
            decimal res = num1 - num2;
            textBox3.Text = res.ToString();
            listBox1.Items.Add(num1.ToString() + " - " + num2.ToString() + " = " + res.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            string operand1 = textBox1.Text;
            string operand2 = textBox2.Text;
            decimal.TryParse(operand1, out num1);
            decimal.TryParse(operand2, out num2);
            decimal res = num1 * num2;
            textBox3.Text = res.ToString();
            listBox1.Items.Add(num1.ToString() + " * " + num2.ToString() + " = " + res.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal num1, num2;
            string operand1 = textBox1.Text;
            string operand2 = textBox2.Text;
            decimal.TryParse(operand1, out num1);
            decimal.TryParse(operand2, out num2);
            decimal res = num1 / num2;
            textBox3.Text = res.ToString();
            listBox1.Items.Add(num1.ToString() + " / " + num2.ToString() + " = " + res.ToString());
        }
    
    }
}
