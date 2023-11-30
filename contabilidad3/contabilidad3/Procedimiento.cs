using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabilidad3
{
    internal class Procedimiento
    {
        public static Datos _datos { get; set; }
        public static void Importar()
        {
            FileInfo file = new FileInfo("InventarioPerpetuo.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Inventario"];
                if (worksheet == null)
                {
                    worksheet = package.Workbook.Worksheets.Add("Inventario");
                }
                worksheet.Cells["A1:K1"].Merge = true;
                worksheet.Cells["A1"].Value = _datos.TituloEmpresa;
                worksheet.Cells[$"A1:K1"].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                //Primeros 4
                int maxRowCount = Math.Max(_datos.AlmacenCargos.Count, _datos.AlmacenAbonos.Count);
                int fila = 2;
                worksheet.Cells["A2:B2"].Merge = true;
                worksheet.Cells["A2"].Value = "Almacen";
                worksheet.Cells[$"A{3}:B{3}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < maxRowCount; i++)
                {
                    if (i < _datos.AlmacenCargos.Count)
                    {
                        worksheet.Cells[$"A{fila + 1}"].Value = _datos.AlmacenCargos[i];
                        worksheet.Cells[$"A{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    if (i < _datos.AlmacenAbonos.Count)
                    {
                        worksheet.Cells[$"B{fila + 1}"].Value = _datos.AlmacenAbonos[i];
                    }
                    fila++;
                }
                worksheet.Cells[$"A{fila + 1}:B{fila+1}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                worksheet.Cells[$"A{fila+1}"].Formula = $"SUM(A3:A{fila})";
                worksheet.Cells[$"A{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                worksheet.Cells[$"B{fila+1}"].Formula = $"SUM(B3:B{fila})";
                worksheet.Cells[$"A{fila+2}"].Formula = $"(A{fila+1} - B{fila+1})";
                worksheet.Cells[$"A{fila + 2}:B{fila + 2}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                fila = 2;
                worksheet.Cells["D2:E2"].Merge = true;
                worksheet.Cells["D2"].Value = "Proveedores";
                worksheet.Cells[$"D{3}:E{3}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < _datos.ProveedoresCargos.Count; i++)
                {
                    worksheet.Cells[$"D{fila + 1}"].Value = _datos.ProveedoresCargos[i];
                    worksheet.Cells[$"D{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    fila++;
                }
                fila = 2;
                for (int i = 0; i < _datos.ProveedoresAbonos.Count; i++)
                {
                    worksheet.Cells[$"E{fila + 1}"].Value = _datos.ProveedoresAbonos[i];
                    fila++;
                }
                
                fila = 2;
                worksheet.Cells["G2:H2"].Merge = true;
                worksheet.Cells["G2"].Value = "Caja";
                worksheet.Cells[$"G{3}:H{3}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < _datos.CajaCargos.Count; i++)
                {
                    worksheet.Cells[$"G{fila + 1}"].Value = _datos.CajaCargos[i];
                    worksheet.Cells[$"G{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    fila++;
                }
                fila = 2;
                for (int i = 0; i < _datos.CajaAbonos.Count; i++)
                {
                    worksheet.Cells[$"H{fila + 1}"].Value = _datos.CajaAbonos[i];
                    fila++;
                }
                
                fila = 2;
                worksheet.Cells["J2:K2"].Merge = true;
                worksheet.Cells["J2"].Value = "Capital";
                worksheet.Cells[$"J{3}:K{3}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < _datos.CapitalCargos.Count; i++)
                {
                    worksheet.Cells[$"J{fila + 1}"].Value = _datos.CapitalCargos[i];
                    worksheet.Cells[$"J{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    fila++;
                }
                fila = 2;
                for (int i = 0; i < _datos.CapitalAbonos.Count; i++)
                {
                    worksheet.Cells[$"K{fila + 1}"].Value = _datos.CapitalAbonos[i];
                    fila++;
                }

                //Ultimos 5
                fila = 12;
                worksheet.Cells["A12:B12"].Merge = true;
                worksheet.Cells["A12"].Value = "Bancos";
                worksheet.Cells[$"A{13}:B{13}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < _datos.BancosCargos.Count; i++)
                {
                    worksheet.Cells[$"A{fila + 1}"].Value = _datos.BancosCargos[i];
                    worksheet.Cells[$"A{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    fila++;
                }
                fila = 12;
                for (int i = 0; i < _datos.BancosAbonos.Count; i++)
                {
                    worksheet.Cells[$"B{fila + 1}"].Value = _datos.BancosAbonos[i];
                    fila++;
                }

                maxRowCount = Math.Max(_datos.VentasCargos.Count, _datos.VentasAbonos.Count);
                fila = 12;
                worksheet.Cells["D12:E12"].Merge = true;
                worksheet.Cells["D12"].Value = "Ventas";
                worksheet.Cells[$"D{13}:E{13}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < maxRowCount; i++)
                {
                    if (i < _datos.VentasCargos.Count)
                    {
                        worksheet.Cells[$"D{fila + 1}"].Value = _datos.VentasCargos[i];
                        worksheet.Cells[$"D{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    if (i < _datos.VentasAbonos.Count)
                    {
                        worksheet.Cells[$"E{fila + 1}"].Value = _datos.VentasAbonos[i];
                    }
                    fila++;
                }
                worksheet.Cells[$"D{fila + 1}"].Formula = $"SUM(D13:D{fila})";
                worksheet.Cells[$"D{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                worksheet.Cells[$"E{fila + 1}"].Formula = $"SUM(E13:E{fila})";
                worksheet.Cells[$"D{fila+1}:E{fila+1}"].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Double;


                maxRowCount = Math.Max(_datos.VentasCargos.Count, _datos.VentasAbonos.Count);
                fila = 12;
                worksheet.Cells["G12:H12"].Merge = true;
                worksheet.Cells["G12"].Value = "Costos de ventas";
                worksheet.Cells[$"G{13}:H{13}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < maxRowCount; i++)
                {
                    if (i < _datos.VentasCargos.Count)
                    {
                        worksheet.Cells[$"G{fila + 1}"].Value = _datos.VentasCargos[i];
                        worksheet.Cells[$"G{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    if (i < _datos.VentasAbonos.Count)
                    {
                        worksheet.Cells[$"H{fila + 1}"].Value = _datos.VentasAbonos[i];
                    }
                    fila++;
                }
                worksheet.Cells[$"G{fila + 1}"].Formula = $"SUM(G13:G{fila})";
                worksheet.Cells[$"G{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                worksheet.Cells[$"H{fila + 1}"].Formula = $"SUM(H13:H{fila})";
                worksheet.Cells[$"G{fila + 1}:H{fila + 1}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Double;

                fila = 12;
                worksheet.Cells["A12:B12"].Merge = true;
                worksheet.Cells["A12"].Value = "Clientes";
                worksheet.Cells[$"A{13}:B{13}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < _datos.ClientesCargos.Count; i++)
                {
                    worksheet.Cells[$"J{fila + 1}"].Value = _datos.ClientesCargos[i];
                    worksheet.Cells[$"J{fila + 1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    fila++;
                }
                fila = 12;
                for (int i = 0; i < _datos.ClientesAbonos.Count; i++)
                {
                    worksheet.Cells[$"K{fila + 1}"].Value = _datos.ClientesAbonos[i];
                    fila++;
                }

                fila = 22;
                worksheet.Cells["A22:B22"].Merge = true;
                worksheet.Cells["A22"].Value = "Utilidades y pérdidas";
                worksheet.Cells[$"A{23}:B{23}"].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                for (int i = 0; i < _datos.UtilidadesPerdidasCargos.Count; i++)
                {
                    worksheet.Cells[$"A{fila + 1}"].Value = _datos.CostosVentasAbonos[i];
                    worksheet.Cells[$"A{fila+1}"].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    fila++;
                }
                fila = 22;
                for (int i = 0; i < _datos.UtilidadesPerdidasAbonos.Count; i++)
                {
                    worksheet.Cells[$"B{fila + 1}"].Value = _datos.ClientesAbonos[i];
                    fila++;
                }

                ExcelRangeBase dataRange = worksheet.Cells[$"A2:{worksheet.Dimension.End.Address}"];
                dataRange.Style.Numberformat.Format = "$###,###,##0.00";
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                package.Save();
            }
        }
    }
}
