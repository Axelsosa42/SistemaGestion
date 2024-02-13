using SistemaGestionData.data;
using SistemaGestionEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.services
{
    internal class ProductsSoldBussiness
    {
        public static class SoldProductBussiness
        {
            public static List<SoldProduct> ObtenerProductosVendidos()
            {
                return SoldProductData.ListarSoldProduct();
            }
            public static SoldProduct ObtenerSoldProduct(int id) => SoldProductData.ObtenerSoldProduct(id);

            public static void CrearSoldProduct(SoldProduct productoVendido)
            {
                SoldProductData.CrearSoldProduct(productoVendido);
            }

            public static void ModificarSoldProduct(SoldProduct productoVendido)
            {
                SoldProductData.ModificarSoldProduct(productoVendido);
            }

            public static void EliminarSoldProduct(int id)
            {
                SoldProductData.EliminarSoldProduct(id);
            }
        }
    }
}
