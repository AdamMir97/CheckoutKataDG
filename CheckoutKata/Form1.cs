namespace CheckoutKata
{
    public partial class Form1 : Form
    {
        int quantA = 0;
        int quantB = 0;
        int quantC = 0;
        int quantD = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public int increment(int value)
        {
            value++;
            return value;
        }

        public int decrement(int value)
        {
            if (value > 0) value = value - 1;
            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void decrementA_Click(object sender, EventArgs e)
        {
            quantA = decrement(quantA);
            quantityA.Text = quantA.ToString();
        }

        private void incrementA_Click(object sender, EventArgs e)
        {
            quantA = increment(quantA);
            quantityA.Text = quantA.ToString();
        }

        private void decrementB_Click(object sender, EventArgs e)
        {
            quantB = decrement(quantB);
            quantityB.Text = quantB.ToString();
        }

        private void incrementB_Click(object sender, EventArgs e)
        {
            quantB = increment(quantB);
            quantityB.Text = quantB.ToString();
        }

        private void decrementC_Click(object sender, EventArgs e)
        {
            quantC = decrement(quantC);
            quantityC.Text = quantC.ToString();
        }

        private void incrementC_Click(object sender, EventArgs e)
        {
            quantC = increment(quantC);
            quantityC.Text = quantC.ToString();
        }

        private void decrementD_Click(object sender, EventArgs e)
        {
            quantD = decrement(quantD);
            quantityD.Text = quantD.ToString();
        }

        private void IncrementD_Click(object sender, EventArgs e)
        {
            quantD = increment(quantD);
            quantityD.Text = quantD.ToString();
        }
    }
}