using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCloud_Entidades
{
    public interface ISerializados<T>
    {
        void Serializar(T tipoT , String nombreParaArchivo);
        T Deserializar(String nombreArchivo);

    }
}
