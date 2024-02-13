using SistemaGestionData.Data;
using SistemaGestionEntities;
using SistemaGestionEntities.Models;

string opcion = menuUser();

while (opcion != "6")
{
    switch (opcion)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Mostrando Lista de Users...");
            var usuarios = UserData.GetUsers();

            foreach (var usuario in usuarios)
            {
                Console.WriteLine("----------------------------------");
            }
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Ingrese el ID de User a Buscar...");
            int id = Convert.ToInt32(Console.ReadLine());
            User getUser = UserData.ObtenerUser(id);

            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Ingrese los datos del User a Crear:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("Contraseña: ");
            string password = Console.ReadLine();
            Console.Write("Correo electrónico: ");
            string mail = Console.ReadLine();


            User usuarioInfo = new User(0, nombre, apellido, nickname, password, mail);
            UserData.CrearUser(usuarioInfo);
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Ingrese el id del usuario a modificar");
            User usuarioModificado = UserData.ObtenerUser(Convert.ToInt32(Console.ReadLine()));
            menuDatosModificar(usuarioModificado);
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Ingrese el id del usuario a eliminar");
            int idUserEliminar = Convert.ToInt32(Console.ReadLine());
            UserData.EliminarUser(idUserEliminar);
            Console.WriteLine("User eliminado correctamente.");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
            break;
    }

    Console.ReadLine();
    Console.Clear();
    opcion = menuUser();

}

string menuUser()
{
    Console.WriteLine("Bievenidos a sistema de gestión de CATPUCCINO");
    Console.WriteLine("Menú para gestionar USUARIOS:");
    Console.WriteLine("1. Mostrar Users");
    Console.WriteLine("2. Obtener User");
    Console.WriteLine("3. Crear User");
    Console.WriteLine("4. Modificar User");
    Console.WriteLine("5. Eliminar User");
    Console.WriteLine("Ingrese la opción deseada: ");
    Console.WriteLine("6. Presione la opción 6 si desea Salir del sistema");

    return Convert.ToString(Console.ReadLine());
}

void menuDatosModificar(User usuario)
{

    int opcionModificar = subMenuModificarUser();

    while (opcionModificar != 6)
    {
        switch (opcionModificar)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Ingrese el nuevo nombre");
                string newUserName = Convert.ToString(Console.ReadLine());

                usuario.Name = newUserName;

                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Ingrese el nuevo apellido");
                string newUserLastName = Convert.ToString(Console.ReadLine());

                usuario.lastName = newUserLastName;

                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Ingrese el nuevo apellido");
                string newUserNickName = Convert.ToString(Console.ReadLine());

                usuario.username = newUserNickName;

                break;


            case 4:
                Console.Clear();
                Console.WriteLine("Ingrese el nuevo apellido");
                string newUserEmail = Convert.ToString(Console.ReadLine());

                usuario.email = newUserEmail;

                break;


            default:
                Console.WriteLine("Valor incorrecto");
                opcionModificar = subMenuModificarUser();
                break;
        }

        UserData.ModificarUser(usuario);

        Console.ReadLine();
        Console.Clear();
        opcionModificar = subMenuModificarUser();

    }


}

int subMenuModificarUser()
{
    Console.WriteLine("1- ¿Desea modificar Nombre? Nombre Anterior: ");
    Console.WriteLine("2- Modificar Apellido");
    Console.WriteLine("3- Modificar Nickname");
    Console.WriteLine("4- Modificar Mail");
    Console.WriteLine("5- Modificar Infusion");
    Console.WriteLine("6- Atras");

    return Convert.ToInt32(Console.ReadLine());
}