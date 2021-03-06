using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace SimiSoft2
{
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();

        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente
            {

                Text = "Nuevo Cliente"
            }.ShowDialog();

           clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();

        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente"))
            {
                Text = "Modificar Cliente (" + (int)gvClientes.GetFocusedRowCellValue("idCliente") + ")"
            }.ShowDialog();

            clienteBindingSource.DataSource = new Cliente().GetAll();
            gvClientes.BestFitColumns();
        }

      
        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView View = (ColumnView)gcClientes.FocusedView;
            int rhFound = View.FocusedRowHandle ;
            View.FocusedRowHandle = rhFound;
            if (rhFound>0)
            {
                new Cliente

                {

                    idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente")
                }.Delete();
                clienteBindingSource.DataSource = new Cliente().GetAll();
                gvClientes.BestFitColumns();
            }           
        }


        private void gcClientes_Click(object sender, EventArgs e)
        {

        }
    }
}