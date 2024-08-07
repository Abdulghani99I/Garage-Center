namespace ManagementCars
{
    partial class frmApplicationSettings
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
            this.checkBoxClientID = new System.Windows.Forms.CheckBox();
            this.checkBoxCarName = new System.Windows.Forms.CheckBox();
            this.checkBoxChassisNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxCarColor = new System.Windows.Forms.CheckBox();
            this.checkBoxOwnerName = new System.Windows.Forms.CheckBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.checkBoxStartDate = new System.Windows.Forms.CheckBox();
            this.checkBoxEndDate = new System.Windows.Forms.CheckBox();
            this.checkBoxCardValidityPeriod = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelResetTextBoxes = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveAndClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxClientID
            // 
            this.checkBoxClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxClientID.AutoSize = true;
            this.checkBoxClientID.Checked = true;
            this.checkBoxClientID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClientID.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClientID.ForeColor = System.Drawing.Color.Green;
            this.checkBoxClientID.Location = new System.Drawing.Point(262, 68);
            this.checkBoxClientID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxClientID.Name = "checkBoxClientID";
            this.checkBoxClientID.Size = new System.Drawing.Size(129, 40);
            this.checkBoxClientID.TabIndex = 0;
            this.checkBoxClientID.Text = "رقم المعرف";
            this.checkBoxClientID.UseVisualStyleBackColor = true;
            this.checkBoxClientID.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxCarName
            // 
            this.checkBoxCarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCarName.AutoSize = true;
            this.checkBoxCarName.Checked = true;
            this.checkBoxCarName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarName.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarName.ForeColor = System.Drawing.Color.Green;
            this.checkBoxCarName.Location = new System.Drawing.Point(265, 144);
            this.checkBoxCarName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxCarName.Name = "checkBoxCarName";
            this.checkBoxCarName.Size = new System.Drawing.Size(126, 40);
            this.checkBoxCarName.TabIndex = 1;
            this.checkBoxCarName.Text = "أسم السيارة";
            this.checkBoxCarName.UseVisualStyleBackColor = true;
            this.checkBoxCarName.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxChassisNumber
            // 
            this.checkBoxChassisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxChassisNumber.AutoSize = true;
            this.checkBoxChassisNumber.Checked = true;
            this.checkBoxChassisNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChassisNumber.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChassisNumber.ForeColor = System.Drawing.Color.Green;
            this.checkBoxChassisNumber.Location = new System.Drawing.Point(261, 220);
            this.checkBoxChassisNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxChassisNumber.Name = "checkBoxChassisNumber";
            this.checkBoxChassisNumber.Size = new System.Drawing.Size(130, 40);
            this.checkBoxChassisNumber.TabIndex = 2;
            this.checkBoxChassisNumber.Text = "رقم الشاصي";
            this.checkBoxChassisNumber.UseVisualStyleBackColor = true;
            this.checkBoxChassisNumber.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxCarColor
            // 
            this.checkBoxCarColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCarColor.AutoSize = true;
            this.checkBoxCarColor.Checked = true;
            this.checkBoxCarColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarColor.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarColor.ForeColor = System.Drawing.Color.Green;
            this.checkBoxCarColor.Location = new System.Drawing.Point(270, 296);
            this.checkBoxCarColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxCarColor.Name = "checkBoxCarColor";
            this.checkBoxCarColor.Size = new System.Drawing.Size(121, 40);
            this.checkBoxCarColor.TabIndex = 3;
            this.checkBoxCarColor.Text = "لون السيارة";
            this.checkBoxCarColor.UseVisualStyleBackColor = true;
            this.checkBoxCarColor.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxOwnerName
            // 
            this.checkBoxOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOwnerName.AutoSize = true;
            this.checkBoxOwnerName.Checked = true;
            this.checkBoxOwnerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOwnerName.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOwnerName.ForeColor = System.Drawing.Color.Green;
            this.checkBoxOwnerName.Location = new System.Drawing.Point(38, 68);
            this.checkBoxOwnerName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxOwnerName.Name = "checkBoxOwnerName";
            this.checkBoxOwnerName.Size = new System.Drawing.Size(122, 40);
            this.checkBoxOwnerName.TabIndex = 4;
            this.checkBoxOwnerName.Text = "أسم المالك";
            this.checkBoxOwnerName.UseVisualStyleBackColor = true;
            this.checkBoxOwnerName.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Checked = true;
            this.checkBoxDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescription.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDescription.ForeColor = System.Drawing.Color.Green;
            this.checkBoxDescription.Location = new System.Drawing.Point(69, 146);
            this.checkBoxDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(91, 40);
            this.checkBoxDescription.TabIndex = 5;
            this.checkBoxDescription.Text = "الوصف";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxStartDate
            // 
            this.checkBoxStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStartDate.AutoSize = true;
            this.checkBoxStartDate.Checked = true;
            this.checkBoxStartDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStartDate.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStartDate.ForeColor = System.Drawing.Color.Green;
            this.checkBoxStartDate.Location = new System.Drawing.Point(51, 224);
            this.checkBoxStartDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxStartDate.Name = "checkBoxStartDate";
            this.checkBoxStartDate.Size = new System.Drawing.Size(109, 40);
            this.checkBoxStartDate.TabIndex = 6;
            this.checkBoxStartDate.Text = "تاريخ البدء";
            this.checkBoxStartDate.UseVisualStyleBackColor = true;
            this.checkBoxStartDate.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxEndDate
            // 
            this.checkBoxEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEndDate.AutoSize = true;
            this.checkBoxEndDate.Checked = true;
            this.checkBoxEndDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEndDate.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEndDate.ForeColor = System.Drawing.Color.Green;
            this.checkBoxEndDate.Location = new System.Drawing.Point(30, 302);
            this.checkBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxEndDate.Name = "checkBoxEndDate";
            this.checkBoxEndDate.Size = new System.Drawing.Size(130, 40);
            this.checkBoxEndDate.TabIndex = 7;
            this.checkBoxEndDate.Text = "تاريخ الإنتهاء";
            this.checkBoxEndDate.UseVisualStyleBackColor = true;
            this.checkBoxEndDate.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // checkBoxCardValidityPeriod
            // 
            this.checkBoxCardValidityPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCardValidityPeriod.AutoSize = true;
            this.checkBoxCardValidityPeriod.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCardValidityPeriod.ForeColor = System.Drawing.Color.Red;
            this.checkBoxCardValidityPeriod.Location = new System.Drawing.Point(199, 362);
            this.checkBoxCardValidityPeriod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxCardValidityPeriod.Name = "checkBoxCardValidityPeriod";
            this.checkBoxCardValidityPeriod.Size = new System.Drawing.Size(192, 40);
            this.checkBoxCardValidityPeriod.TabIndex = 8;
            this.checkBoxCardValidityPeriod.Text = "فترة صلاحية البطاقة";
            this.checkBoxCardValidityPeriod.UseVisualStyleBackColor = true;
            this.checkBoxCardValidityPeriod.CheckedChanged += new System.EventHandler(this.checkBoxCardValidityPeriod_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = ":التحكم في عرض الجدول";
            // 
            // linkLabelResetTextBoxes
            // 
            this.linkLabelResetTextBoxes.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelResetTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelResetTextBoxes.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelResetTextBoxes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelResetTextBoxes.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelResetTextBoxes.Location = new System.Drawing.Point(0, 418);
            this.linkLabelResetTextBoxes.Name = "linkLabelResetTextBoxes";
            this.linkLabelResetTextBoxes.Size = new System.Drawing.Size(394, 36);
            this.linkLabelResetTextBoxes.TabIndex = 11;
            this.linkLabelResetTextBoxes.TabStop = true;
            this.linkLabelResetTextBoxes.Text = "أنقر لإعادة الضبط";
            this.linkLabelResetTextBoxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelResetTextBoxes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResetTextBoxes_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(7, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 45);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveAndClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveAndClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndClose.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAndClose.Location = new System.Drawing.Point(205, 483);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(183, 45);
            this.btnSaveAndClose.TabIndex = 13;
            this.btnSaveAndClose.Text = "حفظ  وإغلاق";
            this.btnSaveAndClose.UseVisualStyleBackColor = false;
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveSettingsAndCloseForm_Click);
            // 
            // frmApplicationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 531);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabelResetTextBoxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxCardValidityPeriod);
            this.Controls.Add(this.checkBoxEndDate);
            this.Controls.Add(this.checkBoxStartDate);
            this.Controls.Add(this.checkBoxDescription);
            this.Controls.Add(this.checkBoxOwnerName);
            this.Controls.Add(this.checkBoxCarColor);
            this.Controls.Add(this.checkBoxChassisNumber);
            this.Controls.Add(this.checkBoxCarName);
            this.Controls.Add(this.checkBoxClientID);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmApplicationSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmApplicationSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxClientID;
        private System.Windows.Forms.CheckBox checkBoxCarName;
        private System.Windows.Forms.CheckBox checkBoxChassisNumber;
        private System.Windows.Forms.CheckBox checkBoxCarColor;
        private System.Windows.Forms.CheckBox checkBoxOwnerName;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxStartDate;
        private System.Windows.Forms.CheckBox checkBoxEndDate;
        private System.Windows.Forms.CheckBox checkBoxCardValidityPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelResetTextBoxes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveAndClose;
    }
}