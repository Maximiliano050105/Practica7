namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doublelado1, lado2, lado3;
            lado 1 = double.Parse(textBox1.Text);
            lado 2 = double.Parse(textBox2.Text);
            lado 3 = double.Parse(textBox3.Text);
            if ((lado1 == lado2) && (lado2 == lado3)) textBox4.Text = "Equilatero";
            else
                if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3)) textBox4.Text = "Isoceles";
            else textBox4.Text = "Escaleno";
        }
    }
}
