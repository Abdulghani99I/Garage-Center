using System;
using System.Windows.Forms;

namespace ManagementCars
{
    public partial class ctrlHeader : UserControl
    {
        bool _EnableFormDrag = false;

        public delegate void RefrechTable();
        // Declare an event using the delegate
        public event RefrechTable BackButtonSettings_Click;

        internal bool EnableFormDrag
        {
            set
            { 
                if (value == true)
                {
                    _EnableFormDrag = true;
                    clsMakeFormMover.EnableFormDrag(this.FindForm(), this);
                }
                else
                {
                    _EnableFormDrag = false;
                    clsMakeFormMover.DisableFormDrag(this);
                }
            }  

            get { return _EnableFormDrag; }
        }

        internal bool EnableFormDragAndMaximizeFormWhenAtTop
        {
            set
            { 
                if (value == true)
                {
                    _EnableFormDrag = true;
                    clsMakeFormMover.EnableFormDrag(this.FindForm(), this, true);
                }
                else
                {
                    _EnableFormDrag = false;
                    clsMakeFormMover.DisableFormDrag(this);
                }
            }  

            get { return _EnableFormDrag; }
        }

        internal bool EnableFormMaximize
        {
            set
            {
                if (value == true)
                {
                    clsMakeFormMover.EnableFormMaximizeByDoubleClickOnHeader(this.FindForm(), this);
                    btnMaximizedForm.Visible = true;
                }
                else
                {
                    clsMakeFormMover.DisableFormMaximizeByDoubleClickOnHeader(this);
                    btnMaximizedForm.Visible = false;
                }
            }

            get { return btnMaximizedForm.Visible; }
        }

        internal bool EnableFormMinimize
        {
            set
            {
                if (value == true)
                {
                    btnMinimizedForm.Visible = true;
                }
                else
                {
                    btnMinimizedForm.Visible = false;
                }
            }

            get { return btnMinimizedForm.Visible; }
        }

        internal bool EnableButtonSettings
        {
            set
            {
                if (value == true)
                {
                    btnSettings.Visible = true;
                }
                else
                {
                    btnSettings.Visible = false;
                }
            }

            get { return btnSettings.Visible; }
        }

        public ctrlHeader()
        {
            InitializeComponent();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void buttonMaximizedForm_Click(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState == FormWindowState.Normal)
            {
                this.FindForm().WindowState = FormWindowState.Maximized;
            }
            else if (this.FindForm().WindowState == FormWindowState.Maximized)
            {
                this.FindForm().WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizedForm_Click(object sender, EventArgs e)
        {
           this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            BackButtonSettings_Click?.Invoke();
        }
    }
}
