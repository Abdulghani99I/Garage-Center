using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementCars
{
    internal class clsFormat
    {
        public static void StartPositionBottomCenterMainScreen(Form frm)
        {
            // الحصول على حجم الشاشة
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // حساب موقع الفورم ليكون في منتصف العرض وفي الأسفل
            int formWidth = frm.Width;
            int formHeight = frm.Height;

            int x = (screenWidth - formWidth) / 2;  // منتصف العرض
            int y = screenHeight - formHeight;      // أسفل الشاشة

            // تعيين موقع الفورم
            frm.Location = new Point(x, y);
        }


        public static void AddBorderToForm(Form frm, Color color, int borderWidth, Graphics graphics)
        {
            frm.Padding = new Padding(borderWidth);

            Color borderColor = color;


            // رسم الإطار باستخدام ControlPaint
            ControlPaint.DrawBorder(graphics, frm.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

    }
}
