using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_Management_V2
{
    public partial class Dashboard : Form
    {
        public UserControl[] userControl;

        public Register register;
        public Schedule schedule;
        public ScheduleDetails scheduleDetails;
        public ScheduleDescriptions scheduleDescriptions;
        public Payment payment;
        public PaymentVerification paymentVerification;
        public Ticket ticket;
        public TicketNotification TicketNotification;

        public bool isRegistered = false;
        public bool isScheduled = false;
        public bool isPayment = false;

        public Dashboard()
        {
            register = new Register(this, schedule);
            schedule = new Schedule(this, register, scheduleDetails);
            scheduleDetails = new ScheduleDetails(this);
            scheduleDescriptions = new ScheduleDescriptions(this);
            payment = new Payment(this, schedule, paymentVerification);
            paymentVerification = new PaymentVerification(this, payment);
            ticket = new Ticket(this);
            TicketNotification = new TicketNotification(this);

            InitializeComponent();

            userControl = new UserControl[] {
                register, // [0]
                schedule, // [1]
                scheduleDetails, // [2]
                scheduleDescriptions, // [3]
                payment, // [4]
                paymentVerification, // [5]
                ticket, // [6]
                TicketNotification // [7]
            };

            changedButtonColor("register");
            stackControls();
            showUserControls(userControl[0]);
        }

        public void stackControls()
        {
            foreach (Control control in userControl)
            {
                control.Dock = DockStyle.Fill;
                control.Visible = false;
                mainPanel.Controls.Add(control);
            }
        }

        public void showUserControls(UserControl control)
        {
            foreach (UserControl hideControl in userControl) hideControl.Visible = false;

            control.Visible = true;
            control.BringToFront();
        }

        public void changedButtonColor(string btnName)
        {
            if (btnName == "register")
            {
                // Register Button Styling
                // ON
                btnRegister.BaseColor = Color.FromArgb(32, 114, 184);
                btnRegister.ForeColor = Color.FromArgb(230, 230, 230);

                btnSchedule.ForeColor = Color.FromArgb(32, 114, 184);
                btnSchedule.BaseColor = Color.White;

                btnPayment.ForeColor = Color.FromArgb(32, 114, 184);
                btnPayment.BaseColor = Color.White;

                btnTicket.ForeColor = Color.FromArgb(32, 114, 184);
                btnTicket.BaseColor = Color.White;
            } else if (btnName == "schedule")
            {
                // Schedule Button Styling
                // ON
                btnSchedule.BaseColor = Color.FromArgb(32, 114, 184);
                btnSchedule.ForeColor = Color.FromArgb(230, 230, 230);

                btnRegister.ForeColor = Color.FromArgb(32, 114, 184);
                btnRegister.BaseColor = Color.White;

                btnPayment.ForeColor = Color.FromArgb(32, 114, 184);
                btnPayment.BaseColor = Color.White;

                btnTicket.ForeColor = Color.FromArgb(32, 114, 184);
                btnTicket.BaseColor = Color.White;
            }
            else if (btnName == "payment")
            {
                // Payment Button Styling
                // ON
                btnPayment.BaseColor = Color.FromArgb(32, 114, 184);
                btnPayment.ForeColor = Color.FromArgb(230, 230, 230);

                btnRegister.ForeColor = Color.FromArgb(32, 114, 184);
                btnRegister.BaseColor = Color.White;

                btnSchedule.ForeColor = Color.FromArgb(32, 114, 184);
                btnSchedule.BaseColor = Color.White;

                btnTicket.ForeColor = Color.FromArgb(32, 114, 184);
                btnTicket.BaseColor = Color.White;
            } else if (btnName == "ticket")
            {
                // Ticket Button Styling
                // ON
                btnTicket.BaseColor = Color.FromArgb(32, 114, 184);
                btnTicket.ForeColor = Color.FromArgb(230, 230, 230);

                btnRegister.ForeColor = Color.FromArgb(32, 114, 184);
                btnRegister.BaseColor = Color.White;

                btnSchedule.ForeColor = Color.FromArgb(32, 114, 184);
                btnSchedule.BaseColor = Color.White;

                btnPayment.ForeColor = Color.FromArgb(32, 114, 184);
                btnPayment.BaseColor = Color.White;
            }
        }

        public string time()
        {
            DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;

            string timePeriod;

            if (hour >= 6 && hour <= 12)
            {
                timePeriod = "Morning";
            } 
            else if (hour >= 13 && hour <= 16)
            {
                timePeriod = "Afternoon";
            }
            else if (hour >= 17 && hour <= 19)
            {
                timePeriod = "Evening";
            } else
            {
                timePeriod = "Night";
            }

            return timePeriod;
        }

        public void SetPassengerName(string name)
        {
            lblGreetings.Text = "Good " + time() + ", " + name;
        }

        public void femalePicture()
        {
            picProfile.Image = Properties.Resources.girlPhoto;

            picProfile.Size = new Size(130,130);
            picProfile.Location = new Point(1740, 86);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        public void malePicture()
        {
            picProfile.Image = Properties.Resources.Icon__6_;

            picProfile.Size = new Size(130, 130);
            picProfile.Location = new Point(1740, 86);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void nullPicture()
        {
            picProfile.Image = Properties.Resources.nullPhoto;

            picProfile.Size = new Size(130, 130);
            picProfile.Location = new Point(1740, 86);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Move(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            showUserControls(userControl[0]);

            changedButtonColor("register");
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (isRegistered == true)
            {
                showUserControls(userControl[1]);

                changedButtonColor("schedule");
            } else
            {
                MessageBox.Show("Please fill the Form in Register menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (isRegistered == true && isScheduled == true)
            {
                showUserControls(userControl[4]);

                changedButtonColor("payment");
            }
            else
            {
                if (isRegistered == false) MessageBox.Show("Please fill the Form in Register menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (isScheduled == false) MessageBox.Show("Please select the flight in Schedule menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (isRegistered == true && isScheduled == true && isPayment == true)
            {
                showUserControls(userControl[6]);

                changedButtonColor("ticket");
            }
            else
            {
                if (isRegistered == false) MessageBox.Show("Please fill the Form in Register menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (isScheduled == false) MessageBox.Show("Please select the flight in Schedule menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (isPayment == false) MessageBox.Show("Please pay the ticket in payment menu!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
