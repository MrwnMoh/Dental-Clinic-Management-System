namespace DCMS.Appointments
{
    partial class ucAppoimentRow
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
            this.pnlGroupALL = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ToolDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TooEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tooolTakeApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ucRoleStatues = new DCMS.People.ucRoleStatues();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblService = new System.Windows.Forms.Label();
            this.lblPhoneDoctor = new System.Windows.Forms.Label();
            this.lblFullNameDoctor = new System.Windows.Forms.Label();
            this.pbPicDoctor = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblPhonePatient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFullNamePatient = new System.Windows.Forms.Label();
            this.pbPicPatinet = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGroupALL.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicPatinet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGroupALL
            // 
            this.pnlGroupALL.BorderRadius = 15;
            this.pnlGroupALL.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.pnlGroupALL.Controls.Add(this.ucRoleStatues);
            this.pnlGroupALL.Controls.Add(this.guna2GradientButton1);
            this.pnlGroupALL.Controls.Add(this.btnEdit);
            this.pnlGroupALL.Controls.Add(this.lblService);
            this.pnlGroupALL.Controls.Add(this.lblPhoneDoctor);
            this.pnlGroupALL.Controls.Add(this.lblFullNameDoctor);
            this.pnlGroupALL.Controls.Add(this.pbPicDoctor);
            this.pnlGroupALL.Controls.Add(this.lblPhonePatient);
            this.pnlGroupALL.Controls.Add(this.lblDate);
            this.pnlGroupALL.Controls.Add(this.lblID);
            this.pnlGroupALL.Controls.Add(this.lblFullNamePatient);
            this.pnlGroupALL.Controls.Add(this.pbPicPatinet);
            this.pnlGroupALL.Controls.Add(this.label1);
            this.pnlGroupALL.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupALL.Name = "pnlGroupALL";
            this.pnlGroupALL.Size = new System.Drawing.Size(1130, 104);
            this.pnlGroupALL.TabIndex = 5;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolDetails,
            this.toolStripSeparator1,
            this.TooEdit,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tooolTakeApp,
            this.toolCancel});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(207, 158);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // ToolDetails
            // 
            this.ToolDetails.Image = global::DCMS.Properties.Resources.Patients;
            this.ToolDetails.Name = "ToolDetails";
            this.ToolDetails.Size = new System.Drawing.Size(206, 24);
            this.ToolDetails.Text = "Show Details";
            this.ToolDetails.Click += new System.EventHandler(this.ToolDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // TooEdit
            // 
            this.TooEdit.Image = global::DCMS.Properties.Resources.pencil;
            this.TooEdit.Name = "TooEdit";
            this.TooEdit.Size = new System.Drawing.Size(206, 24);
            this.TooEdit.Text = "Edit";
            this.TooEdit.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DCMS.Properties.Resources.bin1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
            // 
            // tooolTakeApp
            // 
            this.tooolTakeApp.Image = global::DCMS.Properties.Resources.pencil;
            this.tooolTakeApp.Name = "tooolTakeApp";
            this.tooolTakeApp.Size = new System.Drawing.Size(206, 24);
            this.tooolTakeApp.Text = "Take Appoitment";
            this.tooolTakeApp.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Image = global::DCMS.Properties.Resources.pencil;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(206, 24);
            this.toolCancel.Text = "Cancel Appoitment";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // ucRoleStatues
            // 
            this.ucRoleStatues.BackColor = System.Drawing.Color.Transparent;
            this.ucRoleStatues.Location = new System.Drawing.Point(897, 23);
            this.ucRoleStatues.Name = "ucRoleStatues";
            this.ucRoleStatues.Size = new System.Drawing.Size(118, 45);
            this.ucRoleStatues.TabIndex = 31;
            this.ucRoleStatues.Type = DCMS.People.ucRoleStatues.RoleType.Pending;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.White;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.guna2GradientButton1.Image = global::DCMS.Properties.Resources.bin2;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton1.Location = new System.Drawing.Point(1076, 28);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2GradientButton1.TabIndex = 29;
            this.guna2GradientButton1.Tag = "Dashboard";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.FillColor2 = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Helvetica Rounded", 18F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.btnEdit.Image = global::DCMS.Properties.Resources.pencil;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(1027, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Tag = "Dashboard";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblService
            // 
            this.lblService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.lblService.Location = new System.Drawing.Point(557, 28);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(140, 19);
            this.lblService.TabIndex = 28;
            this.lblService.Text = "??????? ???????";
            // 
            // lblPhoneDoctor
            // 
            this.lblPhoneDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneDoctor.AutoSize = true;
            this.lblPhoneDoctor.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(91)))), ((int)(((byte)(125)))));
            this.lblPhoneDoctor.Location = new System.Drawing.Point(380, 43);
            this.lblPhoneDoctor.Name = "lblPhoneDoctor";
            this.lblPhoneDoctor.Size = new System.Drawing.Size(139, 18);
            this.lblPhoneDoctor.TabIndex = 27;
            this.lblPhoneDoctor.Text = "??????? ???????";
            // 
            // lblFullNameDoctor
            // 
            this.lblFullNameDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullNameDoctor.AutoSize = true;
            this.lblFullNameDoctor.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblFullNameDoctor.Location = new System.Drawing.Point(380, 20);
            this.lblFullNameDoctor.Name = "lblFullNameDoctor";
            this.lblFullNameDoctor.Size = new System.Drawing.Size(140, 19);
            this.lblFullNameDoctor.TabIndex = 26;
            this.lblFullNameDoctor.Text = "??????? ???????";
            // 
            // pbPicDoctor
            // 
            this.pbPicDoctor.Image = global::DCMS.Properties.Resources.Girl;
            this.pbPicDoctor.ImageRotate = 0F;
            this.pbPicDoctor.Location = new System.Drawing.Point(297, 3);
            this.pbPicDoctor.Name = "pbPicDoctor";
            this.pbPicDoctor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPicDoctor.Size = new System.Drawing.Size(80, 80);
            this.pbPicDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicDoctor.TabIndex = 25;
            this.pbPicDoctor.TabStop = false;
            // 
            // lblPhonePatient
            // 
            this.lblPhonePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhonePatient.AutoSize = true;
            this.lblPhonePatient.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(91)))), ((int)(((byte)(125)))));
            this.lblPhonePatient.Location = new System.Drawing.Point(126, 43);
            this.lblPhonePatient.Name = "lblPhonePatient";
            this.lblPhonePatient.Size = new System.Drawing.Size(139, 18);
            this.lblPhonePatient.TabIndex = 12;
            this.lblPhonePatient.Text = "??????? ???????";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblDate.Location = new System.Drawing.Point(700, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 19);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "???????";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblID.Location = new System.Drawing.Point(7, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 19);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "???";
            // 
            // lblFullNamePatient
            // 
            this.lblFullNamePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullNamePatient.AutoSize = true;
            this.lblFullNamePatient.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNamePatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblFullNamePatient.Location = new System.Drawing.Point(125, 20);
            this.lblFullNamePatient.Name = "lblFullNamePatient";
            this.lblFullNamePatient.Size = new System.Drawing.Size(140, 19);
            this.lblFullNamePatient.TabIndex = 5;
            this.lblFullNamePatient.Text = "??????? ???????";
            // 
            // pbPicPatinet
            // 
            this.pbPicPatinet.Image = global::DCMS.Properties.Resources.Girl;
            this.pbPicPatinet.ImageRotate = 0F;
            this.pbPicPatinet.Location = new System.Drawing.Point(43, 3);
            this.pbPicPatinet.Name = "pbPicPatinet";
            this.pbPicPatinet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPicPatinet.Size = new System.Drawing.Size(80, 80);
            this.pbPicPatinet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicPatinet.TabIndex = 1;
            this.pbPicPatinet.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1105, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________";
            // 
            // ucAppoimentRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGroupALL);
            this.Name = "ucAppoimentRow";
            this.Size = new System.Drawing.Size(1130, 104);
            this.pnlGroupALL.ResumeLayout(false);
            this.pnlGroupALL.PerformLayout();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicPatinet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlGroupALL;
        private System.Windows.Forms.Label lblPhonePatient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFullNamePatient;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPicPatinet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblPhoneDoctor;
        private System.Windows.Forms.Label lblFullNameDoctor;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPicDoctor;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private People.ucRoleStatues ucRoleStatues;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tooolTakeApp;
        private System.Windows.Forms.ToolStripMenuItem TooEdit;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolCancel;
    }
}
