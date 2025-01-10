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
    public partial class PaymentVerification : UserControl
    {
        private Dashboard dashboard;
        private Payment payment;
        public PaymentVerification(Dashboard dashboard, Payment payment)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.payment = payment;
        }

        public string GeneratePaymentNumber()
        {
            Random random = new Random();

            string code = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    code += random.Next(0, 10);
                }

                if (i < 3)
                {
                    code += "-";
                }
            }

            code += random.Next(0, 10);

            return lblPaymentCode.Text = code;
        }

        public void UpdatedCMBPaymentMethod(string paymentMethod)
        {
            try
            {
                lblPaymentMethod.Text = paymentMethod;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Payment Method: {ex.Message}");
            }
        }

        public void SetData(ScheduleEntity schedule)
        {
            int serviceFee = 12000;
            int totalPrice = schedule.Price + serviceFee;

            lblTotal.Text = totalPrice.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp ");
        }

        private void btnTransferred_Click(object sender, EventArgs e)
        {
            dashboard.isPayment = true;

            dashboard.payment.cmbPaymentMethod.SelectedIndex = -1;
            dashboard.payment.cbTermsAndConditions.Checked = false;


            dashboard.ticket.GeneratePNR();

            dashboard.changedButtonColor("ticket");
            dashboard.showUserControls(dashboard.userControl[6]);
        }
    }
}
