using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Infrastructure.ApplicationServices.Contracts
{
   public interface IEncryption
    {
        string EncryptString(string encryptString);
        string DecryptString(string cipherText);
       
    }
}
