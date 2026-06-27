namespace DCMS.Treatmets
{
    partial class ucTreatentRow
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlGroupALL = new Guna.UI2.WinForms.Guna2Panel();
            this.chkSelected = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.pbPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGroupALL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblID.Location = new System.Drawing.Point(53, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 19);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "????";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblName.Location = new System.Drawing.Point(180, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 19);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "????????????";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblPrice.Location = new System.Drawing.Point(394, 23);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 19);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "?????";
            // 
            // pnlGroupALL
            // 
            this.pnlGroupALL.BorderRadius = 10;
            this.pnlGroupALL.Controls.Add(this.chkSelected);
            this.pnlGroupALL.Controls.Add(this.lblPrice);
            this.pnlGroupALL.Controls.Add(this.lblName);
            this.pnlGroupALL.Controls.Add(this.lblID);
            this.pnlGroupALL.Controls.Add(this.pbPic);
            this.pnlGroupALL.Controls.Add(this.label1);
            this.pnlGroupALL.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupALL.Name = "pnlGroupALL";
            this.pnlGroupALL.Size = new System.Drawing.Size(514, 79);
            this.pnlGroupALL.TabIndex = 52;
            // 
            // chkSelected
            // 
            this.chkSelected.BackColor = System.Drawing.Color.Transparent;
            this.chkSelected.CheckedState.BorderColor = System.Drawing.Color.White;
            this.chkSelected.CheckedState.BorderRadius = 2;
            this.chkSelected.CheckedState.BorderThickness = 0;
            this.chkSelected.CheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.chkSelected.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(106)))), ((int)(((byte)(253)))));
            this.chkSelected.Location = new System.Drawing.Point(12, 18);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(30, 30);
            this.chkSelected.TabIndex = 52;
            this.chkSelected.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.chkSelected.UncheckedState.BorderRadius = 2;
            this.chkSelected.UncheckedState.BorderThickness = 0;
            this.chkSelected.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.chkSelected.Click += new System.EventHandler(this.chkSelected_Click);
            // 
            // pbPic
            // 
            this.pbPic.Image = global::DCMS.Properties.Resources.medical;
            this.pbPic.ImageRotate = 0F;
            this.pbPic.Location = new System.Drawing.Point(114, 7);
            this.pbPic.Name = "pbPic";
            this.pbPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPic.Size = new System.Drawing.Size(60, 60);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic.TabIndex = 7;
            this.pbPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "_________________________________________________________";
            // 
            // ucTreatentRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGroupALL);
            this.Name = "ucTreatentRow";
            this.Size = new System.Drawing.Size(514, 79);
            this.pnlGroupALL.ResumeLayout(false);
            this.pnlGroupALL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Panel pnlGroupALL;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2CustomCheckBox chkSelected;
    }
}
