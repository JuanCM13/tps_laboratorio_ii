using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCloud_Entidades;


namespace BookCloud_Tests
{

    [TestClass]
    public class Test_BookCloud_Usuarios
    {
        #region PRUEBAS DE CLIENTES
        [TestMethod]
        public void InstanciaUsuarior_CreacionDeDistintosUsuarios_DeberianRetornarDistintoDeNull()
        {
            Regular clBase = new("40423224", "Juan", "Perez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Premium clPrem = new("40423224", "Juan", "Perez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");

            //assert
            //Assert.IsNotNull(clBase);
            Assert.IsNotNull(clPrem);
        }

        [TestMethod]
        [ExpectedException(typeof(DniFormatException))]
        public void InstanciaUsuarior_TesteoExcepcionDniErroneo_DeberianRetornarExcepcion()            
        {
            //arrange / act
            //Cliente_BookCloud_Base clBase = new("4042a224", "Juan", "Perez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Premium clPrem = new("404s3d24", "Juan", "Perez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorFormatoStringException))]
        public void InstanciaUsuarior_TesteoExcepcionFormatoStringErroneoNombre_DeberianRetornarExcepcion()
        {
            //arrange / act
            //Cliente_BookCloud_Base clBase = new("40422241", "J2an", "Perez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Premium clPrem = new("40433124", "Ju#n", "Perez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorFormatoStringException))]
        public void InstanciaUsuarior_TesteoExcepcionFormatoStringErroneoApellido_DeberianRetornarExcepcion()
        {
            //arrange / act
            Regular clBase = new("40422241", "Juan", "Pe1ez", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            //Cliente_BookCloud_Premium clPrem = new("40433124", "Juan", "Per*z", new DateTime(1995, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
        }

        [TestMethod]
        [ExpectedException(typeof(DateTimeException))]
        public void InstanciaUsuarior_TesteoExcepcionFechaFueraDeRango_DeberianRetornarExcepcion()
        {
            //arrange / act
            //Cliente_BookCloud_Base clBase = new("40422241", "Juan", "Perez", new DateTime(2023, 10, 22), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Premium clPrem = new("40433124", "Juan", "Perez", new DateTime(1890, 06, 02), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
        }
        #endregion


        # region PRUEBAS DE LISTAS DE PRODUCTOS DENTRO DE CLIENTES
        [TestMethod]

        public void Agregar_TesteoAgregarPublicacionAusuarioPremiumCasoPositivo__NoDeberiaLanzarExcepcion()
        {            
            Premium clPrem = new("40433124", "Juan", "Perez", new DateTime(2006, 06, 02), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Novela nvl = new Novela(1, "La Chola", "Wholsh", 1, 500.25F, true, 140, ENovela.Suspenso);
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            bool ret;

            //act
            ret = clPrem.CarritoCompras.AgregarProducto(nvl);
            ret = clPrem.CarritoCompras.AgregarProducto(cnt);

            //assert
            Console.WriteLine(clPrem.ToString());
            Assert.IsTrue(ret);
        }

         //PARA QUE ANDE MODIFICAR EL VALOR MAXIMO DE COMPRAS A 2 EN LA CLASE PREMIUM, Y DESCOMENTAR ESTE CODIGO ...
        /*[TestMethod]
        [ExpectedException(typeof(SinLugarException))]
        public void Agregar_TesteoAgregarPublicacionAusuarioPremiumCasoNegativo__DeberiaLanzarExcepcion()
        {
            
            Premium clPrem = new("40433124", "Juan", "Perez", new DateTime(2006, 06, 02), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Novela nvl = new Novela(1, "La Chola", "Wholsh", 1, 500.25F, true, 140, ENovela.Suspenso);
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            bool ret;

            //act
            ret = clPrem.CarritoCompras.AgregarProducto(nvl);
            ret = clPrem.CarritoCompras.AgregarProducto(cnt);
            ret = clPrem.CarritoCompras.AgregarProducto(spr);

            //assert
            Console.WriteLine(clPrem.ToString());
            Assert.IsTrue(ret);
        }*/

        [TestMethod]

        public void Agregar_TesteoAgregarPublicacionAusuarioRegularCasoPositivo__NoDeberiaLanzarExcepcion()
        {
            Regular clRegular = new("40433124", "Juan", "Perez", new DateTime(2006, 06, 02), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Novela nvl = new Novela(1, "La Chola", "Wholsh", 1, 500.25F, true, 140, ENovela.Suspenso);
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);

            bool ret;

            //act
            ret = clRegular.CarritoCompras.AgregarProducto(nvl);
            ret = clRegular.CarritoCompras.AgregarProducto(cnt);
            //assert
            Console.WriteLine(clRegular.ToString());
            Assert.IsTrue(ret);
        }

        /*
         * //PARA QUE ANDE MODIFICAR EL VALOR MAXIMO DE COMPRAS A 2 EN LA CLASE REGULAR, Y DESCOMENTAR ESTE CODIGO ...
        [ExpectedException(typeof(SinLugarException))]
        public void Agregar_TesteoAgregarPublicacionAusuarioRegularCasoNegativo__DeberiaLanzarExcepcion()
        {
            
            Regular clRegular = new("40433124", "Juan", "Perez", new DateTime(2006, 06, 02), ENacionalidad.Argentina, "asfaefgea@gmail.com", "115104742");
            Novela nvl = new Novela(1, "La Chola", "Wholsh", 1, 500.25F, true, 140, ENovela.Suspenso);
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            bool ret;

            //act
            ret = clRegular.CarritoCompras.AgregarProducto(nvl);
            ret = clRegular.CarritoCompras.AgregarProducto(cnt);
            ret = clRegular.CarritoCompras.AgregarProducto(spr);

            //assert
            Console.WriteLine(clRegular.ToString());
            Assert.IsTrue(ret);
        }*/
        #endregion


        #region PRUEBA GENERADORA DE CARRITO CLIENTE Y FACTURACION CON DESCUENTOS

        [TestMethod]

        public void CreacionCarrito_InstanciaDeCarritoClientePremium_DeberiaRetornarCarritoBienCreado()
        {
            //arrange / act
            Premium cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);

            //Assert
            Console.WriteLine(cliente.CarritoCompras.ToString());
            Assert.AreEqual(cliente.CarritoCompras.CantidadProductos, 2);
        }

        [TestMethod]

        public void CreacionCarrito_ValidarImporteDevueltoClientePremium_DeberiaRetornarMismoImporteQueElPuesto()
        {
            //arrange / act
            Premium cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);            
            Double resultadoEsperado;
            Double resultado =0;

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);
            resultadoEsperado = (cnt.Precio + spr.Precio) - ((cnt.Precio + spr.Precio) * 15) / 100;

            resultado = cliente.PrecioTotalCarrito;

            //Assert
            Assert.AreEqual(resultadoEsperado , resultado);
        }

        [TestMethod]

        public void CreacionCarrito_InstanciaDeCarritoClienteRegular_DeberiaRetornarCarritoBienCreado()
        {
            //arrange / act
            Regular cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            bool ret;

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);

            //Assert
            Console.WriteLine(cliente.CarritoCompras.ToString());
            Assert.AreEqual(cliente.CarritoCompras.CantidadProductos, 2);
        }

        [TestMethod]

        public void CreacionCarrito_ValidarImporteDevueltoClienteRegular_DeberiaRetornarMismoImporteQueElPuesto()
        {
            //arrange / act
            Regular cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            Double resultadoEsperado;
            Double resultado = 0;

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);
            resultadoEsperado = (cnt.Precio + spr.Precio);

            resultado = cliente.PrecioTotalCarrito;

            //Assert
            Console.WriteLine(resultadoEsperado);
            Console.WriteLine(resultado);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        #endregion


        #region PRUEBA ELIMINACION DE PUBLICACION DEL LISTADO DE PUBLICACIONES DEL CLIENTE

        [TestMethod]

        public void BajaPublicacion_EliminacionDePublicacionDeListadoClientePremium_CasoPositivoExistePublicacion_DeberiaRetornarTrue()
        {
            //arrange / act
            Premium cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);

            /*libro a eliminar*/
            Cuento cnt2 = new Cuento(5, "Minions", "asd", 4, 500, true, 10, ECuentos.Dinosaurios);

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);

