using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automobile_calculator
{
    public partial class frmAoutomoblieCost : Form
    {
        public frmAoutomoblieCost()
        {
            InitializeComponent();
        }

        private void sumbitExpense(object sender, EventArgs e)
        {
            /*Get the data from the user's input*/
            string carNoteStr = intTxtCarNote.Text;
            string carInsureStr = intTxtCarInsurance.Text;
            string carGasStr = intTxtCarGas.Text;
            string carOilStr = intTxtCarOil.Text;
            string carRegStr = intTxtCarReg.Text;
            string carRepairsStr = intTxtCarRepairs.Text;

            /* convert that user data into double*/
            Double carNoteDbl = Convert.ToDouble(carNoteStr);
            Double carInsureDbl = Convert.ToDouble(carInsureStr);
            Double carGasDbl = Convert.ToDouble(carGasStr);
            Double carOilDbl = Convert.ToDouble(carOilStr);
            Double carRegDbl = Convert.ToDouble(carRegStr);
            Double carRepairDbl = Convert.ToDouble(carRepairsStr);

            /* create the formulas needed to solve monthly and yearly expense*/
            Double monthlyExpense = carNoteDbl + carInsureDbl + carGasDbl + carOilDbl + carRegDbl + carRegDbl;
            Double yearlyExpense = monthlyExpense * 12;

            /* output data (answer) into textbox
             */
            outTxtResults.Text = "";

            outTxtResults.Text = "***Final Results***" + Environment.NewLine;
            outTxtResults.AppendText("Total Monthly Cost " + monthlyExpense.ToString("C") + Environment.NewLine);
            outTxtResults.AppendText("Total Yearly Cost " + yearlyExpense.ToString("C") + Environment.NewLine);
        }
    }
}
