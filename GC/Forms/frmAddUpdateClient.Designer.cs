namespace ManagementCars
{
    partial class frmAddUpdateClient
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOwnerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxChassisNumber = new System.Windows.Forms.TextBox();
            this.textBoxCarColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIDClient = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAddPeriodDate = new System.Windows.Forms.Panel();
            this.ctrlNumricUpDown = new ManagementCars.ctrlNumricUpDown();
            this.lblPreiodValidityCard = new System.Windows.Forms.Label();
            this.ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlHeader1 = new ManagementCars.ctrlHeader();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelAddPeriodDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(0, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(935, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إنشاء / تعديل البطاقة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCarName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCarName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarName.Location = new System.Drawing.Point(502, 196);
            this.textBoxCarName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxCarName.MaximumSize = new System.Drawing.Size(279, 37);
            this.textBoxCarName.MaxLength = 60;
            this.textBoxCarName.MinimumSize = new System.Drawing.Size(279, 37);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCarName.Size = new System.Drawing.Size(279, 37);
            this.textBoxCarName.TabIndex = 1;
            this.textBoxCarName.Validating += new System.ComponentModel.CancelEventHandler(this.btnSave_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(812, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم السيارة:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(808, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "رقم الشاصي:";
            // 
            // textBoxOwnerName
            // 
            this.textBoxOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOwnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOwnerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxOwnerName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOwnerName.Location = new System.Drawing.Point(503, 136);
            this.textBoxOwnerName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxOwnerName.MaximumSize = new System.Drawing.Size(279, 37);
            this.textBoxOwnerName.MaxLength = 60;
            this.textBoxOwnerName.MinimumSize = new System.Drawing.Size(279, 37);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxOwnerName.Size = new System.Drawing.Size(279, 37);
            this.textBoxOwnerName.TabIndex = 0;
            this.textBoxOwnerName.Validating += new System.ComponentModel.CancelEventHandler(this.btnSave_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(817, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "لون السيارة:";
            // 
            // textBoxChassisNumber
            // 
            this.textBoxChassisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChassisNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChassisNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxChassisNumber.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChassisNumber.Location = new System.Drawing.Point(502, 256);
            this.textBoxChassisNumber.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxChassisNumber.MaximumSize = new System.Drawing.Size(279, 37);
            this.textBoxChassisNumber.MaxLength = 25;
            this.textBoxChassisNumber.MinimumSize = new System.Drawing.Size(279, 37);
            this.textBoxChassisNumber.Name = "textBoxChassisNumber";
            this.textBoxChassisNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxChassisNumber.Size = new System.Drawing.Size(279, 37);
            this.textBoxChassisNumber.TabIndex = 2;
            this.textBoxChassisNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxChassisNumber.Validating += new System.ComponentModel.CancelEventHandler(this.btnSave_Validating);
            // 
            // textBoxCarColor
            // 
            this.textBoxCarColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCarColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCarColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCarColor.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarColor.Location = new System.Drawing.Point(503, 316);
            this.textBoxCarColor.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxCarColor.MaximumSize = new System.Drawing.Size(279, 37);
            this.textBoxCarColor.MaxLength = 25;
            this.textBoxCarColor.MinimumSize = new System.Drawing.Size(279, 37);
            this.textBoxCarColor.Name = "textBoxCarColor";
            this.textBoxCarColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCarColor.Size = new System.Drawing.Size(279, 37);
            this.textBoxCarColor.TabIndex = 3;
            this.textBoxCarColor.Validating += new System.ComponentModel.CancelEventHandler(this.btnSave_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(816, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "أسم المالك:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(286, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "تاريخ البدأ:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStartDate.Location = new System.Drawing.Point(11, 77);
            this.lblStartDate.MaximumSize = new System.Drawing.Size(235, 36);
            this.lblStartDate.MinimumSize = new System.Drawing.Size(235, 36);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStartDate.Size = new System.Drawing.Size(235, 36);
            this.lblStartDate.TabIndex = 16;
            this.lblStartDate.Text = "[??????????????????????????]";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndDate.Location = new System.Drawing.Point(11, 136);
            this.lblEndDate.MaximumSize = new System.Drawing.Size(235, 36);
            this.lblEndDate.MinimumSize = new System.Drawing.Size(235, 36);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEndDate.Size = new System.Drawing.Size(235, 36);
            this.lblEndDate.TabIndex = 17;
            this.lblEndDate.Text = "[??????????????????????????]";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(260, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "تاريخ الانتهاء:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(847, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = "الوصف:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::ManagementCars.Properties.Resources.close_55;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(673, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 51);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescription.Location = new System.Drawing.Point(442, 373);
            this.textBoxDescription.MaximumSize = new System.Drawing.Size(340, 123);
            this.textBoxDescription.MaxLength = 800;
            this.textBoxDescription.MinimumSize = new System.Drawing.Size(340, 123);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(340, 123);
            this.textBoxDescription.TabIndex = 4;
            this.textBoxDescription.Text = "";
            this.textBoxDescription.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescription_Validating);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(830, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 30);
            this.label10.TabIndex = 23;
            this.label10.Text = "رقم المعرف:";
            // 
            // lblIDClient
            // 
            this.lblIDClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDClient.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIDClient.Location = new System.Drawing.Point(690, 56);
            this.lblIDClient.Name = "lblIDClient";
            this.lblIDClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIDClient.Size = new System.Drawing.Size(134, 30);
            this.lblIDClient.TabIndex = 24;
            this.lblIDClient.Text = "[????]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelAddPeriodDate
            // 
            this.panelAddPeriodDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddPeriodDate.Controls.Add(this.ctrlNumricUpDown);
            this.panelAddPeriodDate.Controls.Add(this.lblPreiodValidityCard);
            this.panelAddPeriodDate.Controls.Add(this.label6);
            this.panelAddPeriodDate.Controls.Add(this.lblStartDate);
            this.panelAddPeriodDate.Controls.Add(this.lblEndDate);
            this.panelAddPeriodDate.Controls.Add(this.label7);
            this.panelAddPeriodDate.Location = new System.Drawing.Point(14, 136);
            this.panelAddPeriodDate.Name = "panelAddPeriodDate";
            this.panelAddPeriodDate.Size = new System.Drawing.Size(384, 208);
            this.panelAddPeriodDate.TabIndex = 25;
            // 
            // ctrlNumricUpDown
            // 
            this.ctrlNumricUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlNumricUpDown.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlNumricUpDown.Location = new System.Drawing.Point(56, 7);
            this.ctrlNumricUpDown.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ctrlNumricUpDown.Maximum = 100;
            this.ctrlNumricUpDown.MaximumSize = new System.Drawing.Size(134, 57);
            this.ctrlNumricUpDown.Minimum = 1;
            this.ctrlNumricUpDown.MinimumSize = new System.Drawing.Size(46, 33);
            this.ctrlNumricUpDown.Name = "ctrlNumricUpDown";
            this.ctrlNumricUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctrlNumricUpDown.Size = new System.Drawing.Size(123, 55);
            this.ctrlNumricUpDown.TabIndex = 26;
            this.ctrlNumricUpDown.TextColor = System.Drawing.SystemColors.WindowText;
            this.ctrlNumricUpDown.Value = 0;
            // 
            // lblPreiodValidityCard
            // 
            this.lblPreiodValidityCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreiodValidityCard.AutoSize = true;
            this.lblPreiodValidityCard.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreiodValidityCard.ForeColor = System.Drawing.Color.Green;
            this.lblPreiodValidityCard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPreiodValidityCard.Location = new System.Drawing.Point(187, 18);
            this.lblPreiodValidityCard.Name = "lblPreiodValidityCard";
            this.lblPreiodValidityCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPreiodValidityCard.Size = new System.Drawing.Size(188, 36);
            this.lblPreiodValidityCard.TabIndex = 25;
            this.lblPreiodValidityCard.Text = "مدة صلاحية البطاقة:";
            // 
            // ToggleSwitch
            // 
            this.ToggleSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch.Location = new System.Drawing.Point(286, 350);
            this.ToggleSwitch.Name = "ToggleSwitch";
            this.ToggleSwitch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToggleSwitch.Size = new System.Drawing.Size(97, 32);
            this.ToggleSwitch.TabIndex = 26;
            this.ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch.Visible = false;
            this.ToggleSwitch.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::ManagementCars.Properties.Resources.save_40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(801, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlHeader1
            // 
            this.ctrlHeader1.BackColor = System.Drawing.Color.Gray;
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlHeader1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHeader1.Location = new System.Drawing.Point(0, 0);
            this.ctrlHeader1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(935, 42);
            this.ctrlHeader1.TabIndex = 22;
            this.ctrlHeader1.TabStop = false;
            // 
            // frmAddUpdateClient
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(935, 566);
            this.Controls.Add(this.ToggleSwitch);
            this.Controls.Add(this.panelAddPeriodDate);
            this.Controls.Add(this.lblIDClient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.ctrlHeader1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCarColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxChassisNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOwnerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAddUpdateClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء بطاقة جديدة";
            this.Load += new System.EventHandler(this.frmAddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelAddPeriodDate.ResumeLayout(false);
            this.panelAddPeriodDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOwnerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxChassisNumber;
        private System.Windows.Forms.TextBox textBoxCarColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ctrlHeader ctrlHeader1;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIDClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelAddPeriodDate;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch;
        private System.Windows.Forms.Label lblPreiodValidityCard;
        private ctrlNumricUpDown ctrlNumricUpDown;
    }
}

