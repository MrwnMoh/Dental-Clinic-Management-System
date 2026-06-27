namespace DCMS.People.Forms
{
    partial class frmPersonDetails
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
            this.label9 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnSavePerson = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucFilterDetailsWithSerch1 = new DCMS.People.Person.ucFilterDetailsWithSerch();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(801, 19);
            this.label9.TabIndex = 46;
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
            this.lblCaption.Location = new System.Drawing.Point(12, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(227, 34);
            this.lblCaption.TabIndex = 45;
            this.lblCaption.Text = "Person Details";
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
            this.btnSavePerson.Location = new System.Drawing.Point(649, 693);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(183, 58);
            this.btnSavePerson.TabIndex = 48;
            this.btnSavePerson.Tag = "Dashboard";
            this.btnSavePerson.Text = "Back";
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // ucFilterDetailsWithSerch1
            // 
            this.ucFilterDetailsWithSerch1.BackColor = System.Drawing.Color.Transparent;
            this.ucFilterDetailsWithSerch1.Location = new System.Drawing.Point(11, 76);
            this.ucFilterDetailsWithSerch1.Name = "ucFilterDetailsWithSerch1";
            this.ucFilterDetailsWithSerch1.Size = new System.Drawing.Size(821, 611);
            this.ucFilterDetailsWithSerch1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 762);
            this.Controls.Add(this.btnSavePerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.ucFilterDetailsWithSerch1);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Person.ucFilterDetailsWithSerch ucFilterDetailsWithSerch1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCaption;
        private Guna.UI2.WinForms.Guna2GradientButton btnSavePerson;
    }
}