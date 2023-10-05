using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class Hash
    {
        // Función para generar un hash SHA-256 a partir de una contraseña
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir la contraseña en bytes
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Calcular el hash
                byte[] hash = sha256.ComputeHash(bytes);

                // Convertir el hash en una cadena hexadecimal
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        // Función para verificar si una contraseña coincide con su hash
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Calcular el hash de la contraseña proporcionada
            string hashedInput = HashPassword(password);

            // Comparar los hashes para verificar si coinciden
            return string.Equals(hashedInput, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }

        //public static string HashearPassword(string password)
        //{
        //    // Generar un hash Bcrypt a partir de la contraseña
        //    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

        //    return hashedPassword;
        //}

        //public static bool VerificarHasheo(string password, string passwordHasheada)
        //{
        //    // Verificar si la contraseña coincide con el hash almacenado
        //    bool passwordMatches = BCrypt.Net.BCrypt.Verify(password, passwordHasheada);

        //    return passwordMatches;
        //}



        //public static string GetHash(string contrasenia)
        //{
        //    var contraseniaHasheada = BCrypt.Net.BCrypt.EnhancedHashPassword(contrasenia, 8);
        //    return contraseniaHasheada;
        //}

        //public static bool CompararHash(string contraseniaIngresada, string hash)
        //{
        //    return BCrypt.Net.BCrypt.EnhancedVerify(contraseniaIngresada, hash);
        //}
    }
}
