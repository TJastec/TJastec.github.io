using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwareSales
{
    public partial class salesForm1 : Form
    {
        public salesForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //To Future me and others who may be concerned, this is the 1st line of comments in this solution
        //"GradientInactiveCaption" IS THE salesForm1.BackColor;. it b seamless
        //Changed Title bar from "Sales_Force.exe" to  - __- "Software Sales" for thos extra .5 point, glad I looked through work one llast time, again;
        private void clearButton2_Click(object sender, EventArgs e)
            //For all ^^^ your textbox clearing needs. You kept getting lost so here you go        
        {
            textBoxA.Text = ""; textBoxB.Text = ""; textBoxC.Text = ""; aRevenueTextBox.Text = ""; bRevenueTextBox.Text = ""; cRevenueTextBox.Text = ""; totalRevenueTextBox.Text = ""; // ----------------start HERE-----------[ dONE?] WHEN YOU RETURN PLEASSE ADD CLEAR TO REVENUE SIDES
        }

        private void calculateButton1_Click(object sender, EventArgs e)
        {
            int PackageA, PackageB, PackageC;            
            // try...catch- this is some form of "Event handling" which is a way to wrote the program such that it circumvents easy crashing and runtime errs
            try
            {
                PackageA = int.Parse(textBoxA.Text);
                PackageB = int.Parse(textBoxB.Text);
                PackageC = int.Parse(textBoxC.Text);
                PackageA = PackageA * 150; // can also do this:PackageA *= 150;
                PackageB = PackageB * 120;
                PackageC = PackageC * 90;
                aRevenueTextBox.Text = PackageA.ToString("C");
                bRevenueTextBox.Text = PackageB.ToString("C");
                cRevenueTextBox.Text = PackageC.ToString("C");

                int Total;
                Total = PackageA + PackageB + PackageC;
                totalRevenueTextBox.Text = Total.ToString("C");

            }
            catch
            {
                MessageBox.Show("Err 404");
            }
        }
    }
}
