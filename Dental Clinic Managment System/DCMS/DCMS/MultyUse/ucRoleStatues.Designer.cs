namespace DCMS.People
{
    partial class ucRoleStatues
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
            this.plBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.plBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBackground
            // 
            this.plBackground.BorderRadius = 10;
            this.plBackground.Controls.Add(this.lblRole);
            this.plBackground.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(229)))));
            this.plBackground.Location = new System.Drawing.Point(0, 0);
            this.plBackground.Name = "plBackground";
            this.plBackground.Size = new System.Drawing.Size(118, 45);
            this.plBackground.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(45)))));
            this.lblRole.Location = new System.Drawing.Point(21, 9);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(77, 25);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Admin";
            // 
            // ucRoleStatues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.plBackground);
            this.Name = "ucRoleStatues";
            this.Size = new System.Drawing.Size(118, 45);
            this.plBackground.ResumeLayout(false);
            this.plBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel plBackground;
        private System.Windows.Forms.Label lblRole;
    }
}
