using System;
using static System.Console;
using System.Collections.Generic;

namespace ThirdPractice.Practices
{

    class User
    {
        public string Name { get; set; }
        
    }

    internal class Practice3
    {
        private List<User> UsersList = new List<User>();

        public void Start()
        {
            try
            {
                int opt;

                do
                {
                    Clear();
                    WriteLine("Opciones:");
                    WriteLine("1) Agregar usuario");
                    WriteLine("2) Imprimir usuarios");
                    WriteLine("3) Buscar usuario");
                    WriteLine("4) Eliminar usuario");
                    WriteLine("0) Salir");
                    Write("#? ");

                    opt = int.Parse(ReadLine());
                    switch (opt)
                    {
                        case 1:
                            Write("\nNombre del usuario: ");
                            UsersList.Add(new User() { Name = ReadLine() });
                            break;
                        case 2:
                            PrintList();
                            ReadKey();
                            break;
                        case 3:
                            Write("\nNombre a buscar: ");
                            var res = SearchName(ReadLine());
                            Write($"Resultado de búsqueda: {res}\n");
                            ReadKey();
                            break;
                        case 4:
                            Write("\nNombre a eliminar: ");
                            DeleteName(ReadLine());
                            ReadKey();
                            break;
                    }
                } while (opt >= 1 && opt != 0);


            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
        
        private void PrintList()
        {
            WriteLine("\nUsuarios:");

            if (UsersList.Count == 0)
            {
                Write(" No hay usuarios aún\n");
                return;
            }

            foreach (var user in UsersList)
                WriteLine($" - {user.Name}");
        }

        private string SearchName(string n)
        {
            var res = UsersList.Find(u => u.Name == n);
            return res is null ? "not found" : res.Name;
        }

        private void DeleteName(string n)
        {
            if (SearchName(n) == "not found")
            {
                WriteLine("Este usuario no existe");
                return;
            }
            int userIndex = UsersList.FindIndex(u => u.Name == n);
            UsersList.RemoveAt(userIndex);
        }
    }
}
