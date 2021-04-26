using System;
using System.IO;
using System.Diagnostics;
using FinalProject.Models;

namespace FinalProject.Helpers
{
    class HtmlFormat
    {
        string directory = "Facturas";

        public void htmlMake(Alquileres alq, string Cliente, string Vehiculo, int dias, double monto)
        {

            string directory = this.directory;

            string status;

            if(monto == 0) {

                status = "Pagado";

            } else {

                status = monto.ToString();
            }

            if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }

            string content = "<html>"+
"<head>"+
    "<center>"+
        "<h3>Factura de alquiler</h3>"+
    "</center>"+
    "<link rel='stylesheet' href='../wwwroot/css/bootstrap/bootstrap.min.css' />"+
    "<link href='../wwwroot/css/site.css' rel='stylesheet' />"+
"</head>"+
"<body>"+
"<hr>"+
    "<div class='row'>"+
        "<div class='col-md-2'></div>"+
        "<div class='col-md-8'>"+
            "<table class='table table-dark'>"+
                "<thead>"+
                    "<tr>"+
                        "<th>ID Factura</th>"+
                        "<th>Cliente</th>"+
                        "<th>Vehiculo</th>"+
                        "<th>Fecha de inicio</th>"+
                        "<th>Fecha de término</th>"+
                        "<th>Dias alquilados</th>"+
                        "<th>Monto total</th>"+
                    "</tr>"+
                "</thead>"+
                "<tbody>"+
                    "<tr>"+
                        "<td>"+alq.IdAlquileres+"</td>"+
                        "<td>"+Cliente+"</td>"+
                        "<td>"+Vehiculo+"</td>"+
                        "<td>"+alq.FechaInicio+"</td>"+
                        "<td>"+alq.FechaFin+"</td>"+
                        "<td>"+dias+"</td>"+
                        "<td>"+status+"</td>"+
                    "</tr>"+
                "</tbody>"+
            "</table>"+
        "</div>"+
        "<div class='col-md-2'></div>"+
    "</div>"+
"</body>"+
"</html>";

            if (File.Exists(directory + "/" + alq.IdAlquileres + ".html"))
            {

                File.Delete(directory + "/" + alq.IdAlquileres + ".html");

            }

            File.WriteAllText(directory + "/" + alq.IdAlquileres + ".html", content);
        }
    }

}