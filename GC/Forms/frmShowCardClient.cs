using ClientBuisness;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementCars
{
    public partial class frmShowCardClient : Form
    {
        int _ClientID = -1;

        public frmShowCardClient(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;
        }

        private void frmShowDetailsClient_Load(object sender, EventArgs e)
        {
            ctrlHeader1.EnableFormDragAndMaximizeFormWhenAtTop = true;
            ctrlHeader1.EnableFormMaximize = true;


            clsClient Client = clsClient.FindByClientID(_ClientID);

            lblID.Text = _ClientID.ToString();
            lblCarName.Text = Client.CarName;
            lblChassisNumber.Text = Client.ChassisNumber;
            lblOwnerName.Text = Client.OwnerName;
            lblCarColor.Text = Client.CarColor;
            txtDescription.Text = Client.Description;
            lblCardStartDate.Text = Client.StartDate.ToString("yyyy/MM/dd | h:mm tt");
            lblCardEndDate.Text = Client.EndDate.ToString("yyyy/MM/dd | h:mm tt");

            lblCardValidity.Text = Client.CardValidityPeriod;
            
            // Here we change color
            if (Client.EndDate < DateTime.Now)
            {
                // in this case CardValidityPeriod is Invalid
                lblCardValidity.ForeColor = Color.Red;
            }
            else
            {
                // in this case CardValidityPeriod is valid
                lblCardValidity.ForeColor = Color.Green;
            }
        }

        private void txtDescription_MouseEnter(object sender, EventArgs e)
        {
            // dont allow user to select text

            Size textSize = TextRenderer.MeasureText(txtDescription.Text, txtDescription.Font);
            if (textSize.Width > txtDescription.ClientSize.Width || textSize.Height > txtDescription.ClientSize.Height)
            {
                txtDescription.ScrollBars = ScrollBars.Vertical; // تمكين شريط التمرير العمودي عند الحاجة
            }
            else
            {
                txtDescription.ScrollBars = ScrollBars.None; // تعطيل شريط التمرير إذا لم يكن هناك حاجة
            }
        }

        private void txtDescription_MouseLeave(object sender, EventArgs e)
        {
            txtDescription.ScrollBars = ScrollBars.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowCardClient_Paint(object sender, PaintEventArgs e)
        {
            clsFormat.AddBorderToForm(this, Color.FromArgb(70, 70, 70), 2, e.Graphics);
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            clsMessageBox.ShowDialog("معلومة", "سيتم اضافتها في التحديث القادم", "حسنا");
        }
    }
}
