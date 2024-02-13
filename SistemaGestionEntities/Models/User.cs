using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities.Models
{
    public class User //Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail 
    {
        public int id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string lastName { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public string username { get; set; } = string.Empty;

        public User() { }
        public User(int id, string name, string lastname, string password, string email, string username) {
        
        
            this.id = id;
            this.Name = name;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.username = username;

        }

    }
}
