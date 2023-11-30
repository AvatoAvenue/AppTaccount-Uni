namespace contabilidad3
{
    public partial class Form1 : Form
    {
        Datos datos = new Datos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Empresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Almacen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Almacen_Carga_Click(object sender, EventArgs e)
        {
            datos.AlmacenCargos.Add(double.Parse(Almacen.Text));
            Almacen.Text = "";

        }

        private void Almacen_Abono_Click(object sender, EventArgs e)
        {
            datos.AlmacenAbonos.Add(double.Parse(Almacen.Text));
            Almacen.Text = "";
        }

        private void Ventas_TextChanged(object sender, EventArgs e)
        {
        }

        private void Ventas_Carga_Click(object sender, EventArgs e)
        {
            datos.VentasCargos.Add(double.Parse(Ventas.Text));
            Ventas.Text = "";
        }
        private void Ventas_Abono_Click(object sender, EventArgs e)
        {
            datos.VentasAbonos.Add(double.Parse(Ventas.Text));
            Ventas.Text = "";
        }

        private void CostosVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostosVentas_Carga_Click(object sender, EventArgs e)
        {
            datos.CostosVentasCargos.Add(double.Parse(CostosVentas.Text));
            CostosVentas.Text = "";
        }

        private void CostosVentas_Abono_Click(object sender, EventArgs e)
        {
            datos.CostosVentasAbonos.Add(double.Parse(CostosVentas.Text));
            CostosVentas.Text = "";
        }

        private void Bancos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bancos_Carga_Click(object sender, EventArgs e)
        {
            datos.BancosCargos.Add(double.Parse(Bancos.Text));
            Bancos.Text = "";
        }

        private void Bancos_Abono_Click(object sender, EventArgs e)
        {
            datos.BancosCargos.Add(double.Parse(Bancos.Text));
            Bancos.Text = "";
        }

        private void Capital_TextChanged(object sender, EventArgs e)
        {

        }

        private void Capital_Carga_Click(object sender, EventArgs e)
        {
            datos.CapitalCargos.Add(double.Parse(Capital.Text));
            Capital.Text = "";
        }

        private void Capital_Abono_Click(object sender, EventArgs e)
        {
            datos.CapitalAbonos.Add(double.Parse(Capital.Text));
            Capital.Text = "";
        }

        private void Proveedores_TextChanged(object sender, EventArgs e)
        {

        }

        private void Proveedores_Carga_Click(object sender, EventArgs e)
        {
            datos.ProveedoresCargos.Add(double.Parse(Proveedores.Text));
            Proveedores.Text = "";
        }

        private void Proveedores_Abono_Click(object sender, EventArgs e)
        {
            datos.ProveedoresAbonos.Add(double.Parse(Proveedores.Text));
            Proveedores.Text = "";
        }

        private void Caja_TextChanged(object sender, EventArgs e)
        {

        }

        private void Caja_Carga_Click(object sender, EventArgs e)
        {
            datos.CajaCargos.Add(double.Parse(Caja.Text));
            Caja.Text = "";
        }

        private void Caja_Abono_Click(object sender, EventArgs e)
        {
            datos.CajaAbonos.Add(double.Parse(Caja.Text));
            Caja.Text = "";
        }

        private void Clientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clientes_Carga_Click(object sender, EventArgs e)
        {
            datos.ClientesCargos.Add(double.Parse(Clientes.Text));
            Clientes.Text = "";
        }

        private void Clientes_Abono_Click(object sender, EventArgs e)
        {
            datos.ClientesAbonos.Add(double.Parse(Clientes.Text));
            Clientes.Text = "";
        }

        
        private void Utilidades_Cargar_Click(object sender, EventArgs e)
        {
            datos.UtilidadesPerdidasAbonos.Add(double.Parse(Utilidades.Text));
            Utilidades.Text = "";
        }

        private void Utilidades_Abonar_Click(object sender, EventArgs e)
        {
            datos.UtilidadesPerdidasAbonos.Add(double.Parse(Utilidades.Text));
            Utilidades.Text = "";
        }
        private void Importar_Click(object sender, EventArgs e)
        {
            datos.TituloEmpresa = Empresa.Text;
            System.Diagnostics.Debug.WriteLine(datos.TituloEmpresa);
            Procedimiento._datos = datos;
            Procedimiento.Importar();
        }

    }
}