using EsauAguilar._2024.PruebaTecnica.DAL;
using EsauAguilar._2024.PruebaTecnica.Models;

namespace EsauAguilar._2024.PruebaTecnica.BL
{
    public class ProductoBL 
    { 
        private ProductoDAL productoDAL = new ProductoDAL();
        public List<Producto> ObtenerTodosLosProductos() 
        { 
            return productoDAL.ObtenerProductos(); 
        } 
        public void InsertarProducto(Producto producto) 
        { 
            productoDAL.InsertarProducto(producto); 
        } 
    }
}
