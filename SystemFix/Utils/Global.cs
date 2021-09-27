using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFix
{
    public class Global
    {
        public static readonly Users Data = new Users();
        public static List<Clients> lista = new List<Clients>();

        //Se crea una lista global para la clase
        public static readonly List<Users> UserData = new List<Users>()
        {
            //Asignación de valores a la lista (Usuarios del sistema)
            new Users() { Username = "Cristian", Password = "123"}
        };
    }
}
