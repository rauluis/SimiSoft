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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {

        private Proveedor proveedor;
        public frmNMProveedor()
        {
            InitializeComponent();
        }


        public frmNMProveedor(int idProveedor)
        {
            InitializeComponent();
            proveedor = new Proveedor
            {
                idProveedor = idProveedor
            }.GetById();//pobla todo.
            txtId.Text = proveedor.idProveedor.ToString();
            txtNombre.Text = proveedor.nombre;
            txtTelefono.Text = proveedor.telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (proveedor == null)
                {
                    if (new Proveedor
                    {
                        nombre = txtNombre.Text,
                        telefono = txtTelefono.Text                        
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor insertado correctamente", Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la insercion", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    proveedor.nombre = txtNombre.Text;
                    proveedor.telefono = txtTelefono.Text;
                   
                    if (proveedor.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor modificado correctamente", Application.ProductName, MessageBoxButtons.OK,
                                                   MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificacion", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa el Nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresar un Telefono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }

            }
            
            return !ban;
        }
    }
}