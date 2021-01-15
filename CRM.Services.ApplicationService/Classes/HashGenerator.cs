using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CRM.Services.ApplicationService.Classes
{
    public class HashGenerator
    {
        public static string Md5Encoding(string password)
        {

            SHA256 sha256Hash = SHA256.Create();

            byte[] mainBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256Hash.ComputeHash(mainBytes);

            return BitConverter.ToString(hashBytes);


        }
    }
}
