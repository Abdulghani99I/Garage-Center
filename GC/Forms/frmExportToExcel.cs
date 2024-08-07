using ManagementCars.GlobalClasses;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ManagementCars.Forms
{
    public partial class frmExportToExcel : Form
    {
        DataGridView _dgv;

        public delegate void Delegate();
        public event Delegate Back_RefrechrTable;

        public frmExportToExcel(DataGridView dgv)
        {
            InitializeComponent();

            _dgv = dgv;
        }

        private void frmExportToExcel_Load(object sender, EventArgs e)
        {
            ctrlHeader1.EnableFormDrag = true;

            textBoxFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBoxFileName.Text = "ClientDate.xlsx";

            checkBoxAutoFitColumns.Checked = true;
            checkBoxStyleLikeDgv.Checked = true;
            checkBoxTableRightToLeft.Checked = true;
        }

        private void btnSelectFolderPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "اختيار مسار الملف";
                folderDialog.ShowNewFolderButton = true;
                
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFolderPath.Text = folderDialog.SelectedPath;
                    
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ck = (CheckBox)sender;

            if (ck.Checked)
                ck.ForeColor = Color.Green;
            else
                ck.ForeColor = Color.Red;
        }

        private void textBoxFolderPath_Validating(object sender, CancelEventArgs e)
        {
            if (!Directory.Exists(textBoxFolderPath.Text))
            {
                errorProvider1.SetError(textBoxFolderPath, "المسار غير صحيح");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxFolderPath, string.Empty);
            }
        }

        private void textBoxFileName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFileName.Text))
            {
                errorProvider1.SetError(textBoxFolderPath, "يجب إدخا اسم الملف");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxFolderPath, string.Empty);
            }

            // check if file name don't End with xlsx then Add ".xlsx"
            if (!textBoxFileName.Text.EndsWith(".xlsx"))
            {
                textBoxFileName.Text += ".xlsx";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabelResetForm_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Reload Form
            frmExportToExcel_Load(null, null);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (! this.ValidateChildren())
            {
                clsMessageBox.ShowDialog("خطأ","\n" + "قم بإدخال مسار صحيح", "حسنا");
                return;
            }

            string filePath = Path.Combine(textBoxFolderPath.Text, textBoxFileName.Text);

            if (clsMessageBox.ShowDialog("تأكيد", "هل تريد تصدير بيانات الجدول الحالي الى ملف ايكسل ؟", "تصدير", "لا") == DialogResult.OK)
            {
                // change Cursor Mouse to "WaitCursor"
                Cursor = Cursors.WaitCursor;

                // return Cursor Mouse to default

                if (clsConvertDgvToExcel.ExportDataGridViewToExcel(_dgv, filePath, checkBoxTableRightToLeft.Checked, checkBoxStyleLikeDgv.Checked, checkBoxAutoFitColumns.Checked))
                {
                    Cursor = Cursors.Default;
                    if (clsMessageBox.ShowDialog("معلومة", "تم تصدير البيانات الى صيغة ملف ايكسل ", "فتح", "إغلاق") == DialogResult.OK)
                    {
                        // if Click on open, open file
                        try
                        {
                            System.Diagnostics.Process.Start(filePath);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            clsMessageBox.ShowDialog("خطا", "حدث خطأ أثناء محاولة فتح الملف" + "\n" + "Message Error: " + ex.Message, "حسنا");
                        }
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    clsMessageBox.ShowDialog("خطا", "حدث خطأ أثناء التحويل الى ايكسل" + "\n" + "ممكن ان يكون السبب ان البرنامج غير مسوح له ان يصل الى هذا المسار", "حسنا");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
            Back_RefrechrTable?.Invoke();
        }
    }
}
