namespace ManagementCars.Forms
{
    partial class frmExportToExcel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExoprtToExcel = new System.Windows.Forms.Button();
            this.linkLabelResetTextBoxes = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.checkBoxStyleLikeDgv = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoFitColumns = new System.Windows.Forms.CheckBox();
            this.checkBoxTableRightToLeft = new System.Windows.Forms.CheckBox();
            this.btnSelectFolderPath = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ctrlHeader1 = new ManagementCars.ctrlHeader();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnExoprtToExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 64);
            this.panel1.TabIndex = 26;
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
            this.btnClose.Location = new System.Drawing.Point(145, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExoprtToExcel
            // 
            this.btnExoprtToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExoprtToExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExoprtToExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExoprtToExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExoprtToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExoprtToExcel.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExoprtToExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExoprtToExcel.Image = global::ManagementCars.Properties.Resources.export_excel_40;
            this.btnExoprtToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExoprtToExcel.Location = new System.Drawing.Point(277, 7);
            this.btnExoprtToExcel.Name = "btnExoprtToExcel";
            this.btnExoprtToExcel.Size = new System.Drawing.Size(126, 45);
            this.btnExoprtToExcel.TabIndex = 26;
            this.btnExoprtToExcel.TabStop = false;
            this.btnExoprtToExcel.Text = "تصدير";
            this.btnExoprtToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExoprtToExcel.UseVisualStyleBackColor = false;
            this.btnExoprtToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // linkLabelResetTextBoxes
            // 
            this.linkLabelResetTextBoxes.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabelResetTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelResetTextBoxes.AutoSize = true;
            this.linkLabelResetTextBoxes.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelResetTextBoxes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelResetTextBoxes.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabelResetTextBoxes.Location = new System.Drawing.Point(266, 501);
            this.linkLabelResetTextBoxes.Name = "linkLabelResetTextBoxes";
            this.linkLabelResetTextBoxes.Size = new System.Drawing.Size(125, 30);
            this.linkLabelResetTextBoxes.TabIndex = 28;
            this.linkLabelResetTextBoxes.TabStop = true;
            this.linkLabelResetTextBoxes.Text = "أنقر لإعادة الضبط";
            this.linkLabelResetTextBoxes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelResetTextBoxes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResetForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 47);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "ضبط إعدادت جدول الايكسل:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(20, 178);
            this.textBoxFileName.MaxLength = 255;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxFileName.Size = new System.Drawing.Size(234, 43);
            this.textBoxFileName.TabIndex = 29;
            this.textBoxFileName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFileName_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 184);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(108, 34);
            this.label2.TabIndex = 30;
            this.label2.Text = "إسم الملف:";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolderPath.Location = new System.Drawing.Point(20, 107);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(234, 43);
            this.textBoxFolderPath.TabIndex = 31;
            this.textBoxFolderPath.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFolderPath_Validating);
            // 
            // checkBoxStyleLikeDgv
            // 
            this.checkBoxStyleLikeDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStyleLikeDgv.Checked = true;
            this.checkBoxStyleLikeDgv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStyleLikeDgv.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStyleLikeDgv.ForeColor = System.Drawing.Color.Green;
            this.checkBoxStyleLikeDgv.Location = new System.Drawing.Point(166, 396);
            this.checkBoxStyleLikeDgv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxStyleLikeDgv.Name = "checkBoxStyleLikeDgv";
            this.checkBoxStyleLikeDgv.Size = new System.Drawing.Size(239, 76);
            this.checkBoxStyleLikeDgv.TabIndex = 34;
            this.checkBoxStyleLikeDgv.Tag = "256";
            this.checkBoxStyleLikeDgv.Text = "الحفاظ  على تنسيق الجدول (كما في جدول الرئيسي)";
            this.checkBoxStyleLikeDgv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBoxStyleLikeDgv.UseVisualStyleBackColor = true;
            this.checkBoxStyleLikeDgv.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxAutoFitColumns
            // 
            this.checkBoxAutoFitColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoFitColumns.AutoSize = true;
            this.checkBoxAutoFitColumns.Checked = true;
            this.checkBoxAutoFitColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoFitColumns.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoFitColumns.ForeColor = System.Drawing.Color.Green;
            this.checkBoxAutoFitColumns.Location = new System.Drawing.Point(177, 256);
            this.checkBoxAutoFitColumns.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxAutoFitColumns.Name = "checkBoxAutoFitColumns";
            this.checkBoxAutoFitColumns.Size = new System.Drawing.Size(228, 38);
            this.checkBoxAutoFitColumns.TabIndex = 33;
            this.checkBoxAutoFitColumns.Tag = "16";
            this.checkBoxAutoFitColumns.Text = "ضبط تلقائي لأعمدة الخلايا";
            this.checkBoxAutoFitColumns.UseVisualStyleBackColor = true;
            this.checkBoxAutoFitColumns.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxTableRightToLeft
            // 
            this.checkBoxTableRightToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTableRightToLeft.AutoSize = true;
            this.checkBoxTableRightToLeft.Checked = true;
            this.checkBoxTableRightToLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTableRightToLeft.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTableRightToLeft.ForeColor = System.Drawing.Color.Green;
            this.checkBoxTableRightToLeft.Location = new System.Drawing.Point(169, 327);
            this.checkBoxTableRightToLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxTableRightToLeft.Name = "checkBoxTableRightToLeft";
            this.checkBoxTableRightToLeft.Size = new System.Drawing.Size(236, 38);
            this.checkBoxTableRightToLeft.TabIndex = 35;
            this.checkBoxTableRightToLeft.Tag = "16";
            this.checkBoxTableRightToLeft.Text = "الجدول من اليمين الى اليسار";
            this.checkBoxTableRightToLeft.UseVisualStyleBackColor = true;
            this.checkBoxTableRightToLeft.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btnSelectFolderPath
            // 
            this.btnSelectFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolderPath.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolderPath.Location = new System.Drawing.Point(260, 107);
            this.btnSelectFolderPath.Name = "btnSelectFolderPath";
            this.btnSelectFolderPath.Size = new System.Drawing.Size(139, 43);
            this.btnSelectFolderPath.TabIndex = 36;
            this.btnSelectFolderPath.Text = "إختر مسار الملف";
            this.btnSelectFolderPath.UseVisualStyleBackColor = true;
            this.btnSelectFolderPath.Click += new System.EventHandler(this.btnSelectFolderPath_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(87, 553);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(259, 30);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تحديد عواميد معينة (من الإعدادات)";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ctrlHeader1
            // 
            this.ctrlHeader1.BackColor = System.Drawing.Color.Gray;
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlHeader1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHeader1.Location = new System.Drawing.Point(0, 0);
            this.ctrlHeader1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(418, 40);
            this.ctrlHeader1.TabIndex = 0;
            // 
            // frmExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(418, 651);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSelectFolderPath);
            this.Controls.Add(this.checkBoxTableRightToLeft);
            this.Controls.Add(this.checkBoxStyleLikeDgv);
            this.Controls.Add(this.checkBoxAutoFitColumns);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.linkLabelResetTextBoxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlHeader1);
            this.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmExportToExcel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ضبط إعدادت جدول الايكسل";
            this.Load += new System.EventHandler(this.frmExportToExcel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlHeader ctrlHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExoprtToExcel;
        private System.Windows.Forms.LinkLabel linkLabelResetTextBoxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.CheckBox checkBoxStyleLikeDgv;
        private System.Windows.Forms.CheckBox checkBoxAutoFitColumns;
        private System.Windows.Forms.CheckBox checkBoxTableRightToLeft;
        private System.Windows.Forms.Button btnSelectFolderPath;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}