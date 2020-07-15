using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversion_Gui
{
    public partial class Form1 : Form
    {
        string startingFluid;
        double startingAmount;
        string endingFluid;
        double endingAmount;
        public Form1()
        {
            InitializeComponent();
        }

        private double Convert(string startingFluid, string endingFluid, double startingAmount)
        {
            if(startingFluid == "Ounces"){
                switch(endingFluid){
                    case "Ounces":
                        endingAmount = startingAmount;
                        return endingAmount;
                        break;
                    case "Cups":
                        endingAmount = startingAmount * 0.125;
                        return endingAmount;
                        break;
                    case "Pints":
                        endingAmount = startingAmount * 0.0625;
                        return endingAmount;
                        break;
                    case "Liters":
                        endingAmount = startingAmount * 0.0295735;
                        return endingAmount;
                        break;
                    case "Gallons":
                        endingAmount = startingAmount * 0.0078125;
                        return endingAmount;
                        break;
                }
            }else if(startingFluid == "Cups")
            {
                switch (endingFluid)
                {
                    case "Ounces":
                        endingAmount = startingAmount * 8;
                        return endingAmount;
                        break;
                    case "Cups":
                        endingAmount = startingAmount;
                        return endingAmount;
                        break;
                    case "Pints":
                        endingAmount = startingAmount * 0.5;
                        return endingAmount;
                        break;
                    case "Liters":
                        endingAmount = startingAmount * 0.236588;
                        return endingAmount;
                        break;
                    case "Gallons":
                        endingAmount = startingAmount * 0.0625;
                        return endingAmount;
                        break;
                }
            }else if(startingFluid == "Pints")
            {
                switch (endingFluid)
                {
                    case "Ounces":
                        endingAmount = startingAmount * 16;
                        return endingAmount;
                        break;
                    case "Cups":
                        endingAmount = startingAmount * 1.97157;
                        return endingAmount;
                        break;
                    case "Pints":
                        endingAmount = startingAmount;
                        return endingAmount;
                        break;
                    case "Liters":
                        endingAmount = startingAmount * 0.473176;
                        return endingAmount;
                        break;
                    case "Gallons":
                        endingAmount = startingAmount * 0.125;
                        return endingAmount;
                        break;
                }
            }else if(startingFluid == "Liters")
            {
                switch (endingFluid)
                {
                    case "Ounces":
                        endingAmount = startingAmount * 33.814;
                        return endingAmount;
                        break;
                    case "Cups":
                        endingAmount = startingAmount * 4.22675;
                        return endingAmount;
                        break;
                    case "Pints":
                        endingAmount = startingAmount * 2.11338;
                        return endingAmount;
                        break;
                    case "Liters":
                        endingAmount = startingAmount;
                        return endingAmount;
                        break;
                    case "Gallons":
                        endingAmount = startingAmount * 0.264172;
                        return endingAmount;
                        break;
                }
            }else if(startingFluid == "Gallons")
            {
                switch (endingFluid)
                {
                    case "Ounces":
                        endingAmount = startingAmount * 128;
                        return endingAmount;
                        break;
                    case "Cups":
                        endingAmount = startingAmount * 16;
                        return endingAmount;
                        break;
                    case "Pints":
                        endingAmount = startingAmount * 8;
                        return endingAmount;
                        break;
                    case "Liters":
                        endingAmount = startingAmount * 3.78541;
                        return endingAmount;
                        break;
                    case "Gallons":
                        endingAmount = startingAmount;
                        return endingAmount;
                        break;
                }
            }
            return 0;
        }
        private void Startinglabel_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (ouncesButtonIntake.Checked == true)
            {
                startingFluid = "Ounces";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cupsButtonIntake.Checked == true)
            {
                startingFluid = "Cups";
            }
        }

        private void conversionLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void litersButtonIntake_CheckedChanged(object sender, EventArgs e)
        {

            if (litersButtonIntake.Checked == true)
            {
                startingFluid = "Liters";
            }
        }

        private void pintsButtonIntake_CheckedChanged(object sender, EventArgs e)
        {
            if (pintsButtonIntake.Checked == true)
            {
                startingFluid = "Pints";
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Convert(startingFluid, endingFluid, startingAmount);
            conversionLabel.Text = endingAmount + " " + endingFluid;
        }

        private void gallonsButtonIntake_CheckedChanged(object sender, EventArgs e)
        {
            if (gallonsButtonIntake.Checked == true)
            {
                startingFluid = "Gallons";
            }
        }

        private void unitAmountBox_TextChanged(object sender, EventArgs e)
        {
            startingAmount = int.Parse(unitAmountBox.Text);
        }

        private void ouncesButtonExit_CheckedChanged(object sender, EventArgs e)
        {
            if(ouncesButtonExit.Checked == true)
            {
                endingFluid = "Ounces";
            }
        }

        private void cupsButtonExit_CheckedChanged(object sender, EventArgs e)
        {
            if(cupsButtonExit.Checked == true)
            {
                endingFluid = "Cups";
            }
        }

        private void pintsButtonExit_CheckedChanged(object sender, EventArgs e)
        {
            if(pintsButtonExit.Checked == true)
            {
                endingFluid = "Pints";
            }
        }

        private void litersButtonExit_CheckedChanged(object sender, EventArgs e)
        {
            if(litersButtonExit.Checked == true)
            {
                endingFluid = "Liters";
            }
        }

        private void gallonsButtonExit_CheckedChanged(object sender, EventArgs e)
        {
            if(gallonsButtonExit.Checked == true)
            {
                endingFluid = "Gallons";
            }
        }
    }
}
