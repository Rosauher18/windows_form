using formulario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario.Dato
{
    public class Usuario
    {
        List<UsuarioModelo> lista = new List<UsuarioModelo>();
        /// <summary>
        /// Guardar los usuarios
        /// </summary>
        /// <param name="modelo">datos del usuario</param>
        public void Guardar(UsuarioModelo modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos los usuarios 
        /// </summary>
        /// <returns>datos de usuarios</returns>
        public List<UsuarioModelo> Consultart()
        {
            return lista;
        }



    }
}
