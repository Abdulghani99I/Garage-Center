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
    public partial class ctrlNumricUpDown : UserControl
    {
        public delegate void ValueChanged();
        // Declare an event using the delegate
        public event ValueChanged valueChanged;

        private int _Value = 0;
        private int _Minimum = 1;
        private int _Maximum = 100;

        public int Value
        {
            set 
            {
                textBoxResult.Text = value.ToString();    
                _Value = value;
            }
            get { return _Value; }
        }

        public int Maximum
        {
            set { _Maximum = value; }
            get { return _Maximum; }
        }
        public int Minimum
        {
            set { _Minimum = value; }
            get { return _Minimum; }
        }

        public Color TextColor
        {
            set { textBoxResult.ForeColor = value; }
            get { return textBoxResult.ForeColor; }
        }


        public ctrlNumricUpDown()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (_Value < Maximum)
            {
                _Value++;
                textBoxResult.Text = _Value.ToString();
                valueChanged?.Invoke();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (_Value > Minimum)
            {
                _Value--;
                textBoxResult.Text = _Value.ToString();
                valueChanged?.Invoke();
            }

        }
    }
}
