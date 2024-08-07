using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCars
{

    internal partial class frmMessageBox : Form
    {
        private DialogResult _resultDialog;

        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            ctrlHeader1.EnableFormDrag = true;
        }

        public DialogResult ShowBoxDialog(string Caption, string Message, string ValueTextYesBtn, string ValueTextNoBtn)
        {
            lblCaption.Text = Caption;
            lblMessageBox.Text = Message;

            btnYes.Text = ValueTextYesBtn;
            btnNo.Text = ValueTextNoBtn;

            btnNo.Select();

            this.ShowDialog();

            return _resultDialog;
        }

        public void ShowBoxDialog(string Caption, string Message, string EnableOnlybtnYesAndValueText)
        {
            lblCaption.Text = Caption;
            lblMessageBox.Text = Message;

            // in this case we only visable First button and make second button visable => false
            btnYes.Text = EnableOnlybtnYesAndValueText;

            Point NewLocationButtonYes = new Point((this.Width - btnYes.Width) / 2, btnYes.Location.Y);
            btnYes.Location = NewLocationButtonYes;

            btnNo.Visible = false;

            btnYes.Select();

            this.ShowDialog();
        }
        

        private void buttonYes_Click(object sender, EventArgs e)
        {
            _resultDialog = DialogResult.OK;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            _resultDialog = DialogResult.Cancel;
            this.Close();
        }

        private void lblCaption_MouseDown(object sender, MouseEventArgs e)
        {
            // because lblCaption On the ctrlHeader, we make lblCaption when (work MouseDown event)
            // then should form move
            clsMakeFormMover.EnableFormDrag(this, lblCaption, sender, e);
        }

        private void frmMessageBox_Paint(object sender, PaintEventArgs e)
        {
            clsFormat.AddBorderToForm(this, Color.FromArgb(70, 70, 70), 2, e.Graphics);

        }
    }

}
