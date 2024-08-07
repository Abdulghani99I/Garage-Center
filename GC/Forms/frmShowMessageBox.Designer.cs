namespace ManagementCars
{
    partial class frmMessageBox
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
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.ctrlHeader1 = new ManagementCars.ctrlHeader();
            this.SuspendLayout();
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.Location = new System.Drawing.Point(24, 42);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(385, 117);
            this.lblMessageBox.TabIndex = 1;
            this.lblMessageBox.Text = "ستضهر الرسالة هنا في هذا التنسيق ستضهر الرسالة هنا في هذا التنسيق ستضهر الرسالة ه" +
    "نا في هذا التنسيق";
            this.lblMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Gray;
            this.lblCaption.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(69, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(300, 35);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "هل انت متاكد هل انت متاكد هل انت متاكد";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseDown);
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(245, 166);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(109, 46);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "لا";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.AutoSize = true;
            this.btnYes.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(71, 166);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(109, 46);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "نعم";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // ctrlHeader1
            // 
            this.ctrlHeader1.BackColor = System.Drawing.Color.Gray;
            this.ctrlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlHeader1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHeader1.Location = new System.Drawing.Point(0, 0);
            this.ctrlHeader1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ctrlHeader1.Name = "ctrlHeader1";
            this.ctrlHeader1.Size = new System.Drawing.Size(425, 38);
            this.ctrlHeader1.TabIndex = 0;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.ctrlHeader1);
            this.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowMessageBox";
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMessageBox_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlHeader ctrlHeader1;
        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
    }
}