using System;
using System.Collections.Generic;
using System.Text;
using BookCloud_Entidades;

namespace PruebaConsola_BookCloud
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------CLASE DE CONSOLA, PARA PROBAR FUNCIONALIDAD Y RELACION ENTRE ENTIDADES, ANTES DE VOLCAR AL FORM---------------------*/

            List<Cliente_BookCloud> listadoClientes = new();
            List<Venta> registroVentas = new();
            List<Publicacion> listaPublicaciones = new();

            #region Clientes
            
            //Premiums
            Premium p1 = new Premium("12345671", "Juan A", "Perez A", new DateTime(2010, 12, 03), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Premium p2 = new Premium("12345672", "Juan B", "Perez B", new DateTime(2009, 11, 01), ENacionalidad.Bolivia, "asdfafs@gmail.com", "45454545");
            Premium p3 = new Premium("12345675", "Juan E", "Perez E", new DateTime(2006, 08, 21), ENacionalidad.Uruguay, "asdfafs@gmail.com", "45454545");
            Premium p4 = new Premium("12345676", "Juan F", "Perez F", new DateTime(2005, 07, 11), ENacionalidad.España, "asdfafs@gmail.com", "45454545");
            Premium p5 = new Premium("12345677", "Juan G", "Perez G", new DateTime(2004, 06, 10), ENacionalidad.Venezuela, "asdfafs@gmail.com", "45454545");
            Premium p6 = new Premium("12345673", "Juan C", "Perez C", new DateTime(2008, 10, 15), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Premium p7 = new Premium("12345674", "Juan D", "Perez D", new DateTime(2007, 09, 06), ENacionalidad.Colombia, "asdfafs@gmail.com", "45454545");
            Premium p8 = new Premium("12345678", "Juan H", "Perez H", new DateTime(2003, 05, 19), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Premium p9 = new Premium("12345679", "Juan I", "Perez I", new DateTime(2002, 04, 24), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Premium p10 = new Premium("12345610", "Juan J", "Perez J", new DateTime(2001, 03, 14), ENacionalidad.Paraguay, "asdfafs@gmail.com", "45454545");

            //Regulares
            Regular r1 = new Regular("11345671", "Pepe A", "Perez A", new DateTime(2010, 12, 03), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Regular r2 = new Regular("13345672", "Pepe B", "Perez B", new DateTime(2009, 11, 01), ENacionalidad.Bolivia, "asdfafs@gmail.com", "45454545");
            Regular r3 = new Regular("14345673", "Pepe C", "Perez C", new DateTime(2008, 10, 15), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Regular r4 = new Regular("15345674", "Pepe D", "Perez D", new DateTime(2007, 09, 06), ENacionalidad.Colombia, "asdfafs@gmail.com", "45454545");
            Regular r5 = new Regular("16345675", "Pepe E", "Perez E", new DateTime(2006, 08, 21), ENacionalidad.Uruguay, "asdfafs@gmail.com", "45454545");
            Regular r6 = new Regular("17345676", "Pepe F", "Perez F", new DateTime(2005, 07, 11), ENacionalidad.España, "asdfafs@gmail.com", "45454545");
            Regular r7 = new Regular("18345677", "Pepe G", "Perez G", new DateTime(2004, 06, 10), ENacionalidad.Venezuela, "asdfafs@gmail.com", "45454545");
            Regular r8 = new Regular("19345678", "Pepe H", "Perez H", new DateTime(2003, 05, 19), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Regular r9 = new Regular("20345679", "Pepe I", "Perez I", new DateTime(2002, 04, 24), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Regular r10 = new Regular("21345610", "Pepe J", "Perez J", new DateTime(2001, 03, 14), ENacionalidad.Paraguay, "asdfafs@gmail.com", "45454545");
            #endregion

            #region Asignacion a Lista Clientes

            listadoClientes.Add(p1);
            listadoClientes.Add(p2);
            listadoClientes.Add(p3);
            listadoClientes.Add(p4);
            listadoClientes.Add(p5);
            listadoClientes.Add(p6);
            listadoClientes.Add(p7);
            listadoClientes.Add(p8);
            listadoClientes.Add(p9);
            listadoClientes.Add(p10);

            listadoClientes.Add(r1);
            listadoClientes.Add(r2);
            listadoClientes.Add(r3);
            listadoClientes.Add(r4);
            listadoClientes.Add(r5);
            listadoClientes.Add(r6);
            listadoClientes.Add(r7);
            listadoClientes.Add(r8);
            listadoClientes.Add(r9);
            listadoClientes.Add(r10);

            #endregion

            #region Publicaciones

            //Novelas
            Novela n1 = new Novela(1, "Novela 1", "Autor Novela 1", 3, 150.5F, true, 200, ENovela.Accion);
            Novela n2 = new Novela(2, "Novela 2", "Autor Novela 2", 3, 200.5F, false, 200, ENovela.CienciaFiccion);
            Novela n3 = new Novela(3, "Novela 3", "Autor Novela 3", 3, 250.5F, false, 200, ENovela.Policial);
            Novela n4 = new Novela(4, "Novela 4", "Autor Novela 4", 3, 300.5F, true, 200, ENovela.Poesia);
            Novela n5 = new Novela(5, "Novela 5", "Autor Novela 5", 3, 350.5F, false, 200, ENovela.Religion);
            Novela n6 = new Novela(6, "Novela 6", "Autor Novela 6", 3, 400.5F, false, 200, ENovela.Romance);
            Novela n7 = new Novela(7, "Novela 7", "Autor Novela 7", 3, 450.5F, true, 200, ENovela.Suspenso);
            Novela n8 = new Novela(8, "Novela 8", "Autor Novela 8", 3, 500.5F, false, 200, ENovela.Terror);
            Novela n9 = new Novela(9, "Novela 9", "Autor Novela 9", 3, 550.5F, false, 200, ENovela.Accion);
            Novela n10 = new Novela(10, "Novela 10", "Autor Novela 10", 3, 150.5F, true, 200, ENovela.Terror);

            //Cuentos
            Cuento c1 = new Cuento(11, "Cuento 1", "Autor Cuento 1", 1, 650.10F, true, 300, ECuentos.Magos);
            Cuento c2 = new Cuento(12, "Cuento 2", "Autor Cuento 2", 1, 700.10F, false, 300, ECuentos.Dinosaurios);
            Cuento c3 = new Cuento(13, "Cuento 3", "Autor Cuento 3", 1, 750.10F, true, 300, ECuentos.Animales);
            Cuento c4 = new Cuento(14, "Cuento 4", "Autor Cuento 4", 1, 800.10F, false, 300, ECuentos.Animales);
            Cuento c5 = new Cuento(15, "Cuento 5", "Autor Cuento 5", 1, 850.10F, true, 300, ECuentos.Magos);
            Cuento c6 = new Cuento(16, "Cuento 6", "Autor Cuento 6", 1, 900.10F, true, 300, ECuentos.Animales);
            Cuento c7 = new Cuento(17, "Cuento 7", "Autor Cuento 7", 1, 950.10F, false, 300, ECuentos.Animales);
            Cuento c8 = new Cuento(18, "Cuento 8", "Autor Cuento 8", 1, 1000.10F, true, 300, ECuentos.Aventura);
            Cuento c9 = new Cuento(19, "Cuento 9", "Autor Cuento 9", 1, 1540.10F, false, 300, ECuentos.Magos);
            Cuento c10 = new Cuento(20, "Cuento 10", "Autor Cuento 1", 1, 4500.10F, true, 300, ECuentos.Animales);

            //Historietas
            Historieta h1 = new Historieta(21, "Historieta 1", "Autor Historieta 1", 6, 850.15F, false, 400, EHistorietas.Anime);
            Historieta h2 = new Historieta(22, "Historieta 2", "Autor Historieta 2", 6, 900.15F, false, 400, EHistorietas.Marvel);            
            Historieta h3 = new Historieta(23, "Historieta 3", "Autor Historieta 3", 6, 850.15F, false, 400, EHistorietas.DC);
            Historieta h4 = new Historieta(24, "Historieta 4", "Autor Historieta 4", 6, 800.15F, true, 400, EHistorietas.Anime);
            Historieta h5 = new Historieta(25, "Historieta 5", "Autor Historieta 5", 6, 850.15F, false, 400, EHistorietas.Marvel);
            Historieta h6 = new Historieta(26, "Historieta 6", "Autor Historieta 6", 6, 800.15F, true, 400, EHistorietas.Anime);
            Historieta h7 = new Historieta(27, "Historieta 7", "Autor Historieta 7", 6, 850.15F, false, 400, EHistorietas.Marvel);
            Historieta h8 = new Historieta(28, "Historieta 8", "Autor Historieta 8", 6, 800.15F, false, 400, EHistorietas.DC);
            Historieta h9 = new Historieta(29, "Historieta 9", "Autor Historieta 9", 6, 850.15F, true, 400, EHistorietas.Anime);
            Historieta h10 = new Historieta(30, "Historieta 10", "Autor Historieta 10", 6, 800.15F, false, 400, EHistorietas.DC);

            //Manual
            Manual m1 = new Manual(31, "Manual 1", "Autor Manual 1", 11, 400.10F, false, 1200, EManual.Caza);
            Manual m2 = new Manual(32, "Manual 2", "Autor Manual 2", 11, 400.10F, false, 1200, EManual.Cocina);
            Manual m3 = new Manual(33, "Manual 3", "Autor Manual 3", 11, 400.10F, false, 1200, EManual.Pesca);
            Manual m4 = new Manual(34, "Manual 4", "Autor Manual 4", 11, 430.10F, false, 1200, EManual.Auto_Ayuda);
            Manual m5 = new Manual(35, "Manual 5", "Autor Manual 5", 11, 400.10F, false, 1200, EManual.Caza);
            Manual m6 = new Manual(36, "Manual 6", "Autor Manual 6", 11, 400.10F, true, 1200, EManual.Cocina);
            Manual m7 = new Manual(37, "Manual 7", "Autor Manual 7", 11, 400.10F, false, 1200, EManual.Auto_Ayuda);
            Manual m8 = new Manual(38, "Manual 8", "Autor Manual 8", 11, 600.10F, false, 1200, EManual.Pesca);
            Manual m9 = new Manual(39, "Manual  9", "Autor Manual 9", 11, 400.10F, true, 1200, EManual.Caza);
            Manual m10 = new Manual(40, "Manual 10", "Autor Manual 10", 11, 400.10F, true, 1200, EManual.Cocina);
            #endregion

            #region Asignacion Publicaciones a Clientes Premium

            //p1 compras
            _ = p1.CarritoCompras.AgregarProducto(m1);
            _ = p1.CarritoCompras.AgregarProducto(m2);
            _ = p1.CarritoCompras.AgregarProducto(c10);
            _ = p1.CarritoCompras.AgregarProducto(n3);
            _ = p1.CarritoCompras.AgregarProducto(m6);

            //p2 compras
            _ = p2.CarritoCompras.AgregarProducto(m3);
            _ = p2.CarritoCompras.AgregarProducto(n5);
            _ = p2.CarritoCompras.AgregarProducto(c4);
            _ = p2.CarritoCompras.AgregarProducto(n10);
            _ = p2.CarritoCompras.AgregarProducto(h3);
            
            //p3 compras
            _ = p3.CarritoCompras.AgregarProducto(c5);
            _ = p3.CarritoCompras.AgregarProducto(c10);
            _ = p3.CarritoCompras.AgregarProducto(n7);
            _ = p3.CarritoCompras.AgregarProducto(h8);
            _ = p3.CarritoCompras.AgregarProducto(h3);

            //p4 compras
            _ = p4.CarritoCompras.AgregarProducto(h3);
            _ = p4.CarritoCompras.AgregarProducto(c8);
            _ = p4.CarritoCompras.AgregarProducto(n4);
            _ = p4.CarritoCompras.AgregarProducto(c4);
            _ = p4.CarritoCompras.AgregarProducto(c7);

            //p5 compras
            _ = p5.CarritoCompras.AgregarProducto(c5);
            _ = p5.CarritoCompras.AgregarProducto(m5);
            _ = p5.CarritoCompras.AgregarProducto(n2);
            _ = p5.CarritoCompras.AgregarProducto(h7);
            _ = p5.CarritoCompras.AgregarProducto(h10);

            //p6 compras
            _ = p6.CarritoCompras.AgregarProducto(m3);
            _ = p6.CarritoCompras.AgregarProducto(h4);
            _ = p6.CarritoCompras.AgregarProducto(h7);
            _ = p6.CarritoCompras.AgregarProducto(n1);
            _ = p6.CarritoCompras.AgregarProducto(n7);

            //p7 compras
            _ = p7.CarritoCompras.AgregarProducto(m2);
            _ = p7.CarritoCompras.AgregarProducto(m1);
            _ = p7.CarritoCompras.AgregarProducto(h6);
            _ = p7.CarritoCompras.AgregarProducto(n7);
            _ = p7.CarritoCompras.AgregarProducto(n2);

            //p8 compras
            _ = p8.CarritoCompras.AgregarProducto(h5);
            _ = p8.CarritoCompras.AgregarProducto(h6);
            _ = p8.CarritoCompras.AgregarProducto(h7);
            _ = p8.CarritoCompras.AgregarProducto(h8);
            _ = p8.CarritoCompras.AgregarProducto(h9);

            //p9 compras
            _ = p9.CarritoCompras.AgregarProducto(h1);
            _ = p9.CarritoCompras.AgregarProducto(m5);
            _ = p9.CarritoCompras.AgregarProducto(h6);
            _ = p9.CarritoCompras.AgregarProducto(m2);
            _ = p9.CarritoCompras.AgregarProducto(n5);

            //p10 compras
            _ = p10.CarritoCompras.AgregarProducto(n4);
            _ = p10.CarritoCompras.AgregarProducto(n3);
            _ = p10.CarritoCompras.AgregarProducto(h6);
            _ = p10.CarritoCompras.AgregarProducto(m2);
            _ = p10.CarritoCompras.AgregarProducto(h9);

            #endregion

            #region Asignacion Publicaciones a Clientes Regulares

            //r1 compras
            _ = r1.CarritoCompras.AgregarProducto(h1);
            _ = r1.CarritoCompras.AgregarProducto(m2);
            _ = r1.CarritoCompras.AgregarProducto(n10);
            _ = r1.CarritoCompras.AgregarProducto(n3);
            _ = r1.CarritoCompras.AgregarProducto(h6);

            //r2 compras
            _ = r2.CarritoCompras.AgregarProducto(n3);
            _ = r2.CarritoCompras.AgregarProducto(h5);
            _ = r2.CarritoCompras.AgregarProducto(h4);
            _ = r2.CarritoCompras.AgregarProducto(n10);
            _ = r2.CarritoCompras.AgregarProducto(m3);

            //r3 compras
            _ = r3.CarritoCompras.AgregarProducto(c5);
            _ = r3.CarritoCompras.AgregarProducto(c10);
            _ = r3.CarritoCompras.AgregarProducto(c7);
            _ = r3.CarritoCompras.AgregarProducto(h8);
            _ = r3.CarritoCompras.AgregarProducto(m3);

            //r4 compras
            _ = r4.CarritoCompras.AgregarProducto(m3);
            _ = r4.CarritoCompras.AgregarProducto(m8);
            _ = r4.CarritoCompras.AgregarProducto(n4);
            _ = r4.CarritoCompras.AgregarProducto(h4);
            _ = r4.CarritoCompras.AgregarProducto(c7);

            //r5 compras
            _ = r5.CarritoCompras.AgregarProducto(c5);
            _ = r5.CarritoCompras.AgregarProducto(h5);
            _ = r5.CarritoCompras.AgregarProducto(n2);
            _ = r5.CarritoCompras.AgregarProducto(m7);
            _ = r5.CarritoCompras.AgregarProducto(h10);

            //r6 compras
            _ = r6.CarritoCompras.AgregarProducto(c3);
            _ = r6.CarritoCompras.AgregarProducto(h4);
            _ = r6.CarritoCompras.AgregarProducto(h7);
            _ = r6.CarritoCompras.AgregarProducto(n1);
            _ = r6.CarritoCompras.AgregarProducto(h7);

            //r7 compras
            _ = r7.CarritoCompras.AgregarProducto(m9);
            _ = r7.CarritoCompras.AgregarProducto(h1);
            _ = r7.CarritoCompras.AgregarProducto(m1);
            _ = r7.CarritoCompras.AgregarProducto(h7);
            _ = r7.CarritoCompras.AgregarProducto(h2);

            //r8 compras
            _ = r8.CarritoCompras.AgregarProducto(h5);
            _ = r8.CarritoCompras.AgregarProducto(n6);
            _ = r8.CarritoCompras.AgregarProducto(m7);
            _ = r8.CarritoCompras.AgregarProducto(m8);
            _ = r8.CarritoCompras.AgregarProducto(n9);

            //r9 compras
            _ = r9.CarritoCompras.AgregarProducto(c1);
            _ = r9.CarritoCompras.AgregarProducto(m5);
            _ = r9.CarritoCompras.AgregarProducto(c6);
            _ = r9.CarritoCompras.AgregarProducto(m2);
            _ = r9.CarritoCompras.AgregarProducto(n5);

            //r10 compras
            _ = r10.CarritoCompras.AgregarProducto(h4);
            _ = r10.CarritoCompras.AgregarProducto(n3);
            _ = r10.CarritoCompras.AgregarProducto(h6);
            _ = r10.CarritoCompras.AgregarProducto(h2);
            _ = r10.CarritoCompras.AgregarProducto(h9);

            #endregion

            #region Baja de Publicaciones en Clientes

            /*Tendria que figurar: m1,m2,n3,m6*/
            p1.CarritoCompras.EliminarProductos(c10 , 1); //se tendria que borrar
            p1.CarritoCompras.EliminarProductos(n4 , 1); //no existe


            p6.CarritoCompras.EliminarProductos(h7, 1); //se tendria que borrar
            p6.CarritoCompras.EliminarProductos(n3, 1); //no existe
            p6.CarritoCompras.EliminarProductos(n7, 1); //se tendria que borrar

            p8.CarritoCompras.EliminarProductos(h5, 1); //se tendria que borrar

            p10.CarritoCompras.VaciarListado_Productos(); //se tendria que borrar toda la lista

            r3.CarritoCompras.EliminarProductos(c5, 1); //se tendria que borrar
            r3.CarritoCompras.EliminarProductos(c7, 1); //se tendria que borrar

            r7.CarritoCompras.EliminarProductos(h1, 1); //se tendria que borrar
            r7.CarritoCompras.EliminarProductos(m3, 1); //no existe
            r7.CarritoCompras.EliminarProductos(h4, 1); //no existe

            r2.CarritoCompras.EliminarProductos(n3, 1); //se tendria que borrar
            r2.CarritoCompras.EliminarProductos(n10, 1); //se tendria que borrar

            #endregion

            #region Ventas 
    
            Venta v1 = new Venta(DateTime.Now,r3.Nombre,r3.Apellido,r3.Dni,r3.PrecioTotalCarrito);
            Venta v2 = new Venta(DateTime.Now, r7.Nombre, r7.Apellido, r7.Dni, r7.PrecioTotalCarrito);
            Venta v3 = new Venta(DateTime.Now, r10.Nombre, r10.Apellido, r10.Dni, r10.PrecioTotalCarrito);
            Venta v4 = new Venta(DateTime.Now, p7.Nombre, p7.Apellido, p7.Dni, p7.PrecioTotalCarrito);
            Venta v5 = new Venta(DateTime.Now, p2.Nombre, p2.Apellido, p2.Dni, p2.PrecioTotalCarrito);
            Venta v6 = new Venta(DateTime.Now, p9.Nombre, p9.Apellido, p9.Dni, p9.PrecioTotalCarrito);

            Venta v7 = new Venta(DateTime.Now, p10.Nombre, p10.Apellido, p10.Dni, p10.PrecioTotalCarrito); //tendria que devolver 0, esto tengo que arreglarlo, que venta no admita carritos vacios

            #endregion

            #region Asignacion a Lista Ventas

            registroVentas.Add(v1);
            registroVentas.Add(v2);
            registroVentas.Add(v3);
            registroVentas.Add(v4);
            registroVentas.Add(v5);
            registroVentas.Add(v6);
            registroVentas.Add(v7); //a arreglar

            #endregion

            //Resultados

            Console.WriteLine($"c5-- {c5.Precio}");
            Console.WriteLine($"c10-- {c10.Precio}");
            Console.WriteLine($"c7-- {c7.Precio}");
            Console.WriteLine($"h8-- {h8.Precio}");
            Console.WriteLine($"m3-- {m3.Precio}");

            foreach (Venta item in registroVentas)
            {
                Console.WriteLine("--------------------------------------------------------------------------------\n");
                Console.WriteLine(item.ToString());
                Console.WriteLine("--------------------------------------------------------------------------------\n");
            }

            Console.WriteLine("\n\n\n CLIENTES CARGADOS: ");

            foreach(Cliente_BookCloud item in listadoClientes)
            {
                Console.WriteLine("INFO DEL CLIENTE:\n");
                Console.WriteLine(item.MostrarDetalle());
                Console.WriteLine("\nTOTAL PRECIO COMPRAS:\n");
                Console.WriteLine(item.PrecioTotalCarrito);
                Console.WriteLine("\n\n--------------------------------------------------------------");
            }

            Console.WriteLine(c1.MostrarDetalle());
            Console.WriteLine(m1.MostrarDetalle());
            Console.WriteLine(n1.MostrarDetalle());
            Console.WriteLine(h1.MostrarDetalle());

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         PRUEBA SERIALIZACION CLIENTES, XML");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.WriteLine("Prueba serializado clientes en xml..");

            Serializado_Xml <List<Cliente_BookCloud>> auxSerializadorXml = new();

            auxSerializadorXml.Serializar(listadoClientes , "Lista_Clientes");

            Console.WriteLine("Serializado Clientes paso!!!");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Prueba deserializado clientes en xml..");

            List<Cliente_BookCloud> listadoClientesAux = auxSerializadorXml.Deserializar("Lista_Clientes");

            Console.WriteLine("Clientes deserializados:");
            foreach(Cliente_BookCloud item in listadoClientesAux)
            {
                Console.WriteLine(item.MostrarDetalle());                
            }

            Console.WriteLine("Deserializado Clientes parece que paso!!!");


            Console.WriteLine("Prueba de agregado publicaciones al carrito a cliente random del listado deserializado..");

            listadoClientesAux[3].CarritoCompras.AgregarProducto(h1);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h2);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h3);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h4);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h5);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h1);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h2);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h3);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h4);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h5);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h1);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h2);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h3);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h4);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h5);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h1);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h2);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h3);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h4);
            listadoClientesAux[3].CarritoCompras.AgregarProducto(h5);
            //listadoClientesAux[3].CarritoCompras.AgregarProducto(h5); //rompe por exceso de limite de publicaciones, todo okey

            Console.WriteLine($"Productos del miembro 4 del listado: \n{listadoClientesAux[3].MostrarDetalle()}");


            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         PRUEBA SERIALIZACION LISTADO PUBLICACIONES, XML");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            listaPublicaciones.Add(c1 );
            listaPublicaciones.Add(c2 );
            listaPublicaciones.Add(c3 );
            listaPublicaciones.Add(c4 );
            listaPublicaciones.Add(c5 );
            listaPublicaciones.Add(c6 );
            listaPublicaciones.Add(c7 );
            listaPublicaciones.Add(c8 );
            listaPublicaciones.Add(c9 );
            listaPublicaciones.Add(c10);

            listaPublicaciones.Add(m1);
            listaPublicaciones.Add(m2);
            listaPublicaciones.Add(m3);
            listaPublicaciones.Add(m4);
            listaPublicaciones.Add(m5);
            listaPublicaciones.Add(m6);
            listaPublicaciones.Add(m7);
            listaPublicaciones.Add(m8);
            listaPublicaciones.Add(m9);
            listaPublicaciones.Add(m10);

            listaPublicaciones.Add(n1);
            listaPublicaciones.Add(n2);
            listaPublicaciones.Add(n3);
            listaPublicaciones.Add(n4);
            listaPublicaciones.Add(n5);
            listaPublicaciones.Add(n6);
            listaPublicaciones.Add(n7);
            listaPublicaciones.Add(n8);
            listaPublicaciones.Add(n9);
            listaPublicaciones.Add(n10);

            listaPublicaciones.Add(h1);
            listaPublicaciones.Add(h2);
            listaPublicaciones.Add(h3);
            listaPublicaciones.Add(h4);
            listaPublicaciones.Add(h5);
            listaPublicaciones.Add(h6);
            listaPublicaciones.Add(h7);
            listaPublicaciones.Add(h8);
            listaPublicaciones.Add(h9);
            listaPublicaciones.Add(h10);

            Console.WriteLine("Prueba serializado publicaciones en xml..");

            Serializado_Xml<List<Publicacion>> auxSerializadorXml_2 = new();

            auxSerializadorXml_2.Serializar(listaPublicaciones, "Lista_Publicaciones");

            Console.WriteLine("Serializado publicaciones paso!!!");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Prueba deserializado publicaciones en xml..");

            List<Publicacion> listadoPublicacionesAux = auxSerializadorXml_2.Deserializar("Lista_Publicaciones");

            Console.WriteLine("Clientes deserializados:");
            foreach (Publicacion item in listadoPublicacionesAux)
            {
                Console.WriteLine(item.MostrarDetalle());
            }

            Console.WriteLine("Deserializado Clientes parece que paso!!!");

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         PRUEBA SERIALIZACION LISTADO VENTAS, JSON");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.WriteLine("Prueba serializado ventas en json..");

            Serializado_Json<List<Venta>> auxSerializador_json = new();

            auxSerializador_json.Serializar(registroVentas, "Lista_Ventas"); 

            Console.WriteLine("Serializado ventas paso!!!");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Prueba deserializado ventas en json..");

            List<Venta> listadoVentasAux = auxSerializador_json.Deserializar("Lista_Ventas");

            Console.WriteLine("Ventas deserializadas:");
            foreach (Venta item in listadoVentasAux)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Deserializado Clientes parece que paso!!!");

            Console.ReadKey();
        }
    }
}
