using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCloud_Entidades;


namespace UnityTest_BookCloud
{
    [TestClass]

    public class Test_BookCloud_Venta
    {
        [TestMethod]

        public void InstanciarVenta_CreacionDeVentaYvalidacionPrecioDevuelto_NoDeberiaRetornarNull()
        {
            //arrange/act
            Venta venta;
            Premium cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);
            venta = new Venta(DateTime.Now,cliente.Nombre,cliente.Apellido,cliente.Dni,cliente.PrecioTotalCarrito);

            //assert
            Console.WriteLine(venta.ToString());
            Assert.AreEqual(venta.ImporteFinal, cliente.PrecioTotalCarrito);
        }
    }
}
