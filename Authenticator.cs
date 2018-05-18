using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Filialauthentifizierung
{
    public class Authenticator
    {
        // Verschlüsselung
        public byte[] Hash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public byte[] GenerateKey(int filialnummer)
        {
            int fn = filialnummer;
            int clock = Int32.Parse(DateTime.Now.ToString("hmm"));
            int day = Int32.Parse(DateTime.Today.Day.ToString());
            int month = Int32.Parse(DateTime.Today.Month.ToString());
            int year = Int32.Parse(DateTime.Today.Year.ToString());
            int cmdCDMYF = clock * day * month * year * fn;
            string cmbToString = cmdCDMYF.ToString();
            byte[] hash = Hash(cmbToString);
            return hash;
        }

        public static string HashToString()
        {
            throw new NotImplementedException();
        }

        // Gebe die ersten 4 byte der Eingabe als HEX-string zurück.
        public string HashToString(byte[] hash)
        {
            string mdfHash = "";
            for (int i = 0; i < 4; i++)
            {
                mdfHash = mdfHash + hash[i].ToString("X2");
            }
            return mdfHash;
        }
    }
}
