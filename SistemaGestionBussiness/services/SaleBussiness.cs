using SistemaGestionData.Data;
using SistemaGestionEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.services
{
        public static class SaleBussiness
        {
            public static List<Sale> ObtenerSales()
            {
                return SaleData.ListarSale();
            }
            public static Sale ObtenerSale(int id) => SaleData.ObtenerSale(id);

            public static void CrearSale(Sale venta)
            {
                SaleData.CrearSale(venta);
            }

            public static void ModificarSale(Sale venta)
            {
                SaleData.ModificarSale(venta);
            }

            public static void EliminarSale(int id)
            {
                SaleData.EliminarSale(id);
            }
        }
    
}
