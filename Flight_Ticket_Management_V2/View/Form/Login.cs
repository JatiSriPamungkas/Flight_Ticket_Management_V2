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
    public partial class Login : Form
    {
        private Dashboard dashboard;
        public Login()
        {
            dashboard = new Dashboard();
            InitializeComponent();
        }

        private void ResetForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(52, 61, 69);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            dashboard.Close();
            Application.Exit();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                if (name == "jati" && password == "12345")
                {
                    ResetForm();
                    dashboard.Show();
                    this.Hide();
                }
                else if (name == "" && password == "")
                {
                    ResetForm();
                    MessageBox.Show("Please Fill Username and Password Column !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ResetForm();
                    MessageBox.Show("Wrong Username or Password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.Font = new Font(btnReset.Font, FontStyle.Underline);
            btnReset.ForeColor = Color.FromArgb(115, 132, 147);
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.Font = new Font(btnReset.Font, FontStyle.Regular);
            btnReset.ForeColor = Color.FromArgb(52, 61, 69);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Login_Move(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }
    }
}
