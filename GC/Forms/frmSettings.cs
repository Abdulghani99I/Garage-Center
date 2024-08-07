using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementCars.Properties;

namespace ManagementCars
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            ctrlHeader1.EnableFormDragAndMaximizeFormWhenAtTop = true;
            ctrlHeader1.EnableFormMaximize = true;

            LoadTabPageControlDisplayTable();
        }

        private void LoadTabPageControlDisplayTable()
        {
            // we show the settings visable columns by uisng (Bitwise Operation).
            // all check boxes has tag this tag is number (uniqe bit) represent by it Checked box or not.
            foreach (CheckBox checkBox in panelContainerCheckBoxes.Controls)
            {
                int TagValue = Convert.ToInt32(checkBox.Tag);

                if ((TagValue & Settings.Default.BitWiseShowColumns) == TagValue)
                {
                    checkBox.Checked = true;
                }
                else
                    checkBox.Checked = false;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // here we change color Checked Green else read
            CheckBox ck = (CheckBox)sender;

            if (ck.Checked)
                ck.ForeColor = Color.Green;
            else
                ck.ForeColor = Color.Red;
        }

        private void linkLabelResetTextBoxes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkBoxClientID.Checked = true;
            checkBoxCarName.Checked = true;
            checkBoxChassisNumber.Checked = true;
            checkBoxCarColor.Checked = true;
            checkBoxOwnerName.Checked = true;
            checkBoxDescription.Checked = true;
            checkBoxStartDate.Checked = true;
            checkBoxEndDate.Checked = true;

            checkBoxCardValidityPeriod.Checked = false;
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            SaveSettingsControlDisplayTable();
            clsMessageBox.ShowDialog("معلومة", "تم حفظ الإعدادات بنجاح", "حسنا");
            this.Close();
        }

        private void SaveSettingsControlDisplayTable()
        {
            int ResultBitwise = 0;

            // Loop through each checkbox in the panel container
            foreach (CheckBox checkBox in panelContainerCheckBoxes.Controls)
            {
                // If the checkbox is checked, add its tag value to the ResultBitwise
                // here we save set visable columns by useing (bitwise operation),
                // all columns have tag this tag it's a uniqe bit, we represent by it visable column
                if (checkBox.Checked)
                {
                    ResultBitwise += Convert.ToInt32(checkBox.Tag);
                }
            }

            Settings.Default.BitWiseShowColumns = ResultBitwise;

            Settings.Default.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}