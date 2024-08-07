namespace ManagementCars
{
    partial class frmSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageControlDisplayTable = new System.Windows.Forms.TabPage();
            this.panelContainerCheckBoxes = new System.Windows.Forms.Panel();
            this.checkBoxCarName = new System.Windows.Forms.CheckBox();
            this.checkBoxClientID = new System.Windows.Forms.CheckBox();
            this.checkBoxChassisNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxCardValidityPeriod = new System.Windows.Forms.CheckBox();
            this.checkBoxCarColor = new System.Windows.Forms.CheckBox();
            this.checkBoxEndDate = new System.Windows.Forms.CheckBox();
            this.checkBoxOwnerName = new System.Windows.Forms.CheckBox();
            this.checkBoxStartDate = new System.Windows.Forms.CheckBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.linkLabelResetTextBoxes = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageControlInfoClient = new System.Windows.Forms.TabPage();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlHeader1 = new ManagementCars.ctrlHeader();
            this.tabPageSettingsApplication = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageControlDisplayTable.SuspendLayout();
            this.panelContainerCheckBoxes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageControlDisplayTable);
            this.tabControl1.Controls.Add(this.tabPageControlInfoClient);
            this.tabControl1.Controls.Add(this.tabPageSettingsApplication);
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 468);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageControlDisplayTable
            // 
            this.tabPageControlDisplayTable.Controls.Add(this.panelContainerCheckBoxes);
            this.tabPageControlDisplayTable.Controls.Add(this.linkLabelResetTextBoxes);
            this.tabPageControlDisplayTable.Controls.Add(this.label1);
            this.tabPageControlDisplayTable.Location = new System.Drawing.Point(4, 39);
            this.tabPageControlDisplayTable.Name = "tabPageControlDisplayTable";
            this.tabPageControlDisplayTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControlDisplayTable.Size = new System.Drawing.Size(919, 425);
            this.tabPageControlDisplayTable.TabIndex = 0;
            this.tabPageControlDisplayTable.Text = "قائمة العملاء";
            this.tabPageControlDisplayTable.UseVisualStyleBackColor = true;
            // 
            // panelContainerCheckBoxes
            // 
            this.panelContainerCheckBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxCarName);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxClientID);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxChassisNumber);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxCardValidityPeriod);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxCarColor);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxEndDate);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxOwnerName);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxStartDate);
            this.panelContainerCheckBoxes.Controls.Add(this.checkBoxDescription);
            this.panelContainerCheckBoxes.Location = new System.Drawing.Point(42, 111);
            this.panelContainerCheckBoxes.Name = "panelContainerCheckBoxes";
            this.panelContainerCheckBoxes.Size = new System.Drawing.Size(828, 178);
            this.panelContainerCheckBoxes.TabIndex = 25;
            // 
            // checkBoxCarName
            // 
            this.checkBoxCarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCarName.AutoSize = true;
            this.checkBoxCarName.Checked = true;
            this.checkBoxCarName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarName.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarName.ForeColor = System.Drawing.Color.Green;
            this.checkBoxCarName.Location = new System.Drawing.Point(253, 6);
            this.checkBoxCarName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxCarName.Name = "checkBoxCarName";
            this.checkBoxCarName.Size = new System.Drawing.Size(126, 40);
            this.checkBoxCarName.TabIndex = 15;
            this.checkBoxCarName.Tag = "4";
            this.checkBoxCarName.Text = "أسم السيارة";
            this.checkBoxCarName.UseVisualStyleBackColor = true;
            this.checkBoxCarName.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxClientID
            // 
            this.checkBoxClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxClientID.AutoSize = true;
            this.checkBoxClientID.Checked = true;
            this.checkBoxClientID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClientID.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClientID.ForeColor = System.Drawing.Color.Green;
            this.checkBoxClientID.Location = new System.Drawing.Point(693, 6);
            this.checkBoxClientID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxClientID.Name = "checkBoxClientID";
            this.checkBoxClientID.Size = new System.Drawing.Size(129, 40);
            this.checkBoxClientID.TabIndex = 14;
            this.checkBoxClientID.Tag = "1";
            this.checkBoxClientID.Text = "رقم المعرف";
            this.checkBoxClientID.UseVisualStyleBackColor = true;
            this.checkBoxClientID.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxChassisNumber
            // 
            this.checkBoxChassisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxChassisNumber.AutoSize = true;
            this.checkBoxChassisNumber.Checked = true;
            this.checkBoxChassisNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChassisNumber.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChassisNumber.ForeColor = System.Drawing.Color.Green;
            this.checkBoxChassisNumber.Location = new System.Drawing.Point(23, 6);
            this.checkBoxChassisNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxChassisNumber.Name = "checkBoxChassisNumber";
            this.checkBoxChassisNumber.Size = new System.Drawing.Size(130, 40);
            this.checkBoxChassisNumber.TabIndex = 16;
            this.checkBoxChassisNumber.Tag = "8";
            this.checkBoxChassisNumber.Text = "رقم الشاصي";
            this.checkBoxChassisNumber.UseVisualStyleBackColor = true;
            this.checkBoxChassisNumber.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCardValidityPeriod
            // 
            this.checkBoxCardValidityPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCardValidityPeriod.AutoSize = true;
            this.checkBoxCardValidityPeriod.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCardValidityPeriod.ForeColor = System.Drawing.Color.Red;
            this.checkBoxCardValidityPeriod.Location = new System.Drawing.Point(632, 132);
            this.checkBoxCardValidityPeriod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxCardValidityPeriod.Name = "checkBoxCardValidityPeriod";
            this.checkBoxCardValidityPeriod.Size = new System.Drawing.Size(192, 40);
            this.checkBoxCardValidityPeriod.TabIndex = 22;
            this.checkBoxCardValidityPeriod.Tag = "256";
            this.checkBoxCardValidityPeriod.Text = "فترة صلاحية البطاقة";
            this.checkBoxCardValidityPeriod.UseVisualStyleBackColor = true;
            this.checkBoxCardValidityPeriod.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCarColor
            // 
            this.checkBoxCarColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCarColor.AutoSize = true;
            this.checkBoxCarColor.Checked = true;
            this.checkBoxCarColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarColor.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarColor.ForeColor = System.Drawing.Color.Green;
            this.checkBoxCarColor.Location = new System.Drawing.Point(701, 69);
            this.checkBoxCarColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxCarColor.Name = "checkBoxCarColor";
            this.checkBoxCarColor.Size = new System.Drawing.Size(121, 40);
            this.checkBoxCarColor.TabIndex = 17;
            this.checkBoxCarColor.Tag = "16";
            this.checkBoxCarColor.Text = "لون السيارة";
            this.checkBoxCarColor.UseVisualStyleBackColor = true;
            this.checkBoxCarColor.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxEndDate
            // 
            this.checkBoxEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEndDate.AutoSize = true;
            this.checkBoxEndDate.Checked = true;
            this.checkBoxEndDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEndDate.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEndDate.ForeColor = System.Drawing.Color.Green;
            this.checkBoxEndDate.Location = new System.Drawing.Point(23, 67);
            this.checkBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxEndDate.Name = "checkBoxEndDate";
            this.checkBoxEndDate.Size = new System.Drawing.Size(130, 40);
            this.checkBoxEndDate.TabIndex = 21;
            this.checkBoxEndDate.Tag = "128";
            this.checkBoxEndDate.Text = "تاريخ الإنتهاء";
            this.checkBoxEndDate.UseVisualStyleBackColor = true;
            this.checkBoxEndDate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxOwnerName
            // 
            this.checkBoxOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOwnerName.AutoSize = true;
            this.checkBoxOwnerName.Checked = true;
            this.checkBoxOwnerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOwnerName.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOwnerName.ForeColor = System.Drawing.Color.Green;
            this.checkBoxOwnerName.Location = new System.Drawing.Point(475, 6);
            this.checkBoxOwnerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxOwnerName.Name = "checkBoxOwnerName";
            this.checkBoxOwnerName.Size = new System.Drawing.Size(122, 40);
            this.checkBoxOwnerName.TabIndex = 18;
            this.checkBoxOwnerName.Tag = "2";
            this.checkBoxOwnerName.Text = "أسم المالك";
            this.checkBoxOwnerName.UseVisualStyleBackColor = true;
            this.checkBoxOwnerName.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxStartDate
            // 
            this.checkBoxStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStartDate.AutoSize = true;
            this.checkBoxStartDate.Checked = true;
            this.checkBoxStartDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStartDate.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartDate.ForeColor = System.Drawing.Color.Green;
            this.checkBoxStartDate.Location = new System.Drawing.Point(270, 67);
            this.checkBoxStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxStartDate.Name = "checkBoxStartDate";
            this.checkBoxStartDate.Size = new System.Drawing.Size(109, 40);
            this.checkBoxStartDate.TabIndex = 20;
            this.checkBoxStartDate.Tag = "64";
            this.checkBoxStartDate.Text = "تاريخ البدء";
            this.checkBoxStartDate.UseVisualStyleBackColor = true;
            this.checkBoxStartDate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Checked = true;
            this.checkBoxDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescription.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDescription.ForeColor = System.Drawing.Color.Green;
            this.checkBoxDescription.Location = new System.Drawing.Point(506, 67);
            this.checkBoxDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(91, 40);
            this.checkBoxDescription.TabIndex = 19;
            this.checkBoxDescription.Tag = "32";
            this.checkBoxDescription.Text = "الوصف";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // linkLabelResetTextBoxes
            // 
            this.linkLabelResetTextBoxes.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelResetTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelResetTextBoxes.AutoSize = true;
            this.linkLabelResetTextBoxes.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelResetTextBoxes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelResetTextBoxes.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelResetTextBoxes.Location = new System.Drawing.Point(742, 346);
            this.linkLabelResetTextBoxes.Name = "linkLabelResetTextBoxes";
            this.linkLabelResetTextBoxes.Size = new System.Drawing.Size(133, 30);
            this.linkLabelResetTextBoxes.TabIndex = 24;
            this.linkLabelResetTextBoxes.TabStop = true;
            this.linkLabelResetTextBoxes.Text = "أنقر لإعادة الضبط";
            this.linkLabelResetTextBoxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelResetTextBoxes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResetTextBoxes_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "التحكم في عرض قائمة العملاء:";
            // 
            // tabPageControlInfoClient
            // 
            this.tabPageControlInfoClient.Location = new System.Drawing.Point(4, 39);
            this.tabPageControlInfoClient.Name = "tabPageControlInfoClient";
            this.tabPageControlInfoClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageControlInfoClient.Size = new System.Drawing.Size(919, 425);
            this.tabPageControlInfoClient.TabIndex = 1;
            this.tabPageControlInfoClient.Text = "معلومات العميل";
            this.tabPageControlInfoClient.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveAndClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndClose.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAndClose.Image = global::ManagementCars.Properties.Resources.save_40;
            this.btnSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAndClose.Location = new System.Drawing.Point(789, 7);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(134, 45);
            this.btnSaveAndClose.TabIndex = 26;
            this.btnSaveAndClose.TabStop = false;
            this.btnSaveAndClose.Text = "حفظ";
            this.btnSaveAndClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAndClose.UseVisualStyleBackColor = false;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::ManagementCars.Properties.Resources.close_55;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(649, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSaveAndClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 64);
            this.panel1.TabIndex = 25;
            // 
            // ctrlHeader1
            // 
            this.ctrlHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlHeader1.BackColor = System.Drawing.SystemColors.GrayText;
            this.ctrlHeader1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHeader1.Location = new System.Drawing.Point(0, 0);
            this.ctrlHeader1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(927, 42);
            this.ctrlHeader1.TabIndex = 1;
            // 
            // tabPageSettingsApplication
            // 
            this.tabPageSettingsApplication.Location = new System.Drawing.Point(4, 39);
            this.tabPageSettingsApplication.Name = "tabPageSettingsApplication";
            this.tabPageSettingsApplication.Size = new System.Drawing.Size(919, 425);
            this.tabPageSettingsApplication.TabIndex = 2;
            this.tabPageSettingsApplication.Text = "إعدادات البرنامج";
            this.tabPageSettingsApplication.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(927, 584);
            this.Controls.Add(this.ctrlHeader1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageControlDisplayTable.ResumeLayout(false);
            this.tabPageControlDisplayTable.PerformLayout();
            this.panelContainerCheckBoxes.ResumeLayout(false);
            this.panelContainerCheckBoxes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageControlDisplayTable;
        private System.Windows.Forms.TabPage tabPageControlInfoClient;
        private System.Windows.Forms.Button btnSaveAndClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkLabelResetTextBoxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCardValidityPeriod;
        private System.Windows.Forms.CheckBox checkBoxEndDate;
        private System.Windows.Forms.CheckBox checkBoxStartDate;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxOwnerName;
        private System.Windows.Forms.CheckBox checkBoxCarColor;
        private System.Windows.Forms.CheckBox checkBoxChassisNumber;
        private System.Windows.Forms.CheckBox checkBoxCarName;
        private System.Windows.Forms.CheckBox checkBoxClientID;
        private System.Windows.Forms.Panel panel1;
        private ctrlHeader ctrlHeader1;
        private System.Windows.Forms.Panel panelContainerCheckBoxes;
        private System.Windows.Forms.TabPage tabPageSettingsApplication;
    }
}