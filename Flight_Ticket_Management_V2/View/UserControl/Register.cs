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
    public partial class Register : UserControl
    {
        private Dashboard dashboard;
        private DateTime? nullableDate = null;
        public List<Passenger> listOfPassenger = new List<Passenger>();
        private Schedule schedule;

        public Register(Dashboard dashboard, Schedule schedule)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.schedule = schedule;
        }

        public void ResetForm()
        {
            txtIdentityNumber.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            dtmDateOfBirth.CustomFormat = " ";
            nullableDate = null;
            dtmDateOfBirth.Format = DateTimePickerFormat.Custom;

            rdbMale.Checked = false;
            rdbFemale.Checked = false;

            txtStreetAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPostal.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            cmbNationality.SelectedIndex = -1;
            cmbDeparture.SelectedIndex = -1;
            cmbArrival.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbPassenger.SelectedIndex = -1;
        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private string GetSelectedRadioButtonText()
        {
            if (rdbMale.Checked) return rdbMale.Text;
            if (rdbFemale.Checked) return rdbFemale.Text;

            return null;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtIdentityNumber.Text))
            {
                MessageBox.Show("Identity Number has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First Name has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last Name has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtmDateOfBirth.CustomFormat == " ")
            {
                MessageBox.Show("Date Of Birth has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (GetSelectedRadioButtonText() == null)
            {
                MessageBox.Show("Gender has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtStreetAddress.Text))
            {
                MessageBox.Show("Street Address has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtRegion.Text))
            {
                MessageBox.Show("Region has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtPostal.Text))
            {
                MessageBox.Show("Postal has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                MessageBox.Show("Country has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbNationality.SelectedIndex == -1)
            {
                MessageBox.Show("Nationality has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbDeparture.SelectedIndex == -1)
            {
                MessageBox.Show("Departure has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbArrival.SelectedIndex == -1)
            {
                MessageBox.Show("Arrival has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Class has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbPassenger.SelectedIndex == -1)
            {
                MessageBox.Show("Passenger(s) has not been filled in!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void GetPassengerName(string name)
        {
            dashboard.SetPassengerName(name);
        }

        public void PhotoProfileValidation()
        {
            if (GetSelectedRadioButtonText() == "Male") dashboard.malePicture();
            else dashboard.femalePicture();
        }

        private void isFormNotLocked(bool lockedForm)
        {
            txtIdentityNumber.Enabled = lockedForm;
            txtFirstName.Enabled = lockedForm;
            txtLastName.Enabled = lockedForm;

            dtmDateOfBirth.Enabled = lockedForm;

            rdbMale.Enabled = lockedForm;
            rdbFemale.Enabled = lockedForm;

            txtStreetAddress.Enabled = lockedForm;
            txtCity.Enabled = lockedForm;
            txtPostal.Enabled = lockedForm;
            txtCountry.Enabled = lockedForm;
            txtRegion.Enabled = lockedForm;
            txtPhone.Enabled     = lockedForm;
            txtEmail.Enabled = lockedForm;

            cmbNationality.Enabled = lockedForm;
            cmbDeparture.Enabled = lockedForm;
            cmbArrival.Enabled = lockedForm;
            cmbClass.Enabled = lockedForm;
            cmbPassenger.Enabled = lockedForm;

            btnSave.Enabled = lockedForm;
            btnReset.Enabled = lockedForm;
            btnEdit.Enabled = !lockedForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    Passenger passenger = new Passenger();

                    passenger.IdentityNumber = txtIdentityNumber.Text;
                    passenger.FirstName = txtFirstName.Text;
                    passenger.Lastname = txtLastName.Text;
                    passenger.DateOfBirth = dtmDateOfBirth.Value.ToString();
                    passenger.Gender = GetSelectedRadioButtonText();
                    passenger.StreetAddress = txtStreetAddress.Text;
                    passenger.City = txtCity.Text;
                    passenger.Region = txtRegion.Text;
                    passenger.Postal = txtPostal.Text;
                    passenger.Country= txtCountry.Text;
                    passenger.Phone = txtPhone.Text;
                    passenger.Email = txtEmail.Text;
                    passenger.Nationality = cmbNationality.Text;
                    passenger.Departure = cmbDeparture.SelectedItem.ToString();
                    passenger.Arrival = cmbArrival.SelectedItem.ToString();
                    passenger.Class = cmbClass.SelectedItem.ToString();
                    passenger.Passengers = cmbPassenger.SelectedItem.ToString();

                    listOfPassenger.Add(passenger);

                    MessageBox.Show("All forms have been filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard.isRegistered = true;
                    PhotoProfileValidation();
                    isFormNotLocked(false);
                    GetPassengerName(txtFirstName.Text + " " + txtLastName.Text);
                    dashboard.changedButtonColor("schedule");
                    dashboard.showUserControls(dashboard.userControl[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Register: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dtmDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dtmDateOfBirth.CustomFormat = "";
            nullableDate = dtmDateOfBirth.Value;
            dtmDateOfBirth.Format = DateTimePickerFormat.Long;
        }

        private void txtIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void txtPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void cmbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDeparture = cmbDeparture.SelectedItem?.ToString();

            cmbArrival.SelectedIndexChanged -= cmbArrival_SelectedIndexChanged;

            cmbArrival.Items.Clear();
            foreach (var item in cmbDeparture.Items)
            {
                if (item.ToString() != selectedDeparture) // Hindari item yang sama
                {
                    cmbArrival.Items.Add(item);
                }
            }

            cmbArrival.SelectedIndexChanged += cmbArrival_SelectedIndexChanged;
        }

        private void cmbArrival_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Edit the Form?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if (result == DialogResult.Yes) isFormNotLocked(true);
        }
    }
}
