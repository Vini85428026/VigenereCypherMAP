using System;
using VigenereMAP.Models;

namespace VigenereMAP.Services
{
    public class Cypher
    {
        public static String encryptText(IndexModel model)
        {
            model.cypher = new Encrypt();
            return model.cypher.encryptOrDecrypt(IndexModel.ENCRYPT, model.inputValue, model.key);
        }
        public static String decryptText(IndexModel model)
        {
            model.cypher = new Decrypt();
            return model.cypher.encryptOrDecrypt(IndexModel.DECRYPT, model.inputValue, model.key);
        }
    }
}
