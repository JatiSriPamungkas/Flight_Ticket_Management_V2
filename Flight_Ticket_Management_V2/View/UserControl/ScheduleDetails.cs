using Flight_Ticket_Management_V2.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Flight_Ticket_Management_V2
{
    public partial class ScheduleDetails : UserControl
    {
        private Dashboard dashboard;

        float time = 0;          // Waktu (dalam detik)
        float Vx = 65f;           // Kecepatan horizontal
        float Vy = 70f;          // Kecepatan vertikal awal
        float gravity = 9.8f;    // Gravitasi
        Point initialPosition;   // Posisi awal panel

        public ScheduleDetails(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;

            initialPosition = picDeparture.Location; // Simpan posisi awal
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

        public void ResetAnimation()
        {
            // reset picture ke posisi awal
            time = 0;
            picDeparture.Location = initialPosition;
            circleDeparture.Location = new Point(177, 319);

            //reset line ke posisi awal
            lblLine.Size = new Size(791, 2); // restart size line
            lblLine.Location = new Point(194, 328); // restart lokasi line
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[3]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard.showUserControls(dashboard.userControl[1]);
        }

        private void ScheduleDetails_Load(object sender, EventArgs e)
        {
            tmPlaneAnimation.Interval = 1;
            tmPlaneAnimation.Enabled = true;
            tmPlaneAnimation.Tick += tmPlaneAnimation_Tick;
        }

        private void tmPlaneAnimation_Tick(object sender, EventArgs e)
        {
            // Plane Picture
            Point currentPicDeparturePosition = picDeparture.Location;

            // Circle
            Point currentCircleDeparturePosition = circleDeparture.Location;

            // Line
            Point currentlblLinePosition = lblLine.Location;
            Size currentlblLineSize = lblLine.Size;

            int newReducedLine = currentlblLineSize.Width - 12;
            int newLineX = currentlblLinePosition.X + 12;

            int newCircleX = currentCircleDeparturePosition.X + 12;

            // Parabolik Animation
            // Hitung posisi baru
            float newX = initialPosition.X + Vx * time;
            float newY = initialPosition.Y - (Vy * time) + (0.5f * gravity * time * time);

            // Update posisi panel
            picDeparture.Location = new Point((int)newX, (int)newY);

            // Tambah waktu
            time += 0.2f; // Inkrement waktu (dalam detik)

            // Deteksi jika panel menyentuh tanah atau keluar layar
            if (picDeparture.Bottom >= this.ClientSize.Height || picDeparture.Left >= this.ClientSize.Width)
            {
                // Restart gerakan
                time = 0;
                picDeparture.Location = initialPosition;
            }
            if (picDeparture.Bounds.IntersectsWith(picArrival.Bounds))
            {
                time = 0;
                picDeparture.Location = initialPosition;
                circleDeparture.Location = new Point(177, 319);
            }
            if (newReducedLine < 10)
            {
                lblLine.Size = new Size(791, 2); // restart size line
                lblLine.Location = new Point(194, 328); // restart lokasi line
                return;
            }

            lblLine.Size = new Size(newReducedLine, 2); // berkurang
            lblLine.Location = new Point(newLineX, 328); // geser
            circleDeparture.Location = new Point(newCircleX, 319); // geser
        }
    }
}
