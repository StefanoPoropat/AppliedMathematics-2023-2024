using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace determinantaTrecegReda
{
    public partial class KalkulatorDeterminanteTrećegReda : Form
    {
        public KalkulatorDeterminanteTrećegReda()
        {
            InitializeComponent();
        }
        float a11=0, a12=0, a13=0, a21 = 0, a22 = 0, a23 = 0, a31 = 0, a32 = 0, a33 = 0;

        float rez = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            rez = 0;
            a11 = (int)Convert.ToSingle(txtA11.Text);
            a12 = (int)Convert.ToSingle(txtA12.Text);
            a13 = (int)Convert.ToSingle(txtA13.Text);
//-----------------------------------------------------------------------
            a21 = (int)Convert.ToSingle(txtA21.Text);
            a22 = (int)Convert.ToSingle(txtA22.Text);
            a23 = (int)Convert.ToSingle(txtA23.Text);
//-----------------------------------------------------------------------
            a31 = (int)Convert.ToSingle(txtA31.Text);
            a32 = (int)Convert.ToSingle(txtA32.Text);
            a33 = (int)Convert.ToSingle(txtA33.Text);
            //-----------------------------------------------------------------------
            rez = a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a31 * a22 * a13 - a32 * a23 * a11 - a33 * a21 * a12;
            lblD.Text = "D = " + rez;
        }
    }
}
