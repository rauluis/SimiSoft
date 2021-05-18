﻿using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimiSoft2
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   

            if(tabMdiManager.MdiParent==null)
                tabMdiManager.MdiParent=this;
            foreach(Form form in Application.OpenForms)
                if(form.GetType()==typeof(frmProductos))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando productos ...");
            new frmProductos() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProveedores))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando provedores ...");
            new frmProveedores() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //
            Close();           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmClientes))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Clientes ...");
            new frmClientes() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

       

        private void btnAdminVentas_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabMdiManager.MdiParent == null)
                tabMdiManager.MdiParent = this;
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(FrmVentas))
                {
                    form.Activate();
                    return;
                }
            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas ...");
            new FrmVentas() { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();

        }
    }
}
