using System;

namespace UnidadDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de salida en consola
            Console.WriteLine("¡Bienvenido al programa de autenticación!");

            // Llamar a un método que simula autenticación (lo agregarás más adelante)
            bool isAuthenticated = AuthenticateUser("usuario", "contraseña");
            Console.WriteLine($"Autenticación { (isAuthenticated ? "exitosa" : "fallida") }.");
        }

        // Método simulado de autenticación
        static bool AuthenticateUser(string username, string password)
        {
            // Esta es una implementación simple para la demostración
            return username == "usuario" && password == "contraseña";
        }
    }
}
