namespace DCMS.People.Person
{
    partial class ucPersonRow
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
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.flpRoles = new System.Windows.Forms.FlowLayoutPanel();
            this.ucRoleAdmin = new DCMS.People.ucRoleStatues();
            this.ucRoleDoctor = new DCMS.People.ucRoleStatues();
            this.ucRolePatient = new DCMS.People.ucRoleStatues();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pbPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGroupALL.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.flpRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGroupALL
            // 
            this.pnlGroupALL.BorderRadius = 15;
            this.pnlGroupALL.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.pnlGroupALL.Controls.Add(this.lblBloodType);
            this.pnlGroupALL.Controls.Add(this.lblCountry);
            this.pnlGroupALL.Controls.Add(this.flpRoles);
            this.pnlGroupALL.Controls.Add(this.lblPhone);
            this.pnlGroupALL.Controls.Add(this.lblPersonID);
            this.pnlGroupALL.Controls.Add(this.lblFullName);
            this.pnlGroupALL.Controls.Add(this.pbPic);
            this.pnlGroupALL.Controls.Add(this.label1);
            this.pnlGroupALL.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupALL.Name = "pnlGroupALL";
            this.pnlGroupALL.Size = new System.Drawing.Size(1130, 104);
            this.pnlGroupALL.TabIndex = 2;
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
            this.guna2ContextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.guna2ContextMenuStrip1_Closed);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DCMS.Properties.Resources.Patients;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(252)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
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
            // lblBloodType
            // 
            this.lblBloodType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblBloodType.Location = new System.Drawing.Point(1030, 28);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(54, 19);
            this.lblBloodType.TabIndex = 13;
            this.lblBloodType.Text = "?????";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblCountry.Location = new System.Drawing.Point(875, 28);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(140, 19);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "??????? ???????";
            // 
            // flpRoles
            // 
            this.flpRoles.Controls.Add(this.ucRoleAdmin);
            this.flpRoles.Controls.Add(this.ucRoleDoctor);
            this.flpRoles.Controls.Add(this.ucRolePatient);
            this.flpRoles.Location = new System.Drawing.Point(476, 13);
            this.flpRoles.Name = "flpRoles";
            this.flpRoles.Size = new System.Drawing.Size(393, 53);
            this.flpRoles.TabIndex = 11;
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
            this.ucRoleDoctor.Size = new System.Drawing.Size(123, 48);
            this.ucRoleDoctor.TabIndex = 7;
            this.ucRoleDoctor.Visible = false;
            // 
            // ucRolePatient
            // 
            this.ucRolePatient.BackColor = System.Drawing.Color.Transparent;
            this.ucRolePatient.Location = new System.Drawing.Point(259, 3);
            this.ucRolePatient.Name = "ucRolePatient";
            this.ucRolePatient.Type = DCMS.People.ucRoleStatues.RoleType.Patient;
            this.ucRolePatient.Size = new System.Drawing.Size(121, 48);
            this.ucRolePatient.TabIndex = 6;
            this.ucRolePatient.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblPhone.Location = new System.Drawing.Point(330, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(140, 19);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "??????? ???????";
            // 
            // lblPersonID
            // 
            this.lblPersonID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(38)))));
            this.lblPersonID.Location = new System.Drawing.Point(7, 28);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(45, 19);
            this.lblPersonID.TabIndex = 6;
            this.lblPersonID.Text = "????";
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
            // ucPersonRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlGroupALL);
            this.Name = "ucPersonRow";
            this.Size = new System.Drawing.Size(1130, 104);
            this.MouseLeave += new System.EventHandler(this.ucPersonRow_MouseLeave);
            this.pnlGroupALL.ResumeLayout(false);
            this.pnlGroupALL.PerformLayout();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.flpRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPic;
        private Guna.UI2.WinForms.Guna2Panel pnlGroupALL;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.FlowLayoutPanel flpRoles;
        private ucRoleStatues ucRoleAdmin;
        private ucRoleStatues ucRolePatient;
        private ucRoleStatues ucRoleDoctor;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
