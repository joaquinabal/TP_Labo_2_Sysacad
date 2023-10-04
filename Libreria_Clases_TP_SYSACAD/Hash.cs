using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class Hash
    {
        public static string GetHash(string contrasenia)
        {
            var contraseniaHasheada = BCrypt.Net.BCrypt.EnhancedHashPassword(contrasenia, 8);
            return contraseniaHasheada;
        }

        public static bool CompararHash(string contraseniaIngresada, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(contraseniaIngresada, hash);
        }
    }
}
