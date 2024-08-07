using ClientBuisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ManagementCars
{
    public partial class frmAddUpdateClient : Form
    {
        clsClient _Client = new clsClient();

        private int _ClientID = -1;
        private int _PreviousValueNumricUpDown;
        private DateTime _StartDate, _EndDate;

        enum enMode { AddNew, Update}
        enMode Mode = enMode.AddNew;

        public frmAddUpdateClient()
        {
            InitializeComponent();
            Mode = enMode.AddNew;

            ctrlNumricUpDown.valueChanged += numericUpDown_ValueChanged;
        }
        
        public frmAddUpdateClient(int ClientID)
        {
            InitializeComponent();
            
            _ClientID = ClientID;
            Mode = enMode.Update;

            ctrlNumricUpDown.valueChanged += numericUpDown_ValueChanged;
        }

        private void frmAddNew_Load(object sender, EventArgs e)
        {
            // here set setting ctrlHeader
            ctrlHeader1.EnableFormDragAndMaximizeFormWhenAtTop = true;
            ctrlHeader1.EnableFormMaximize = true;

            
            if (Mode == enMode.Update)
            {
                lblTitle.Text = "التعديل على البطاقة";

                // show ToggleSwitch, and enable reduce numricUpDown and increrment
                ToggleSwitch.Visible = true;
                ToggleSwitch.Checked = false;
                panelAddPeriodDate.Enabled = false;

                ctrlNumricUpDown.Minimum = -50;
                ctrlNumricUpDown.Maximum = 50;

                _Client = clsClient.FindByClientID(_ClientID);

                lblIDClient.Text = _ClientID.ToString();
                textBoxOwnerName.Text = _Client.OwnerName;
                textBoxCarName.Text = _Client.CarName;
                textBoxChassisNumber.Text = _Client.ChassisNumber;
                textBoxCarColor.Text = _Client.CarColor;
                textBoxDescription.Text = _Client.Description;

                ctrlNumricUpDown.Value = 0;
            }
            else
            {
                lblTitle.Text = "إضافة بطاقة جديدة";

                ctrlNumricUpDown.Minimum = 0;
                ctrlNumricUpDown.Maximum = 50;

                // set start Date card and end date
                _Client.StartDate = DateTime.Now;

                // increment EndDate 3 days because we wan't increment date 3 days by default
                ctrlNumricUpDown.Value = 3;
                _Client.EndDate = DateTime.Now.AddDays(3);

            }

            _StartDate = _Client.StartDate;
            _EndDate = _Client.EndDate;
            lblStartDate.Text = _Client.StartDate.ToString("yyyy/MM/dd | h:mm tt");
            lblEndDate.Text = _Client.EndDate.ToString("yyyy/MM/dd | h:mm tt");

            _PreviousValueNumricUpDown = ctrlNumricUpDown.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // if Check text boxes in form, Filled right way or not.
            if (!this.ValidateChildren())
            {
                return;
            }

            _Client.OwnerName = textBoxOwnerName.Text.Trim();
            _Client.CarName = textBoxCarName.Text.Trim();
            _Client.ChassisNumber = textBoxChassisNumber.Text.Trim();
            _Client.CarColor = textBoxCarColor.Text.Trim();
            _Client.Description = textBoxDescription.Text.Trim();
            _Client.StartDate = _StartDate;
            _Client.EndDate = _EndDate;

            // 'Client.StartDate' And 'Client.EndDate' is Added direct when select date (Dirctly)
            if (_Client.Save())
            {
                if (Mode == enMode.AddNew)
                    SwetchToModeUpdate();

                lblIDClient.Text = _Client.ClientID.ToString();
                

                if (clsMessageBox.ShowDialog("معلومة", "تم حفظ العملية بنجاح", "عرض البطاقة", "إغلاق") == DialogResult.OK)
                {
                    // in this case we show CardClient
                    frmShowCardClient frm = new frmShowCardClient(_Client.ClientID);
                    frm.ShowDialog();
                }
            }
            else
            {
                clsMessageBox.ShowDialog("خطأ", "حدث خطأ ما, لم يتم حفظ العملية", "حسنا");
            }
        }

        private void SwetchToModeUpdate()
        {
            Mode = enMode.Update;
            _ClientID = _Client.ClientID;
            frmAddNew_Load(null, null);
        }

        private void btnSave_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = ((TextBox)sender);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, " '_' اذا كنت تريد ترك الحقل فارغ ضع اي شي على سيبل المثال");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, string.Empty);
            }
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            RichTextBox richTextBox = ((RichTextBox)sender);

            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                errorProvider1.SetError(richTextBox, " '_' اذا كنت تريد ترك الحقل فارغ ضع اي شي على سيبل المثال");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(richTextBox, string.Empty);
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch.Checked)
            {
                panelAddPeriodDate.Enabled = true;
            }
            else
            {
                panelAddPeriodDate.Enabled = false;
                
                // reset End date and handle it in form
                ctrlNumricUpDown.Value = 0;
                _EndDate = _Client.EndDate;
                lblEndDate.Text = _Client.EndDate.ToString("yyyy/MM/dd | h:mm tt");
                lblPreiodValidityCard.Text = "زيادة مدة الصلاحية:";
                lblPreiodValidityCard.ForeColor = Color.Green;
                ctrlNumricUpDown.TextColor = Color.Green;
            }
        }

        private void numericUpDown_ValueChanged()
        {
            if (ctrlNumricUpDown.Value < 0)
            {
                lblPreiodValidityCard.Text = "تقليل مدة الصلاحية:";
                lblPreiodValidityCard.ForeColor = Color.Red;
                ctrlNumricUpDown.TextColor = Color.Red;
            }
            else
            {
                lblPreiodValidityCard.Text = "زيادة مدة الصلاحية:";
                lblPreiodValidityCard.ForeColor = Color.Green;
                ctrlNumricUpDown.TextColor = Color.Green;
            }


            if (_PreviousValueNumricUpDown < ctrlNumricUpDown.Value)
            {
                _EndDate = _EndDate.AddDays(1);
            }
            else
            {
                // The specified end date must be at least one day greater than the start date
                if (_StartDate.AddDays(1) >= _EndDate)
                {
                    ctrlNumricUpDown.Value = _PreviousValueNumricUpDown;
                    clsMessageBox.ShowDialog("معلومة", "يجب ان تكون صلاحية البطاقة يوم على الاقل", "حسنا");
                    return;
                }
                _EndDate = _EndDate.AddDays(-1);
            }

            lblEndDate.Text = _EndDate.ToString("yyyy/MM/dd | h:mm tt");
            _PreviousValueNumricUpDown = ctrlNumricUpDown.Value;
        }
    }
}
