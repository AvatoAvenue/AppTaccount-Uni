using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabilidad3
{
    internal class Datos
    {
        public string TituloEmpresa {  get; set; }
        public List<double> AlmacenCargos { get; set; } = new List<double>();
        public List<double> ProveedoresCargos { get; set; } = new List<double>();
        public List<double> CajaCargos { get; set; } = new List<double>();
        public List<double> CapitalCargos { get; set; } = new List<double>();
        public List<double> BancosCargos { get; set; } = new List<double>();
        public List<double> VentasCargos { get; set; } = new List<double>();
        public List<double> CostosVentasCargos { get; set; } = new List<double>();
        public List<double> ClientesCargos { get; set; } = new List<double>();
        public List<double> UtilidadesPerdidasCargos { get; set; } = new List<double>();
        public List<double> AlmacenAbonos { get; set; } = new List<double>();
        public List<double> ProveedoresAbonos { get; set; } = new List<double>();
        public List<double> CajaAbonos { get; set; } = new List<double>();
        public List<double> CapitalAbonos { get; set; } = new List<double>();
        public List<double> BancosAbonos { get; set; } = new List<double>();
        public List<double> VentasAbonos { get; set; } = new List<double>();
        public List<double> CostosVentasAbonos { get; set; } = new List<double>();
        public List<double> ClientesAbonos { get; set; } = new List<double>();
        public List<double> UtilidadesPerdidasAbonos { get; set; } = new List<double>();

    }
}
