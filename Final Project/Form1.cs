namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double monthlyPayment = double.Parse(monthlyPaymentTextBox.Text);
            double annualPayment = double.Parse(annualPaymentTextBox.Text);
            double initialPayment = double.Parse(initialPaymentTextBox.Text);
            int termInYears = int.Parse(termTextBox.Text);
            double interestRate = double.Parse(interestRateTextBox.Text) / 100;

            string initialPaymentResult = initialPayment.ToString("C2");

            double finalTotalPayments = TotalPayments(initialPayment, monthlyPayment, annualPayment, termInYears);
            double finelFutureMoneyFromItitialPayment = FutureMoneyFromItitialPayment(initialPayment, termInYears, interestRate);
            double finalFutureMoneyFromMonthlyPayments = FutureMoneyFromMonthlyPayments(monthlyPayment, termInYears, interestRate);
            double finalFutureMoneyFromAnnualPayments = FutureMoneyFromAnnualPayments(annualPayment, termInYears, interestRate);
            double finalTotalMoney = finelFutureMoneyFromItitialPayment + finalFutureMoneyFromMonthlyPayments + finalFutureMoneyFromAnnualPayments;

            resultsBox.Text = "Total payments: " + finalTotalPayments.ToString("C2") + "\n";
            resultsBox.Text += "Total money from initial payment: " + finelFutureMoneyFromItitialPayment.ToString("C2") + "\n";
            resultsBox.Text += "Total money from monthly payments: " + finalFutureMoneyFromMonthlyPayments.ToString("C2") + "\n";
            resultsBox.Text += "Total money from annual payments: " + finalFutureMoneyFromAnnualPayments.ToString("C2") + "\n";
            resultsBox.Text += "Your total final savings: " + finalTotalMoney.ToString("C2");
        }

        private double TotalPayments(double initialPayment, double monthlyPayment, double annualPayment, int termInYears)
        {
            return initialPayment + monthlyPayment * 12 * termInYears + annualPayment * termInYears;
        }
        private double FutureMoneyFromItitialPayment(double initialPayment, int termInYears, double interestRate)
        {
            double finalAmount = initialPayment;
            for (int i = 1; i < termInYears * 12; i++)
            {
                finalAmount += (finalAmount * (interestRate / 12));
            }
            return finalAmount;
        }
        private double FutureMoneyFromMonthlyPayments(double monthlyPayment, int termInYears, double interestRate)
        {
            double finalAmount = monthlyPayment;
            for (int i = 1; i < termInYears * 12; i++)
            {
                finalAmount += monthlyPayment + (finalAmount * (interestRate / 12));
            }
            return finalAmount;
        }
        private double FutureMoneyFromAnnualPayments(double annualPayment, int termInYears, double interestRate)
        {
            double finalAmount = annualPayment;
            for (int i = 1; i < termInYears; i++)
            {
                finalAmount += annualPayment + (finalAmount * (interestRate));
            }
            return finalAmount;
        }
    }
}