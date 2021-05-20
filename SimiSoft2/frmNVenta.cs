using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmNVenta()
        {
            SplashScreenManager.ShowDefaultWaitForm("Porfavor espere", "Inicianlizando nueva venta...");

            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}