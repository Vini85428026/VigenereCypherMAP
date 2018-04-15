using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VigenereMAP.Models;

namespace VigenereMAP.Services
{
    public class Encrypt : ICypher
    {
        public string encryptOrDecrypt(String type, string inputValue, string key)
        {
            String output = null;
            int cont = 0;

            for (int i = 0; i < inputValue.Length; ++i)
            {
                if (!char.IsLetter(inputValue[i]))
                {
                    output += inputValue[i];
                    ++cont;
                }
                else
                {
                    char offset = char.IsUpper(inputValue[i]) ? 'A' : 'a';
                    int indexKey = (i - cont) % key.Length;
                    int z = (char.IsUpper(inputValue[i]) ? char.ToUpper(key[indexKey]) : char.ToLower(key[indexKey])) - offset;
                    if (type == IndexModel.DECRYPT)
                        z = -z;
                    char ch = (char)(((((inputValue[i] + z) - offset) % 26 + 26) % 26) + offset);
                    output += ch;
                }
            }

            return output;
        }
    }
}
