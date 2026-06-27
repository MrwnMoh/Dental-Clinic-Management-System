namespace DCMS.User.Forms
{
    partial class frmUserDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSavePerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucUserDetails1 = new DCMS.User.Ucs.ucUserDetails();
            this.ucFilterDetailsWithSerch1 = new DCMS.People.Person.ucFilterDetailsWithSerch();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Animated = true;
            this.btnSavePerson.BorderRadius = 8;
            this.btnSavePerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSavePerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSavePerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSavePerson.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSavePerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSavePerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.btnSavePerson.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(106)))), ((int)(((byte)(253)))));
            this.btnSavePerson.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold);
            this.btnSavePerson.ForeColor = System.Drawing.Color.White;
            this.btnSavePerson.Location = new System.Drawing.Point(648, 987);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(183, 58);
            this.btnSavePerson.TabIndex = 52;
            this.btnSavePerson.Tag = "Dashboard";
            this.btnSavePerson.Text = "Back";
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(801, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Helvetica Rounded", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblCaption.Location = new System.Drawing.Point(12, 10);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(194, 34);
            this.lblCaption.TabIndex = 50;
            this.lblCaption.Text = "User Details";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Person Details :";
            // 
            // ucUserDetails1
            // 
            this.ucUserDetails1.BackColor = System.Drawing.Color.Transparent;
            this.ucUserDetails1.Location = new System.Drawing.Point(10, 730);
            this.ucUserDetails1.Name = "ucUserDetails1";
            this.ucUserDetails1.Size = new System.Drawing.Size(821, 251);
            this.ucUserDetails1.TabIndex = 54;
            // 
            // ucFilterDetailsWithSerch1
            // 
            this.ucFilterDetailsWithSerch1.BackColor = System.Drawing.Color.Transparent;
            this.ucFilterDetailsWithSerch1.Location = new System.Drawing.Point(10, 98);
            this.ucFilterDetailsWithSerch1.Name = "ucFilterDetailsWithSerch1";
            this.ucFilterDetailsWithSerch1.Size = new System.Drawing.Size(821, 611);
            this.ucFilterDetailsWithSerch1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(14, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "User Details :";
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 1053);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucUserDetails1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.ucFilterDetailsWithSerch1);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnSavePerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCaption;
        private People.Person.ucFilterDetailsWithSerch ucFilterDetailsWithSerch1;
        private System.Windows.Forms.Label label1;
        private Ucs.ucUserDetails ucUserDetails1;
        private System.Windows.Forms.Label label2;
    }
}