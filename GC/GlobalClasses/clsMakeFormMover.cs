using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCars
{
    internal class clsMakeFormMover
    {

        // Importing the necessary user32.dll functions
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public static void EnableFormDrag(Form form, UserControl userControl, bool isMaximizeFormWhenAtTop = false)
        {
            if (form == null || userControl == null) return;

            userControl.MouseMove += new MouseEventHandler((sender, e) =>
            {
                //MessageBox.Show("MouseUp");
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }

                if (isMaximizeFormWhenAtTop)
                {
                    if (form.Top <= 0 && e.Button == MouseButtons.Left)
                    {
                        // Maximize the form
                        form.WindowState = FormWindowState.Maximized;
                    }
                }
            });
        }
        
        public static void EnableFormDrag(Form form, Control control, object Sender, MouseEventArgs E)
        {
            if (form == null || control == null) return;

            control.MouseMove += new MouseEventHandler((sender, e) =>
            {
                //MessageBox.Show("MouseUp");
                if (E.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }

                //if (isMaximizeFormWhenAtTop)
                //{
                //    if (form.Top <= 0 && e.Button == MouseButtons.Left)
                //    {
                //        // Maximize the form
                //        form.WindowState = FormWindowState.Maximized;
                //    }
                //}
            });
        }

        public static void EnableFormMaximizeByDoubleClickOnHeader(Form form, UserControl userControl)
        {
            if (form == null || userControl == null) return;

            userControl.DoubleClick += new EventHandler((sender, e) =>
            {
                if (form.WindowState == FormWindowState.Normal)
                {
                    form.WindowState = FormWindowState.Maximized;
                }
                else if (form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
            });
        }

        public static void DisableFormDrag(UserControl userControl)
        {
            if (userControl != null)
            {
                userControl.MouseMove -= new MouseEventHandler((sender, e) =>
                {
                    // Empty event handler to remove the original one
                });
            }
        }

        public static void DisableFormMaximizeByDoubleClickOnHeader(UserControl userControl)
        {
            if (userControl != null)
            {
                userControl.DoubleClick -= new EventHandler((sender, e) =>
                {
                    // Empty event handler to remove the original one
                });
            }
        }
       
    }
}