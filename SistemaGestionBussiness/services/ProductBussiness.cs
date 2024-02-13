using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData.data;
using SistemaGestionData.Data;
using SistemaGestionEntities.Models;

namespace SistemaGestionBussiness.services
{

    public static class ProductBussiness
    {
        public static List<Product> ObtenerProductos()
        {
            return ProductData.ListarProductos();
        }
        public static Product ObtenerProducto(int id) => ProductData.ObtenerProducto(id);

        public static void CrearProducto(Product producto)
        {
            ProductData.CrearProducto(producto);
        }

        public static void ModificarProducto(Product producto)
        {
            ProductData.ModificarProducto(producto);
        }

        public static void EliminarProducto(int id)
        {
            ProductData.EliminarProducto(id);
        }
    }
}
