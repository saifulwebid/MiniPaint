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

        private void btnSave_Click(object sender, EventArgs e)
        {
            double[] consts = new double[]
            {
                double.Parse(txtX0.Text),
                double.Parse(txtX1.Text),
                double.Parse(txtX2.Text),
                double.Parse(txtX3.Text),
                double.Parse(txtX4.Text),
                double.Parse(txtX5.Text),
                double.Parse(txtX6.Text),
            };

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
