using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFix
{
    //Clase global para el almacenamiento de usuarios del sistema 
    public class Users
    {
        //Se definen las propiedades de la clase 
        public string Username { get; set; }
        public string Password { get; set; }

        //Se crea una lista global para la clase
        public static List<Users> UserData = new List<Users>()
        {
            //Asignación de valores a la lista (Usuarios del sistema)
            new Users() { Username = "Cristian", Password = "123"}
        };
    }
}
