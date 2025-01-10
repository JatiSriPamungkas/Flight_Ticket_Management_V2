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
    public partial class Ticket : UserControl
    {
        private Dashboard dashboard;
        public Ticket(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        public void GetPNRCode(string code)
        {
            dashboard.TicketNotification.SetPNRCode(code);
        }

        public string GeneratePNR()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ1234567890"; // Hindari 'I', 'O', '0', '1'
            int length = 6; // Panjang PNR
            StringBuilder pnr = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                pnr.Append(chars[index]);
            }

            return lblPNRCode.Text = pnr.ToString();
        }

        public void SetData(ScheduleEntity schedule)
        {
            DateTime departure = DateTime.ParseExact(schedule.DepartureTime, "HH:mm", null);
            DateTime arrival = DateTime.ParseExact(schedule.ArrivalTime, "HH:mm", null);

            // Menghitung selisih waktu (durasi perjalanan)
            TimeSpan travelDuration = arrival - departure;

            lblAirline.Text = schedule.Airline;
            lblAircraftType.Text = schedule.AircraftType;
            lblDepartureTime.Text = schedule.DepartureTime;
            lblArrivalTime.Text = schedule.ArrivalTime;
            lblOrigin.Text = schedule.Origin;
            lblDestination.Text = schedule.Destination;
            lblEstimate.Text = travelDuration.Hours.ToString() + " hours " + travelDuration.Minutes.ToString() + " minutes ";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GetPNRCode(lblPNRCode.Text);

            dashboard.showUserControls(dashboard.userControl[7]);
        }
    }
}
