using static CheckoutKata.PriceCalculations;

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
            DisplayCosts();
            //DisplayTotal();
            
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

        void DisplayCosts()
        {
            PriceA.Text = PriceCalculations.UnitPriceA.ToString();
            PriceB.Text = PriceCalculations.UnitPriceB.ToString();
            PriceC.Text = PriceCalculations.UnitPriceC.ToString();
            PriceD.Text = PriceCalculations.UnitPriceD.ToString();
        }

        public decimal CalculateTotal()
        {

            Decimal TotalA = PriceCalculations.TotalPriceA(PriceCalculations.UnitPriceA, quantA);
            Decimal TotalB = PriceCalculations.TotalPriceB(PriceCalculations.UnitPriceB, quantB);
            Decimal TotalC = PriceCalculations.TotalPriceC(PriceCalculations.UnitPriceC, quantC);
            Decimal TotalD = PriceCalculations.TotalPriceD(PriceCalculations.UnitPriceD, quantD);

            Decimal Total = PriceCalculations.TotalPrice(TotalA, TotalB, TotalC, TotalD);
            

            return Total;
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

        private void incrementD_Click(object sender, EventArgs e)
        {
            quantD = increment(quantD);
            quantityD.Text = quantD.ToString();
        }

        private void calculateCost_Click(object sender, EventArgs e)
        {
            decimal Total = CalculateTotal();
            TotalPrice.Text = Total.ToString();
        }
    }
}