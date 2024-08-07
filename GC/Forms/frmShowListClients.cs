using System;
using System.Windows.Forms;
using System.Data;
using ClientBuisness;
using ManagementCars.GlobalClasses;
using ManagementCars.Properties;
using ManagementCars.Forms;

namespace ManagementCars
{
    public partial class frmShowListClients : Form
    {
        private DataTable  _dtClients;

        public frmShowListClients()
        {   
            InitializeComponent();

            // when click on button settings this button return this event
            ctrlHeader1.BackButtonSettings_Click += buttonSettings_Click;

            // set settings ctrlHeader
            ctrlHeader1.EnableFormDragAndMaximizeFormWhenAtTop = true;
            ctrlHeader1.EnableFormMaximize = true;
            ctrlHeader1.EnableFormMinimize = true;
            ctrlHeader1.EnableButtonSettings = true;
        }

        private void frmShowListClients_Load(object sender, EventArgs e)
        {
            // تعيين الـ ToolTip للـ DataGridView

            // default selected in combo Box Filter is "None" ("غير محدد")
            comboBoxFilter.SelectedIndex = 0;

            // default selected in sub combo Box Filter is "Valid" ("بطاقة صالحة")
            comboBoxCardValidity.SelectedIndex = 0;

            _dtClients = clsClient.GetAllClient();

            lblRecordsCount.Text = _dtClients.Rows.Count.ToString();

            if (_dtClients.Rows.Count > 0)
            {
                // we want to show format startDate and EndDate like this for Example => (AM 05:20	| 2024-03-03) 
                var FormatDate = new DataGridViewCellStyle();
                FormatDate.Format = "yyyy-MM-dd | tt hh:mm";


                dgvClients.DataSource = _dtClients;


                dgvClients.Columns[0].HeaderText = "رقم المعرف";
                dgvClients.Columns[0].Width = 60;
                dgvClients.Columns[0].Tag = 1;

                dgvClients.Columns[1].HeaderText = "أسم المالك";
                dgvClients.Columns[1].Width = 200;
                dgvClients.Columns[1].Tag = 2;

                dgvClients.Columns[2].HeaderText = "أسم السيارة";
                dgvClients.Columns[2].Width = 200;
                dgvClients.Columns[2].Tag = 4;

                dgvClients.Columns[3].HeaderText = "رقم الشاصي";
                dgvClients.Columns[3].Width = 150;
                dgvClients.Columns[3].Tag = 8;

                dgvClients.Columns[4].HeaderText = "لون السيارة";
                dgvClients.Columns[4].Width = 100;
                dgvClients.Columns[4].Tag = 16;

                dgvClients.Columns[5].HeaderText = "الوصف";
                dgvClients.Columns[5].Width = 250;
                dgvClients.Columns[5].Tag = 32;

                dgvClients.Columns[6].HeaderText = "تاريخ البدء";
                dgvClients.Columns[6].Width = 150;
                dgvClients.Columns[6].Tag = 64;
                dgvClients.Columns[6].DefaultCellStyle = FormatDate;

                dgvClients.Columns[7].HeaderText = "تاريخ الانتهاء";
                dgvClients.Columns[7].Width = 150;
                dgvClients.Columns[7].Tag = 128;
                dgvClients.Columns[7].DefaultCellStyle = FormatDate;

                dgvClients.Columns[8].HeaderText = "صلاحية البطاقة";
                dgvClients.Columns[8].Width = 150;
                dgvClients.Columns[8].Tag = 256;


                handleVisableColumns();
            }
        }

        private void handleVisableColumns()
        {
            foreach (DataGridViewColumn Column in dgvClients.Columns)
            {
                int TagValue = Convert.ToInt32(Column.Tag);

                // here we use bit wise in varible (Settings.Default.BitWiseShowColumns)
                // we represent Visable Colomns by useing Bitwise
                if ((TagValue & Settings.Default.BitWiseShowColumns) == TagValue)
                {
                    Column.Visible = true;
                }
                else
                {
                    Column.Visible = false;
                } 
            }
        }

        private void RefrechDataTable()
        {
            string PreviousRowFilter =_dtClients.DefaultView.RowFilter;
            _dtClients = clsClient.GetAllClient();

            // return set PreviousRowFilter
            _dtClients.DefaultView.RowFilter = PreviousRowFilter;

            dgvClients.DataSource = _dtClients;
            lblRecordsCount.Text = dgvClients.RowCount.ToString();
        }

        private void buttonSettings_Click()
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
            handleVisableColumns();
        }
        
        private void textBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string FilterColumn = CurrentRealNameInFilterComboBox();

