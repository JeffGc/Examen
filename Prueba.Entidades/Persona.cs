using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
    public class Persona
    {
        private int _Id;
        private string _Nombre;
        private string _Email;
      
        /* ***********snnipets*********** */

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Email { get => _Email; set => _Email = value; }

        public Persona(int Id, string Nombre, string Email)
        {
            _Id = Id;
            _Nombre = Nombre;
            _Email = Email;
        }
        public Persona()
        {
        }


    }
}
