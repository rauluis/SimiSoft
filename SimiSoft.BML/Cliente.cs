﻿using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
   public  class Cliente
    {

        private DataAcces dataAcces = DataAcces.Instance();
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public decimal descuento { get; set; }
        public bool activo { get; set; }

        public Cliente()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@nombre", nombre);
            parametros.Add("@razonSocial", razonSocial);
            parametros.Add("@telefono", telefono);
            parametros.Add("@descuento", descuento);

            return dataAcces.Excute("stp_clientes_add", parametros);
        }


        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAcces.Excute("stp_clientes_delete", parametros);
        }

        public List<Cliente> GetAll()
        {
            return dataAcces.Query<Cliente>("stp_clientes_getall").ToList();

        }

        public Cliente GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAcces.QuerySingle<Cliente>("stp_clientes_getabyid", parametros);

        }

        public int Update()
        {
            var parametros = new DynamicParameters();

            parametros.Add("@idCliente", idCliente);
            parametros.Add("@nombre", nombre);
            parametros.Add("@razonSocial", razonSocial);
            parametros.Add("@telefono", telefono);
            parametros.Add("@descuento", descuento);

            return dataAcces.Excute("stp_clientes_update", parametros);
        }
    }
}