            // In this case we deal with Number
            if (FilterColumn == "ClientID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = CurrentRealNameInFilterComboBox();

            if (textBoxFilter.Text.Trim() == string.Empty || textBoxFilter.Text == "None")
            {
                _dtClients.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "ClientID")
            {
                // In this case we deal with number
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textBoxFilter.Text.Trim());
            }
            else
            {
                if (FilterColumn == "Description")
                {
                    _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", FilterColumn, textBoxFilter.Text.Trim());
                }
                else
                {
                    _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, textBoxFilter.Text.Trim());
                }
            }

            lblRecordsCount.Text = _dtClients.DefaultView.Count.ToString();
        }
        
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtClients == null) return;

            // reset textBoxFilter allways when selected Change
            textBoxFilter.Text = string.Empty;

            string FilterColumn = CurrentRealNameInFilterComboBox();

            //if (FilterColumn == "None")
            //{
                _dtClients.DefaultView.RowFilter = string.Empty;
                lblRecordsCount.Text = _dtClients.Rows.Count.ToString();
            //}

            if (FilterColumn == "CardValidity")
            {
                // if selected CardValidity then should comboBoxCardValidity implement default select
                comboBoxCardValidity_SelectedIndexChanged(null, null);
            }

            // Show textBoxFilter if Filter was don't equel "None" and don't equel "CardValidity"
            textBoxFilter.Visible = (FilterColumn != "None" && FilterColumn != "CardValidity");
            
            // Show comboBoxCardValidity if Filter was equel CardValidity
            comboBoxCardValidity.Visible = (FilterColumn == "CardValidity");

            textBoxFilter.Focus();
        }

        private void comboBoxCardValidity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtClients == null) return;

            // here don't use Filter textBox so value it Empty. to make Rows by right way
            textBoxFilter.Text = string.Empty;

            string FilterColumn = "CardValidityPeriod";
            string RealNameComboBox = string.Empty;

            // Set Real Name for comboBox
            switch (comboBoxCardValidity.Text)
            {
                case "صالحة":
                    RealNameComboBox = "Valid";
                    break;

                case "غير صالحة":
                    RealNameComboBox = "InValid";
                    break;
            }

            if (RealNameComboBox == "Valid")
            {
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, "لم تنتهي");
            }
            else
            {
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, "إنتهت");
            }

            lblRecordsCount.Text = dgvClients.RowCount.ToString();
        }

        private string CurrentRealNameInFilterComboBox()
        {
            string FilterColumn = string.Empty;

            //Map Selected Filter to real Column name
            switch (comboBoxFilter.Text)
            {
                case "رقم المعرف":
                    FilterColumn = "ClientID";
                    break;

                case "أسم السيارة":
                    FilterColumn = "CarName";
                    break;

                case "رقم الشاصي":
                    FilterColumn = "ChassisNumber";
                    break;

                case "لون السيارة":
                    FilterColumn = "CarColor";
                    break;

                case "أسم المالك":
                    FilterColumn = "OwnerName";
                    break;
                
                case "حالة البطاقة":
                    FilterColumn = "CardValidity";
                    break;

                case "الوصف":
                    FilterColumn = "Description";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            return FilterColumn;
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormCardCleint();
        }
        
        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormAddNewClient();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                // Save Previous selectedClientId
                int selectedClientId = (int)dgvClients.SelectedRows[0].Cells[0].Value;

                
                frmAddUpdateClient frm = new frmAddUpdateClient(selectedClientId);
                frm.ShowDialog();

                // Refrech Table After Update Client
                RefrechDataTable();

                // After Update reutrn the row slelected
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if ((int)row.Cells[0].Value == selectedClientId)
                    {
                        row.Selected = true;
                        dgvClients.FirstDisplayedScrollingRowIndex = row.Index; // handle Scroll palce in data grid view
                        break;
                    }
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsMessageBox.ShowDialog("تحذير", "هل تريد حذف هذا العميل", "نعم", "لا") == DialogResult.OK)
            {
                int selectedClientId = (int)dgvClients.SelectedRows[0].Cells[0].Value;

                if (clsClient.DeleteClientByID(selectedClientId))
                {
                    RefrechDataTable();

                    clsMessageBox.ShowDialog("معلومة", "تم الحذف بنجاح", "حسنا");
                }
                else
                {
                    clsMessageBox.ShowDialog("خطأ", "حدث خطا ما", "حسنا");
                }
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMessageBox.ShowDialog("معلومة", "سيتم اضافتها في التحديث القادم", "حسنا");
        }
        
        private void dgvClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowFormCardCleint();
            }
        }

        private void ShowFormCardCleint()
        {
            int selectedClientId = (int) dgvClients.SelectedRows[0].Cells[0].Value;

            frmShowCardClient frm = new frmShowCardClient(selectedClientId);

            frm.ShowDialog();
        }

        private void ShowFormAddNewClient()
        {
            frmAddUpdateClient frm = new frmAddUpdateClient();
            frm.ShowDialog();

            RefrechDataTable();
        }
    
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            ShowFormAddNewClient();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            RefrechDataTable();
        }

        private void btnConvertToExcel_Click(object sender, EventArgs e)
        {
            frmExportToExcel frm = new frmExportToExcel(dgvClients);

            // we should return event to Do Refresh to visable columns
            frm.Back_RefrechrTable += handleVisableColumns;
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvClients == null || dgvClients.RowCount == 0)
            {
                contextMenuStrip1.Enabled = false;
            }
        }
    }
}

