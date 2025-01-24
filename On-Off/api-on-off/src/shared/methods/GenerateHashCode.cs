using System.Security.Cryptography;
using System.Text;

namespace api_on_off.src.shared.methods
{
    public class GenerateHashCode
    {
        /// <summary>
        /// Computes a deterministic hash code for the given string using SHA-256.
        /// </summary>
        /// <param name="code">The input string to compute the hash code for.</param>
        /// <returns>An integer representing the deterministic hash code of the input string.</returns>
        public static int GetDeterministicHashCode(string code)
        {
            using var sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(code));
            int hash = BitConverter.ToInt32(hashBytes, 0);
            return hash;
        }
    }
}