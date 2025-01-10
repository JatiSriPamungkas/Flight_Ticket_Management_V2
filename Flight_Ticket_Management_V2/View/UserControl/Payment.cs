using Flight_Ticket_Management_V2.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_Management_V2
{
    public partial class Payment : UserControl
    {
        private Dashboard dashboard;
        private Schedule schedule;
        private PaymentVerification paymentVerification;
        public Payment(Dashboard dashboard, Schedule schedule, PaymentVerification paymentVerification)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.schedule = schedule;
            this.paymentVerification = paymentVerification;
        }

        public void SetUpdatePaymentMethod(string paymentMethod)
        {
            dashboard.paymentVerification.UpdatedCMBPaymentMethod(paymentMethod);
            dashboard.paymentVerification.GeneratePaymentNumber();
        }

        public void SetData(ScheduleEntity schedule)
        {
            int serviceFee = 12000;
            int totalPrice = schedule.Price + serviceFee;

            lblAirline.Text = schedule.Airline;
            lblAirlinePrice.Text = schedule.Price.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp ");
            lblAdminFee.Text = serviceFee.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp ");
            lblTotalPrice.Text = totalPrice.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp ");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select the Payment Method!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (cbTermsAndConditions.Checked)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to proceed to the Payment menu?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                        if (result == DialogResult.Yes) dashboard.showUserControls(dashboard.userControl[5]);
                    }
                    else
                    {
                        MessageBox.Show("Please agree to the terms and conditions to proceed to the Payment Menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    SetUpdatePaymentMethod(cmbPaymentMethod.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Button Pay: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel this Transaction?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


            if (result == DialogResult.Yes) dashboard.showUserControls(dashboard.userControl[0]);

            cmbPaymentMethod.SelectedIndex = -1;
            schedule.ShowAll();
            cbTermsAndConditions.Checked = false;
        }
    }
}
