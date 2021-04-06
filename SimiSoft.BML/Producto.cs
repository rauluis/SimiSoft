﻿using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Producto
    {

        private DataAcces dataAcces = DataAcces.Instance();
        public int idProducto { get; set; }

        public string descripcion { get; set; }

        public string unidadMedida { get; set; }
        public string codigo { get; set; }

        public decimal precio { get; set; }

        public int stock { get; set; }

        public string marca { get; set; }

        public bool activo { get; set; }

        public Producto()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProductos", idProducto);
            parametros.Add("@descripcion", descripcion);
            parametros.Add("@unidadMedida", unidadMedida);
            parametros.Add("@codigo", codigo);
            parametros.Add("@precio", precio);
            parametros.Add("@stock", stock);
            parametros.Add("@marca", marca);
            

            return dataAcces.Excute("stp_productos_add", parametros);
         }


        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            return dataAcces.Excute("stp_productos_delete", parametros);
        }

        public List<Producto> GetAll()
        {
            return dataAcces.Query<Producto>("stp_productos_getall");

        }

        public Producto GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProducto", idProducto);
            return dataAcces.QuerySingle<Producto>("stp_productos_getbyid",parametros);

        }

        public int Update()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@idProducto", idProducto);
            parametros.Add("@descripcion", descripcion);
            parametros.Add("@unidadMedida", unidadMedida);
            parametros.Add("@codigo", codigo);
            parametros.Add("@precio", precio);
            parametros.Add("@stock", stock);
            parametros.Add("@marca", marca);

            return dataAcces.Excute("stp_productos_update", parametros);
        }





    }
}
