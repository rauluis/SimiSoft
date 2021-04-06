﻿using DevExpress.XtraEditors;
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
    public partial class frmNMCliente : DevExpress.XtraEditors.XtraForm
    {


        private Cliente cliente;
        public frmNMCliente()
        {
            InitializeComponent();
        }

        public frmNMCliente(int idCliente)
        {
            InitializeComponent();
            cliente = new Cliente
            {
                idCliente = idCliente
            }.GetById();//pobla todo.
            txtId.Text = cliente.idCliente.ToString();
            txtNombre.Text = cliente.nombre;
            txtRazonS.Text = cliente.razonSocial;
            txtTelefono.Text = cliente.telefono;
            txtDescuento.Text = cliente.descuento.ToString();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                if (cliente == null)
                {
                    if (new Cliente
                    {
                        nombre = txtNombre.Text,
                        razonSocial = txtRazonS.Text,
                        telefono = txtTelefono.Text,
                        descuento = Convert.ToDecimal(txtDescuento.Text)
                        
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Cliente insertado correctamente", Application.ProductName, MessageBoxButtons.OK,
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
                    cliente.nombre = txtNombre.Text;
                    cliente.razonSocial = txtRazonS.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.descuento = Convert.ToDecimal(txtDescuento.Text);
                    
                    if (cliente.Update() > 0)
                    {
                        XtraMessageBox.Show("Cliente modificado correctamente", Application.ProductName, MessageBoxButtons.OK,
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

        private bool ValNumeros(KeyPressEventArgs e)
        {
            var ban = false;
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                ban = true;
            }
            return !ban;
            
        }
        private bool ValLetras(KeyPressEventArgs e)
        {
            var ban = false;
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                ban = true;
            }
            return !ban;
        }

        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                txtNombre.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(txtRazonS.Text))
            {
                txtRazonS.ErrorText = "Ingresar una Razon Social";
                if (!ban)
                {
                    txtRazonS.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.ErrorText = "Ingresar un telefono";
                if (!ban)
                {
                    txtTelefono.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.ErrorText = "Ingresar un descuento";
                if (!ban)
                {
                    txtDescuento.Focus();
                    ban = true;
                }

            }

            return !ban;
        }

        private void txtTelefono_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValLetras(e);
        }

        private void txtRazonS_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValLetras(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValNumeros(e);
        }
    }
}