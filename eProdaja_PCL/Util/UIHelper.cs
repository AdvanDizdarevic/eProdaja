using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PCLCrypto;
using System.Security.Cryptography;

namespace eProdaja_UI.Util
{
    public class UIHelper
    {
        #region Korisnici
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string lozinka, string salt)
        {
            byte[] pass = Encoding.Unicode.GetBytes(lozinka);
            byte[] dodatak = Convert.FromBase64String(salt);
            byte[] forhash = new byte[pass.Length + dodatak.Length];

            System.Buffer.BlockCopy(pass, 0, forhash, 0, pass.Length);
            System.Buffer.BlockCopy(dodatak, 0, forhash, pass.Length, dodatak.Length);

            //Izmijenjeno
            var algorithm = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] inArray = algorithm.HashData(forhash);

            return Convert.ToBase64String(inArray);
        }

        #endregion

    }
}
