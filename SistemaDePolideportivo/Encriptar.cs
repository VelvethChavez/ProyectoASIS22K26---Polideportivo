using System.Security.Cryptography;
using System.Text;

namespace SistemaDePolideportivo
{
    public class Encriptar
    {
        public static string HashPassword(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);

                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder resultado = new StringBuilder();

                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }
    }
}