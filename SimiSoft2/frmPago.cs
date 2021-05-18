using DevExpress.XtraEditors;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimiSoft2
{
    public partial class frmPago : DevExpress.XtraEditors.XtraForm
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            formaPagoBindingSource.DataSource = new FormaPago().GetAll();
            Clean();
            lupFpago.EditValue = 1;
            txtTotalPagar.EditValue = Misc.totalPago;
            txtPago.EditValue = Misc.totalPago;
            txtPago.EditValue = 0;
        }

        private void Clean()
        {
            txtTotalPagar.EditValue = null;
            txtPago.EditValue = null;
            txtCambio.EditValue = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (lupFpago.EditValue == null)
            //    return;
            //Misc.totalPago = Convert.ToDecimal(txtPago.EditValue);
            //Misc.idFPago = Convert.ToInt32(lupFpago.EditValue);
            //txtCambio.EditValue = (Misc.totalPago - Misc.totalPago) * -1;
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}