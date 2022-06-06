using System;
using System.Collections.Generic;
using BookCloud_Entidades;

namespace CreadorDeArchivosAborrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba y backup de archivos, tanto clientes , ventas y publicaciones
            Console.WriteLine("Hello World!");

            Serializado_Xml<List<Publicacion>> serializadoPublicaciones = new();
            Serializado_Xml<List<Cliente_BookCloud>> serializadoClientes = new();
            Serializado_Json<List<Venta>> serializadoVentas = new();

            List<Publicacion> listadoPublicaciones = new();
            List<Cliente_BookCloud> listadoCliente = new();
            List<Venta> listadoVentas = new();

            #region Creacion de clientes

            Premium p1 = new Premium("12345671", "Jorge", "Perez", new DateTime(2010, 12, 03), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Premium p2 = new Premium("14125672", "Alvaro", "Lopez", new DateTime(2009, 11, 01), ENacionalidad.Bolivia, "asdfafs@gmail.com", "45454545");
            Premium p3 = new Premium("23135775", "Manuel", "Gonzalez", new DateTime(2006, 08, 21), ENacionalidad.Uruguay, "asdfafs@gmail.com", "45454545");
            Premium p4 = new Premium("23863146", "Juan ", "Alfonso", new DateTime(2005, 07, 11), ENacionalidad.España, "asdfafs@gmail.com", "45454545");
            Premium p5 = new Premium("23123135", "Juan Pablo", "Lopez", new DateTime(2004, 06, 10), ENacionalidad.Venezuela, "asdfafs@gmail.com", "45454545");
            Premium p6 = new Premium("12345673", "Juan Cruz", "Veraz", new DateTime(2008, 10, 15), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Premium p7 = new Premium("12145674", "Juan Ignacio", "Gomez", new DateTime(2007, 09, 06), ENacionalidad.Colombia, "asdfafs@gmail.com", "45454545");
            Premium p8 = new Premium("12545778", "Jose Gian", "Morra", new DateTime(2003, 05, 19), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Premium p9 = new Premium("32345689", "Thiago", "Silva", new DateTime(2002, 04, 24), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Premium p10 = new Premium("45531610", "Santino", "Asis", new DateTime(2001, 03, 14), ENacionalidad.Paraguay, "asdfafs@gmail.com", "45454545");
            Premium p11 = new Premium("92346710", "Camila", "Perez", new DateTime(2004, 06, 10), ENacionalidad.Venezuela, "asdfafs@gmail.com", "45454545");
            Premium p12 = new Premium("61345573", "Milagros", "Veraz", new DateTime(2008, 10, 15), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Premium p13 = new Premium("71345864", "Florencia", "Lopez", new DateTime(2007, 09, 06), ENacionalidad.Colombia, "asdfafs@gmail.com", "45454545");
            Premium p14 = new Premium("12546278", "Julia", "Perez", new DateTime(2003, 05, 19), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Premium p15 = new Premium("82315619", "Sofia", "Perez", new DateTime(2002, 04, 24), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Premium p16 = new Premium("42245614", "Milena", "Gomez", new DateTime(2001, 03, 14), ENacionalidad.Paraguay, "asdfafs@gmail.com", "45454545");

            Regular r1 = new Regular("11435171", "Flore", "Gonzalez", new DateTime(2010, 12, 03), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Regular r2 = new Regular("13335270", "Julia", "Perez B", new DateTime(2009, 11, 01), ENacionalidad.Bolivia, "asdfafs@gmail.com", "45454545");
            Regular r3 = new Regular("04305679", "Sofia", "Perez C", new DateTime(2008, 10, 15), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Regular r4 = new Regular("23340674", "Milena", "Gonzalez", new DateTime(2007, 09, 06), ENacionalidad.Colombia, "asdfafs@gmail.com", "45454545");
            Regular r5 = new Regular("96347615", "Valeria", "Alfonso", new DateTime(2006, 08, 21), ENacionalidad.Uruguay, "asdfafs@gmail.com", "45454545");
            Regular r6 = new Regular("14341677", "Felipe", "Perez F", new DateTime(2005, 07, 11), ENacionalidad.España, "asdfafs@gmail.com", "45454545");
            Regular r7 = new Regular("18547671", "Pablo", "Veraz", new DateTime(2004, 06, 10), ENacionalidad.Venezuela, "asdfafs@gmail.com", "45454545");
            Regular r8 = new Regular("10342676", "Pepe", "Perez H", new DateTime(2003, 05, 19), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Regular r9 = new Regular("06344676", "Alvaro", "Perez I", new DateTime(2002, 04, 24), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Regular r10 = new Regular("11112910", "Alma", "Perez J", new DateTime(2001, 03, 14), ENacionalidad.Paraguay, "asdfafs@gmail.com", "45454545");
            Regular r11 = new Regular("11125675", "Carlos", "Perez E", new DateTime(2006, 08, 21), ENacionalidad.Uruguay, "asdfafs@gmail.com", "45454545");
            Regular r12 = new Regular("11135676", "Victor", "Perez F", new DateTime(2005, 07, 11), ENacionalidad.España, "asdfafs@gmail.com", "45454545");
            Regular r13 = new Regular("11175677", "Hugo", "Perez G", new DateTime(2004, 06, 10), ENacionalidad.Venezuela, "asdfafs@gmail.com", "45454545");
            Regular r14 = new Regular("11145678", "Santiago", "Perez H", new DateTime(2003, 05, 19), ENacionalidad.Chile, "asdfafs@gmail.com", "45454545");
            Regular r15 = new Regular("11415679", "Celeste", "Perez I", new DateTime(2002, 04, 24), ENacionalidad.Argentina, "asdfafs@gmail.com", "45454545");
            Regular r16 = new Regular("96165610", "Andre", "Perez J", new DateTime(2001, 03, 14), ENacionalidad.Paraguay, "asdfafs@gmail.com", "45454545");

            listadoCliente.Add(p1);
            listadoCliente.Add(p2);
            listadoCliente.Add(p3);
            listadoCliente.Add(p4);
            listadoCliente.Add(p5);
            listadoCliente.Add(p6);
            listadoCliente.Add(p7);
            listadoCliente.Add(p8);
            listadoCliente.Add(p9);
            listadoCliente.Add(p10);
            listadoCliente.Add(p11);
            listadoCliente.Add(p12);
            listadoCliente.Add(p13);
            listadoCliente.Add(p14);
            listadoCliente.Add(p15);
            listadoCliente.Add(p16);

            listadoCliente.Add(r1);
            listadoCliente.Add(r2);
            listadoCliente.Add(r3);
            listadoCliente.Add(r4);
            listadoCliente.Add(r5);
            listadoCliente.Add(r6);
            listadoCliente.Add(r7);
            listadoCliente.Add(r8);
            listadoCliente.Add(r9);
            listadoCliente.Add(r10);
            listadoCliente.Add(r11);
            listadoCliente.Add(r12);
            listadoCliente.Add(r13);
            listadoCliente.Add(r14);
            listadoCliente.Add(r15);
            listadoCliente.Add(r16);

            #endregion

            #region Creacion de publicaciones
            //Novelas
            Novela n1 = new Novela(1, "Odisea", "Homero", 3, 150.5F, true, 200, ENovela.Accion);
            Novela n2 = new Novela(2, "Don Quijote", "Cervantes", 3, 200.5F, false, 200, ENovela.CienciaFiccion);
            Novela n3 = new Novela(3, "Frankestein", "Shelly", 3, 250.5F, false, 200, ENovela.Policial);
            Novela n4 = new Novela(4, "Madame Bovart", "Flaublet", 3, 300.5F, true, 200, ENovela.Poesia);
            Novela n5 = new Novela(5, "Cumbres Rocosas", "Bronie", 3, 350.5F, false, 200, ENovela.Religion);
            Novela n6 = new Novela(6, "Crimen y Castigo", "Dostelevski", 3, 400.5F, false, 200, ENovela.Romance);
            Novela n7 = new Novela(7, "Las uvas de la ira", "Steinbeck", 3, 450.5F, true, 200, ENovela.Suspenso);
            Novela n8 = new Novela(8, "Anna", "Karemina", 3, 500.5F, false, 200, ENovela.Terror);
            Novela n9 = new Novela(9, "Niebla", "Unamuno", 3, 550.5F, false, 200, ENovela.Accion);
            Novela n10 = new Novela(10, "La metamorfosis", "Kafka", 3, 150.5F, true, 200, ENovela.Terror);
            Novela n11 = new Novela(11, "El Corazon", "Conrad", 3, 150.5F, true, 200, ENovela.Accion);
            Novela n12 = new Novela(12, "Huckleberry Fin", "Twain", 3, 200.5F, false, 200, ENovela.CienciaFiccion);
            Novela n13 = new Novela(13, "Cien años de soledad", "Marquez", 3, 250.5F, false, 200, ENovela.Policial);
            Novela n14 = new Novela(14, "El hereje", "Delibes", 3, 300.5F, true, 200, ENovela.Poesia);
            Novela n15 = new Novela(15, "Fuga de JB", "Bailester", 3, 350.5F, false, 200, ENovela.Religion);
            Novela n16 = new Novela(16, "Olvidado", "Matute", 3, 400.5F, false, 200, ENovela.Romance);
            Novela n17 = new Novela(17, "A esmorga", "Blanco", 3, 450.5F, true, 200, ENovela.Suspenso);
            Novela n18 = new Novela(18, "La señora Dalloway", "Woolf", 3, 500.5F, false, 200, ENovela.Terror);
            Novela n19 = new Novela(19, "Pedro Paramo", "Rulfo", 3, 550.5F, false, 200, ENovela.Accion);
            Novela n20 = new Novela(20 , "Merlin", "Conquero", 3, 150.5F, true, 200, ENovela.Terror);

            //Cuentos
            Cuento c1 = new Cuento(21, "La jirafa", "Arreola", 1, 650.10F, true, 300, ECuentos.Magos);
            Cuento c2 = new Cuento(22, "Alguien Soñara", "Luis Borges", 1, 700.10F, false, 300, ECuentos.Dinosaurios);
            Cuento c3 = new Cuento(23, "Amores Lejanos", "Cortazar", 1, 750.10F, true, 300, ECuentos.Animales);
            Cuento c4 = new Cuento(24, "Lamparas de Hojalata", "Mutis", 1, 800.10F, false, 300, ECuentos.Animales);
            Cuento c5 = new Cuento(25, "Duelo", "Reyes", 1, 850.10F, true, 300, ECuentos.Magos);
            Cuento c6 = new Cuento(26, "Los Besos", "Onetti", 1, 900.10F, true, 300, ECuentos.Animales);
            Cuento c7 = new Cuento(27, "El drama del desencantado", "Marquez", 1, 950.10F, false, 300, ECuentos.Animales);
            Cuento c8 = new Cuento(28, "Aguafuerte", "Dario", 1, 1000.10F, true, 300, ECuentos.Aventura);
            Cuento c9 = new Cuento(29, "Un paciente", "Fernandez", 1, 1540.10F, false, 300, ECuentos.Magos);
            Cuento c10 = new Cuento(30, "El dinosaurio", "Monterroso", 1, 4500.10F, true, 300, ECuentos.Animales);

            //Historietas
            Historieta h1 = new Historieta(31, "Baki", "QRA", 6, 850.15F, false, 400, EHistorietas.Anime);
            Historieta h2 = new Historieta(32, "Loki", "MOA", 6, 900.15F, false, 400, EHistorietas.Marvel);
            Historieta h3 = new Historieta(33, "Joker", "FVA", 6, 850.15F, false, 400, EHistorietas.DC);
            Historieta h4 = new Historieta(34, "Berserk", "AFF", 6, 800.15F, true, 400, EHistorietas.Anime);
            Historieta h5 = new Historieta(35, "Capitan America", "BHA", 6, 850.15F, false, 400, EHistorietas.Marvel);
            Historieta h6 = new Historieta(36, "Initial D", "GAX", 6, 800.15F, true, 400, EHistorietas.Anime);
            Historieta h7 = new Historieta(37, "Ironman", "QOI", 6, 850.15F, false, 400, EHistorietas.Marvel);
            Historieta h8 = new Historieta(38, "Batman", "LMZ", 6, 800.15F, false, 400, EHistorietas.DC);
            Historieta h9 = new Historieta(39, "Ghost in the Shell", "OOQ", 6, 850.15F, true, 400, EHistorietas.Anime);
            Historieta h10 = new Historieta(40, "Flash", "Autor Historieta 10", 6, 800.15F, false, 400, EHistorietas.DC);

            //Manual
            Manual m1 = new Manual(41, "Caza vol Uno", "Alvo", 11, 400.10F, false, 1200, EManual.Caza);
            Manual m2 = new Manual(42, "Cocina vol Uno", "Losada", 11, 400.10F, false, 1200, EManual.Cocina);
            Manual m3 = new Manual(43, "Pesca vol Uno", "Perez", 11, 400.10F, false, 1200, EManual.Pesca);
            Manual m4 = new Manual(44, "Auto ayuda vol Uno", "Diaz", 11, 430.10F, false, 1200, EManual.Auto_Ayuda);
            Manual m5 = new Manual(45, "Caza vol Dos", "Alvo", 11, 400.10F, false, 1200, EManual.Caza);
            Manual m6 = new Manual(46, "Cocina vol Dos", "Losada", 11, 400.10F, true, 1200, EManual.Cocina);
            Manual m7 = new Manual(47, "Auto ayuda vol Dos", "Diaz", 11, 400.10F, false, 1200, EManual.Auto_Ayuda);
            Manual m8 = new Manual(48, "Pesca vol Dos", "Perez", 11, 600.10F, false, 1200, EManual.Pesca);
            Manual m9 = new Manual(49, "Caza vol Tres", "Alvo", 11, 400.10F, true, 1200, EManual.Caza);
            Manual m10 = new Manual(50, "Cocina vol Tres", "Losada", 11, 400.10F, true, 1200, EManual.Cocina);

            listadoPublicaciones.Add(n1);
            listadoPublicaciones.Add(n2);
            listadoPublicaciones.Add(n3);
            listadoPublicaciones.Add(n4);
            listadoPublicaciones.Add(n5);
            listadoPublicaciones.Add(n6);
            listadoPublicaciones.Add(n7);
            listadoPublicaciones.Add(n8);
            listadoPublicaciones.Add(n9);
            listadoPublicaciones.Add(n10);
            listadoPublicaciones.Add(n11);
            listadoPublicaciones.Add(n12);
            listadoPublicaciones.Add(n13);
            listadoPublicaciones.Add(n14);
            listadoPublicaciones.Add(n15);
            listadoPublicaciones.Add(n16);
            listadoPublicaciones.Add(n17);
            listadoPublicaciones.Add(n18);
            listadoPublicaciones.Add(n19);
            listadoPublicaciones.Add(n20);

            listadoPublicaciones.Add(c1);
            listadoPublicaciones.Add(c2);
            listadoPublicaciones.Add(c3);
            listadoPublicaciones.Add(c4);
            listadoPublicaciones.Add(c5);
            listadoPublicaciones.Add(c6);
            listadoPublicaciones.Add(c7);
            listadoPublicaciones.Add(c8);
            listadoPublicaciones.Add(c9);
            listadoPublicaciones.Add(c10);

            listadoPublicaciones.Add(m1);
            listadoPublicaciones.Add(m2);
            listadoPublicaciones.Add(m3);
            listadoPublicaciones.Add(m4);
            listadoPublicaciones.Add(m5);
            listadoPublicaciones.Add(m6);
            listadoPublicaciones.Add(m7);
            listadoPublicaciones.Add(m8);
            listadoPublicaciones.Add(m9);
            listadoPublicaciones.Add(m10);

            listadoPublicaciones.Add(h1);
            listadoPublicaciones.Add(h2);
            listadoPublicaciones.Add(h3);
            listadoPublicaciones.Add(h4);
            listadoPublicaciones.Add(h5);
            listadoPublicaciones.Add(h6);
            listadoPublicaciones.Add(h7);
            listadoPublicaciones.Add(h8);
            listadoPublicaciones.Add(h9);
            listadoPublicaciones.Add(h10);

            #endregion

            #region Asignacion de publicaciones a clientes

            r1.CarritoCompras.AgregarProducto(m3);
            r1.CarritoCompras.AgregarProducto(m5);
            r1.CarritoCompras.AgregarProducto(h4);

            r2.CarritoCompras.AgregarProducto(h3);
            r2.CarritoCompras.AgregarProducto(h7);
            r2.CarritoCompras.AgregarProducto(m4);

            r3.CarritoCompras.AgregarProducto(c3);
            r3.CarritoCompras.AgregarProducto(c2);
            r3.CarritoCompras.AgregarProducto(h9);

            r4.CarritoCompras.AgregarProducto(m3);
            r4.CarritoCompras.AgregarProducto(m9);
            r4.CarritoCompras.AgregarProducto(h9);

            r5.CarritoCompras.AgregarProducto(h1);
            r5.CarritoCompras.AgregarProducto(c3);
            r5.CarritoCompras.AgregarProducto(h4);

            r6.CarritoCompras.AgregarProducto(m3);
            r6.CarritoCompras.AgregarProducto(m5);
            r6.CarritoCompras.AgregarProducto(h4);

            r7.CarritoCompras.AgregarProducto(m3);
            r7.CarritoCompras.AgregarProducto(m5);
            r7.CarritoCompras.AgregarProducto(h6);

            r8.CarritoCompras.AgregarProducto(m7);
            r8.CarritoCompras.AgregarProducto(m5);
            r8.CarritoCompras.AgregarProducto(h4);

            r9.CarritoCompras.AgregarProducto(m3);
            r9.CarritoCompras.AgregarProducto(m9);
            r9.CarritoCompras.AgregarProducto(h4);

            r10.CarritoCompras.AgregarProducto(m3);
            r10.CarritoCompras.AgregarProducto(m5);
            r10.CarritoCompras.AgregarProducto(h4);

            r11.CarritoCompras.AgregarProducto(m3);
            r11.CarritoCompras.AgregarProducto(m5);
            r11.CarritoCompras.AgregarProducto(h4);

            p1.CarritoCompras.AgregarProducto(h3);
            p1.CarritoCompras.AgregarProducto(h5);
            p1.CarritoCompras.AgregarProducto(c4);

            p2.CarritoCompras.AgregarProducto(m3);
            p2.CarritoCompras.AgregarProducto(m5);
            p2.CarritoCompras.AgregarProducto(h4);

            p3.CarritoCompras.AgregarProducto(c3);
            p3.CarritoCompras.AgregarProducto(c5);
            p3.CarritoCompras.AgregarProducto(h4);

            p4.CarritoCompras.AgregarProducto(m3);
            p4.CarritoCompras.AgregarProducto(m5);
            p4.CarritoCompras.AgregarProducto(h4);

            p5.CarritoCompras.AgregarProducto(m3);
            p5.CarritoCompras.AgregarProducto(m5);
            p5.CarritoCompras.AgregarProducto(h4);

            p6.CarritoCompras.AgregarProducto(m3);
            p6.CarritoCompras.AgregarProducto(c5);
            p6.CarritoCompras.AgregarProducto(h4);

            p7.CarritoCompras.AgregarProducto(h3);
            p7.CarritoCompras.AgregarProducto(h5);
            p7.CarritoCompras.AgregarProducto(h4);

            p8.CarritoCompras.AgregarProducto(m3);
            p8.CarritoCompras.AgregarProducto(m5);
            p8.CarritoCompras.AgregarProducto(h4);

            p9.CarritoCompras.AgregarProducto(m3);
            p9.CarritoCompras.AgregarProducto(m5);
            p9.CarritoCompras.AgregarProducto(h4);

            #endregion

            #region Creacion de Ventas

            Venta v1 =  new Venta(DateTime.Now, r1 .Nombre, r1.Apellido, r1.Dni, r1.PrecioTotalCarrito);
            Venta v2 =  new Venta(DateTime.Now, r2 .Nombre, r2 .Apellido, r2.Dni, r2.PrecioTotalCarrito);
            Venta v3 =  new Venta(DateTime.Now, r3 .Nombre, r3 .Apellido, r3.Dni, r3.PrecioTotalCarrito);
            Venta v4 =  new Venta(DateTime.Now, r4 .Nombre, r4 .Apellido, r4.Dni, r4.PrecioTotalCarrito);
            Venta v5 =  new Venta(DateTime.Now, r5 .Nombre, r5 .Apellido, r5.Dni, r5.PrecioTotalCarrito);
            Venta v6 =  new Venta(DateTime.Now, r6 .Nombre, r6 .Apellido, r6.Dni, r6.PrecioTotalCarrito);
            Venta v7 =  new Venta(DateTime.Now, r7 .Nombre, r7 .Apellido, r7.Dni, r7.PrecioTotalCarrito);
            Venta v8 =  new Venta(DateTime.Now, r8 .Nombre, r8 .Apellido, r8.Dni, r8.PrecioTotalCarrito);
            Venta v9 =  new Venta(DateTime.Now, r9 .Nombre, r9 .Apellido, r9.Dni, r9.PrecioTotalCarrito);
            Venta v10 = new Venta(DateTime.Now, r10.Nombre, r10.Apellido, r10.Dni, r10.PrecioTotalCarrito);
            Venta v11 = new Venta(DateTime.Now, r11.Nombre, r11.Apellido, r11.Dni, r11.PrecioTotalCarrito);

            Venta v12 = new Venta(DateTime.Now, p1.Nombre, p1.Apellido, p1.Dni, p1.PrecioTotalCarrito);
            Venta v13 = new Venta(DateTime.Now, p2.Nombre, p2.Apellido, p2.Dni, p2.PrecioTotalCarrito);
            Venta v14 = new Venta(DateTime.Now, p3.Nombre, p3.Apellido, p3.Dni, p3.PrecioTotalCarrito);
            Venta v15 = new Venta(DateTime.Now, p4.Nombre, p4.Apellido, p4.Dni, p4.PrecioTotalCarrito);
            Venta v16 = new Venta(DateTime.Now, p5.Nombre, p5.Apellido, p5.Dni, p5.PrecioTotalCarrito);
            Venta v17 = new Venta(DateTime.Now, p6.Nombre, p6.Apellido, p6.Dni, p6.PrecioTotalCarrito);
            Venta v18 = new Venta(DateTime.Now, p7.Nombre, p7.Apellido, p7.Dni, p7.PrecioTotalCarrito);
            Venta v19 = new Venta(DateTime.Now, p8.Nombre, p8.Apellido, p8.Dni, p8.PrecioTotalCarrito);
            Venta v20 = new Venta(DateTime.Now, p9.Nombre, p9.Apellido, p9.Dni, p9.PrecioTotalCarrito);

            listadoVentas.Add(v1);
            listadoVentas.Add(v2);
            listadoVentas.Add(v3);
            listadoVentas.Add(v4);
            listadoVentas.Add(v5);
            listadoVentas.Add(v6);
            listadoVentas.Add(v7);
            listadoVentas.Add(v8);
            listadoVentas.Add(v9);
            listadoVentas.Add(v10);
            listadoVentas.Add(v11);            
            listadoVentas.Add(v12);
            listadoVentas.Add(v13);
            listadoVentas.Add(v14);
            listadoVentas.Add(v15);
            listadoVentas.Add(v16);
            listadoVentas.Add(v17);
            listadoVentas.Add(v18);
            listadoVentas.Add(v19);
            listadoVentas.Add(v20);

            #endregion

            /*Descomentar y ejecutar em caso de perdida de archivos
            
            serializadoPublicaciones.Serializar(listadoPublicaciones, "Listado_Publicaciones");
            serializadoClientes.Serializar(listadoCliente, "Listado_Clientes");
            serializadoVentas.Serializar(listadoVentas, "Listado_Ventas");
            
             */

            Console.ReadKey();
        }
    }
}
