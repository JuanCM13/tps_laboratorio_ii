using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public abstract class Usuario : IComun
    {
        private String dni;
        private String nombre;
        private String apellido;
        private DateTime fechaNac;
        private ENacionalidad nacionalidad;

        public Usuario()
        {}

        protected Usuario(String dni , String nombre , String apellido , DateTime fecha , ENacionalidad nac)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fecha;
            this.Nacionalidad = nac;
        }

        public String Dni
        {
            get { return this.dni; }
            set 
            {
                if(Validadores.Validar_EsDni(value))
                {
                    this.dni = value;
                }
                else
                {
                    throw new DniFormatException();
                }
            }
        }

        public String Nombre
        {
            get { return this.nombre; }
            set
            {
                if (Validadores.Validar_SoloLetras(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new ErrorFormatoStringException("Error, solo se admiten letras en el nombre!");
                }
            }
        }

        public String Apellido
        {
            get { return this.apellido; }
            set
            {
                if (Validadores.Validar_SoloLetras(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new ErrorFormatoStringException("Error, solo se admiten letras en el apellido!");
                }
            }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNac; }
            set
            {
                if(new Validadores().CalcularEdad(value) == -1)
                {
                    throw new DateTimeException($"Error, la edad del usuario no puede ser menor a 1 y mayor a 120");                    
                }
                else
                {
                    this.fechaNac = value;
                }
            }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public virtual String MostrarDetalle()
        {
            StringBuilder str = new();

            str.AppendLine($"Nombre: {this.Nombre}\nApellido: {this.Apellido}\n" +
                $"DNI: {this.Dni}\nNacionalidad: {this.Nacionalidad}\nEdad: {new Validadores().CalcularEdad(this.FechaNacimiento)}");

            return str.ToString();
        }
    }
}
