using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            SelectedList.Items.Clear();
            List<ICreditManager> selectCreditList = new List<ICreditManager>();

            if (ConsumerCreditCheck.Checked)
                selectCreditList.Add(new ConsumerCreditManager());
            if (MortgageCreditCheck.Checked)
                selectCreditList.Add(new MortgageCreditManager());
            if (VehicleCreditCheck.Checked)
                selectCreditList.Add(new VehicleCreditManager());


            foreach (var credit in selectCreditList)
            {
                SelectedList.Items.Add(credit.Calculate(Convert.ToInt32(CreditAmountNumber.Value)));
            }
        }
    }
}
