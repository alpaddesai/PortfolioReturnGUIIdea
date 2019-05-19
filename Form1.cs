using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioReturn
{
    public partial class Form1 : Form
    {


        double RateofReturnMutualFundA = 0;
        double RateofReturnMutualFundB = 0;
        double RateofReturnMutualFundC = 0;
        double RateofReturnMutualFundD = 0;
        double RateofReturnMutualFundE = 0;

        double InitialMutualFundA = 0;
        double InitialMutualFundB = 0;
        double InitialMutualFundC = 0;
        double InitialMutualFundD = 0;
        double InitialMutualFundE = 0;

        double FinalMutualFundA = 0;
        double FinalMutualFundB = 0;
        double FinalMutualFundC = 0;
        double FinalMutualFundD = 0;
        double FinalMutualFundE = 0;


        double WeightMutualFundA = 0;
        double WeightMutualFundB = 0;
        double WeightMutualFundC = 0;
        double WeightMutualFundD = 0;
        double WeightMutualFundE = 0;



        public Form1()
        {
            InitializeComponent();

            MutualFundAInput.Text = "0";
            MutualFundBInput.Text = "0";
            MutualFundCInput.Text = "0";
            MutualFundDInput.Text = "0";
            MutualFundEInput.Text = "0";

            InitialMutualFundA = 2500;
            InitialMutualFundB = 5297;
            InitialMutualFundC = 4115;
            InitialMutualFundD = 5848;
            InitialMutualFundE = 3898;

            FinalMutualFundA = 3110;
            FinalMutualFundB = 6400;
            FinalMutualFundC = 4768;
            FinalMutualFundD = 7559;
            FinalMutualFundE = 4509;


            WeightMutualFundA = 0.1164;
            WeightMutualFundB = 0.2406;
            WeightMutualFundC = 0.1849;
            WeightMutualFundD = 0.2791;
            WeightMutualFundE = 0.1791;



            RateofReturnMutualFundA = (FinalMutualFundA - InitialMutualFundA) / InitialMutualFundA;
            RateofReturnMutualFundB = (FinalMutualFundB - InitialMutualFundB) / InitialMutualFundB;
            RateofReturnMutualFundC = (FinalMutualFundC - InitialMutualFundC) / InitialMutualFundC;
            RateofReturnMutualFundD = (FinalMutualFundD - InitialMutualFundD) / InitialMutualFundD;
            RateofReturnMutualFundE = (FinalMutualFundE - InitialMutualFundE) / InitialMutualFundE;




        }

        private void MutualFundA_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mutual fund A rate of return is {Math.Round(RateofReturnMutualFundA, 3) * 100 } %");
        }

        private void MutualFundB_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mutual fund B rate of return is {Math.Round(RateofReturnMutualFundB, 3) * 100 } %");

        }

        private void MutualFundC_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mutual fund C rate of return is {Math.Round(RateofReturnMutualFundC, 3) * 100 } %");

        }

        private void MutualFundD_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mutual fund D rate of return is {Math.Round(RateofReturnMutualFundD, 3) * 100 } %");

        }

        private void MutualFundE_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mutual fund E rate of return is {Math.Round(RateofReturnMutualFundE, 3) * 100 } %");

        }

        private void CustomRateofReturn_Click(object sender, EventArgs e)
        {

            WeightMutualFundA = double.Parse(MutualFundAInput.Text);
            WeightMutualFundB = double.Parse(MutualFundBInput.Text);
            WeightMutualFundC = double.Parse(MutualFundCInput.Text);
            WeightMutualFundD = double.Parse(MutualFundDInput.Text);
            WeightMutualFundE = double.Parse(MutualFundEInput.Text);

            WeightMutualFundA = WeightMutualFundA / 100;
            WeightMutualFundB = WeightMutualFundB / 100;
            WeightMutualFundC = WeightMutualFundC / 100;
            WeightMutualFundD = WeightMutualFundD / 100;
            WeightMutualFundE = WeightMutualFundE / 100;


            if ((WeightMutualFundA + WeightMutualFundB + WeightMutualFundC + WeightMutualFundD + WeightMutualFundE) == 1)
            {
                double PortfolioRateofReturnPercentage = (RateofReturnMutualFundA * WeightMutualFundA + RateofReturnMutualFundB * WeightMutualFundB +
                                        RateofReturnMutualFundC * WeightMutualFundC + RateofReturnMutualFundD * WeightMutualFundD +
                                        RateofReturnMutualFundE * WeightMutualFundE) * 100;

                MessageBox.Show($"The Portfolio Rate of Return is { Math.Round(PortfolioRateofReturnPercentage, 3) } %");
            }
            else
                MessageBox.Show($" Error the weightage of all mutual funds must equal 100 %");



        }

        private void DefaultRateofReturn_Click(object sender, EventArgs e)
        {

            WeightMutualFundA = 0.1164;
            WeightMutualFundB = 0.2406;
            WeightMutualFundC = 0.1849;
            WeightMutualFundD = 0.2791;
            WeightMutualFundE = 0.1791;


            double PortfolioRateofReturnPercentage = (RateofReturnMutualFundA * WeightMutualFundA + RateofReturnMutualFundB * WeightMutualFundB +
               RateofReturnMutualFundC * WeightMutualFundC + RateofReturnMutualFundD * WeightMutualFundD +
               RateofReturnMutualFundE * WeightMutualFundE) * 100;

               MessageBox.Show($"The Portfolio Rate of Return is { Math.Round(PortfolioRateofReturnPercentage, 3) } %");

        }

        private void MutualFundAInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void MutualFundBInput_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void MutualFundCInput_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void MutualFundDInput_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void MutualFundEInput_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
