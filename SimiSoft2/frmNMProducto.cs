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
    public partial class frmNMProducto : DevExpress.XtraEditors.XtraForm
    {

        private Producto producto;



        //      cuando es nuevo producto
        public frmNMProducto()
        {
            InitializeComponent();
            
        }


        //cuando es modificar producto
        public frmNMProducto(int idProducto)
        {
            InitializeComponent();
            producto = new Producto
            {
                idProducto = idProducto
            }.GetById();//pobla todo.
            txtId.Text = producto.idProducto.ToString();
            txtDescripcion.Text = producto.descripcion;
            cbtxtUnidadMedida.Text = producto.unidadMedida;
            txtCodigo.Text = producto.codigo;
            txtPrecio.Text = producto.precio.ToString();
            txtStock.Text = producto.stock.ToString();
            txtMarca.Text = producto.marca;


        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (producto == null)
                {
                    decimal pre;
                    if (!decimal.TryParse(txtPrecio.Text, out pre))
                    {
                        XtraMessageBox.Show("Ocurrio un error en la modificacion", Application.ProductName, MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                        return;
                    }

                   string a = cbtxtUnidadMedida.SelectedItem.ToString();
                    if (new Producto
                    {

                        descripcion = txtDescripcion.Text,
                        unidadMedida =a,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDecimal(txtPrecio.Text),
                        stock = Convert.ToInt32(txtStock.Text),
                        marca = txtMarca.Text
                    }.Add() <= 0)
                    {
                        XtraMessageBox.Show("Ocurrio un error en la insercion", Application.ProductName, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Producto insertado correctamente", Application.ProductName, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    producto.descripcion = txtDescripcion.Text;
                    producto.unidadMedida = cbtxtUnidadMedida.Text;
                    producto.codigo = txtCodigo.Text;
                    producto.precio = Convert.ToDecimal(txtPrecio.Text);
                    producto.stock = Convert.ToInt32(txtStock.Text);
                    producto.marca = txtMarca.Text;
                    if (producto.Update() > 0)
                    {
                        XtraMessageBox.Show("Producto modificado correctamente", Application.ProductName, MessageBoxButtons.OK,
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
           


        private bool Validar()
        {
            var ban = false;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                txtDescripcion.ErrorText = "Ingresa el Descripcion";
                txtDescripcion.Focus();
                ban = true;
            }
            if (string.IsNullOrEmpty(cbtxtUnidadMedida.Text))
            {

                cbtxtUnidadMedida.ErrorText = "Selecciona un elemento";
                if (!ban)
                {
                   cbtxtUnidadMedida.Focus();
                    ban = true;
                }

            }
              //if (string.IsNullOrEmpty(txtUnidadMedida.Text))
            //{

            //    txtUnidadMedida.ErrorText = "Ingresar una Unidad de Medida";
            //    if (!ban)
            //    {
            //        txtUnidadMedida.Focus();
            //        ban = true;
            //    }

            //}
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.ErrorText = "Ingresar un codigo";
                if (!ban)
                {
                    txtCodigo.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.ErrorText = "Ingresar un Precio";
                if (!ban)
                {
                    txtPrecio.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                txtStock.ErrorText = "Ingresar un Stock";
                if (!ban)
                {
                    txtStock.Focus();
                    ban = true;
                }

            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                txtMarca.ErrorText = "Ingresar una Marca";
                if (!ban)
                {
                    txtMarca.Focus();
                    ban = true;
                }

            }


            return !ban;
        }

        private void frmNMProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {

            decimal pre;
            if (!decimal.TryParse(txtPrecio.Text, out pre))
            {
                ErrorProvider.Equals(txtPrecio, "Ingrese valor en numeros");
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}