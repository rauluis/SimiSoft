﻿using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{



   

    public class Proveedor
    {

        private DataAcces dataAcces = DataAcces.Instance();

        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }

        public Proveedor()
        {
        }
        public int Add()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@nombre", nombre);
            parametros.Add("@telefono", telefono);

            return dataAcces.Excute("stp_proveedores_add", parametros);
        }



        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            return dataAcces.Excute("stp_proveedores_delete", parametros);
        }

        public List<Proveedor> GetAll()
        {
            return dataAcces.Query<Proveedor>("stp_proveedores_getall");

        }

        public Proveedor GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            return dataAcces.QuerySingle<Proveedor>("stp_proveedores_getabyid", parametros);

        }

        public int Update()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@nombre", nombre);
            parametros.Add("@telefono", telefono);

            return dataAcces.Excute("stp_proveedores_update", parametros);
        }


    }
}
