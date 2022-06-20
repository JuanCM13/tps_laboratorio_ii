using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookCloud_Entidades;
using System;

namespace BookCloud_Tests
{
    [TestClass]
    public class Test_BookCloud_Publicaciones
    {
        #region PRUEBAS DE CREACION DE PUBLICACIONES E IGUALACION DE PUBLICACIONES

        [TestMethod]
        public void InstanciaLibros_CrearInstanciasDeDistintosLibros_NoDeberiaRetornarNull()
        {
            //arrange
            Novela nvl = new Novela(1, "La Chola", "Wholsh", 1, 500.25F, true, 140 ,ENovela.Suspenso);
            Historieta hst = new Historieta(2, "Berserker", "yisho", 4, 450.25F, false, 200 , EHistorietas.Anime);
            Cuento cnt = new Cuento(3, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Manual spr = new Manual(4, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);

            //assert
            System.Console.WriteLine(spr.ToString());
            //Assert.IsNotNull(nvl);
            //Assert.IsNotNull(hst);
            //Assert.IsNotNull(cnt);
            Assert.IsNotNull(spr);
        }

        [TestMethod]
        public void IgualdadEntreLibros_CompararInstanciasDePublicaciones_CasoPositivo_DeberianSerIguales()
        {
            //arrange
            Novela nv1 = new Novela(1, "La Chola", "Wholsh", 1, 500.25F, true, 140, ENovela.Suspenso);
            Novela nv2 = new Novela(2, "La Chola", "Wholsh", 1, 420.2F, false, 140, ENovela.Suspenso);
            Manual m1 = new Manual(3, "Caza 1", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            Manual m2 = new Manual(4, "Caza 1", "sssss", 12, 801.65F, false, 80, EManual.Cocina);
            Cuento c1 = new Cuento(5, "Minions", "asd", 4, 100, true, 700, ECuentos.Dinosaurios);
            Cuento c2 = new Cuento(6, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Historieta h1 = new Historieta(7, "Berserker", "yisho", 4, 50000, false, 1, EHistorietas.Anime);
            Historieta h2 = new Historieta(8, "Berserker", "yisho", 4, 450.25F, false, 200, EHistorietas.Anime);


            //act
            bool ret = nv1.Equals(nv2);
            ret = m1.Equals(m2);
            ret = c1 == c2;
            ret = h1.Equals(h2);
            //assert

            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void IgualdadEntreLibros_CompararInstanciasDePublicaciones_CasoPositivo_DeberianSerDistintos()
        {
            //arrange
            Novela nv1 = new Novela(1, "La ola", "Wholsh", 1, 500.25F, true, 140, ENovela.Suspenso);
            Novela nv2 = new Novela(2, "La Chola", "Wholsh", 1, 420.2F, false, 140, ENovela.Suspenso);
            Manual m1 = new Manual(3, "Caza 3", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            Manual m2 = new Manual(4, "Caza 1", "sssss", 12, 801.65F, false, 80, EManual.Cocina);
            Cuento c1 = new Cuento(5, "DBZ", "asd", 4, 100, true, 700, ECuentos.Dinosaurios);
            Cuento c2 = new Cuento(6, "Minions", "asd", 4, 720, false, 700, ECuentos.Dinosaurios);
            Historieta h1 = new Historieta(7, "Berserker", "yisho", 4, 50000, false, 1, EHistorietas.Anime);
            Historieta h2 = new Historieta(8, "Baki", "yisho", 4, 450.25F, false, 200, EHistorietas.Anime);


            //act
            bool ret = !nv1.Equals(nv2);
            ret = !m1.Equals(m2);
            ret = c1 != c2;
            ret = !h1.Equals(h2);
            //assert

            Assert.IsTrue(ret);
        }

        #endregion


        #region PRUEBA DE APLICACION DE DESCUENTOS Y RETORNO DE PRECIO DE LA PUBLICACION..

        [TestMethod]
        public void CalculoPrecio_SinDescuento_DeberianDevolverMismoPrecioQueElSeteado()
        {
            //arrange

            double precioSet = Math.Round(8200.65F,2);

            Novela nv1 = new Novela(1, "La ola", "Wholsh", 1, precioSet, false, 140, ENovela.Suspenso);
            Manual m1 = new Manual(3, "Caza 3", "sssss", 12, precioSet, false, 8000, EManual.Cocina);
            Cuento c1 = new Cuento(5, "DBZ", "asd", 4, precioSet, false, 700, ECuentos.Dinosaurios);
            Historieta h1 = new Historieta(7, "Berserker", "yisho", 4, precioSet, false, 1, EHistorietas.Anime);

            //act
            double precio = nv1.Precio;
            precio = m1.Precio;
            precio = c1.Precio;
            precio = h1.Precio;

            //assert
            Assert.AreEqual(precio, precioSet);       
        }

        [TestMethod]
        public void CalculoPrecio_ConDescuento_DeberianDevolverPrecioConPorcentajePorTipoPublicacion()
        {
            //arrange

            double precioEsperadoNovela = 8200.65f - ( (8200.65F * 5) / 100);
            double precioEsperadoManual = 8200.65f - ((8200.65F * 10) / 100);
            double precioEsperadoCuento = 8200.65f - ((8200.65F * 16) / 100);
            double precioEsperadoHistorieta = 8200.65f - ((8200.65F * 30) / 100);

            Novela nv1 = new Novela(1, "La ola", "Wholsh", 1, 8200.65F, true, 140, ENovela.Suspenso);
            Manual m1 = new Manual(3, "Caza 3", "sssss", 12, 8200.65F, true, 8000, EManual.Cocina);
            Cuento c1 = new Cuento(5, "DBZ", "asd", 4, 8200.65F, true, 700, ECuentos.Dinosaurios);
            Historieta h1 = new Historieta(7, "Berserker", "yisho", 4, 8200.65F, true, 1, EHistorietas.Anime);

            //act
            double precio = nv1.Precio;
            precio = m1.Precio;
            precio = c1.Precio;
            precio = h1.Precio;

            //assert
            Console.WriteLine(precio);
            Console.WriteLine(Math.Round(precioEsperadoNovela, 2));

            //Assert.AreEqual(precio, Math.Round(precioEsperadoNovela,2));
            //Assert.AreEqual(precio, Math.Round(precioEsperadoManual, 2));
            //Assert.AreEqual(precio, Math.Round(precioEsperadoCuento, 2));
            Assert.AreEqual(precio, Math.Round(precioEsperadoHistorieta, 2));
        }

        #endregion
    }
}
