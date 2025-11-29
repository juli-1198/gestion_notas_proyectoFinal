using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_H2.Utils
{
     public static class CodigoGenerador
    {
        private static readonly Random random = new Random();

        public static string GenerarCodigo(int longitud = 5)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] buffer = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                buffer[i] = chars[random.Next(chars.Length)];
            }

            return new string(buffer);
        }
    }
}
