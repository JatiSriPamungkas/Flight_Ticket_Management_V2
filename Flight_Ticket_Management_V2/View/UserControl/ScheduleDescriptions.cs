using Flight_Ticket_Management_V2.Model.Entity;
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
    public partial class ScheduleDescriptions : UserControl
    {
        private Dashboard dashboard;
        public ScheduleDescriptions(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        public void SetData(ScheduleEntity schedule)
        {
            lblRefundAirline.Text = schedule.Airline;
            lblRefundOriginAndDestination.Text = schedule.Origin + " -----> " + schedule.Destination;

            lblRescheduleAirline.Text = schedule.Airline;
            lblRescheduleOriginAndDestination.Text = schedule.Origin + " -----> " + schedule.Destination;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dashboard.isScheduled = true;

            dashboard.changedButtonColor("payment");

            dashboard.showUserControls(dashboard.userControl[4]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard.scheduleDetails.ResetAnimation();

            dashboard.showUserControls(dashboard.userControl[2]);
        }
    }
}
