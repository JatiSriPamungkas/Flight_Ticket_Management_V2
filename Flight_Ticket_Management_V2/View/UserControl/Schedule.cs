using Flight_Ticket_Management_V2.Controller;
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
    public partial class Schedule : UserControl
    {
        private Dashboard dashboard;
        public List<ScheduleEntity> listOfSchedule = new List<ScheduleEntity>();
        private ScheduleController scheduleController;
        private Register register;
        private ScheduleDetails scheduleDetails;

        public Schedule(Dashboard dashboard, Register register, ScheduleDetails scheduleDetails)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.register = register;
            this.scheduleDetails = scheduleDetails;

            scheduleController = new ScheduleController();

            LoadScheduleData();
        }

        private void LoadScheduleData()
        {
            // kosongkan listview
            lvwSchedule.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfSchedule = scheduleController.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var schedule in listOfSchedule)
            {
                var noUrut = lvwSchedule.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(schedule.Airline);
                item.SubItems.Add(schedule.AircraftType);
                item.SubItems.Add(schedule.DepartureTime);
                item.SubItems.Add(schedule.ArrivalTime);
                item.SubItems.Add(schedule.Price.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp "));
                item.SubItems.Add(schedule.Origin);
                item.SubItems.Add(schedule.Destination);

                // tampilkan data mhs ke listview
                lvwSchedule.Items.Add(item);
            }
        }

        public void ShowAll()
        {
            // kosongkan listview
            lvwSchedule.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfSchedule = scheduleController.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var schedule in listOfSchedule)
            {
                var noUrut = lvwSchedule.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(schedule.Airline);
                item.SubItems.Add(schedule.AircraftType);
                item.SubItems.Add(schedule.DepartureTime);
                item.SubItems.Add(schedule.ArrivalTime);
                item.SubItems.Add(schedule.Price.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp "));
                item.SubItems.Add(schedule.Origin);
                item.SubItems.Add(schedule.Destination);

                // tampilkan data mhs ke listview
                lvwSchedule.Items.Add(item);
            }
        }

        private void ShowScheduleDetail(ScheduleEntity selectedSchedule)
        {
            dashboard.scheduleDetails.SetData(selectedSchedule);
            dashboard.scheduleDescriptions.SetData(selectedSchedule);
            dashboard.payment.SetData(selectedSchedule);
            dashboard.paymentVerification.SetData(selectedSchedule);
            dashboard.ticket.SetData(selectedSchedule);

            dashboard.showUserControls(dashboard.userControl[2]);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwSchedule.SelectedItems.Count > 0)
                {
                    // Mendapatkan item yang dipilih
                    ListViewItem selectedItem = lvwSchedule.SelectedItems[0];

                    // Mengakses data dari sub-item
                    ScheduleEntity selectedSchedule = new ScheduleEntity()
                    {
                        Airline = selectedItem.SubItems[1].Text,
                        AircraftType = selectedItem.SubItems[2].Text,
                        DepartureTime = selectedItem.SubItems[3].Text,
                        ArrivalTime = selectedItem.SubItems[4].Text,
                        Price = int.Parse(selectedItem.SubItems[5].Text.Replace("Rp ", "").Replace(".", "").Trim()),
                        Origin = selectedItem.SubItems[6].Text,
                        Destination = selectedItem.SubItems[7].Text
                    };
                    // Panggil metode untuk menampilkan user control selanjutnya
                    ShowScheduleDetail(selectedSchedule);
                    dashboard.scheduleDetails.ResetAnimation();
                }
                else
                {
                    MessageBox.Show("Data has not been selected!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Select Button: {ex.Message}");
            }
            // dashboard.showUserControls(dashboard.userControl[2]);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lvwSchedule.Items.Clear();
            listOfSchedule = scheduleController.ReadByOriginAndDestination(register.cmbDeparture.SelectedItem?.ToString(), register.cmbArrival.SelectedItem?.ToString());

            foreach (var schedule in listOfSchedule)
            {
                var noUrut = lvwSchedule.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(schedule.Airline);
                item.SubItems.Add(schedule.AircraftType);
                item.SubItems.Add(schedule.DepartureTime);
                item.SubItems.Add(schedule.ArrivalTime);
                item.SubItems.Add(schedule.Price.ToString("C0", new CultureInfo("id_ID")).Replace("Rp", "Rp "));
                item.SubItems.Add(schedule.Origin);
                item.SubItems.Add(schedule.Destination);

                //tampilkan isi jadwal ke lvw
                lvwSchedule.Items.Add(item);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
    }
}
