namespace ManagementCars
{
    partial class frmShowListClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowListClients));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntSettings = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCardValidity = new System.Windows.Forms.ComboBox();
            this.btnConvertToExcel = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.ctrlHeader1 = new ManagementCars.ctrlHeader();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowDrop = true;
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgvClients, "dgvClients");
            this.dgvClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowTemplate.Height = 30;
            this.dgvClients.RowTemplate.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.TabStop = false;
            this.dgvClients.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClients_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewClient,
            this.toolStripSeparator1,
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator2,
            this.إضافةToolStripMenuItem,
            this.toolStripSeparator3,
            this.حذفToolStripMenuItem,
            this.toolStripSeparator4,
            this.PrintToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ViewClient
            // 
            this.ViewClient.Image = global::ManagementCars.Properties.Resources.show_35;
            resources.ApplyResources(this.ViewClient, "ViewClient");
            this.ViewClient.Name = "ViewClient";
            this.ViewClient.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = global::ManagementCars.Properties.Resources.edit_user_35;
            resources.ApplyResources(this.تعديلToolStripMenuItem, "تعديلToolStripMenuItem");
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.Image = global::ManagementCars.Properties.Resources.add_users_35;
            resources.ApplyResources(this.إضافةToolStripMenuItem, "إضافةToolStripMenuItem");
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Click += new System.EventHandler(this.AddNewToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::ManagementCars.Properties.Resources.delete_user_35;
            resources.ApplyResources(this.حذفToolStripMenuItem, "حذفToolStripMenuItem");
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // PrintToolStripMenuItem
            // 
            resources.ApplyResources(this.PrintToolStripMenuItem, "PrintToolStripMenuItem");
            this.PrintToolStripMenuItem.Image = global::ManagementCars.Properties.Resources.print_35;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // bntSettings
            // 
            resources.ApplyResources(this.bntSettings, "bntSettings");
            this.bntSettings.Name = "bntSettings";
            this.bntSettings.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            resources.ApplyResources(this.lbl, "lbl");
            this.lbl.Name = "lbl";
            // 
            // lblRecordsCount
            // 
            resources.ApplyResources(this.lblRecordsCount, "lblRecordsCount");
            this.lblRecordsCount.Name = "lblRecordsCount";
            // 
            // comboBoxFilter
            // 
            resources.ApplyResources(this.comboBoxFilter, "comboBoxFilter");
            this.comboBoxFilter.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            resources.GetString("comboBoxFilter.Items"),
            resources.GetString("comboBoxFilter.Items1"),
            resources.GetString("comboBoxFilter.Items2"),
            resources.GetString("comboBoxFilter.Items3"),
            resources.GetString("comboBoxFilter.Items4"),
            resources.GetString("comboBoxFilter.Items5"),
            resources.GetString("comboBoxFilter.Items6")});
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // textBoxFilter
            // 
            resources.ApplyResources(this.textBoxFilter, "textBoxFilter");
            this.textBoxFilter.BackColor = System.Drawing.Color.White;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilter_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBoxCardValidity);
            this.panel1.Controls.Add(this.btnConvertToExcel);
            this.panel1.Controls.Add(this.btnAddNewClient);
            this.panel1.Controls.Add(this.btnUpdateData);
            this.panel1.Controls.Add(this.ctrlHeader1);
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.dgvClients);
            this.panel1.Controls.Add(this.textBoxFilter);
            this.panel1.Controls.Add(this.lblRecordsCount);
            this.panel1.Controls.Add(this.lbl);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::ManagementCars.Properties.Resources.search_user_45;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCardValidity
            // 
            resources.ApplyResources(this.comboBoxCardValidity, "comboBoxCardValidity");
            this.comboBoxCardValidity.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxCardValidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCardValidity.FormattingEnabled = true;
            this.comboBoxCardValidity.Items.AddRange(new object[] {
            resources.GetString("comboBoxCardValidity.Items"),
            resources.GetString("comboBoxCardValidity.Items1")});
            this.comboBoxCardValidity.Name = "comboBoxCardValidity";
            this.comboBoxCardValidity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCardValidity_SelectedIndexChanged);
            // 
            // btnConvertToExcel
            // 
            this.btnConvertToExcel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConvertToExcel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConvertToExcel.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnConvertToExcel, "btnConvertToExcel");
            this.btnConvertToExcel.Image = global::ManagementCars.Properties.Resources.microsoft_excel_2019_70;
            this.btnConvertToExcel.Name = "btnConvertToExcel";
            this.btnConvertToExcel.UseVisualStyleBackColor = false;
            this.btnConvertToExcel.Click += new System.EventHandler(this.btnConvertToExcel_Click);
            // 
            // btnAddNewClient
            // 
            resources.ApplyResources(this.btnAddNewClient, "btnAddNewClient");
            this.btnAddNewClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewClient.FlatAppearance.BorderSize = 0;
            this.btnAddNewClient.Image = global::ManagementCars.Properties.Resources.add_users_70;
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.UseVisualStyleBackColor = false;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnUpdateData
            // 
            resources.ApplyResources(this.btnUpdateData, "btnUpdateData");
            this.btnUpdateData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.Image = global::ManagementCars.Properties.Resources.refresh_40;
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // ctrlHeader1
            // 
            this.ctrlHeader1.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.ctrlHeader1, "ctrlHeader1");
            this.ctrlHeader1.Name = "ctrlHeader1";
            // 
            // frmShowListClients
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmShowListClients";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowListClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.Button bntSettings;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private ctrlHeader ctrlHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.ToolStripMenuItem ViewClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnConvertToExcel;
        private System.Windows.Forms.ComboBox comboBoxCardValidity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}