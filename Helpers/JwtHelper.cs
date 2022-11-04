using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace portfolio.Helpers;

public class JwtHelper
{
    public static string GetId(string auth)
    {
        string token = auth.Remove(0, 7);

        string payload = token.Split('.')[1];

        string jsonPayload = Encoding.UTF8.GetString(DecodePayload(payload));

        return jsonPayload.Split('"')[3]; //Position where the Id is
    }

    static byte[] DecodePayload(string input)
    {
        var output = input;
        output = output.Replace('-', '+'); // 62nd char of encoding
        output = output.Replace('_', '/'); // 63rd char of encoding
        switch (output.Length % 4) // Pad with trailing '='s
        {
            case 0: break; // No pad chars in this case
            case 2: output += "=="; break; // Two pad chars
            case 3: output += "="; break; // One pad char
            default: throw new System.ArgumentOutOfRangeException("input", "Illegal base64url string!");
        }
        var converted = Convert.FromBase64String(output); // Standard base64 decoder
        return converted;
    }
}