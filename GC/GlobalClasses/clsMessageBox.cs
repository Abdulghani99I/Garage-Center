using System.Windows.Forms;

namespace ManagementCars
{
    public static class clsMessageBox
    {
        public static DialogResult ShowDialog(string Caption, string MessageBox, string ValueTextYesBtn ="Yes", string ValueTextNoBtn = "No")
        {
            frmMessageBox frmMessageBox = new frmMessageBox();

           return frmMessageBox.ShowBoxDialog(Caption, MessageBox, ValueTextYesBtn, ValueTextNoBtn);
        }

        public static void ShowDialog(string Caption, string MessageBox, string ValueTextYesBtn)
        {
            frmMessageBox frmMessageBox = new frmMessageBox();

            frmMessageBox.ShowBoxDialog(Caption, MessageBox, ValueTextYesBtn);
        }
    }
}
