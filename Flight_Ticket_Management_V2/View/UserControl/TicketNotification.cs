using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_Management_V2
{
    public partial class TicketNotification : UserControl
    {
        private Dashboard dashboard;
        public TicketNotification(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        public void SetPNRCode(string code)
        {
            lblPNRCode.Text = code;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            dashboard.lblGreetings.Text = "Good " + dashboard.time() + ", {user}";
            dashboard.register.ResetForm();
            dashboard.changedButtonColor("register");
            dashboard.schedule.ShowAll();
            dashboard.nullPicture();
            dashboard.register.isFormNotLocked(true);
            dashboard.showUserControls(dashboard.userControl[0]);
        }
    }
}
