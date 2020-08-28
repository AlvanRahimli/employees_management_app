using System.Security.Cryptography;
using System.Text;

namespace employee_management_app.Util
{
    public class Helper
    {
        public static byte[] ComputeHash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] passHash = sha256Hash
                    .ComputeHash(Encoding.UTF8.GetBytes(password));
                return passHash;
            }
        }

        public static bool Equals(byte[] pass, byte[] input)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] != input[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}