            _ = cliente.CarritoCompras.EliminarProductos(cnt2, 1);

            //assert

            Console.WriteLine(cliente.ToString());
            Assert.AreEqual(cliente.CarritoCompras.CantidadProductos, 1);
        }

        [TestMethod]

        public void BajaPublicacion_EliminacionDePublicacionDeListadoClientePremium_CasoNegativoNoExistePublicacion_DeberiaRetornarTrue()
        {
            //arrange / act
            Premium cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);        

            /*libro a eliminar*/
            Cuento cnt2 = new Cuento(5, "Zafari", "asd", 4, 500, true, 10, ECuentos.Dinosaurios); //no tendria que elimninarlo..

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);

            _ = cliente.CarritoCompras.EliminarProductos(cnt2, 1);

            //assert

            Console.WriteLine(cliente.ToString());
            Assert.AreEqual(cliente.CarritoCompras.CantidadProductos, 2);
        }

        [TestMethod]

        public void BajaPublicacion_EliminacionDePublicacionDeListadoClienteRegular_CasoPositivoExistePublicacion_DeberiaRetornarTrue()
        {
            //arrange / act
            Regular cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);

            /*libro a eliminar*/
            Cuento cnt2 = new Cuento(5, "Minions", "asd", 4, 500, true, 10, ECuentos.Dinosaurios);

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);

            _ = cliente.CarritoCompras.EliminarProductos(cnt2, 1);

            //assert

            Console.WriteLine(cliente.ToString());
            Assert.AreEqual(cliente.CarritoCompras.CantidadProductos, 1);
        }

        [TestMethod]

        public void BajaPublicacion_EliminacionDePublicacionDeListadoClienteRegular_CasoNegativoNoExistePublicacion_DeberiaRetornarTrue()
        {
            //arrange / act
            Regular cliente = new("12345678", "Juan", "Perez", new DateTime(2010, 04, 22), ENacionalidad.Bolivia, "pepe@gmail.com", "123456789451");
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);

            /*libro a eliminar*/
            Cuento cnt2 = new Cuento(5, "Zafari", "asd", 4, 500, true, 10, ECuentos.Dinosaurios); //no tendria que elimninarlo..

            _ = cliente.CarritoCompras.AgregarProducto(cnt);
            _ = cliente.CarritoCompras.AgregarProducto(spr);

            _ = cliente.CarritoCompras.EliminarProductos(cnt2, 1);

            //assert

            Console.WriteLine(cliente.ToString());
            Assert.AreEqual(cliente.CarritoCompras.CantidadProductos, 2);
        }

        #endregion
    }
}
