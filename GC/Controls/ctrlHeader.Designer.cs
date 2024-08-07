namespace ManagementCars
{
    partial class ctrlHeader
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMaximizedForm = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinimizedForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::ManagementCars.Properties.Resources.settings_47;
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(5, 5);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(59, 41);
            this.btnSettings.TabIndex = 115;
            this.btnSettings.TabStop = false;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMaximizedForm
            // 
            this.btnMaximizedForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizedForm.BackColor = System.Drawing.Color.White;
            this.btnMaximizedForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizedForm.FlatAppearance.BorderSize = 0;
            this.btnMaximizedForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizedForm.Image = global::ManagementCars.Properties.Resources.maximize_45;
            this.btnMaximizedForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMaximizedForm.Location = new System.Drawing.Point(623, 5);
            this.btnMaximizedForm.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnMaximizedForm.Name = "btnMaximizedForm";
            this.btnMaximizedForm.Size = new System.Drawing.Size(59, 41);
            this.btnMaximizedForm.TabIndex = 121;
            this.btnMaximizedForm.TabStop = false;
            this.btnMaximizedForm.UseVisualStyleBackColor = false;
            this.btnMaximizedForm.Visible = false;
            this.btnMaximizedForm.Click += new System.EventHandler(this.buttonMaximizedForm_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Image = global::ManagementCars.Properties.Resources.close_55;
            this.btnCloseForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseForm.Location = new System.Drawing.Point(685, 5);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(59, 41);
            this.btnCloseForm.TabIndex = 119;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // btnMinimizedForm
            // 
            this.btnMinimizedForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizedForm.BackColor = System.Drawing.Color.White;
            this.btnMinimizedForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizedForm.FlatAppearance.BorderSize = 0;
            this.btnMinimizedForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizedForm.Image = global::ManagementCars.Properties.Resources.shrink_57;
            this.btnMinimizedForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimizedForm.Location = new System.Drawing.Point(561, 5);
            this.btnMinimizedForm.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnMinimizedForm.Name = "btnMinimizedForm";
            this.btnMinimizedForm.Size = new System.Drawing.Size(59, 41);
            this.btnMinimizedForm.TabIndex = 120;
            this.btnMinimizedForm.TabStop = false;
            this.btnMinimizedForm.UseVisualStyleBackColor = false;
            this.btnMinimizedForm.Visible = false;
            this.btnMinimizedForm.Click += new System.EventHandler(this.btnMinimizedForm_Click);
            // 
            // ctrlHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btnMaximizedForm);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnMinimizedForm);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ctrlHeader";
            this.Size = new System.Drawing.Size(749, 52);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMaximizedForm;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimizedForm;
    }
}
