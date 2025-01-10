namespace Flight_Ticket_Management_V2
{
    partial class Schedule
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Garuda Indonesia",
            "GA-241",
            "20:00",
            "22:00",
            "1000000",
            "Soekarno-Hatta",
            "Yogyakarta"}, -1);
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnFilter = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnShowAll = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSelect = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lvwSchedule = new System.Windows.Forms.ListView();
            this.columnNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAirlines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAircraftType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 40;
            this.mainPanel.Controls.Add(this.btnFilter);
            this.mainPanel.Controls.Add(this.btnShowAll);
            this.mainPanel.Controls.Add(this.btnSelect);
            this.mainPanel.Controls.Add(this.lvwSchedule);
            this.mainPanel.Controls.Add(this.label13);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.BorderRadius = 40;
            this.mainPanel.ShadowDecoration.Depth = 10;
            this.mainPanel.ShadowDecoration.Enabled = true;
            this.mainPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.mainPanel.Size = new System.Drawing.Size(1292, 772);
            this.mainPanel.TabIndex = 19;
            // 
            // btnFilter
            // 
            this.btnFilter.AnimationHoverSpeed = 0.07F;
            this.btnFilter.AnimationSpeed = 0.03F;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BaseColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnFilter.BorderSize = 2;
            this.btnFilter.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFilter.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFilter.CheckedForeColor = System.Drawing.Color.White;
            this.btnFilter.CheckedImage = null;
            this.btnFilter.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFilter.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnFilter.Image = null;
            this.btnFilter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFilter.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnFilter.Location = new System.Drawing.Point(261, 682);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnFilter.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnFilter.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnFilter.OnHoverImage = null;
            this.btnFilter.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnFilter.OnPressedColor = System.Drawing.Color.Black;
            this.btnFilter.Radius = 15;
            this.btnFilter.Size = new System.Drawing.Size(200, 50);
            this.btnFilter.TabIndex = 49;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilter.UseTransfarantBackground = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.AnimationHoverSpeed = 0.07F;
            this.btnShowAll.AnimationSpeed = 0.03F;
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BaseColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnShowAll.BorderSize = 2;
            this.btnShowAll.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShowAll.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShowAll.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowAll.CheckedImage = null;
            this.btnShowAll.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShowAll.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnShowAll.Image = null;
            this.btnShowAll.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShowAll.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnShowAll.Location = new System.Drawing.Point(53, 682);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnShowAll.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnShowAll.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnShowAll.OnHoverImage = null;
            this.btnShowAll.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnShowAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowAll.Radius = 15;
            this.btnShowAll.Size = new System.Drawing.Size(200, 50);
            this.btnShowAll.TabIndex = 48;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowAll.UseTransfarantBackground = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.AnimationHoverSpeed = 0.07F;
            this.btnSelect.AnimationSpeed = 0.03F;
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnSelect.BorderColor = System.Drawing.Color.Black;
            this.btnSelect.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSelect.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSelect.CheckedForeColor = System.Drawing.Color.White;
            this.btnSelect.CheckedImage = null;
            this.btnSelect.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSelect.Image = null;
            this.btnSelect.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelect.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnSelect.Location = new System.Drawing.Point(1038, 682);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnSelect.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnSelect.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSelect.OnHoverImage = null;
            this.btnSelect.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnSelect.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelect.Radius = 15;
            this.btnSelect.Size = new System.Drawing.Size(200, 50);
            this.btnSelect.TabIndex = 47;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelect.UseTransfarantBackground = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lvwSchedule
            // 
            this.lvwSchedule.BackColor = System.Drawing.Color.White;
            this.lvwSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNo,
            this.columnAirlines,
            this.columnAircraftType,
            this.columnDepartureTime,
            this.columnArrivalTime,
            this.columnPrice,
            this.columnOrigin,
            this.columnDestination});
            this.lvwSchedule.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSchedule.FullRowSelect = true;
            this.lvwSchedule.GridLines = true;
            this.lvwSchedule.HideSelection = false;
            this.lvwSchedule.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lvwSchedule.Location = new System.Drawing.Point(53, 115);
            this.lvwSchedule.MultiSelect = false;
            this.lvwSchedule.Name = "lvwSchedule";
            this.lvwSchedule.Size = new System.Drawing.Size(1185, 541);
            this.lvwSchedule.TabIndex = 15;
            this.lvwSchedule.UseCompatibleStateImageBehavior = false;
            this.lvwSchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnNo
            // 
            this.columnNo.Text = "No";
            this.columnNo.Width = 54;
            // 
            // columnAirlines
            // 
            this.columnAirlines.Text = "Airlines";
            this.columnAirlines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAirlines.Width = 198;
            // 
            // columnAircraftType
            // 
            this.columnAircraftType.Text = "Aircraft Type";
            this.columnAircraftType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAircraftType.Width = 157;
            // 
            // columnDepartureTime
            // 
            this.columnDepartureTime.Text = "Departure Time";
            this.columnDepartureTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDepartureTime.Width = 167;
            // 
            // columnArrivalTime
            // 
            this.columnArrivalTime.Text = "Arrival Time";
            this.columnArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnArrivalTime.Width = 140;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrice.Width = 119;
            // 
            // columnOrigin
            // 
            this.columnOrigin.Text = "Origin";
            this.columnOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOrigin.Width = 158;
            // 
            // columnDestination
            // 
            this.columnDestination.Text = "Destination";
            this.columnDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDestination.Width = 184;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(216, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1080, 2);
            this.label13.TabIndex = 12;
            this.label13.Text = "sadf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Schedule";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(1292, 772);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwSchedule;
        private Guna.UI.WinForms.GunaAdvenceButton btnFilter;
        private Guna.UI.WinForms.GunaAdvenceButton btnShowAll;
        private Guna.UI.WinForms.GunaAdvenceButton btnSelect;
        private System.Windows.Forms.ColumnHeader columnAirlines;
        private System.Windows.Forms.ColumnHeader columnAircraftType;
        private System.Windows.Forms.ColumnHeader columnDepartureTime;
        private System.Windows.Forms.ColumnHeader columnArrivalTime;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnOrigin;
        private System.Windows.Forms.ColumnHeader columnDestination;
        private System.Windows.Forms.ColumnHeader columnNo;
    }
}
