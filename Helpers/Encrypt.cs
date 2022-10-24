using System.Security.Cryptography;
using System.Text;

namespace portfolio.Helpers;

public class Encrypt
{
    public static string GetSHA512(string str)
    {
        SHA512 sha512 = SHA512.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] stream = null;
        StringBuilder sb = new StringBuilder();
        stream = sha512.ComputeHash(encoding.GetBytes(str));
        for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
        return sb.ToString();
    }
}