namespace Flight_Ticket_Management_V2
{
    partial class PaymentVerification
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
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblPaymentCode = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransferred = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 40;
            this.mainPanel.Controls.Add(this.guna2CustomGradientPanel1);
            this.mainPanel.Controls.Add(this.btnTransferred);
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
            this.guna2CustomGradientPanel1.Controls.Add(this.lblPaymentCode);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblPaymentMethod);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTotal);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(53, 115);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1185, 541);
            this.guna2CustomGradientPanel1.TabIndex = 49;
            // 
            // lblPaymentCode
            // 
            this.lblPaymentCode.Font = new System.Drawing.Font("Quicksand", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentCode.Location = new System.Drawing.Point(0, 321);
            this.lblPaymentCode.Name = "lblPaymentCode";
            this.lblPaymentCode.Size = new System.Drawing.Size(1182, 107);
            this.lblPaymentCode.TabIndex = 15;
            this.lblPaymentCode.Text = "XXXX-XXXX-XXXX-XXXXX";
            this.lblPaymentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(46, 227);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(61, 35);
            this.lblPaymentMethod.TabIndex = 14;
            this.lblPaymentMethod.Text = "BCA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(45, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(179, 41);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Rp 1.512.000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total";
            // 
            // btnTransferred
            // 
            this.btnTransferred.AnimationHoverSpeed = 0.07F;
            this.btnTransferred.AnimationSpeed = 0.03F;
            this.btnTransferred.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferred.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(114)))), ((int)(((byte)(184)))));
            this.btnTransferred.BorderColor = System.Drawing.Color.Black;
            this.btnTransferred.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTransferred.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTransferred.CheckedForeColor = System.Drawing.Color.White;
            this.btnTransferred.CheckedImage = null;
            this.btnTransferred.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTransferred.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTransferred.Image = null;
            this.btnTransferred.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTransferred.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnTransferred.Location = new System.Drawing.Point(356, 682);
            this.btnTransferred.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransferred.Name = "btnTransferred";
            this.btnTransferred.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnTransferred.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnTransferred.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTransferred.OnHoverImage = null;
            this.btnTransferred.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(153)))), ((int)(((byte)(203)))));
            this.btnTransferred.OnPressedColor = System.Drawing.Color.Black;
            this.btnTransferred.Radius = 15;
            this.btnTransferred.Size = new System.Drawing.Size(620, 50);
            this.btnTransferred.TabIndex = 47;
            this.btnTransferred.Text = "I Have Transferred";
            this.btnTransferred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTransferred.UseTransfarantBackground = true;
            this.btnTransferred.Click += new System.EventHandler(this.btnTransferred_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(386, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(910, 2);
            this.label13.TabIndex = 12;
            this.label13.Text = "sadf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Payment Verification";
            // 
            // PaymentVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PaymentVerification";
            this.Size = new System.Drawing.Size(1292, 772);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTransferred;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaymentCode;
    }
}
