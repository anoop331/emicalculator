using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = double.Parse(textBox1.Text);
            var r = double.Parse(textBox2.Text)/12;
            var n = int.Parse(textBox3.Text);
            var c = int.Parse(closeAfter.Text);
            var result = Calculate(p,r,n);
            var total = result*n;
            var left = total - c*result;
            resultLabel.Text = result.ToString();
            remainingLabel.Text = CalculateRemaining(p, result, c, r).ToString();
        }

        private double CalculateRemaining(double p, double e, int n, double r)
        {
            var x = 1 + r / 100;
            return p*Math.Pow(x, n) - ((SumSeries(x,n) - 1))*e;
        }

        private double Calculate(double p, double r, int n)
        {
            var x = 1 + r/100;
            return p*Math.Pow(x, n)/SumSeries(x, n);
        }

        private double SumSeries(double x, int n)
        {
            if (n == 1) return 1;
            return SumSeries(x, n - 1) + Math.Pow(x, n - 1);
        }

    }
}
