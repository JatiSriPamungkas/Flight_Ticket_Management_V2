namespace Flight_Ticket_Management_V2
{
    partial class ScheduleDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.lblAirline = new System.Windows.Forms.Label();
            this.lblAircraftType = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.circleArrival = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleDeparture = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblLine = new System.Windows.Forms.Label();
            this.picArrival = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picDeparture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNext = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmPlaneAnimation = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeparture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 40;
            this.mainPanel.Controls.Add(this.guna2CustomGradientPanel1);
            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Controls.Add(this.btnNext);
            this.mainPanel.Controls.Add(this.label13);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.BorderRadius = 40;
            this.mainPanel.ShadowDecoration.Depth = 10;
            this.mainPanel.ShadowDecoration.Enabled = true;
            this.mainPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.mainPanel.Size = new System.Drawing.Size(1292, 772);
            this.mainPanel.TabIndex = 21;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 40;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblEstimate);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblAirline);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblAircraftType);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblArrivalTime);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblDestination);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblDepartureTime);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblOrigin);
            this.guna2CustomGradientPanel1.Controls.Add(this.circleArrival);
            this.guna2CustomGradientPanel1.Controls.Add(this.circleDeparture);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblLine);
            this.guna2CustomGradientPanel1.Controls.Add(this.picArrival);
            this.guna2CustomGradientPanel1.Controls.Add(this.picDeparture);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(53, 115);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1185, 541);
            this.guna2CustomGradientPanel1.TabIndex = 49;
            // 
            // lblEstimate
            // 
            this.lblEstimate.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(423, 234);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(342, 41);
            this.lblEstimate.TabIndex = 61;
            this.lblEstimate.Text = "0 h 0 m";
            this.lblEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAirline
            // 
            this.lblAirline.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirline.Location = new System.Drawing.Point(423, 275);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(342, 41);
            this.lblAirline.TabIndex = 60;
            this.lblAirline.Text = "Airline";
            this.lblAirline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAircraftType
            // 
            this.lblAircraftType.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAircraftType.Location = new System.Drawing.Point(423, 342);
            this.lblAircraftType.Name = "lblAircraftType";
            this.lblAircraftType.Size = new System.Drawing.Size(342, 41);
            this.lblAircraftType.TabIndex = 59;
            this.lblAircraftType.Text = "Aircraft Type";
            this.lblAircraftType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(952, 419);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(221, 41);
            this.lblArrivalTime.TabIndex = 58;
            this.lblArrivalTime.Text = "00:00";
            this.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestination
            // 
            this.lblDestination.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(952, 378);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(221, 41);
            this.lblDestination.TabIndex = 57;
            this.lblDestination.Text = "Destination";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(3, 419);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(221, 41);
            this.lblDepartureTime.TabIndex = 56;
            this.lblDepartureTime.Text = "00:00";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigin
            // 
            this.lblOrigin.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigin.Location = new System.Drawing.Point(4, 378);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(221, 41);
            this.lblOrigin.TabIndex = 53;
            this.lblOrigin.Text = "Origin";
            this.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circleArrival
            // 
            this.circleArrival.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.circleArrival.BorderThickness = 2;
            this.circleArrival.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.circleArrival.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.circleArrival.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.circleArrival.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.circleArrival.FillColor = System.Drawing.Color.Transparent;
            this.circleArrival.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.circleArrival.ForeColor = System.Drawing.Color.White;
            this.circleArrival.Location = new System.Drawing.Point(985, 319);
            this.circleArrival.Name = "circleArrival";
            this.circleArrival.PressedColor = System.Drawing.Color.Transparent;
            this.circleArrival.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleArrival.Size = new System.Drawing.Size(20, 20);
            this.circleArrival.TabIndex = 55;
            // 
            // circleDeparture
            // 
            this.circleDeparture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.circleDeparture.BorderThickness = 2;
            this.circleDeparture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.circleDeparture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.circleDeparture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.circleDeparture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.circleDeparture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.circleDeparture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.circleDeparture.ForeColor = System.Drawing.Color.White;
            this.circleDeparture.Location = new System.Drawing.Point(177, 319);
            this.circleDeparture.Name = "circleDeparture";
            this.circleDeparture.PressedColor = System.Drawing.Color.Transparent;
            this.circleDeparture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleDeparture.Size = new System.Drawing.Size(20, 20);
            this.circleDeparture.TabIndex = 54;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.lblLine.Location = new System.Drawing.Point(194, 328);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(791, 2);
            this.lblLine.TabIndex = 53;
            this.lblLine.Text = "sadf";
            // 
            // picArrival
            // 
            this.picArrival.FillColor = System.Drawing.Color.Transparent;
            this.picArrival.Image = global::Flight_Ticket_Management_V2.Properties.Resources.Icon__11_;
            this.picArrival.ImageRotate = 0F;
            this.picArrival.Location = new System.Drawing.Point(1011, 275);
            this.picArrival.Name = "picArrival";
            this.picArrival.Size = new System.Drawing.Size(100, 100);
            this.picArrival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrival.TabIndex = 51;
            this.picArrival.TabStop = false;
            // 
            // picDeparture
            // 
            this.picDeparture.FillColor = System.Drawing.Color.Transparent;
            this.picDeparture.Image = global::Flight_Ticket_Management_V2.Properties.Resources.Icon__9_;
            this.picDeparture.ImageRotate = 0F;
            this.picDeparture.Location = new System.Drawing.Point(74, 275);
            this.picDeparture.Name = "picDeparture";
            this.picDeparture.Size = new System.Drawing.Size(100, 100);
            this.picDeparture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeparture.TabIndex = 50;
            this.picDeparture.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnBack.BorderSize = 2;
            this.btnBack.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBack.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBack.CheckedForeColor = System.Drawing.Color.White;
            this.btnBack.CheckedImage = null;
            this.btnBack.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnBack.Image = null;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnBack.Location = new System.Drawing.Point(53, 682);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnBack.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 15;
            this.btnBack.Size = new System.Drawing.Size(200, 50);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.UseTransfarantBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNext.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNext.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext.CheckedImage = null;
            this.btnNext.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNext.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNext.Image = null;
            this.btnNext.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNext.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnNext.Location = new System.Drawing.Point(1038, 682);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnNext.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 15;
            this.btnNext.Size = new System.Drawing.Size(200, 50);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.UseTransfarantBackground = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(314, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(982, 2);
            this.label13.TabIndex = 12;
            this.label13.Text = "sadf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detail Schedule";
            // 
            // tmPlaneAnimation
            // 
            this.tmPlaneAnimation.Tick += new System.EventHandler(this.tmPlaneAnimation_Tick);
            // 
            // ScheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ScheduleDetails";
            this.Size = new System.Drawing.Size(1292, 772);
            this.Load += new System.EventHandler(this.ScheduleDetails_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeparture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.Label lblAircraftType;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblOrigin;
        private Guna.UI2.WinForms.Guna2CircleButton circleArrival;
        private Guna.UI2.WinForms.Guna2CircleButton circleDeparture;
        private System.Windows.Forms.Label lblLine;
        private Guna.UI2.WinForms.Guna2PictureBox picArrival;
        private Guna.UI2.WinForms.Guna2PictureBox picDeparture;
        private Guna.UI.WinForms.GunaAdvenceButton btnBack;
        private Guna.UI.WinForms.GunaAdvenceButton btnNext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmPlaneAnimation;
    }
}
