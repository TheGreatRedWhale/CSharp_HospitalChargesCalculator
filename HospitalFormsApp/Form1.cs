using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalFormsApp
{
    public partial class hospForm : Form
    {
        HospitalCharges charges = new HospitalCharges();

        public hospForm()
        {
            InitializeComponent();
        }

        private void resetTotals(object sender, EventArgs e)
        {
            stayChargeBox.Text = "";
            miscChargeBox.Text = "";
            totalChargeBox.Text = "";
        }

        private void calculateTotals(object sender, EventArgs e)
        {
            charges.Days = Int32.Parse(daysBox.Text);
            charges.RxFee = Int32.Parse(rxBox.Text);
            charges.SurgFee = Int32.Parse(surgBox.Text);
            charges.LabFee = Int32.Parse(labBox.Text);
            charges.RehabFee = Int32.Parse(rehabBox.Text);

            stayChargeBox.Text = $"{charges.CalcStayCharges()}";
            miscChargeBox.Text = $"{charges.CalcMiscCharges()}";
            totalChargeBox.Text = $"{charges.CalcTotalCharges()}";

        }
    }
}
