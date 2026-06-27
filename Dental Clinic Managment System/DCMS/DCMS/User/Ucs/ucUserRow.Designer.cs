namespace DCMS.User.Ucs
{
    partial class ucUserRow
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
            this.btnActiveationColor = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.flpRoles = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucRoleAdmin = new DCMS.People.ucRoleStatues();
            this.ucRoleDoctor = new DCMS.People.ucRoleStatues();
            this.pnlGroupALL.SuspendLayout();
            this.flpRoles.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGroupALL
            // 
            this.pnlGroupALL.BorderRadius = 15;
            this.pnlGroupALL.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.pnlGroupALL.Controls.Add(this.btnDelete);
            this.pnlGroupALL.Controls.Add(this.btnEdit);
            this.pnlGroupALL.Controls.Add(this.btnActiveationColor);
            this.pnlGroupALL.Controls.Add(this.lblActive);
            this.pnlGroupALL.Controls.Add(this.lblPhone);
            this.pnlGroupALL.Controls.Add(this.flpRoles);
            this.pnlGroupALL.Controls.Add(this.lblUserName);
            this.pnlGroupALL.Controls.Add(this.lblUserID);
            this.pnlGroupALL.Controls.Add(this.lblFullName);
            this.pnlGroupALL.Controls.Add(this.pbPic);
            this.pnlGroupALL.Controls.Add(this.label1);
            this.pnlGroupALL.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupALL.Name = "pnlGroupALL";
            this.pnlGroupALL.Size = new System.Drawing.Size(1130, 104);
            this.pnlGroupALL.TabIndex = 3;
            // 
            // btnActiveationColor
            // 
            this.btnActiveationColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActiveationColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActiveationColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActiveationColor.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActiveationColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActiveationColor.FillColor = System.Drawing.Color.Lime;
            this.btnActiveationColor.FillColor2 = System.Drawing.Color.Green;
            this.btnActiveationColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActiveationColor.ForeColor = System.Drawing.Color.White;
            this.btnActiveationColor.Location = new System.Drawing.Point(904, 27);
            this.btnActiveationColor.Name = "btnActiveationColor";
            this.btnActiveationColor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnActiveationColor.Size = new System.Drawing.Size(20, 20);
            this.btnActiveationColor.TabIndex = 16;
            // 
            // lblActive
            // 
            this.lblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblActive.Location = new System.Drawing.Point(925, 28);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(57, 19);
            this.lblActive.TabIndex = 15;
            this.lblActive.Text = "Active";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblPhone.Location = new System.Drawing.Point(734, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(140, 19);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "??????? ???????";
            // 
            // flpRoles
            // 
            this.flpRoles.Controls.Add(this.ucRoleAdmin);
            this.flpRoles.Controls.Add(this.ucRoleDoctor);
            this.flpRoles.Location = new System.Drawing.Point(462, 13);
            this.flpRoles.Name = "flpRoles";
            this.flpRoles.Size = new System.Drawing.Size(258, 53);
            this.flpRoles.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblUserName.Location = new System.Drawing.Point(343, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 19);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "???????";
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblUserID.Location = new System.Drawing.Point(7, 28);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 19);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "????";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblFullName.Location = new System.Drawing.Point(149, 28);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(140, 19);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "??????? ???????";
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(165, 82);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.FillColor2 = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnDelete.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.btnDelete.Image = global::DCMS.Properties.Resources.bin2;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(1070, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Tag = "Dashboard";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(1021, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Tag = "Dashboard";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pbPic
            // 
            this.pbPic.Image = global::DCMS.Properties.Resources.Girl;
            this.pbPic.ImageRotate = 0F;
            this.pbPic.Location = new System.Drawing.Point(61, 3);
            this.pbPic.Name = "pbPic";
            this.pbPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPic.Size = new System.Drawing.Size(80, 80);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 1;
            this.pbPic.TabStop = false;
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DCMS.Properties.Resources.Patients;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DCMS.Properties.Resources.pencil;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DCMS.Properties.Resources.bin1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ucRoleAdmin
            // 
            this.ucRoleAdmin.BackColor = System.Drawing.Color.Transparent;
            this.ucRoleAdmin.Location = new System.Drawing.Point(3, 3);
            this.ucRoleAdmin.Name = "ucRoleAdmin";
            this.ucRoleAdmin.Type = DCMS.People.ucRoleStatues.RoleType.Admin;
            this.ucRoleAdmin.Size = new System.Drawing.Size(121, 48);
            this.ucRoleAdmin.TabIndex = 5;
            this.ucRoleAdmin.Visible = false;
            // 
            // ucRoleDoctor
            // 
            this.ucRoleDoctor.BackColor = System.Drawing.Color.Transparent;
            this.ucRoleDoctor.Location = new System.Drawing.Point(130, 3);
            this.ucRoleDoctor.Name = "ucRoleDoctor";
            this.ucRoleDoctor.Type = DCMS.People.ucRoleStatues.RoleType.Doctor;
            this.ucRoleDoctor.Size = new System.Drawing.Size(121, 48);
            this.ucRoleDoctor.TabIndex = 6;
            this.ucRoleDoctor.Visible = false;
            // 
            // ucUserRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGroupALL);
            this.Name = "ucUserRow";
            this.Size = new System.Drawing.Size(1130, 104);
            this.pnlGroupALL.ResumeLayout(false);
            this.pnlGroupALL.PerformLayout();
            this.flpRoles.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlGroupALL;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.FlowLayoutPanel flpRoles;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPic;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnActiveationColor;
        private System.Windows.Forms.Label lblActive;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private People.ucRoleStatues ucRoleAdmin;
        private People.ucRoleStatues ucRoleDoctor;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
