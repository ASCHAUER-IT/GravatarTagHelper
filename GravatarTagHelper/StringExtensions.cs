using System.Security.Cryptography;
using System.Text;

namespace AschauerIT.TagHelpers;

internal static class StringExtensions
{
    #region Internal Methods

    internal static string GetMD5Hash(this string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return string.Empty;

        var loweredBytes = Encoding.Default.GetBytes(s.ToLower());

        using MD5 md5Alg = MD5.Create();

        var buffer = md5Alg.ComputeHash(loweredBytes);
        var sb = new StringBuilder(buffer.Length * 2);
        for (var i = 0; i < buffer.Length; i++)
        {
            sb.Append(buffer[i].ToString("X2"));
        }

        return sb.ToString().ToLower();
    }

    #endregion Internal Methods
}