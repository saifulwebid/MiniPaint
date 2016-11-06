using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint.WinForms
{
    public partial class frmEditPolyFunc : Form
    {
        public frmEditPolyFunc()
        {
            InitializeComponent();
        }

        public frmEditPolyFunc(double[] consts) : this()
        {
            TextBox[] txt = new TextBox[] { txtX0, txtX1, txtX2, txtX3, txtX4, txtX5, txtX6 };

            for (int i = 0; i < consts.Length && i < txt.Length; i++)
            {
                txt[i].Text = consts[i].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] txt = new TextBox[] { txtX0, txtX1, txtX2, txtX3, txtX4, txtX5, txtX6 };
            double[] consts = new double[7];
            for (int i = 0; i < txt.Length; i++)
                consts[i] = double.Parse(txt[i].Text);

            ((frmMain)Owner).ChangePolynomialFunction(consts);
            Close();
        }

        private void txtConstants_Validating(object sender, CancelEventArgs e)
        {
            TextBox o = (TextBox)sender;
            
            try
            {
                double.Parse(o.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Konstanta harus berupa nilai riil.", "Nilai tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                o.SelectAll();
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
