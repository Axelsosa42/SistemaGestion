using SistemaGestionData.Data;
using SistemaGestionEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.services
{
    internal class Class1
    {
        public static class UserBussiness
        {
            public static List<User> ObtenerUsers()
            {
                return UserData.GetUsers();
            }
            public static User ObtenerUser(int id) => UserData.ObtenerUser(id);

            public static void CrearUser(User usuario)
            {
                UserData.CrearUser(usuario);
            }

            public static void ModificarUser(User usuario)
            {
                UserData.ModificarUser(usuario);
            }

            public static void EliminarUser(int id)
            {
                UserData.EliminarUser(id);
            }
        }
    }
}
