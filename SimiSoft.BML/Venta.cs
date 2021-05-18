using Dapper;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
    public class Venta
    {

        private DataAcces dataAcces = DataAcces.Instance();
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }

        public decimal importe { get; set; }
        public string status { get; set; }



        public Venta()
        {
        }

        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            parametros.Add("@fecha", fecha);
            parametros.Add("@cantidad", cantidad);
            parametros.Add("@importe", importe);
            parametros.Add("@status", status);
            return dataAcces.Insert("stp_ventas_add", parametros, "idVenta");
        }

        public List<Venta> GetALL()
        {
            return dataAcces.Query<Venta>("stp_ventas_getall").ToList();

        }
    }
}
