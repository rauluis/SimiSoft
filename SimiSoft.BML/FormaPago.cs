using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class FormaPago
    {


        private DataAcces dataAccess = DataAcces.Instance();
        public int idFPago { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }

        public FormaPago()
        {

        }


        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@descripcion", parametros);
            return dataAccess.Excute("stp_formaspago_add", parametros);


        }

        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idFPago", parametros);
            return dataAccess.Excute("stp_formaspago_delete", parametros);
        }

        public List<FormaPago> GetAll()
        {
            return dataAccess.Query<FormaPago>("stp_formaspago_getball");
        }

        public FormaPago GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idFPago", parametros);
            return dataAccess.QuerySingle<FormaPago>("stp_formaspago_getbyid", parametros);
        }


        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idFPago", parametros);
            parametros.Add("@descripcion", parametros);
            return dataAccess.Excute("stp_formaspago_update", parametros);
        }







    }
}
