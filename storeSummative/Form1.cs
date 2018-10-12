using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storeSummative
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


        const double burgerCost = 2.49;
        const double friesCost = 1.89;
        const double drinkCost = 0.99;
        const double tax = 0.13;
        int numberBurgers;
        int numberFries;
        int numberDrinks;
        double price;
        double total;
        double taxTotal;
        double numberTendered;
        double change;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            numberBurgers = Convert.ToInt16(burgerBox.Text);
            numberFries = Convert.ToInt16(friesBox.Text);
            numberDrinks = Convert.ToInt16(drinkBox.Text);
            price = numberBurgers * burgerCost + numberFries * friesCost + numberDrinks * drinkCost;
            taxTotal = price * tax;
            total = price + taxTotal;
            subtotal.Text = "   Subtotal         " + price.ToString("C");
            totalLabel.Text = "   Total              " + total.ToString("C");
            taxLabel.Text = "   Tax                " + taxTotal.ToString("C");
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            numberTendered = Convert.ToDouble(tenderedBox.Text);
            change = numberTendered - total;
            changeLabel.Text = change.ToString("C");
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black, 2);
            g.DrawRectangle(drawPen, 300, 100, 300, 400);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Consolas", 20, FontStyle.Bold);
            g.DrawString(
            "\nBurgers:      " + numberBurgers + " " + burgerCost +
               "\nFries:      " + numberFries + " " + friesCost +
               "\nDrinks:      " + numberDrinks + " " + drinkCost +
               "\nSubtotal:      " + price +
               "\nTax:      " + taxTotal +
               "\nTotal:      " + total +
               "\nTendered      " + numberTendered +
               "\nChange      " + change, drawFont, drawBrush, 350, 150);  
        }
    }
}